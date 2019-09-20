using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
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
        public DataSet Events { get; set; }
        public Dictionary<int, EventViewModel> EventDictionary { get; set; }
        public Frm_Main()
        {
            InitializeComponent();
            cmbConv1.SelectedIndex = 0;
            cmbConv2.SelectedIndex = 0;
            LoadEvents();
            LoadEventsThisMonth();
        }

        private void LoadEventsThisMonth()
        {
            var currentMonth = DateTime.Today.Month;
            var currentYear = DateTime.Today.Year;
            List<string> eventsThisMonth = new List<string>();

            for (int i = 0; i < EventDictionary.Count; i++)
            {
                if (EventDictionary[i].Date.Month == currentMonth && EventDictionary[i].Date.Year == currentYear)
                {
                  eventsThisMonth.Add(EventDictionary[i].Name + " - " + EventDictionary[i].Date.ToString("d"));}
            }

            if (eventsThisMonth.Count == 0)
            {
                txtDaysEvents.Text = "No Events This Month";
            }
            else
            {
                foreach (var item in eventsThisMonth)
                {
                    txtDaysEvents.AppendText("\n\r" + item);
                }
            }

        }

        public void LoadEvents()
        {
            Events = GetEvents();

            EventDictionary = new Dictionary<int, EventViewModel>();

            for (int i = 0; i < Events.Tables[0].Rows.Count; i++)
            {
                EventDictionary.Add(i, new EventViewModel
                {
                    EventId = (int)Events.Tables[0].Rows[i]["Event_Id"],
                    Name = Events.Tables[0].Rows[i]["Event"].ToString(),
                    Date = (DateTime)Events.Tables[0].Rows[i]["Date"],
                    DateAdded = (DateTime)Events.Tables[0].Rows[i]["Date_Added"],
                    //DateExpired = (DateTime)Events.Tables[0].Rows[i]["Date_Expired"]
                });
            }

            //Load Events Combobox
            Dictionary<int, string> cmbEvents = new Dictionary<int, string>();
            for (int i = 0; i < EventDictionary.Count; i++)
            {
                cmbEvents.Add(i, EventDictionary[i].Name);
            }

            cmbDays.DataSource = new BindingSource(cmbEvents, null);
            cmbDays.ValueMember = "Key";
            cmbDays.DisplayMember = "Value";
        }

        public DataSet GetEvents()
        {
            SqlConnection connection;
            SqlCommand cmd;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            string sql;

            var connectString = Settings.Default.LocalDb;
            connection = new SqlConnection(connectString);

            try
            {
                connection.Open();
                sql = "" +
                      "SELECT * " +
                      "FROM EventsView " +
                      "WHERE Date >= CAST(GETDATE() as date) AND " +
                      "Date_Expired IS NULL"; //Won't get older dates'
                cmd = new SqlCommand(sql, connection);
                adapter.SelectCommand = cmd;
                adapter.Fill(ds, "EventsView");
                adapter.Dispose();
                cmd.Dispose();
                connection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Cannot Open Connection...\n\r\n\r" + exception, "Time Traveler", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            return ds;
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

        private void CmbDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = cmbDays.SelectedIndex;

            dateTimePickerDays.Text = EventDictionary[index].Date.ToString();

            var today = DateTime.Today;
            var futureDate = EventDictionary[index].Date;
            var span = futureDate - today;
            txtDays.Text = span.Days + " Days";
        }

        private void BtnDaysAdd_Click(object sender, EventArgs e)
        {
            dateTimePickerDays.Enabled = true;
            txtDaysEvent.ReadOnly = false;
            btnDaysEdit.Enabled = false;
            btnDaysDelete.Enabled = false;
            btnDaysCancel.Enabled = true;
            cmbDays.Enabled = false;
            btnDaysEnter.Enabled = true;

            dateTimePickerDays.Text = DateTime.Today.ToString();
        }

        private void BtnDaysCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Cancel?", "Time Traveler", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Reset(sender, e);
            }
        }

        private void Reset(object sender, EventArgs e)
        {
            dateTimePickerDays.Enabled = false;
            txtDaysEvent.ReadOnly = true;
            btnDaysAdd.Enabled = true;
            btnDaysEdit.Enabled = true;
            btnDaysDelete.Enabled = true;
            btnDaysCancel.Enabled = false;
            cmbDays.Enabled = true;
            btnDaysEnter.Enabled = false;
            txtDaysEvent.Text = "";
            txtDaysEvent.Enabled = false;

            CmbDays_SelectedIndexChanged(sender, e);
        }

        private void BtnDaysEnter_Click(object sender, EventArgs e)
        {
            var addEnabled = btnDaysAdd.Enabled;
            var editEnabled = btnDaysEdit.Enabled;
            var deleteEnabled = btnDaysDelete.Enabled;

            if (addEnabled)
            {
                if (string.IsNullOrEmpty(txtDaysEvent.Text))
                {
                    MessageBox.Show("Cannot Leave Blank", "Time Traveler", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    txtDaysEvent.Focus();
                }

                var result = MessageBox.Show("Add New Event: " + txtDaysEvent.Text + "?", "Time Traveler",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    SqlConnection connection;
                    SqlCommand command;
                    var connectionString = Settings.Default.LocalDb;
                    connection = new SqlConnection(connectionString);
                    
                    var sql = "INSERT INTO Event (Event, Date, Date_Added) " +
                          "Values (@Event,@Date,@DateAdded)";
                    try
                    {
                        connection.Open();
                        command = new SqlCommand(sql, connection);
                        command.Parameters.AddWithValue("@Event", txtDaysEvent.Text);
                        command.Parameters.AddWithValue("@Date", Convert.ToDateTime(dateTimePickerDays.Text));
                        command.Parameters.AddWithValue("@DateAdded", DateTime.Today);
                        command.ExecuteNonQuery();
                        MessageBox.Show(txtDaysEvent.Text + " Added...", "Time Traveler", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtDaysEvents.Clear();
                        LoadEvents();
                        LoadEventsThisMonth();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Could Not Save Event...\n\r" + ex, "Time Traveler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            if (editEnabled)
            {
                if (string.IsNullOrEmpty(txtDaysEvent.Text))
                {
                    MessageBox.Show("Cannot Leave Blank", "Time Traveler", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    txtDaysEvent.Focus();
                }

                var result = MessageBox.Show("Save: " + txtDaysEvent.Text + "?", "Time Traveler",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var eventId = EventDictionary[cmbDays.SelectedIndex].EventId;
                    SqlConnection connection;
                    SqlCommand command;
                    var connectionString = Settings.Default.LocalDb;
                    connection = new SqlConnection(connectionString);

                    var sql = "UPDATE Event Set " +
                              "Event = '" + txtDaysEvent.Text + "', " +
                              "Date = '" + dateTimePickerDays.Value.Date + "' " +
                              "WHERE Event_Id = " + eventId;
                    try
                    {
                        connection.Open();
                        command = new SqlCommand(sql, connection);
                        command.ExecuteNonQuery();
                        command.Dispose();
                        connection.Close();

                        MessageBox.Show(txtDaysEvent.Text + " Saved...", "Time Traveler", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        txtDaysEvents.Clear();
                        LoadEvents();
                        LoadEventsThisMonth();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Could Not Save Event...\n\r" + ex, "Time Traveler", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnDaysEdit_Click(object sender, EventArgs e)
        {
            btnDaysAdd.Enabled = false;
            btnDaysDelete.Enabled = false;
            btnDaysEnter.Enabled = true;
            btnDaysCancel.Enabled = true;
            cmbDays.Enabled = false;
            dateTimePickerDays.Enabled = true;
            txtDaysEvent.ReadOnly = false;

            txtDaysEvent.Text = cmbDays.Text;
        }

        private void BtnDaysDelete_Click(object sender, EventArgs e)
        {
            btnDaysAdd.Enabled = false;
            btnDaysEdit.Enabled = false;
            txtDaysEvent.Text = cmbDays.Text;

            var result = MessageBox.Show("Delete " + cmbDays.Text + "?", "Time Traveler", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                var index = cmbDays.SelectedIndex;
                var dbId = EventDictionary[index].EventId;

                SqlConnection connection;
                SqlDataAdapter adapter = new SqlDataAdapter();
                var connetionString = Settings.Default.LocalDb;
                connection = new SqlConnection(connetionString);
                var sql = "UPDATE Event Set Date_Expired = GETDATE() WHERE Event_Id = " + dbId;
                try
                {
                    connection.Open();
                    adapter.UpdateCommand = connection.CreateCommand();
                    adapter.UpdateCommand.CommandText = sql;
                    adapter.UpdateCommand.ExecuteNonQuery();
                    MessageBox.Show(cmbDays.Text + " Deleted...", "Time Traveler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to Delete... \n\r" + ex, "Time Traveler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            dateTimePickerDays.Enabled = false;
            txtDaysEvent.ReadOnly = true;
            btnDaysAdd.Enabled = true;
            btnDaysEdit.Enabled = true;
            btnDaysDelete.Enabled = true;
            btnDaysCancel.Enabled = false;
            cmbDays.Enabled = true;
            btnDaysEnter.Enabled = false;
            txtDaysEvent.Text = "";
            txtDaysEvent.Enabled = false;

            LoadEvents();
            CmbDays_SelectedIndexChanged(sender, e);
            txtDaysEvents.Clear();
            LoadEventsThisMonth();
        }
    }
}