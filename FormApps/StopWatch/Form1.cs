using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace StopWatch {
    public partial class Form1 : Form {

        Stopwatch sw = new Stopwatch();

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            TimeDispray.Text = "00:00:00.00";
        }
        //スタートボタンのイベントハンドラ
        private void Start_Button_Click(object sender, EventArgs e) {
            sw.Start();
            tmDispTimer.Start();//画面更新用のタイマーをスタート
        }

        private void Stop_Button_Click(object sender, EventArgs e) {
            sw.Stop();
            tmDispTimer.Stop();
        }

        private void Reset_Button_Click(object sender, EventArgs e) {
            sw.Reset();
        }

        private void tmDispTimer_Tick(object sender, EventArgs e) {
            TimeDispray.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\.ff");
        }
    }
}
