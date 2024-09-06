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
namespace RssReader {

    public partial class Form1 : Form {
        List<ItemData> items;

        public Form1() {
            InitializeComponent();
        }

        private void btGet_Click(object sender, EventArgs e) {
            using (var wc = new WebClient()) {
                var url = wc.OpenRead(tbRssUrl.Text);
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
            //if (webView21 != null && webView21.CoreWebView2 != null) {
            //    webView21.CoreWebView2.Navigate(items[lbRssTitle.SelectedIndex].Link);
            //}
            Uri uri = new Uri(items[lbRssTitle.SelectedIndex].Link);
            webView21.Source = uri;
        }
    }
    
    public class ItemData {
        public string Title { get; set; }
        public string Link { get; set; }
    }
}

