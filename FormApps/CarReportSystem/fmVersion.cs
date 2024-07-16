using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace CarReportSystem {
    public partial class fmVersion : Form {
        public fmVersion() {
            InitializeComponent();
        }

        private void btVersionOK_Click(object sender, EventArgs e) {
            Close();
        }

        private void fmVersion_Load(object sender, EventArgs e) {
            var ams = Assembly.GetExecutingAssembly();
            var ver = ams.GetName().Version;
            lbVersion.Text ="Ver"+ ver.Major+"."+ver.Minor+"."+ver.Build+"."+ver.Revision;
        }
    }
}
