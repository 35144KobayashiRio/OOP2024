using System.ComponentModel;

namespace CarReportSystem {
    public partial class Form1 : Form {
       
        //�J�[���|�[�g�Ǘ��p���X�g
        BindingList<CarReport>listCarReports=new BindingList<CarReport>();

        //�R���X�g���N�^
        public Form1() {
            InitializeComponent();
            dgvCarReport.DataSource = listCarReports;
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e) {

        }

        private void label7_Click(object sender, EventArgs e) {

        }

        private void btReportOpen_Click(object sender, EventArgs e) {

        }

        //�摜(�ǉ�)
        private void btAddReport_Click(object sender, EventArgs e) {
            CarReport carReport = new CarReport {
                Date = dtpDate.Value,
            };
            listCarReports.Add(carReport);

        }
    }
}
