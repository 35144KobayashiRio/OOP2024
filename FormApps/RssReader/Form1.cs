using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader {
    public partial class Form1 : Form {
        List<ItemData> items;


        public Form1() {
            InitializeComponent();
            InitializeAsync();
        }

        async void InitializeAsync() {
            await webView21.EnsureCoreWebView2Async(null);
        }

        private void btGet_Click(object sender, EventArgs e) {
            using (var wc = new WebClient()) {
                var url = wc.OpenRead(comboBox1.Text);
                var xdoc = XDocument.Load(url);


                items = xdoc.Root.Descendants("item")
                                    .Select(item => new ItemData {
                                        Title = item.Element("title").Value,
                                        Link = item.Element("link").Value,
                                    }).ToList();

                foreach (var item in items) {
                    lbRssTitle.Items.Add(item.Title);
                }
            }
        }

        private void lbRssTitle_SelectedIndexChanged(object sender, EventArgs e) {

            if (webView21 != null && webView21.CoreWebView2 != null) {
                webView21.CoreWebView2.Navigate(items[lbRssTitle.SelectedIndex].Link);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            
            

            
        }
    }
}


    public class ItemData {
            public string Title { get; set; }
            public string Link { get; set; }
        }
