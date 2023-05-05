
namespace client_schedule
{
    partial class UpdateAppointment
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.ConfirmBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.StartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.UserIdBox = new System.Windows.Forms.ComboBox();
            this.CustIdBox = new System.Windows.Forms.ComboBox();
            this.AppointTypeBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AppointmentIdBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MatchStartPicker = new System.Windows.Forms.DateTimePicker();
            this.MatchEndPicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Start  Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Appointment Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Customer ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "User ID";
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(282, 377);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 11;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.Location = new System.Drawing.Point(117, 377);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(75, 23);
            this.ConfirmBtn.TabIndex = 10;
            this.ConfirmBtn.Text = "Confirm";
            this.ConfirmBtn.UseVisualStyleBackColor = true;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "End Time";
            // 
            // StartTimePicker
            // 
            this.StartTimePicker.CustomFormat = "MM-dd-yyyy hh:mm tt";
            this.StartTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartTimePicker.Location = new System.Drawing.Point(188, 270);
            this.StartTimePicker.Name = "StartTimePicker";
            this.StartTimePicker.Size = new System.Drawing.Size(200, 20);
            this.StartTimePicker.TabIndex = 21;
            // 
            // EndTimePicker
            // 
            this.EndTimePicker.CustomFormat = "MM-dd-yyyy hh:mm tt";
            this.EndTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndTimePicker.Location = new System.Drawing.Point(188, 318);
            this.EndTimePicker.Name = "EndTimePicker";
            this.EndTimePicker.Size = new System.Drawing.Size(200, 20);
            this.EndTimePicker.TabIndex = 22;
            // 
            // UserIdBox
            // 
            this.UserIdBox.FormattingEnabled = true;
            this.UserIdBox.Location = new System.Drawing.Point(188, 168);
            this.UserIdBox.Name = "UserIdBox";
            this.UserIdBox.Size = new System.Drawing.Size(200, 21);
            this.UserIdBox.TabIndex = 23;
            // 
            // CustIdBox
            // 
            this.CustIdBox.FormattingEnabled = true;
            this.CustIdBox.Location = new System.Drawing.Point(188, 120);
            this.CustIdBox.Name = "CustIdBox";
            this.CustIdBox.Size = new System.Drawing.Size(200, 21);
            this.CustIdBox.TabIndex = 24;
            // 
            // AppointTypeBox
            // 
            this.AppointTypeBox.FormattingEnabled = true;
            this.AppointTypeBox.Location = new System.Drawing.Point(188, 218);
            this.AppointTypeBox.Name = "AppointTypeBox";
            this.AppointTypeBox.Size = new System.Drawing.Size(200, 21);
            this.AppointTypeBox.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Appointment Id";
            // 
            // AppointmentIdBox
            // 
            this.AppointmentIdBox.Location = new System.Drawing.Point(188, 66);
            this.AppointmentIdBox.Name = "AppointmentIdBox";
            this.AppointmentIdBox.ReadOnly = true;
            this.AppointmentIdBox.Size = new System.Drawing.Size(100, 20);
            this.AppointmentIdBox.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(419, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "End Time Conflict";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(416, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Start Time Conflict";
            // 
            // MatchStartPicker
            // 
            this.MatchStartPicker.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.MatchStartPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.MatchStartPicker.Location = new System.Drawing.Point(515, 264);
            this.MatchStartPicker.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.MatchStartPicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.MatchStartPicker.Name = "MatchStartPicker";
            this.MatchStartPicker.Size = new System.Drawing.Size(182, 20);
            this.MatchStartPicker.TabIndex = 33;
            this.MatchStartPicker.Value = new System.DateTime(2022, 12, 3, 0, 0, 0, 0);
            // 
            // MatchEndPicker
            // 
            this.MatchEndPicker.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.MatchEndPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.MatchEndPicker.Location = new System.Drawing.Point(515, 312);
            this.MatchEndPicker.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.MatchEndPicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.MatchEndPicker.Name = "MatchEndPicker";
            this.MatchEndPicker.Size = new System.Drawing.Size(182, 20);
            this.MatchEndPicker.TabIndex = 34;
            this.MatchEndPicker.Value = new System.DateTime(2022, 12, 3, 0, 0, 0, 0);
            // 
            // UpdateAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 446);
            this.Controls.Add(this.MatchEndPicker);
            this.Controls.Add(this.MatchStartPicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AppointmentIdBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AppointTypeBox);
            this.Controls.Add(this.CustIdBox);
            this.Controls.Add(this.UserIdBox);
            this.Controls.Add(this.EndTimePicker);
            this.Controls.Add(this.StartTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.ConfirmBtn);
            this.Name = "UpdateAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button ConfirmBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker StartTimePicker;
        private System.Windows.Forms.DateTimePicker EndTimePicker;
        private System.Windows.Forms.ComboBox UserIdBox;
        private System.Windows.Forms.ComboBox CustIdBox;
        private System.Windows.Forms.ComboBox AppointTypeBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AppointmentIdBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker MatchStartPicker;
        private System.Windows.Forms.DateTimePicker MatchEndPicker;
    }
}