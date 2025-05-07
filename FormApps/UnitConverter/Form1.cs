using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitConverter
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Conversion_Button_Click(object sender, EventArgs e) {
            int inval = int.Parse(BeforeConversion_tb.Text);
            double outval = inval * 0.3048;
            AfterConversion_tb.Text = outval.ToString();
        }

        private void Division_Button_Click(object sender, EventArgs e) {
            ErrorBox.Text = "";
            if (WaruCount.Value!=0) {
           Answer.Value=Math.Floor(WarareruCount.Value / WaruCount.Value);
           Remainder.Value = WarareruCount.Value%WaruCount.Value;
            } else {
                ErrorBox.Text = "ERROR";
            }

        }
    }
}
