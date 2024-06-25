namespace DateTimeApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void bpDateCount_Click(object sender, EventArgs e) {
            var today = DateTime.Today;

            TimeSpan diff = today - dtpDate.Value;

            tbDisp.Text = (diff.Days + 1) + "“ú–Ú";





        }
        //“ú‘O
        private void btDayBefore_Click(object sender, EventArgs e) {

            var past = dtpDate.Value.AddDays(-(double)nudDay.Value);
            tbDisp.Text = past.ToString("D");
        }
        //“úŒã
        private void btDayAfter_Click(object sender, EventArgs e) {

            var future = dtpDate.Value.AddDays((double)nudDay.Value);
            tbDisp.Text = future.ToString("D");
        }

        private void btalld_Click(object sender, EventArgs e) {
            var birthday = dtpDate.Value;
            var today = DateTime.Today;
            int age = GetAge(birthday, today);
            tbDisp.Text = age.ToString("D");
        }
        public static int GetAge(DateTime , DateTime today) {
            if()
        }
    }
}
