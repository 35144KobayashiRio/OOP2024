using System;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;
using String = System.String;

namespace Exercise01 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        //8.1
        private void btEx8_1_Click(object sender, EventArgs e) {
            var dateTime = DateTime.Now;
            var time = string.Format("{0:yyyy/M/d HH:mm}", dateTime);
            tbDisp.Text = time + "\r\n";

            var time2 = dateTime.ToString("yyyyîNMMåéddì˙ HHéûmmï™ssïb");
            tbDisp.Text += time2 + "\r\n";

            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();

            var datetime = dateTime.ToString("ggyy", culture);
            var dayOfWeek = culture.DateTimeFormat.GetDayName(dateTime.DayOfWeek);

            var time3 = string.Format("{0}îN{1,2}åé{2,2}ì˙({3})", datetime, dateTime.Month, dateTime.Day, dayOfWeek);
            tbDisp.Text += time3 + "\r\n";

        }

        //8.2
        private void tbEx8_2_Click(object sender, EventArgs e) {
            var dateTime = DateTime.Today;

            foreach (var dayofweek in Enum.GetValues(typeof(DayOfWeek))) {
                var str = string.Format("{0:yy/MM/dd}ÇÃéüèTÇÃ{1}:", dateTime, (DayOfWeek)dayofweek);
                tbDisp.Text += str + NextWeek(dateTime, (DayOfWeek)dayofweek) + "\r\n";

            }
        }

        public static DateTime NextWeek(DateTime date, DayOfWeek dayofweek) {
            var nextweek = date.AddDays(7);
            var day = (int)dayofweek - (int)date.DayOfWeek;
            return nextweek.AddDays(day);

        }

        private void tbDisp_TextChanged(object sender, EventArgs e) {

        }

        //8.3
        private void tbEx8_3_Click(object sender, EventArgs e) {
            var tw = new TimeWatch();
            tw.Start();
            Thread.Sleep(1000);
            TimeSpan duration = tw.Stop();
            var str = String.Format("èàóùéûä‘ÇÕ{0}É~ÉäïbÇ≈ÇµÇΩ", duration.TotalMilliseconds);
            tbDisp.Text = str;

        }
    }

    class TimeWatch {
        private DateTime _time;

        public void Start() {
            _time = DateTime.Now;

        }

        public TimeSpan Stop() {
            return DateTime.Now - _time;

        }
    }
}
