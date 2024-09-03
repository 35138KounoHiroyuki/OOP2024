using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btGet_Click(object sender, EventArgs e) {
            using (var wc = new WebClient()) {
                var url = wc.OpenRead(tbRssUrl.Text);
                var xdoc = XDocument.Load(url);

                var xelements = xdoc.Root.Descendants("item");
                foreach (var item in xelements) {
                    XElement xname = item.Element("item")
                                          .Elements("title")
                                          .Select(x => x.);
                                          
                    lbRssTitle.Items.Add();


               }
            }
        }
    }
}
