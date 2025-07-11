using System.ComponentModel;
using System.Drawing.Text;
using System.Linq.Expressions;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms.VisualStyles;
using System.Xml;
using System.Xml.Serialization;
using static CarReportSystem.CarReport;

namespace CarReportSystem {
    public partial class Form1 : Form {
        BindingList<CarReport> listCarReports = new BindingList<CarReport>();

        Settings settings = Settings.getInstance();

        public Form1() {
            InitializeComponent();
            dgvRecord.DataSource = listCarReports;
            //�F�ݒ�t�@�C���ǂݍ���
            if (File.Exists("setting.xml")) {
                try {
                    using (var reader = XmlReader.Create("setting.xml")) {
                        var serializer = new XmlSerializer(typeof(Settings));
                        var colorset = serializer.Deserialize(reader) as Settings;
                        settings = colorset ?? new Settings();
                        BackColor = Color.FromArgb(settings.MainFormBackColor);
                    }
                }
                catch (Exception ex) {
                    tsslbMessage.Text = ex.Message;
                }
            }
        }

        private void btPicOpen_Click(object sender, EventArgs e) {
            if (ofdPicFileOpen.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdPicFileOpen.FileName);
            }
        }

        private void btPicDelete_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        private void btRecordAdd_Click(object sender, EventArgs e) {
            if (cbAuthor.Text == "" || cbCarName.Text == "") {
                tsslbMessage.Text = "�L�^�ҁA�܂��͎Ԗ��������͂ł�";
                return;
            }
            listCarReports.Add(makeCarReportslist());
            setCbAuthor(cbAuthor.Text);
            setCbCarName(cbCarName.Text);
            ClearAllWriting();
            tsslbMessage.Text = "�ǉ�����";
        }

        private void btRecordModify_Click(object sender, EventArgs e) {
            if (dgvRecord.CurrentRow is null || !dgvRecord.CurrentCell.Selected) {
                tsslbMessage.Text = "�C�����闓��������܂���";
                return;
            }
            listCarReports[dgvRecord.CurrentRow.Index] = makeCarReportslist();
            tsslbMessage.Text = "�C������";
        }

        private void btRecordDelete_Click(object sender, EventArgs e) {
            if (dgvRecord.CurrentCell is null || !dgvRecord.CurrentCell.Selected) {
                tsslbMessage.Text = "�폜���闓��������܂���";
                return;
            }
            listCarReports.RemoveAt(dgvRecord.CurrentRow.Index);
            tsslbMessage.Text = "�폜����";
        }

        private void btNewWrite_Click(object sender, EventArgs e) {
            ClearAllWriting();
        }

        private void dgvRecord_Click(object sender, EventArgs e) {
            if (dgvRecord.CurrentRow is null) {
                return;
            }
            dtpDate.Value = (DateTime)dgvRecord.CurrentRow.Cells["Date"].Value;
            cbAuthor.Text = (string)dgvRecord.CurrentRow.Cells["Author"].Value;
            setButtonMaker((MakerGroup)dgvRecord.CurrentRow.Cells["Maker"].Value);
            cbCarName.Text = (string)dgvRecord.CurrentRow.Cells["CarName"].Value;
            tbReport.Text = (string)dgvRecord.CurrentRow.Cells["Report"].Value;
            pbPicture.Image = (Image)dgvRecord.CurrentRow.Cells["Picture"].Value;
        }

        private void tsmiExit_Click(object sender, EventArgs e) {
            Close();
        }

        private void tsmiAbout_Click(object sender, EventArgs e) {
            fmVersion fmv = new fmVersion();
            fmv.Show();
        }

        private void tsmiColorOption_Click(object sender, EventArgs e) {
            if (cdColor.ShowDialog() == DialogResult.OK) {
                BackColor = cdColor.Color;
                //�ݒ�t�@�C���֕ۑ�
                settings.MainFormBackColor = cdColor.Color.ToArgb();
            }
        }

        private void tsmiSave_Click(object sender, EventArgs e) {
            reportSaveFile();
        }

        private void tsmiOpen_Click(object sender, EventArgs e) {
            reportOpenFile();
        }

