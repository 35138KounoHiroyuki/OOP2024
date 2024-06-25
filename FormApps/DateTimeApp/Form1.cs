namespace DateTimeApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void bpDateCount_Click(object sender, EventArgs e) {
            var today = DateTime.Today;

            TimeSpan diff = today - dtpBirthday.Value;

            tbDisp.Text = (diff.Days + 1) + "日目";

           
           

          
        }
        //日前
        private void btDayBefore_Click(object sender, EventArgs e) {
            var today = DateTime.Today;
            var past = today.AddDays((double)-nudDay.Value);
            tbDisp.Text = past.ToString();
        }
        //日後
        private void btDayAfter_Click(object sender, EventArgs e) {
            var today = DateTime.Today;
            var future = today.AddDays((double)nudDay.Value);
            tbDisp.Text = future.ToString();
        }
    }
}
