using System.Security.Cryptography.X509Certificates;

namespace DateTimeApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            var today = DateTime.Today;
            TimeSpan diff = today - dtpBirthday.Value;

            tbDisp.Text = (diff.Days + 1) + "“ú–Ú";
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) {

        }

        private void btDayBefore_Click(object sender, EventArgs e) {
            var past = dtpBirthday.Value.AddDays(-(double)nudDay.Value);
            tbDisp.Text = past.ToString("");




        }

        private void btDayafter_Click(object sender, EventArgs e) {
            var future = dtpBirthday.Value.AddDays((double)nudDay.Value);
            tbDisp.Text = future.ToString("");
        }

        private void btAge_Click(object sender, EventArgs e) {
            var birthday = dtpBirthday.Value;
            var today = DateTime.Today;
            int age = GetAge(birthday, today);
            tbDisp.Text = age.ToString("D");
        }

         public static int GetAge(DateTime birthday, DateTime targetDay) {
        var age=targetDay.Year-birthday.Year;
            if (targetDay <= birthday.AddYears(age)) {
                age--;
            }
            return age;
        }
    }
}