        /// <summary>
        /// �L�^���̃��W�I�{�^����Ԃ��܂��B
        /// </summary>
        /// <param name="targetMaker"></param>
        private void setButtonMaker(MakerGroup targetMaker) {
            switch (targetMaker) {
                case MakerGroup.�Ȃ�:
                    rbToyota.Checked = false;
                    rbNissan.Checked = false;
                    rbHonda.Checked = false;
                    rbSubaru.Checked = false;
                    rbImport.Checked = false;
                    rbOther.Checked = false;
                    break;
                case MakerGroup.�g���^:
                    rbToyota.Checked = true;
                    break;
                case MakerGroup.���Y:
                    rbNissan.Checked = true;
                    break;
                case MakerGroup.�z���_:
                    rbHonda.Checked = true;
                    break;
                case MakerGroup.�X�o��:
                    rbSubaru.Checked = true;
                    break;
                case MakerGroup.�A����:
                    rbImport.Checked = true;
                    break;
                case MakerGroup.���̑�:
                    rbOther.Checked = true;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// �I������Ă��郉�W�I�{�^���ɉ������ԓ���Ԃ��܂��B
        /// </summary>
        /// <returns></returns>
        private MakerGroup GetButtonMakers() {
            if (rbToyota.Checked) return MakerGroup.�g���^;
            else if (rbNissan.Checked) return MakerGroup.���Y;
            else if (rbHonda.Checked) return MakerGroup.�z���_;
            else if (rbSubaru.Checked) return MakerGroup.�X�o��;
            else if (rbImport.Checked) return MakerGroup.�A����;
            else return MakerGroup.���̑�;
        }

        /// <summary>
        /// �R���{�{�b�N�X�֋L�^�҂̗�����ǉ����܂��B
        /// </summary>
        /// <param name="author"></param>
        private void setCbAuthor(string author) {
            //���ɓo�^�ς݂��m�F
            if (cbAuthor.Items.Contains(author)) {
                return;
            } else if (author is null) {
                return;
            }
            cbAuthor.Items.Add(author);
        }

        /// <summary>
        /// �R���{�{�b�N�X�֎Ԗ��̗�����ǉ����܂��B
        /// </summary>
        /// <param name="carname"></param>
        private void setCbCarName(string carname) {
            if (cbCarName.Items.Contains(carname)) {
                return;
            } else if (carname is null) {
                return;
            }
            cbCarName.Items.Add(carname);
        }

        /// <summary>
        /// �S�Ă̌��݂̋L�����폜
        /// </summary>
        private void ClearAllWriting() {
            dtpDate.Value = DateTime.Today;
            cbAuthor.Text = string.Empty;
            rbOther.Checked = true;
            rbOther.Checked = false;
            cbCarName.Text = string.Empty;
            tbReport.Text = string.Empty;
            pbPicture.Image = null;
        }

        /// <summary>
        /// �������܂ꂽ����CarReport�^�̃��X�g�ɓ���ĕԂ��܂��B
        /// </summary>
        /// <returns></returns>
        private CarReport makeCarReportslist() {
            var carReport = new CarReport {
                Date = dtpDate.Value,
                Author = cbAuthor.Text,
                Maker = GetButtonMakers(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                Picture = pbPicture.Image,
            };
            return carReport;
        }

        /// <summary>
        /// �t�@�C�����o�C�i���`���ŃZ�[�u���܂�
        /// </summary>
        private void reportSaveFile() {
            if (sfdReportFileSave.ShowDialog() == DialogResult.OK) {
                try {
                    //�o�C�i���`���ŃV���A����
#pragma warning disable SYSLIB0011
                    var bf = new BinaryFormatter();
#pragma warning restore SYSLIB0011
                    using (FileStream fs = File.Open(
                                        sfdReportFileSave.FileName, FileMode.Create)) {
                        bf.Serialize(fs, listCarReports);

                    }
                }
                catch (Exception ex) {

                    tsslbMessage.Text = "�t�@�C�������o���G���[" + ex.Message;
                }
            }
        }

        /// <summary>
        /// �o�C�i���t�@�C����ǂݍ��݂܂�
        /// </summary>
        private void reportOpenFile() {
            if (ofdReportFileOpen.ShowDialog() == DialogResult.OK) {
                try {
                    //�t�V���A�����Ńo�C�i���`������荞��
#pragma warning disable SYSLIB0011 // �^�܂��̓����o�[�����^���ł�
                    var bf = new BinaryFormatter();
#pragma warning restore SYSLIB0011 // �^�܂��̓����o�[�����^���ł�
                    using (FileStream fs = File.Open(ofdReportFileOpen.FileName, FileMode.Open, FileAccess.Read)) {
                        listCarReports = (BindingList<CarReport>)bf.Deserialize(fs);
                        dgvRecord.DataSource = listCarReports;

                        cbAuthor.Items.Clear();
                        cbCarName.Items.Clear();
                        //�R���{�{�b�N�X�֓o�^
                        foreach (var report in listCarReports) {
                            setCbAuthor(report.Author);
                            setCbCarName(report.CarName);
                        }

                    }
                }
                catch (Exception ex) {
                    tsslbMessage.Text = "�t�@�C���`�����Ⴂ�܂�" + ex.Message;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            ClearAllWriting();

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            try {
                //�ݒ�t�@�C���֐F�����V���A�����ۑ����鏈��
                using (var Color = XmlWriter.Create("setting.xml")) {
                    var serializer = new XmlSerializer(settings.GetType());
                    serializer.Serialize(Color, settings);
                }
            }
            catch (Exception ex) {
                tsslbMessage.Text = ex.Message;
            }

        }
    }
}
