using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Policy;
using System.Windows.Forms;
using System.Xml.Linq;
using Windows.Media.AppBroadcasting;

namespace RssReader {
    public partial class Form1 : Form {
        private List<ItemData> items;
        
        private Dictionary<string, string> data;

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
            


        }


        async void InitializeAsync() {
            await webView21.EnsureCoreWebView2Async(null);
        }

        private void btGet_Click(object sender, EventArgs e) {
            using (var wc = new WebClient()) {

                var url = wc.OpenRead(data[cbRSS.Text]);

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




        //ブラウザ表示
        private void lbRssTitle_SelectedIndexChanged(object sender, EventArgs e) {
            if (webView21 != null && webView21.CoreWebView2 != null) {
                webView21.CoreWebView2.Navigate(items[lbRssTitle.SelectedIndex].Link);

            }

        }


        //URL又はお気に入り名
        private void cbRSS_SelectedIndexChanged(object sender, EventArgs e) {
          
                string selectedItem = cbRSS.SelectedItem.ToString();

                //dataのクリア
                lbRssTitle.Items.Clear();

                
            }
    

        

        

        //お気に入り登録(削除)ボタン
        private void btinput_Click(object sender, EventArgs e) {
            if (tb1RSS.Text == "") {
                MessageBox.Show(
                    "未入力です。",
                    "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Hand
                    );
            } else {
                MessageBox.Show(
                    "登録しました。",
                    "お気に入り",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            cbRSS.Items.Add((string)tb1RSS.Text);
            tb1RSS.Text = "";



        }
    }
}


public class ItemData {
    public string Title { get; set; }
    public string Link { get; set; }
    
}
