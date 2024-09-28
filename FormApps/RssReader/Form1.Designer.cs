namespace RssReader {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.btGet = new System.Windows.Forms.Button();
            this.lbRssTitle = new System.Windows.Forms.ListBox();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.cbRSS = new System.Windows.Forms.ComboBox();
            this.tb1RSS = new System.Windows.Forms.TextBox();
            this.btinput = new System.Windows.Forms.Button();
            this.labelRss = new System.Windows.Forms.Label();
            this.labelFavRss = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // btGet
            // 
            this.btGet.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btGet.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btGet.Location = new System.Drawing.Point(1105, 8);
            this.btGet.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btGet.Name = "btGet";
            this.btGet.Size = new System.Drawing.Size(155, 49);
            this.btGet.TabIndex = 1;
            this.btGet.Text = "取得";
            this.btGet.UseVisualStyleBackColor = false;
            this.btGet.Click += new System.EventHandler(this.btGet_Click);
            // 
            // lbRssTitle
            // 
            this.lbRssTitle.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRssTitle.FormattingEnabled = true;
            this.lbRssTitle.ItemHeight = 25;
            this.lbRssTitle.Location = new System.Drawing.Point(50, 166);
            this.lbRssTitle.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lbRssTitle.Name = "lbRssTitle";
            this.lbRssTitle.Size = new System.Drawing.Size(1417, 129);
            this.lbRssTitle.TabIndex = 2;
            this.lbRssTitle.SelectedIndexChanged += new System.EventHandler(this.lbRssTitle_SelectedIndexChanged);
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(50, 324);
            this.webView21.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(1420, 542);
            this.webView21.TabIndex = 4;
            this.webView21.ZoomFactor = 1D;
            // 
            // cbRSS
            // 
            this.cbRSS.DropDownHeight = 150;
            this.cbRSS.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRSS.FormattingEnabled = true;
            this.cbRSS.IntegralHeight = false;
            this.cbRSS.Location = new System.Drawing.Point(261, 23);
            this.cbRSS.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbRSS.Name = "cbRSS";
            this.cbRSS.Size = new System.Drawing.Size(802, 33);
            this.cbRSS.TabIndex = 5;
            this.cbRSS.SelectedIndexChanged += new System.EventHandler(this.cbRSS_SelectedIndexChanged);
            // 
            // tb1RSS
            // 
            this.tb1RSS.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb1RSS.Location = new System.Drawing.Point(261, 93);
            this.tb1RSS.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tb1RSS.Multiline = true;
            this.tb1RSS.Name = "tb1RSS";
            this.tb1RSS.Size = new System.Drawing.Size(452, 26);
            this.tb1RSS.TabIndex = 6;

            // 
            // btinput
            // 
            this.btinput.BackColor = System.Drawing.SystemColors.Menu;
            this.btinput.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btinput.Location = new System.Drawing.Point(747, 79);
            this.btinput.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btinput.Name = "btinput";
            this.btinput.Size = new System.Drawing.Size(183, 48);
            this.btinput.TabIndex = 7;
            this.btinput.Text = "登録";
            this.btinput.UseVisualStyleBackColor = false;
            this.btinput.Click += new System.EventHandler(this.btinput_Click);
            // 
            // labelRss
            // 
            this.labelRss.AutoSize = true;
            this.labelRss.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRss.Location = new System.Drawing.Point(30, 23);
            this.labelRss.Name = "labelRss";
            this.labelRss.Size = new System.Drawing.Size(199, 30);
            this.labelRss.TabIndex = 8;
            this.labelRss.Text = "URL又はお気に入り名";
            // 
            // labelFavRss
            // 
            this.labelFavRss.AutoSize = true;
            this.labelFavRss.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFavRss.Location = new System.Drawing.Point(117, 88);
            this.labelFavRss.Name = "labelFavRss";
            this.labelFavRss.Size = new System.Drawing.Size(122, 30);
            this.labelFavRss.TabIndex = 9;
            this.labelFavRss.Text = "お気に入り名";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 927);
            this.Controls.Add(this.labelFavRss);
            this.Controls.Add(this.labelRss);
            this.Controls.Add(this.btinput);
            this.Controls.Add(this.tb1RSS);
            this.Controls.Add(this.cbRSS);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.lbRssTitle);
            this.Controls.Add(this.btGet);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btGet;
        private System.Windows.Forms.ListBox lbRssTitle;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.ComboBox cbRSS;
        private System.Windows.Forms.TextBox tb1RSS;
        private System.Windows.Forms.Button btinput;
        private System.Windows.Forms.Label labelRss;
        private System.Windows.Forms.Label labelFavRss;
    }
}

