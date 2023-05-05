
namespace client_schedule
{
    partial class ReportForm
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
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.TypeReport = new System.Windows.Forms.Button();
            this.TypeGridView = new System.Windows.Forms.DataGridView();
            this.BackButton = new System.Windows.Forms.Button();
            this.ConsultantBox = new System.Windows.Forms.ComboBox();
            this.MonthPicker = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ScheduleGrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ScheduleButton = new System.Windows.Forms.Button();
            this.ActiveCustomerGrid = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.ActiveCustomer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TypeGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActiveCustomerGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Location = new System.Drawing.Point(66, 70);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(145, 21);
            this.TypeComboBox.TabIndex = 17;
            // 
            // TypeReport
            // 
            this.TypeReport.Location = new System.Drawing.Point(12, 180);
            this.TypeReport.Name = "TypeReport";
            this.TypeReport.Size = new System.Drawing.Size(101, 23);
            this.TypeReport.TabIndex = 20;
            this.TypeReport.Text = "Generate Report";
            this.TypeReport.UseVisualStyleBackColor = true;
            this.TypeReport.Click += new System.EventHandler(this.TypeReport_Click);
            // 
            // TypeGridView
            // 
            this.TypeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TypeGridView.Location = new System.Drawing.Point(12, 124);
            this.TypeGridView.Name = "TypeGridView";
            this.TypeGridView.Size = new System.Drawing.Size(199, 50);
            this.TypeGridView.TabIndex = 21;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(681, 415);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 22;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ConsultantBox
            // 
            this.ConsultantBox.FormattingEnabled = true;
            this.ConsultantBox.Location = new System.Drawing.Point(357, 23);
            this.ConsultantBox.Name = "ConsultantBox";
            this.ConsultantBox.Size = new System.Drawing.Size(121, 21);
            this.ConsultantBox.TabIndex = 24;
            // 
            // MonthPicker
            // 
            this.MonthPicker.FormattingEnabled = true;
            this.MonthPicker.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.MonthPicker.Location = new System.Drawing.Point(66, 23);
            this.MonthPicker.Name = "MonthPicker";
            this.MonthPicker.Size = new System.Drawing.Size(144, 21);
            this.MonthPicker.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Choose Month:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Choose Appointment Type:";
            // 
            // ScheduleGrid
            // 
            this.ScheduleGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScheduleGrid.Location = new System.Drawing.Point(324, 70);
            this.ScheduleGrid.Name = "ScheduleGrid";
            this.ScheduleGrid.Size = new System.Drawing.Size(269, 103);
            this.ScheduleGrid.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Number of Appointments by Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Consultant ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(321, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Consultant Schedule:";
            // 
            // ScheduleButton
            // 
            this.ScheduleButton.Location = new System.Drawing.Point(324, 179);
            this.ScheduleButton.Name = "ScheduleButton";
            this.ScheduleButton.Size = new System.Drawing.Size(108, 23);
            this.ScheduleButton.TabIndex = 32;
            this.ScheduleButton.Text = "Generate Schedule";
            this.ScheduleButton.UseVisualStyleBackColor = true;
            this.ScheduleButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ActiveCustomerGrid
            // 
            this.ActiveCustomerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActiveCustomerGrid.Location = new System.Drawing.Point(12, 261);
            this.ActiveCustomerGrid.Name = "ActiveCustomerGrid";
            this.ActiveCustomerGrid.Size = new System.Drawing.Size(316, 119);
            this.ActiveCustomerGrid.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Current Active Customers:";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // ActiveCustomer
            // 
            this.ActiveCustomer.Location = new System.Drawing.Point(12, 396);
            this.ActiveCustomer.Name = "ActiveCustomer";
            this.ActiveCustomer.Size = new System.Drawing.Size(126, 24);
            this.ActiveCustomer.TabIndex = 35;
            this.ActiveCustomer.Text = "Generate Cust. Data";
            this.ActiveCustomer.UseVisualStyleBackColor = true;
            this.ActiveCustomer.Click += new System.EventHandler(this.ActiveCustomer_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ActiveCustomer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ActiveCustomerGrid);
            this.Controls.Add(this.ScheduleButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ScheduleGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MonthPicker);
            this.Controls.Add(this.ConsultantBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.TypeGridView);
            this.Controls.Add(this.TypeReport);
            this.Controls.Add(this.TypeComboBox);
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)(this.TypeGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActiveCustomerGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.Button TypeReport;
        private System.Windows.Forms.DataGridView TypeGridView;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ComboBox ConsultantBox;
        private System.Windows.Forms.ComboBox MonthPicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView ScheduleGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ScheduleButton;
        private System.Windows.Forms.DataGridView ActiveCustomerGrid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ActiveCustomer;
    }
}