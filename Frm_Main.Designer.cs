namespace TimeTraveler
{
    partial class Frm_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDurClear = new System.Windows.Forms.Button();
            this.btnDurCalculate = new System.Windows.Forms.Button();
            this.btnDurCopy = new System.Windows.Forms.Button();
            this.txtDurHourlyDecimal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDurSeconds = new System.Windows.Forms.TextBox();
            this.txtDurMinutes = new System.Windows.Forms.TextBox();
            this.txtDurHours = new System.Windows.Forms.TextBox();
            this.txtDurDays = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSecEnd = new System.Windows.Forms.TextBox();
            this.txtMinEnd = new System.Windows.Forms.TextBox();
            this.txtHourEnd = new System.Windows.Forms.TextBox();
            this.txtSecStart = new System.Windows.Forms.TextBox();
            this.txtMinStart = new System.Windows.Forms.TextBox();
            this.txtHourStart = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerDuration2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDuration1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnConvCopy = new System.Windows.Forms.Button();
            this.btnConvClear = new System.Windows.Forms.Button();
            this.btnConvCalculate = new System.Windows.Forms.Button();
            this.txtConvResult = new System.Windows.Forms.TextBox();
            this.cmbConv2 = new System.Windows.Forms.ComboBox();
            this.txtConvRequest = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbConv1 = new System.Windows.Forms.ComboBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Controls.Add(this.btnDurClear);
            this.groupBox1.Controls.Add(this.btnDurCalculate);
            this.groupBox1.Controls.Add(this.btnDurCopy);
            this.groupBox1.Controls.Add(this.txtDurHourlyDecimal);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtDurSeconds);
            this.groupBox1.Controls.Add(this.txtDurMinutes);
            this.groupBox1.Controls.Add(this.txtDurHours);
            this.groupBox1.Controls.Add(this.txtDurDays);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtSecEnd);
            this.groupBox1.Controls.Add(this.txtMinEnd);
            this.groupBox1.Controls.Add(this.txtHourEnd);
            this.groupBox1.Controls.Add(this.txtSecStart);
            this.groupBox1.Controls.Add(this.txtMinStart);
            this.groupBox1.Controls.Add(this.txtHourStart);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePickerDuration2);
            this.groupBox1.Controls.Add(this.dateTimePickerDuration1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(13, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 268);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Duration Calculator";
            // 
            // btnDurClear
            // 
            this.btnDurClear.BackColor = System.Drawing.Color.Red;
            this.btnDurClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDurClear.ForeColor = System.Drawing.Color.White;
            this.btnDurClear.Location = new System.Drawing.Point(257, 236);
            this.btnDurClear.Name = "btnDurClear";
            this.btnDurClear.Size = new System.Drawing.Size(75, 23);
            this.btnDurClear.TabIndex = 11;
            this.btnDurClear.Text = "Clear";
            this.btnDurClear.UseVisualStyleBackColor = false;
            this.btnDurClear.Click += new System.EventHandler(this.BtnDurClear_Click);
            // 
            // btnDurCalculate
            // 
            this.btnDurCalculate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDurCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDurCalculate.ForeColor = System.Drawing.Color.White;
            this.btnDurCalculate.Location = new System.Drawing.Point(338, 236);
            this.btnDurCalculate.Name = "btnDurCalculate";
            this.btnDurCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnDurCalculate.TabIndex = 9;
            this.btnDurCalculate.Text = "Calculate";
            this.btnDurCalculate.UseVisualStyleBackColor = false;
            this.btnDurCalculate.Click += new System.EventHandler(this.BtnDurCalculate_Click);
            // 
            // btnDurCopy
            // 
            this.btnDurCopy.BackColor = System.Drawing.Color.Green;
            this.btnDurCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDurCopy.ForeColor = System.Drawing.Color.White;
            this.btnDurCopy.Location = new System.Drawing.Point(92, 236);
            this.btnDurCopy.Name = "btnDurCopy";
            this.btnDurCopy.Size = new System.Drawing.Size(75, 23);
            this.btnDurCopy.TabIndex = 10;
            this.btnDurCopy.Text = "Copy";
            this.btnDurCopy.UseVisualStyleBackColor = false;
            this.btnDurCopy.Click += new System.EventHandler(this.BtnDurCopy_Click);
            // 
            // txtDurHourlyDecimal
            // 
            this.txtDurHourlyDecimal.Location = new System.Drawing.Point(10, 238);
            this.txtDurHourlyDecimal.Name = "txtDurHourlyDecimal";
            this.txtDurHourlyDecimal.ReadOnly = true;
            this.txtDurHourlyDecimal.Size = new System.Drawing.Size(75, 20);
            this.txtDurHourlyDecimal.TabIndex = 26;
            this.txtDurHourlyDecimal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 219);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Hourly Decimal";
            // 
            // txtDurSeconds
            // 
            this.txtDurSeconds.Location = new System.Drawing.Point(169, 178);
            this.txtDurSeconds.Name = "txtDurSeconds";
            this.txtDurSeconds.ReadOnly = true;
            this.txtDurSeconds.Size = new System.Drawing.Size(47, 20);
            this.txtDurSeconds.TabIndex = 24;
            this.txtDurSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDurMinutes
            // 
            this.txtDurMinutes.Location = new System.Drawing.Point(116, 178);
            this.txtDurMinutes.Name = "txtDurMinutes";
            this.txtDurMinutes.ReadOnly = true;
            this.txtDurMinutes.Size = new System.Drawing.Size(47, 20);
            this.txtDurMinutes.TabIndex = 23;
            this.txtDurMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDurHours
            // 
            this.txtDurHours.Location = new System.Drawing.Point(63, 178);
            this.txtDurHours.Name = "txtDurHours";
            this.txtDurHours.ReadOnly = true;
            this.txtDurHours.Size = new System.Drawing.Size(47, 20);
            this.txtDurHours.TabIndex = 22;
            this.txtDurHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDurDays
            // 
            this.txtDurDays.Location = new System.Drawing.Point(10, 178);
            this.txtDurDays.Name = "txtDurDays";
            this.txtDurDays.ReadOnly = true;
            this.txtDurDays.Size = new System.Drawing.Size(47, 20);
            this.txtDurDays.TabIndex = 21;
            this.txtDurDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(117, 159);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Minutes";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(166, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Seconds";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(68, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Hours";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Days";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Duration";
            // 
            // txtSecEnd
            // 
            this.txtSecEnd.Location = new System.Drawing.Point(279, 84);
            this.txtSecEnd.Name = "txtSecEnd";
            this.txtSecEnd.Size = new System.Drawing.Size(27, 20);
            this.txtSecEnd.TabIndex = 8;
            this.txtSecEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMinEnd
            // 
            this.txtMinEnd.Location = new System.Drawing.Point(246, 84);
            this.txtMinEnd.Name = "txtMinEnd";
            this.txtMinEnd.Size = new System.Drawing.Size(27, 20);
            this.txtMinEnd.TabIndex = 7;
            this.txtMinEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHourEnd
            // 
            this.txtHourEnd.Location = new System.Drawing.Point(213, 84);
            this.txtHourEnd.Name = "txtHourEnd";
            this.txtHourEnd.Size = new System.Drawing.Size(27, 20);
            this.txtHourEnd.TabIndex = 6;
            this.txtHourEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSecStart
            // 
            this.txtSecStart.Location = new System.Drawing.Point(76, 84);
            this.txtSecStart.Name = "txtSecStart";
            this.txtSecStart.Size = new System.Drawing.Size(27, 20);
            this.txtSecStart.TabIndex = 5;
            this.txtSecStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMinStart
            // 
            this.txtMinStart.Location = new System.Drawing.Point(43, 84);
            this.txtMinStart.Name = "txtMinStart";
            this.txtMinStart.Size = new System.Drawing.Size(27, 20);
            this.txtMinStart.TabIndex = 4;
            this.txtMinStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHourStart
            // 
            this.txtHourStart.Location = new System.Drawing.Point(10, 84);
            this.txtHourStart.Name = "txtHourStart";
            this.txtHourStart.Size = new System.Drawing.Size(27, 20);
            this.txtHourStart.TabIndex = 3;
            this.txtHourStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Sec";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(248, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Min";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(212, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Hour";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sec";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Min";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hour";
            // 
            // dateTimePickerDuration2
            // 
            this.dateTimePickerDuration2.Location = new System.Drawing.Point(213, 37);
            this.dateTimePickerDuration2.Name = "dateTimePickerDuration2";
            this.dateTimePickerDuration2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDuration2.TabIndex = 2;
            // 
            // dateTimePickerDuration1
            // 
            this.dateTimePickerDuration1.Location = new System.Drawing.Point(7, 37);
            this.dateTimePickerDuration1.Name = "dateTimePickerDuration1";
            this.dateTimePickerDuration1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDuration1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date End";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date Start";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MidnightBlue;
            this.groupBox2.Controls.Add(this.btnConvCopy);
            this.groupBox2.Controls.Add(this.btnConvClear);
            this.groupBox2.Controls.Add(this.btnConvCalculate);
            this.groupBox2.Controls.Add(this.txtConvResult);
            this.groupBox2.Controls.Add(this.cmbConv2);
            this.groupBox2.Controls.Add(this.txtConvRequest);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.cmbConv1);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 299);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(424, 145);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Time Converter";
            // 
            // btnConvCopy
            // 
            this.btnConvCopy.BackColor = System.Drawing.Color.Green;
            this.btnConvCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvCopy.ForeColor = System.Drawing.Color.White;
            this.btnConvCopy.Location = new System.Drawing.Point(158, 110);
            this.btnConvCopy.Name = "btnConvCopy";
            this.btnConvCopy.Size = new System.Drawing.Size(75, 23);
            this.btnConvCopy.TabIndex = 17;
            this.btnConvCopy.Text = "Copy";
            this.btnConvCopy.UseVisualStyleBackColor = false;
            this.btnConvCopy.Click += new System.EventHandler(this.BtnConvCopy_Click);
            // 
            // btnConvClear
            // 
            this.btnConvClear.BackColor = System.Drawing.Color.Red;
            this.btnConvClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvClear.ForeColor = System.Drawing.Color.White;
            this.btnConvClear.Location = new System.Drawing.Point(258, 110);
            this.btnConvClear.Name = "btnConvClear";
            this.btnConvClear.Size = new System.Drawing.Size(75, 23);
            this.btnConvClear.TabIndex = 18;
            this.btnConvClear.Text = "Clear";
            this.btnConvClear.UseVisualStyleBackColor = false;
            this.btnConvClear.Click += new System.EventHandler(this.BtnConvClear_Click);
            // 
            // btnConvCalculate
            // 
            this.btnConvCalculate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnConvCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvCalculate.ForeColor = System.Drawing.Color.White;
            this.btnConvCalculate.Location = new System.Drawing.Point(339, 110);
            this.btnConvCalculate.Name = "btnConvCalculate";
            this.btnConvCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnConvCalculate.TabIndex = 16;
            this.btnConvCalculate.Text = "Calculate";
            this.btnConvCalculate.UseVisualStyleBackColor = false;
            this.btnConvCalculate.Click += new System.EventHandler(this.BtnConvCalculate_Click);
            // 
            // txtConvResult
            // 
            this.txtConvResult.Location = new System.Drawing.Point(8, 69);
            this.txtConvResult.Name = "txtConvResult";
            this.txtConvResult.ReadOnly = true;
            this.txtConvResult.Size = new System.Drawing.Size(100, 20);
            this.txtConvResult.TabIndex = 15;
            this.txtConvResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbConv2
            // 
            this.cmbConv2.FormattingEnabled = true;
            this.cmbConv2.Items.AddRange(new object[] {
            "Days",
            "Hours",
            "Minutes",
            "Seconds",
            "Hourly Decimal"});
            this.cmbConv2.Location = new System.Drawing.Point(121, 69);
            this.cmbConv2.Name = "cmbConv2";
            this.cmbConv2.Size = new System.Drawing.Size(121, 21);
            this.cmbConv2.TabIndex = 14;
            // 
            // txtConvRequest
            // 
            this.txtConvRequest.Location = new System.Drawing.Point(8, 19);
            this.txtConvRequest.Name = "txtConvRequest";
            this.txtConvRequest.Size = new System.Drawing.Size(100, 20);
            this.txtConvRequest.TabIndex = 13;
            this.txtConvRequest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(169, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(22, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "TO";
            // 
            // cmbConv1
            // 
            this.cmbConv1.FormattingEnabled = true;
            this.cmbConv1.Items.AddRange(new object[] {
            "Days",
            "Hours",
            "Minutes",
            "Seconds",
            "10-Second Data"});
            this.cmbConv1.Location = new System.Drawing.Point(121, 19);
            this.cmbConv1.Name = "cmbConv1";
            this.cmbConv1.Size = new System.Drawing.Size(121, 21);
            this.cmbConv1.TabIndex = 12;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.Location = new System.Drawing.Point(12, 6);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(48, 13);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "Version: ";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(219, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(214, 13);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Time and Date";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(454, 458);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time Traveler - Calculator and Converter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDurClear;
        private System.Windows.Forms.Button btnDurCalculate;
        private System.Windows.Forms.Button btnDurCopy;
        private System.Windows.Forms.TextBox txtDurHourlyDecimal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDurSeconds;
        private System.Windows.Forms.TextBox txtDurMinutes;
        private System.Windows.Forms.TextBox txtDurHours;
        private System.Windows.Forms.TextBox txtDurDays;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSecEnd;
        private System.Windows.Forms.TextBox txtMinEnd;
        private System.Windows.Forms.TextBox txtHourEnd;
        private System.Windows.Forms.TextBox txtSecStart;
        private System.Windows.Forms.TextBox txtMinStart;
        private System.Windows.Forms.TextBox txtHourStart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerDuration2;
        private System.Windows.Forms.DateTimePicker dateTimePickerDuration1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnConvCalculate;
        private System.Windows.Forms.TextBox txtConvResult;
        private System.Windows.Forms.ComboBox cmbConv2;
        private System.Windows.Forms.TextBox txtConvRequest;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbConv1;
        private System.Windows.Forms.Button btnConvCopy;
        private System.Windows.Forms.Button btnConvClear;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblTime;
    }
}

