using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoForFactory.HttpAccess
{
    public class HttpClientOperationAsync
    {
        #region Fields

        private static string DEFAULTCONTENTTYPE = "application/json";
        private Tuple<WebRequestHandler, HttpClient> _handleClient;
        private CancellationToken _cancellationToken;
        private ILogger _logger = LogManager.GetCurrentClassLogger();

        #endregion

        #region Properties

        public HttpContent HttpBody { get; set; }

        public string RequestUrl { get; set; }

        public CancellationToken CancellationToken
        {
            get
            {
                if (_cancellationToken == null)
                {
                    return CancellationToken.None;
                }
                return _cancellationToken;
            }
            set { _cancellationToken = value; }
        }

        public string ContentType { get; set; }

        private Dictionary<string, string> _heards = new Dictionary<string, string>();
        public Dictionary<string, string> Heards
        {
            get { return _heards; }
            set { _heards = value; }
        }

        private List<Cookie> _cooikes = new List<Cookie>();
        public List<Cookie> Cooikes
        {
            get { return _cooikes; }
            set { _cooikes = value; }
        }

        public Func<object, X509Certificate, X509Chain, SslPolicyErrors, bool> ServerCertificateValidationCallback
        {
            get;
            set;
        }

        #endregion

        #region Construction

        public HttpClientOperationAsync(string requestUrl)
        {
            this.RequestUrl = requestUrl;
            _handleClient = CreateHttpClient();
            this.ContentType = DEFAULTCONTENTTYPE;
            ServerCertificateValidationCallback = (obj, certificate, x509Chain, sslpolicyerrors) => true;
            this.CreateHttpClient();
        }

        #endregion

        #region Construction for Get method

        public HttpClientOperationAsync(string requestUrl,
            Dictionary<string, string> hearders)
            : this(requestUrl)
        {
            this.Heards = hearders;
        }
        public HttpClientOperationAsync(string requestUrl,
            Dictionary<string, string> hearders, List<Cookie> cooikes)
            : this(requestUrl, hearders)
        {
            this.Cooikes = cooikes;
        }

        #endregion

        #region Construction for POST,PUT,DELETE method
        public HttpClientOperationAsync(string requestUrl, HttpContent httpBody)
            : this(requestUrl)
        {
            this.HttpBody = httpBody;
        }
        public HttpClientOperationAsync(string requestUrl, HttpContent httpBody,
            Dictionary<string, string> hearders)
            : this(requestUrl, httpBody)
        {
            this.Heards = hearders;
        }
        public HttpClientOperationAsync(string requestUrl, HttpContent httpBody,
            Dictionary<string, string> hearders, List<Cookie> cooikes)
            : this(requestUrl, httpBody, hearders)
        {
            this.Cooikes = cooikes;
        }
        #endregion

        #region Private method
        private Tuple<WebRequestHandler, HttpClient> CreateHttpClient()
        {
            WebRequestHandler handler = new WebRequestHandler();
            handler.ClientCertificateOptions = ClientCertificateOption.Manual;

            //Handle Cookie
            handler.CookieContainer = new CookieContainer();
            CookieCollection cookieCollection = new CookieCollection();

            if (this.Cooikes != null)
            {
                foreach (Cookie cookie in this.Cooikes)
                {
                    cookieCollection.Add(cookie);
                }
            }
            handler.CookieContainer.Add(cookieCollection);
            handler.ServerCertificateValidationCallback = CheckValidationResult;


            var httpClient = new HttpClient(handler);

            //Handled Heards
            if (this.HttpBody != null)
            {
                this.HttpBody.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(this.ContentType);
                if (this.HttpBody != null)
                {
                    foreach (string key in this.Heards.Keys)
                    {
                        this.HttpBody.Headers.Add(key, this.Heards[key]);
                    }
                }
            }

            return new Tuple<WebRequestHandler, HttpClient>(handler, httpClient);
        }

        private bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslpolicyerrors)
        {
            if (this.ServerCertificateValidationCallback != null)
            {
                return ServerCertificateValidationCallback(sender, certificate, chain, sslpolicyerrors);
            }
            else
            {
                return true;
            }
        }

        #endregion

        public Task<HttpResponseMessage> GetAsync()
        {
            _handleClient = CreateHttpClient();
            Task<HttpResponseMessage> task = null;
            try
            {
                using (_handleClient.Item1)
                {
                    task = _handleClient.Item2.GetAsync(this.RequestUrl, this.CancellationToken);
                }
            }
            catch (Exception e)
            {
                _logger.Error(e);
            }
            return task;
        }

        public Task<HttpResponseMessage> PostAsync()
        {
            //Check HttpBody
            if (this.HttpBody == null)
            {
                throw new ArgumentException("HttpBody cannot be null");
            }

            _handleClient = CreateHttpClient();
            Task<HttpResponseMessage> task = null;
            try
            {
                using (_handleClient.Item1)
                {

                    task = _handleClient.Item2.PostAsync(this.RequestUrl, this.HttpBody, this.CancellationToken);

                }
            }
            catch (Exception e)
            {
                _logger.Error(e);
            }

            return task;
        }

        public Task<HttpResponseMessage> DeleteAsync()
        {
            //Check HttpBody
            if (this.HttpBody == null)
            {
                throw new ArgumentException("HttpBody cannot be null");
            }

            _handleClient = CreateHttpClient();
            Task<HttpResponseMessage> task = null;
            try
            {
                using (_handleClient.Item1)
                {
                    task = _handleClient.Item2.DeleteAsync(this.RequestUrl, this.CancellationToken);
                }
            }
            catch (Exception e)
            {
                _logger.Error(e);
            }
            return task;
        }

        public Task<HttpResponseMessage> PutAsync()
        {
            //Check HttpBody
            if (this.HttpBody == null)
            {
                throw new ArgumentException("HttpBody cannot be null");
            }

            _handleClient = CreateHttpClient();
            Task<HttpResponseMessage> task = null;
            try
            {
                using (_handleClient.Item1)
                {
                    task = _handleClient.Item2.PutAsync(this.RequestUrl, this.HttpBody, this.CancellationToken);
                }
            }
            catch (Exception e)
            {
                _logger.Error(e);
            }
            return task;
        }

        public void CreateX509Certificate2(string certFilePath, string password)
        {
            if (this._handleClient == null)
            {
                throw new ArgumentException("Httphandle HttpClient null");
            }

            X509Certificate2 x509Certificate2 = null;
            if (string.IsNullOrEmpty(password))
            {
                x509Certificate2 = new X509Certificate2(certFilePath);
            }
            else
            {
                //TODO:Need test
                x509Certificate2 = new X509Certificate2(certFilePath, password);
            }
            this._handleClient.Item1.ClientCertificates.Add(x509Certificate2);
        }
    }
}
