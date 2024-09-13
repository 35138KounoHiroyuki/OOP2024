using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace RssReader {

    public partial class Form1 : Form {
        List<ItemData> items;
        // ComboBox cbUel;

        public Form1() {
            InitializeComponent();

            cbRssUrl.Items.Add(new cbRssUrlItem { DisplayText = "主要", Url = "https://news.yahoo.co.jp/rss/topics/top-picks.xml" });
            cbRssUrl.Items.Add(new cbRssUrlItem { DisplayText = "国内", Url = "https://news.yahoo.co.jp/rss/topics/top-picks.xml" });
            cbRssUrl.Items.Add(new cbRssUrlItem { DisplayText = "国際", Url = "https://news.yahoo.co.jp/rss/topics/top-picks.xml" });
            cbRssUrl.Items.Add(new cbRssUrlItem { DisplayText = "経済", Url = "https://news.yahoo.co.jp/rss/topics/top-picks.xml" });
            cbRssUrl.Items.Add(new cbRssUrlItem { DisplayText = "エンタメ", Url = "https://news.yahoo.co.jp/rss/topics/top-picks.xml" });
            cbRssUrl.Items.Add(new cbRssUrlItem { DisplayText = "スポーツ", Url = "https://news.yahoo.co.jp/rss/topics/top-picks.xml" });
            cbRssUrl.Items.Add(new cbRssUrlItem { DisplayText = "IT", Url = "https://news.yahoo.co.jp/rss/topics/top-picks.xml" });
            cbRssUrl.Items.Add(new cbRssUrlItem { DisplayText = "科学", Url = "https://news.yahoo.co.jp/rss/topics/top-picks.xml" });
            cbRssUrl.Items.Add(new cbRssUrlItem { DisplayText = "地域", Url = "https://news.yahoo.co.jp/rss/topics/top-picks.xml" });

        }

        private void cbRssUrl_SelectedIndexChanged(object sender, EventArgs e) {
            if (cbRssUrl.SelectedItem is cbRssUrlItem selectedItem) {
                string url = selectedItem.Url;
                // URL を使用した処理
                
            }
        }




        private void btGet_Click(object sender, EventArgs e) {


              using (var wc = new WebClient()) {
                   var url = wc.OpenRead(cbRssUrl.Text);
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
               // webView21.Navigate(items[lbRssTitle.SelectedIndex].Link);

               Uri uri = new Uri(items[lbRssTitle.SelectedIndex].Link);
               webView21.Source = uri;
           }

        }

        public class ItemData {
            public string Title { get; set; }
            public string Link { get; set; }
        }
        public class cbRssUrlItem {
            public string DisplayText { get; set; }
            public string Url { get; set; }

            public override string ToString() {
                return DisplayText;

            }
        }
    }

