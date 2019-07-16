using DemoForFactory.Entity;
using DemoForFactory.HttpAccess;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoForFactory
{
    public partial class Sample : Form
    {
        private Random _ro = new Random(DateTime.Now.Second);

        
        public Sample()
        {
            InitializeComponent();
        }

       

        private void Sample_Load(object sender, EventArgs e)
        {
            this.cmb_ApiAchema.SelectedIndex = 0;
            this.cmb_HttpMethod.SelectedIndex = 0;

            //Load App settings
            txt_ApiHost.Text = ConfigurationManager.AppSettings.Get("env_address");
            num_ApiPort.Value = Decimal.Parse(ConfigurationManager.AppSettings.Get("env_port"));
        }

        private void Btn_SendApi_Click(object sender, EventArgs e)
        {
            //Generate Demo Entity
            UploadSo uploadSo = CreateEntity();

            //Generate Json
            string entityJson = JsonConvert.SerializeObject(uploadSo);
            txt_Nas_SendContext.Text = entityJson;

            //Get HOST address,port,......
            string url = GetUrl();

            //Set hearders
            SendToServer(entityJson, url);

        }

        //private void SendToByGet(string url)
        //{
        //    Afx.HttpClient.HttpClient client = new Afx.HttpClient.HttpClient();
            
        //    string timestamp = DateTime.Now.ToString("yyyyMMddHHmmss");
        //    string random = _ro.Next(1000, 9999).ToString();

        //    string apiToken = GetApiToken(timestamp, random);
        //    client.AddHeader("tokenKey", apiToken);
        //    client.AddHeader("timestamp", timestamp);
        //    client.AddHeader("random", random);
            
        //    string result = client.Get(url).Body;
        //    txt_received.Text = result;
        //}

        private void SendToServer(string entityJson, string url)
        {
            Dictionary<string, string> hearders = new Dictionary<string, string>();
            string timestamp = DateTime.Now.ToString("yyyyMMddHHmmss");
            string random = _ro.Next(1000, 9999).ToString();

            string apiToken = GetApiToken(timestamp, random);
            hearders.Add("tokenKey", apiToken);
            hearders.Add("timestamp", timestamp);
            hearders.Add("random", random);

            HttpContent content = new StringContent(entityJson);
            HttpClientOperationAsync operationAsync = new HttpClientOperationAsync(url, content, hearders);
            

            string selectedHttpMethod = cmb_HttpMethod.SelectedItem.ToString();
            Task<HttpResponseMessage> task = null;
            switch (selectedHttpMethod)
            {
                case "POST":
                    {
                        task = operationAsync.PostAsync();
                        break;
                    }
                case "GET":
                    {
                        task = operationAsync.GetAsync();
                        break;
                    }
                case "DELETE":
                    {
                        task = operationAsync.DeleteAsync();
                        break;
                    }
                case "PUT":
                    {
                        task = operationAsync.PutAsync();
                        break;
                    }
                default:

                    break;
            }

            if (task != null && task.Result.Content == null)
            {
                MessageBox.Show("WTF!!!!");
                return;
            }

            if (task != null)
            {
                string httpResponse = task.Result.Content.ReadAsStringAsync().Result;

                txt_received.Text = httpResponse;
            }
        }

        private string GetApiToken(string timestamp,string random)
        {
            string apiKey = "power_on_qrcode";
            string tobeEncode = String.Format("apikey={0}&timestamp={1}&random={2}", apiKey, timestamp, random);
            string apiToekn = Sha256(tobeEncode);

            return apiToekn;
        }

        public string Sha256(string data)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(data);
            byte[] hash = SHA256Managed.Create().ComputeHash(bytes);

            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                builder.Append(hash[i].ToString("X2"));
            }

            return builder.ToString();

        }

        //public static string HmacSha1Sign(string secret, string strOrgData)
        //{
        //    var hmacsha256 = new HMACSHA256(Encoding.UTF8.GetBytes(secret));
        //    var dataBuffer = Encoding.UTF8.GetBytes(strOrgData);
        //    var hashBytes = hmacsha256.ComputeHash(dataBuffer);
        //    return Convert.ToBase64String(hashBytes);
        //}


        private string GetUrl()
        {
            string schema = cmb_ApiAchema.SelectedItem.ToString();
            string host = txt_ApiHost.Text;
            int port = (int)num_ApiPort.Value;
            string uri = txt_ApiAction.Text;
            string url = string.Format("{0}{1}:{2}{3}", schema, host, port, uri);
            return url;
        }

        private static UploadSo CreateEntity()
        {
            //Create Demo Entity:
            SalesOrder salesOrder = new SalesOrder();
            salesOrder.soNumber = 123456L;
            salesOrder.orderLineId = "15.5";
            salesOrder.modelNo = "KJ400";
            salesOrder.requestDate = "2018-06-25";
            salesOrder.promiseDate = "2018-07-25";
            salesOrder.soInputDate = "2018-08-25";
            salesOrder.orderedQuantity = 100;
            salesOrder.salespresonNumber = "H144198";

            SalesOrder salesOrder2 = new SalesOrder();
            salesOrder2.soNumber = 123456L;
            salesOrder2.orderLineId = "20.5";
            salesOrder2.modelNo = "KJ410";
            salesOrder2.requestDate = "2017-06-25";
            salesOrder2.promiseDate = "2016-06-25";
            salesOrder2.soInputDate = "2015-06-25";
            salesOrder2.orderedQuantity = 200;
            salesOrder2.salespresonNumber = "E123456";

            UploadSo uploadSo = new UploadSo();
            List<SalesOrder> salesOrders = new List<SalesOrder>();
            salesOrders.Add(salesOrder);
            salesOrders.Add(salesOrder2);
            uploadSo.list = salesOrders;
            return uploadSo;
        }
 
    }
}
