using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTraveler
{
    public partial class Frm_Main : Form
    {

        public Frm_Main()
        {
            InitializeComponent();
        }

        private void BtnDurCalculate_Click(object sender, EventArgs e)
        {
            DurationCalculator dc = new DurationCalculator();
            dc.StartDate = Convert.ToDateTime(dateTimePickerDuration1.Text);
            dc.EndDate = Convert.ToDateTime(dateTimePickerDuration2.Text);
            dc.Hours1 = IsNumber(txtHourStart);
            dc.Minutes1 = IsNumber(txtMinStart);
            dc.Seconds1 = IsNumber(txtSecStart);
            dc.Hours2 = IsNumber(txtHourEnd);
            dc.Minutes2 = IsNumber(txtMinEnd);
            dc.Seconds2 = IsNumber(txtSecEnd);
            txtDurDays.Text = dc.DurationDays.Days.ToString();
            txtDurHours.Text = dc.DurationDays.Hours.ToString();
            txtDurMinutes.Text = dc.DurationDays.Minutes.ToString();
            txtDurSeconds.Text = dc.DurationDays.Minutes.ToString();
            txtDurHourlyDecimal.Text = dc.Hourly.ToString(CultureInfo.InvariantCulture);
        }

        public int IsNumber(TextBox textBox)
        {
            var text = textBox.Text;
            var check = int.TryParse(text, out var result);
            if (result == 0) return 0;
            if (!check)
            {
                MessageBox.Show("Must Be an Integer", "Time Traveler", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                textBox.Clear();
                textBox.Focus();

                return 0;
            }

            return result;
        }
    }
}
