using System.Windows.Forms;

namespace Exercise01 {
    public partial class Form1 : Form {
        string _filename;

        public Form1() {
            InitializeComponent();
        }

        private void bt_FileSelect_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "テキストファイル(*.txt)|*.txt";
            ofd.Title = "開くファイルを選択してください";
            if (ofd.ShowDialog() == DialogResult.OK) {
                tb_FileName.Text = ofd.FileName;
                _filename = ofd.FileName;
            }
        }

        private void bt_Read_Click(object sender, EventArgs e) {
            tb_SelectedText.Text = string.Empty;
            ReadTextAsync();
        }
        public async Task ReadTextAsync() {
            var filepath = _filename;
            await foreach (var line in File.ReadLinesAsync(filepath)) {
                tb_SelectedText.AppendText(line + Environment.NewLine);
            }
        }
    }
}
