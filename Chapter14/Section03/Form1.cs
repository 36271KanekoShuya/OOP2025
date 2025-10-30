using System.Diagnostics;
using System.Threading.Tasks;

namespace Section03 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e) {
            toolStripStatusLabel1.Text = "";
            var elapsed = await DoLongTimeWorkAsync(4000);

            toolStripStatusLabel1.Text = $"èIóπ {elapsed}É~Éäïb";
        }

        private async Task<long> DoLongTimeWorkAsync(int y) {
            var sw = Stopwatch.StartNew();
            await Task.Run(() => System.Threading.Thread.Sleep(y));
            sw.Stop();
            return sw.ElapsedMilliseconds;
        }

    }
}
