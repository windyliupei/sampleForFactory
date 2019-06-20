namespace DemoForFactory
{
    partial class Sample
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmb_HttpMethod = new System.Windows.Forms.ComboBox();
            this.btn_SendApi = new System.Windows.Forms.Button();
            this.cmb_ApiAchema = new System.Windows.Forms.ComboBox();
            this.txt_ApiAction = new System.Windows.Forms.TextBox();
            this.txt_ApiHost = new System.Windows.Forms.TextBox();
            this.num_ApiPort = new System.Windows.Forms.NumericUpDown();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txt_Nas_SendContext = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_received = new System.Windows.Forms.TextBox();
            this.txt_Token = new System.Windows.Forms.TextBox();
            this.lbl_token = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_ApiPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_HttpMethod
            // 
            this.cmb_HttpMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_HttpMethod.FormattingEnabled = true;
            this.cmb_HttpMethod.Items.AddRange(new object[] {
            "POST",
            "GET",
            "PUT",
            "DELETE"});
            this.cmb_HttpMethod.Location = new System.Drawing.Point(725, 29);
            this.cmb_HttpMethod.Name = "cmb_HttpMethod";
            this.cmb_HttpMethod.Size = new System.Drawing.Size(138, 21);
            this.cmb_HttpMethod.TabIndex = 32;
            // 
            // btn_SendApi
            // 
            this.btn_SendApi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SendApi.Location = new System.Drawing.Point(605, 66);
            this.btn_SendApi.Name = "btn_SendApi";
            this.btn_SendApi.Size = new System.Drawing.Size(258, 58);
            this.btn_SendApi.TabIndex = 31;
            this.btn_SendApi.Text = "Send";
            this.btn_SendApi.UseVisualStyleBackColor = true;
            this.btn_SendApi.Click += new System.EventHandler(this.Btn_SendApi_Click);
            // 
            // cmb_ApiAchema
            // 
            this.cmb_ApiAchema.FormattingEnabled = true;
            this.cmb_ApiAchema.Items.AddRange(new object[] {
            "http://",
            "https://"});
            this.cmb_ApiAchema.Location = new System.Drawing.Point(13, 30);
            this.cmb_ApiAchema.Name = "cmb_ApiAchema";
            this.cmb_ApiAchema.Size = new System.Drawing.Size(97, 21);
            this.cmb_ApiAchema.TabIndex = 30;
            // 
            // txt_ApiAction
            // 
            this.txt_ApiAction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ApiAction.Location = new System.Drawing.Point(116, 66);
            this.txt_ApiAction.Name = "txt_ApiAction";
            this.txt_ApiAction.Size = new System.Drawing.Size(482, 20);
            this.txt_ApiAction.TabIndex = 29;
            this.txt_ApiAction.Text = "/v1/api/thirdparty/factory/uploadSo";
            // 
            // txt_ApiHost
            // 
            this.txt_ApiHost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ApiHost.Location = new System.Drawing.Point(116, 30);
            this.txt_ApiHost.Name = "txt_ApiHost";
            this.txt_ApiHost.Size = new System.Drawing.Size(483, 20);
            this.txt_ApiHost.TabIndex = 27;
            this.txt_ApiHost.Text = "localhost";
            // 
            // num_ApiPort
            // 
            this.num_ApiPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.num_ApiPort.Location = new System.Drawing.Point(605, 29);
            this.num_ApiPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.num_ApiPort.Name = "num_ApiPort";
            this.num_ApiPort.Size = new System.Drawing.Size(101, 20);
            this.num_ApiPort.TabIndex = 28;
            this.num_ApiPort.Value = new decimal(new int[] {
            8081,
            0,
            0,
            0});
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(13, 130);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txt_Nas_SendContext);
            this.splitContainer1.Panel1.Controls.Add(this.label15);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label16);
            this.splitContainer1.Panel2.Controls.Add(this.txt_received);
            this.splitContainer1.Size = new System.Drawing.Size(850, 480);
            this.splitContainer1.SplitterDistance = 238;
            this.splitContainer1.TabIndex = 33;
            // 
            // txt_Nas_SendContext
            // 
            this.txt_Nas_SendContext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Nas_SendContext.Location = new System.Drawing.Point(6, 21);
            this.txt_Nas_SendContext.Multiline = true;
            this.txt_Nas_SendContext.Name = "txt_Nas_SendContext";
            this.txt_Nas_SendContext.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_Nas_SendContext.Size = new System.Drawing.Size(841, 200);
            this.txt_Nas_SendContext.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "Send Context:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 13);
            this.label16.TabIndex = 22;
            this.label16.Text = "Received Context:";
            // 
            // txt_received
            // 
            this.txt_received.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_received.Location = new System.Drawing.Point(6, 16);
            this.txt_received.Multiline = true;
            this.txt_received.Name = "txt_received";
            this.txt_received.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_received.Size = new System.Drawing.Size(841, 208);
            this.txt_received.TabIndex = 21;
            // 
            // txt_Token
            // 
            this.txt_Token.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Token.Location = new System.Drawing.Point(116, 104);
            this.txt_Token.Name = "txt_Token";
            this.txt_Token.Size = new System.Drawing.Size(481, 20);
            this.txt_Token.TabIndex = 34;
            this.txt_Token.Text = "";
            // 
            // lbl_token
            // 
            this.lbl_token.AutoSize = true;
            this.lbl_token.Location = new System.Drawing.Point(51, 107);
            this.lbl_token.Name = "lbl_token";
            this.lbl_token.Size = new System.Drawing.Size(59, 13);
            this.lbl_token.TabIndex = 35;
            this.lbl_token.Text = "Api Token:";
            // 
            // Sample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 654);
            this.Controls.Add(this.lbl_token);
            this.Controls.Add(this.txt_Token);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.cmb_HttpMethod);
            this.Controls.Add(this.btn_SendApi);
            this.Controls.Add(this.cmb_ApiAchema);
            this.Controls.Add(this.txt_ApiAction);
            this.Controls.Add(this.txt_ApiHost);
            this.Controls.Add(this.num_ApiPort);
            this.MinimumSize = new System.Drawing.Size(807, 693);
            this.Name = "Sample";
            this.Text = "Sample";
            this.Load += new System.EventHandler(this.Sample_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_ApiPort)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_HttpMethod;
        private System.Windows.Forms.Button btn_SendApi;
        private System.Windows.Forms.ComboBox cmb_ApiAchema;
        private System.Windows.Forms.TextBox txt_ApiAction;
        private System.Windows.Forms.TextBox txt_ApiHost;
        private System.Windows.Forms.NumericUpDown num_ApiPort;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txt_Nas_SendContext;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_received;
        private System.Windows.Forms.TextBox txt_Token;
        private System.Windows.Forms.Label lbl_token;
    }
}

