using System;
using System.Windows.Forms;

namespace TemperatureConverter
{
    public partial class Form1 : Form
    {
        private Single num1;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(txtNum1.Text, out _))
            {
                MessageBox.Show("This is a number only field");
            }
            else
            {
                lblAnswer.Text = chckbxSwitch.Checked ? ConvertF2C(txtNum1.Text) : ConvertC2F(txtNum1.Text);
            }
        }

        private void chckbxSwitch_CheckedChanged(object sender, EventArgs e)
        {
            lblUnit1.Text = chckbxSwitch.Checked ? "°F  to °C" : "°C  to °F";
        }

        public string ConvertC2F(string Num1)
        {
            num1 = Convert.ToSingle(Num1);

            var result = num1 * 9 / 5 + 32 + "°F";

            return result.ToString();
        }

        public string ConvertF2C(string Num1)
        {
            num1 = Convert.ToSingle(Num1) - 32;

            var result = (float)Math.Round(num1 * 5 / 9, 2) + "°C ";

            return result.ToString();
        }
    }
}
