using System.ComponentModel;
using System.Drawing.Text;
using System.Linq.Expressions;
using System.Runtime.Serialization.Formatters.Binary;
using static CarReportSystem.CarReport;

namespace CarReportSystem {
    public partial class Form1 : Form {
        BindingList<CarReport> listCarReports = new BindingList<CarReport>();

        public Form1() {
            InitializeComponent();
            dgvRecord.DataSource = listCarReports;
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
                tsslbMessage.Text = "記録者、または車名が未入力です";
                return;
            }
            listCarReports.Add(makeCarReportslist());
            setCbAuthor(cbAuthor.Text);
            setCbCarName(cbCarName.Text);
            ClearAllWriting();
            tsslbMessage.Text = "追加完了";
        }

        private void btRecordModify_Click(object sender, EventArgs e) {
            if (dgvRecord.CurrentRow is null || !dgvRecord.CurrentCell.Selected) {
                tsslbMessage.Text = "修正する欄が見つかりません";
                return;
            }
            listCarReports[dgvRecord.CurrentRow.Index] = makeCarReportslist();
            tsslbMessage.Text = "修正完了";
        }

        private void btRecordDelete_Click(object sender, EventArgs e) {
            if (dgvRecord.CurrentCell is null || !dgvRecord.CurrentCell.Selected) {
                tsslbMessage.Text = "削除する欄が見つかりません";
                return;
            }
            listCarReports.RemoveAt(dgvRecord.CurrentRow.Index);
            tsslbMessage.Text = "削除完了";
        }

        /// <summary>
        /// 全ての現在の記入を削除
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
            }

        }

        private void tsmiSave_Click(object sender, EventArgs e) {
            reportSaveFile();
        }

        private void tsmiOpen_Click(object sender, EventArgs e) {
            reportOpenFile();
        }

        /// <summary>
        /// 記録内のラジオボタンを返します。
        /// </summary>
        /// <param name="targetMaker"></param>
        private void setButtonMaker(MakerGroup targetMaker) {
            switch (targetMaker) {
                case MakerGroup.なし:
                    rbToyota.Checked = false;
                    rbNissan.Checked = false;
                    rbHonda.Checked = false;
                    rbSubaru.Checked = false;
                    rbImport.Checked = false;
                    rbOther.Checked = false;
                    break;
                case MakerGroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case MakerGroup.日産:
                    rbNissan.Checked = true;
                    break;
                case MakerGroup.ホンダ:
                    rbHonda.Checked = true;
                    break;
                case MakerGroup.スバル:
                    rbSubaru.Checked = true;
                    break;
                case MakerGroup.輸入車:
                    rbImport.Checked = true;
                    break;
                case MakerGroup.その他:
                    rbOther.Checked = true;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 選択されているラジオボタンに応じた返答を返します。
        /// </summary>
        /// <returns></returns>
        private MakerGroup GetButtonMakers() {
            if (rbToyota.Checked) return MakerGroup.トヨタ;
            else if (rbNissan.Checked) return MakerGroup.日産;
            else if (rbHonda.Checked) return MakerGroup.ホンダ;
            else if (rbSubaru.Checked) return MakerGroup.スバル;
            else if (rbImport.Checked) return MakerGroup.輸入車;
            else return MakerGroup.その他;
        }

        /// <summary>
        /// コンボボックスへ記録者の履歴を追加します。
        /// </summary>
        /// <param name="author"></param>
        private void setCbAuthor(string author) {
            //既に登録済みか確認
            if (cbAuthor.Items.Contains(author)) {
                return;
            } else if (author is null) {
                return;
            }
            cbAuthor.Items.Add(author);
        }

        /// <summary>
        /// コンボボックスへ車名の履歴を追加します。
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
        /// 書き込まれた情報をCarReport型のリストに入れて返します。
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
        /// ファイルをセーブします
        /// </summary>
        private void reportSaveFile() {
            if (sfdReportFileSave.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリ形式でシリアル化
#pragma warning disable SYSLIB0011
                    var bf = new BinaryFormatter();
#pragma warning restore SYSLIB0011
                    using (FileStream fs = File.Open(
                                        sfdReportFileSave.FileName, FileMode.Create)) {
                        bf.Serialize(fs, listCarReports);

                    }
                }
                catch (Exception e) {

                    tsslbMessage.Text = "ファイル書き出しエラー"+ e.Message;
                }
            }
        }

        /// <summary>
        /// ファイルを読み込みます
        /// </summary>
        private void reportOpenFile() {
            if (ofdReportFileOpen.ShowDialog() == DialogResult.OK) {
                try {
                    //逆シリアル化でバイナリ形式を取り込む
#pragma warning disable SYSLIB0011 // 型またはメンバーが旧型式です
                    var bf = new BinaryFormatter();
#pragma warning restore SYSLIB0011 // 型またはメンバーが旧型式です
                    using (FileStream fs = File.Open(ofdReportFileOpen.FileName, FileMode.Open, FileAccess.Read)) {
                        listCarReports = (BindingList < CarReport >) bf.Deserialize(fs);
                        dgvRecord.DataSource = listCarReports;

                        cbAuthor.Items.Clear();
                        cbCarName.Items.Clear();
                        //コンボボックスへ登録
                        foreach (var report in listCarReports) {
                            setCbAuthor(report.Author);
                            setCbCarName(report.CarName);
                        }

                    }
                }
                catch (Exception e) {
                    tsslbMessage.Text = "ファイル形式が違います" + e.Message;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            ClearAllWriting();

        }


    }
}
