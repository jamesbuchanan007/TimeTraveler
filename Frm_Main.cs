using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Deployment.Application;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTraveler.Classes;
using TimeTraveler.Properties;

namespace TimeTraveler
{
    public partial class Frm_Main : Form
    {
        Timer t = new Timer();

        public Frm_Main()
        {
            InitializeComponent();
            cmbConv1.SelectedIndex = 0;
            cmbConv2.SelectedIndex = 0;

            try
            {
                var version = ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString(4);
                lblVersion.Text = "Version: " + version;

            }
            catch (Exception e)
            {
                lblVersion.Text = "Version: Debug";
            }

            Clock();
        }

        private void Clock()
        {
          
            t.Interval = 1000;
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("F");
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
            txtDurSeconds.Text = dc.DurationDays.Seconds.ToString();
            txtDurHourlyDecimal.Text = dc.Hourly.ToString("F");
        }

        private void BtnDurClear_Click(object sender, EventArgs e)
        {
            txtHourStart.Clear();
            txtMinStart.Clear();
            txtSecStart.Clear();
            txtHourEnd.Clear();
            txtMinEnd.Clear();
            txtSecEnd.Clear();
            txtDurHours.Clear();
            txtDurHourlyDecimal.Clear();
            txtDurSeconds.Clear();
            txtDurDays.Clear();
            txtDurMinutes.Clear();
            dateTimePickerDuration1.Text = DateTime.Today.ToString();
            dateTimePickerDuration2.Text = DateTime.Today.ToString();
            txtHourStart.Focus();
        }
        public int IsNumber(TextBox textBox)
        {
            var text = textBox.Text;
            var check = int.TryParse(text, out var result);
            if (string.IsNullOrEmpty(text)) return 0;
            if (!check)
            {
                MessageBox.Show("Must Be an Number", "Time Traveler", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                textBox.Clear();
                textBox.Focus();

                return 0;
            }

            return result;
        }

        public void BtnDurCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtDurHourlyDecimal.Text);
            MessageBox.Show("Added to Clipboard", "Time Traveler", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnConvCalculate_Click(object sender, EventArgs e)
        {
            if (txtConvRequest.Text.Contains("."))
            {
                MessageBox.Show("Must Be a Whole Number, No Decimals", "Time Traveler", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                txtConvRequest.Clear();
                txtConvRequest.Focus();
                return;
            }

            var tc = new TimerConverter();
            tc.Request = IsNumber(txtConvRequest);
            tc.TimeUnit1 = cmbConv1.Text;
            tc.TimeUnit2 = cmbConv2.Text;
            txtConvResult.Text = tc.Convert.ToString();
        }

        private void BtnConvClear_Click(object sender, EventArgs e)
        {
            cmbConv1.SelectedIndex = 0;
            cmbConv2.SelectedIndex = 0;
            txtConvRequest.Clear();
            txtConvResult.Clear();
            txtConvRequest.Focus();
        }

        private void BtnConvCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtConvResult.Text); MessageBox.Show("Added to Clipboard", "Time Traveler", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}