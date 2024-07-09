using System.ComponentModel;
using System.Data;
using System.Runtime.Serialization.Formatters.Binary;

namespace CarReportSystem {
    public partial class Form1 : Form {

        //�J�[���|�[�g�Ǘ��p���X�g
        BindingList<CarReport> listCarReports = new BindingList<CarReport>();

        //�R���X�g���N�^
        public Form1() {
            InitializeComponent();
            dgvCarReport.DataSource = listCarReports;
        }



        //�ꗗ�̒ǉ��{�^��
        private void btAddReport_Click(object sender, EventArgs e) {
            if (cbAuthor.Text == "" || cbCarName.Text == "") {
                tslbMessage.Text = "�L�^�ҁA�܂��Ԗ��������͂ł�";
                return;
            }

            CarReport carReport = new CarReport {
                Date = dtpDate.Value,
                Auther = cbAuthor.Text,
                Maker = GetRadioButtonMaker(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                Picture = pbPicture.Image,

            };

            listCarReports.Add(carReport);

            setCbAuthor(cbAuthor.Text);
            setCbCarName(cbCarName.Text);

            dgvCarReport.ClearSelection();�@//�Z���N�V�������O��
            InputItemAllClear();  //���͍��ڂ����ׂăN���A

        }


        //���͍��ڂ����ׂăN���A
        private void InputItemAllClear() {
            dtpDate.Value = DateTime.Now;
            cbAuthor.Text = "";
            setRadioBottonMaker(CarReport.MakerGroup.�Ȃ�);
            cbCarName.Text = "";
            tbReport.Text = "";
            pbPicture.Image = null;
        }

        //�L�^�҂̗������R���{�b�N�X�֓o�^(�d���Ȃ�)
        private void setCbAuthor(string author) {
            if (!cbAuthor.Items.Contains(author))

                cbAuthor.Items.Add(author);
        }


        //�Ԗ��̗������R���{�b�N�X�֓o�^(�d���Ȃ�)
        private void setCbCarName(string carName) {
            if (!cbCarName.Items.Contains(carName))

                cbCarName.Items.Add(carName);
        }




        //�I������Ă��郁�[�J�[����񋓌^�ŕԂ�
        private CarReport.MakerGroup GetRadioButtonMaker() {
            if (rbToyota.Checked)
                return CarReport.MakerGroup.�g���^;

            if (rbNissan.Checked)
                return CarReport.MakerGroup.���Y;

            if (rbHonda.Checked)
                return CarReport.MakerGroup.�z���_;

            if (rbSubaru.Checked)
                return CarReport.MakerGroup.�X�o��;

            if (rbInport.Checked)
                return CarReport.MakerGroup.�A����;

            if (rbOther.Checked)
                return CarReport.MakerGroup.���̑�;

            return CarReport.MakerGroup.���̑�;
        }

        //�w�肵�����[�J�[�̃��W�I�{�^�����Z�b�g
        private void setRadioBottonMaker(CarReport.MakerGroup targetMaker) {
            switch (targetMaker) {
                case CarReport.MakerGroup.�Ȃ�:
                    rbAllClear();

                    break;
                case CarReport.MakerGroup.�g���^:
                    rbToyota.Checked = true;
                    break;
                case CarReport.MakerGroup.���Y:
                    rbNissan.Checked = true;
                    break;
                case CarReport.MakerGroup.�z���_:
                    rbHonda.Checked = true;
                    break;
                case CarReport.MakerGroup.�X�o��:
                    rbSubaru.Checked = true;
                    break;
                case CarReport.MakerGroup.�A����:
                    rbInport.Checked = true;
                    break;
                case CarReport.MakerGroup.���̑�:
                    rbOther.Checked = true;
                    break;

            }

        }

        //���͍��ڂ����ׂăN���A
        private void rbAllClear() {
            rbToyota.Checked = false;
            rbNissan.Checked = false;
            rbHonda.Checked = false;
            rbSubaru.Checked = false;
            rbInport.Checked = false;
            rbOther.Checked = false;
        }

        //�摜���J��
        private void btPicOpen_Click(object sender, EventArgs e) {
            if (ofdPicFileOpen.ShowDialog() == DialogResult.OK)
                pbPicture.Image = Image.FromFile(ofdPicFileOpen.FileName);

        }
        //�摜���폜
        private void btPicDelete_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        private void Form1_Load(object sender, EventArgs e) {
            dgvCarReport.Columns["Picture"].Visible = false;  //�摜�\�����Ȃ�

            //���݂ɐF��ݒ�(�f�[�^�O���b�h�r���[)
            dgvCarReport.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dgvCarReport.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;

        }

        //�ꗗ�\��
        private void dgvCarReport_Click(object sender, EventArgs e) {
            if ((dgvCarReport.Rows.Count == 0) ||
            (!dgvCarReport.CurrentRow.Selected)) return;

            dtpDate.Value = (DateTime)dgvCarReport.CurrentRow.Cells["Date"].Value;
            cbAuthor.Text = (string)dgvCarReport.CurrentRow.Cells["Auther"].Value;
            setRadioBottonMaker((CarReport.MakerGroup)dgvCarReport.CurrentRow.Cells["Maker"].Value);
            cbCarName.Text = (string)dgvCarReport.CurrentRow.Cells["CarName"].Value;
            tbReport.Text = (string)dgvCarReport.CurrentRow.Cells["Report"].Value;
            pbPicture.Image = (Image)dgvCarReport.CurrentRow.Cells["Picture"].Value;

        }

        //�ꗗ�̍폜�{�^��
        private void btDeleteReport_Click(object sender, EventArgs e) {
            if ((dgvCarReport.CurrentRow == null) || (!dgvCarReport.CurrentRow.Selected)) return;

            listCarReports.RemoveAt(dgvCarReport.CurrentRow.Index);
            dgvCarReport.ClearSelection();


        }

        //�ꗗ�̏C���{�^��
        private void btModifyReport_Click(object sender, EventArgs e) {
            if ((dgvCarReport.CurrentRow == null) || (!dgvCarReport.CurrentRow.Selected)) return;

            listCarReports[dgvCarReport.CurrentRow.Index].Date = dtpDate.Value;
            listCarReports[dgvCarReport.CurrentRow.Index].Auther = cbAuthor.Text;
            listCarReports[dgvCarReport.CurrentRow.Index].Maker = GetRadioButtonMaker();
            listCarReports[dgvCarReport.CurrentRow.Index].CarName = cbCarName.Text;
            listCarReports[dgvCarReport.CurrentRow.Index].Report = tbReport.Text;
            listCarReports[dgvCarReport.CurrentRow.Index].Picture = pbPicture.Image;

            dgvCarReport.Refresh(); //�f�[�^�O���b�h�r���[�̍X�V

            if (cbAuthor.Text == "" || cbCarName.Text == "") {
                tslbMessage.Text = "�L�^�ҁA�܂��Ԗ��������͂ł�";
                return;
            }
        }

        //�L�^�҂̃e�L�X�g���ҏW���ꂽ��
        private void cbAuthor_TextChanged(object sender, EventArgs e) {
            tslbMessage.Text = "";


        }

        //�Ԗ��̃e�L�X�g���ҏW���ꂽ��
        private void cbCarName_TextChanged(object sender, EventArgs e) {
            tslbMessage.Text = "";
        }

        //�ۑ��{�^��
        private void btReportSave_Click(object sender, EventArgs e) {
            ReportSaveFile();
        }

        //�ۑ��{�^��(���g)
        private void ReportSaveFile() {
            if (sfdReportFileSave.ShowDialog() == DialogResult.OK) {
                try {
                    //�o�C�i���`���ŃV���A����
#pragma warning disable SYSLIB0011 // �^�܂��̓����o�[�����^���ł�
                    var bf = new BinaryFormatter();
#pragma warning restore SYSLIB0011 // �^�܂��̓����o�[�����^���ł�
                    using (FileStream fs = File.Open(sfdReportFileSave.FileName, FileMode.Create)) {
                        bf.Serialize(fs, listCarReports);

                    }
                }
                catch (Exception) {
                    tslbMessage.Text = "�������݃G���[";


                }

            }
        }

        //�ꗗ�̊J���{�^��
        private void btReportOpen_Click(object sender, EventArgs e) {
            ReportOpenFile();
        }

        //�J���{�^��(���g)
        private void ReportOpenFile() {
            if (ofdReportFileOpen.ShowDialog() == DialogResult.OK) {
                try {
                    //�t�V���A�����Ńo�C�i���`������荞��
#pragma warning disable SYSLIB0011 // �^�܂��̓����o�[�����^���ł�
                    var bf = new BinaryFormatter();
#pragma warning restore SYSLIB0011 // �^�܂��̓����o�[�����^���ł�
                    using (FileStream fs = File.Open(ofdReportFileOpen.FileName, FileMode.Open, FileAccess.Read)) {

                        listCarReports = (BindingList<CarReport>)bf.Deserialize(fs);
                        dgvCarReport.DataSource = listCarReports;

                        foreach (var carReport in listCarReports) {
                            setCbAuthor(carReport.Auther);
                            setCbCarName(carReport.CarName);
                        }
                    }

                }
                catch (Exception ex) {
                    tslbMessage.Text = "�t�@�C���`�����Ⴂ�܂�";
                }
                dgvCarReport.ClearSelection();



            }
        }

        //���ڃN���A�{�^��
        private void btInputItemClear_Click(object sender, EventArgs e) {
            InputItemAllClear();
            dgvCarReport.ClearSelection();
        }


        private void �J��ToolStripMenuItem_Click(object sender, EventArgs e) {
            ReportOpenFile();  //�t�@�C���I�[�v������
        }

        private void �ۑ�ToolStripMenuItem_Click(object sender, EventArgs e) {
            ReportSaveFile();  //�t�@�C���Z�[�u����
        }

        private void �I��ToolStripMenuItem_Click(object sender, EventArgs e) {
            if (MessageBox.Show("�{���ɏI�����܂����H", "�m�F", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();


        }


    }
}