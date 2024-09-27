using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Policy;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader {
    public partial class Form1 : Form {
        List<ItemData> items;
        List<ItemData> myItems;
        Dictionary<string, string> data;

        public Form1() {
            InitializeComponent();
            InitializeAsync();

            //コンボボックスのアイテムとデータ
            data = new Dictionary<string, string>{
                {"主要","https://news.yahoo.co.jp/rss/topics/top-picks.xml" },
                {"国内","https://news.yahoo.co.jp/rss/topics/domestic.xml"},
                {"国際","https://news.yahoo.co.jp/rss/topics/world.xml" },
                {"経済","https://news.yahoo.co.jp/rss/topics/business.xml" },
                {"エンタメ","https://news.yahoo.co.jp/rss/topics/entertainment.xml" },
                {"スポーツ","https://news.yahoo.co.jp/rss/topics/sports.xml" },
                {"IT","https://news.yahoo.co.jp/rss/topics/it.xml" },
                {"科学","https://news.yahoo.co.jp/rss/topics/science.xml"},
                {"地域","https://news.yahoo.co.jp/rss/topics/science.xml" }
            };

            

            

            cbRSS.Items.AddRange(data.Keys.ToArray());
            
            cbRSS.SelectedIndex = 0;
            myItems = new List<ItemData>();    //
        }

        async void InitializeAsync() {
            await webView21.EnsureCoreWebView2Async(null);
        }

        private void btGet_Click(object sender, EventArgs e) {
            




            if (data.TryGetValue(Name, out var cU)){
                using (var wc = new WebClient()) {
                    var url = wc.OpenRead(cbRSS.Text);


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
        }

        //ブラウザ表示
        private void lbRssTitle_SelectedIndexChanged(object sender, EventArgs e) {
            if (lbRssTitle.SelectedItems != null) {
                var selectTitle = lbRssTitle.SelectedItems.ToString();
                var selectItem = items?.FirstOrDefault(item => item.Title == selectTitle);
            };

            

        }

        //コンボボックス
        private void cbRSS_SelectedIndexChanged(object sender, EventArgs e) {
            string selectedItem = cbRSS.SelectedItem.ToString();


        }

        private void tb1RSS_TextChanged(object sender, EventArgs e) {

        }

        private void btinput_Click(object sender, EventArgs e) {

        }

        
    }
}


public class ItemData {
    public string Title { get; set; }
    public string Link { get; set; }
}
