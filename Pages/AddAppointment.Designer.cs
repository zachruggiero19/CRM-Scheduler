
namespace client_schedule
{
    partial class AddAppointment
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
            this.ConfirmBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CustomerIdBox = new System.Windows.Forms.ComboBox();
            this.AppointmentTypeBox = new System.Windows.Forms.ComboBox();
            this.UserIdBox = new System.Windows.Forms.ComboBox();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.MatchStartPicker = new System.Windows.Forms.DateTimePicker();
            this.MatchEndPicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.Location = new System.Drawing.Point(115, 333);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(75, 23);
            this.ConfirmBtn.TabIndex = 0;
            this.ConfirmBtn.Text = "Confirm";
            this.ConfirmBtn.UseVisualStyleBackColor = true;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(248, 333);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Customer ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "User ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Appointment Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Appointment  Start";
            // 
            // CustomerIdBox
            // 
            this.CustomerIdBox.FormattingEnabled = true;
            this.CustomerIdBox.Location = new System.Drawing.Point(153, 29);
            this.CustomerIdBox.Name = "CustomerIdBox";
            this.CustomerIdBox.Size = new System.Drawing.Size(183, 21);
            this.CustomerIdBox.TabIndex = 10;
            // 
            // AppointmentTypeBox
            // 
            this.AppointmentTypeBox.FormattingEnabled = true;
            this.AppointmentTypeBox.Location = new System.Drawing.Point(153, 142);
            this.AppointmentTypeBox.Name = "AppointmentTypeBox";
            this.AppointmentTypeBox.Size = new System.Drawing.Size(183, 21);
            this.AppointmentTypeBox.TabIndex = 12;
            // 
            // UserIdBox
            // 
            this.UserIdBox.FormattingEnabled = true;
            this.UserIdBox.Location = new System.Drawing.Point(153, 87);
            this.UserIdBox.Name = "UserIdBox";
            this.UserIdBox.Size = new System.Drawing.Size(183, 21);
            this.UserIdBox.TabIndex = 13;
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.StartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartDatePicker.Location = new System.Drawing.Point(154, 201);
            this.StartDatePicker.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.StartDatePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(182, 20);
            this.StartDatePicker.TabIndex = 14;
            this.StartDatePicker.Value = new System.DateTime(2022, 12, 3, 0, 0, 0, 0);
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.EndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndDatePicker.Location = new System.Drawing.Point(154, 242);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(182, 20);
            this.EndDatePicker.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Appointment End";
            // 
            // MatchStartPicker
            // 
            this.MatchStartPicker.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.MatchStartPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.MatchStartPicker.Location = new System.Drawing.Point(466, 200);
            this.MatchStartPicker.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.MatchStartPicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.MatchStartPicker.Name = "MatchStartPicker";
            this.MatchStartPicker.Size = new System.Drawing.Size(182, 20);
            this.MatchStartPicker.TabIndex = 17;
            this.MatchStartPicker.Value = new System.DateTime(2022, 12, 3, 0, 0, 0, 0);
            // 
            // MatchEndPicker
            // 
            this.MatchEndPicker.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.MatchEndPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.MatchEndPicker.Location = new System.Drawing.Point(466, 241);
            this.MatchEndPicker.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.MatchEndPicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.MatchEndPicker.Name = "MatchEndPicker";
            this.MatchEndPicker.Size = new System.Drawing.Size(182, 20);
            this.MatchEndPicker.TabIndex = 18;
            this.MatchEndPicker.Value = new System.DateTime(2022, 12, 3, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(367, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Start Time Conflict";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(367, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "End Time Conflict";
            // 
            // AddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 454);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MatchEndPicker);
            this.Controls.Add(this.MatchStartPicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EndDatePicker);
            this.Controls.Add(this.StartDatePicker);
            this.Controls.Add(this.UserIdBox);
            this.Controls.Add(this.AppointmentTypeBox);
            this.Controls.Add(this.CustomerIdBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.ConfirmBtn);
            this.Name = "AddAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConfirmBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CustomerIdBox;
        private System.Windows.Forms.ComboBox AppointmentTypeBox;
        private System.Windows.Forms.ComboBox UserIdBox;
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.DateTimePicker EndDatePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker MatchStartPicker;
        private System.Windows.Forms.DateTimePicker MatchEndPicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}