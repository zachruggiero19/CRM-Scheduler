
namespace client_schedule
{
    partial class Calendar
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
            this.AddEvntBtn = new System.Windows.Forms.Button();
            this.UpdateEvntBtn = new System.Windows.Forms.Button();
            this.DeleteEvntBtn = new System.Windows.Forms.Button();
            this.MonthButton = new System.Windows.Forms.RadioButton();
            this.WeekButton = new System.Windows.Forms.RadioButton();
            this.AppointmentGrid = new System.Windows.Forms.DataGridView();
            this.deleteCustomer = new System.Windows.Forms.Button();
            this.updateCustomer = new System.Windows.Forms.Button();
            this.addCustomer = new System.Windows.Forms.Button();
            this.CustomerGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.AllButton = new System.Windows.Forms.RadioButton();
            this.ReportButton = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.AllCustomersButton = new System.Windows.Forms.Button();
            this.UserSearchBox = new System.Windows.Forms.TextBox();
            this.SearchUserButton = new System.Windows.Forms.Button();
            this.AllUserButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AddEvntBtn
            // 
            this.AddEvntBtn.Location = new System.Drawing.Point(8, 353);
            this.AddEvntBtn.Name = "AddEvntBtn";
            this.AddEvntBtn.Size = new System.Drawing.Size(113, 23);
            this.AddEvntBtn.TabIndex = 0;
            this.AddEvntBtn.Text = "Add Appointment";
            this.AddEvntBtn.UseVisualStyleBackColor = true;
            this.AddEvntBtn.Click += new System.EventHandler(this.AddEvntBtn_Click);
            // 
            // UpdateEvntBtn
            // 
            this.UpdateEvntBtn.Location = new System.Drawing.Point(8, 399);
            this.UpdateEvntBtn.Name = "UpdateEvntBtn";
            this.UpdateEvntBtn.Size = new System.Drawing.Size(113, 23);
            this.UpdateEvntBtn.TabIndex = 1;
            this.UpdateEvntBtn.Text = "Update Appointment";
            this.UpdateEvntBtn.UseVisualStyleBackColor = true;
            this.UpdateEvntBtn.Click += new System.EventHandler(this.UpdateEvntBtn_Click);
            // 
            // DeleteEvntBtn
            // 
            this.DeleteEvntBtn.Location = new System.Drawing.Point(316, 353);
            this.DeleteEvntBtn.Name = "DeleteEvntBtn";
            this.DeleteEvntBtn.Size = new System.Drawing.Size(113, 23);
            this.DeleteEvntBtn.TabIndex = 2;
            this.DeleteEvntBtn.Text = "Delete Appointment";
            this.DeleteEvntBtn.UseVisualStyleBackColor = true;
            this.DeleteEvntBtn.Click += new System.EventHandler(this.DeleteEvntBtn_Click);
            // 
            // MonthButton
            // 
            this.MonthButton.AutoSize = true;
            this.MonthButton.Location = new System.Drawing.Point(168, 24);
            this.MonthButton.Name = "MonthButton";
            this.MonthButton.Size = new System.Drawing.Size(55, 17);
            this.MonthButton.TabIndex = 3;
            this.MonthButton.TabStop = true;
            this.MonthButton.Text = "Month";
            this.MonthButton.UseVisualStyleBackColor = true;
            this.MonthButton.CheckedChanged += new System.EventHandler(this.MonthButton_CheckedChanged);
            // 
            // WeekButton
            // 
            this.WeekButton.AutoSize = true;
            this.WeekButton.Location = new System.Drawing.Point(91, 24);
            this.WeekButton.Name = "WeekButton";
            this.WeekButton.Size = new System.Drawing.Size(54, 17);
            this.WeekButton.TabIndex = 4;
            this.WeekButton.TabStop = true;
            this.WeekButton.Text = "Week";
            this.WeekButton.UseVisualStyleBackColor = true;
            this.WeekButton.CheckedChanged += new System.EventHandler(this.WeekButton_CheckedChanged);
            // 
            // AppointmentGrid
            // 
            this.AppointmentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentGrid.Location = new System.Drawing.Point(8, 81);
            this.AppointmentGrid.Name = "AppointmentGrid";
            this.AppointmentGrid.Size = new System.Drawing.Size(421, 249);
            this.AppointmentGrid.TabIndex = 5;
            this.AppointmentGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AppointmentGrid_CellContentClick);
            // 
            // deleteCustomer
            // 
            this.deleteCustomer.Location = new System.Drawing.Point(818, 399);
            this.deleteCustomer.Name = "deleteCustomer";
            this.deleteCustomer.Size = new System.Drawing.Size(99, 23);
            this.deleteCustomer.TabIndex = 6;
            this.deleteCustomer.Text = "Delete Customer";
            this.deleteCustomer.UseVisualStyleBackColor = true;
            this.deleteCustomer.Click += new System.EventHandler(this.DeleteCustomer_Click);
            // 
            // updateCustomer
            // 
            this.updateCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.updateCustomer.Location = new System.Drawing.Point(498, 399);
            this.updateCustomer.Name = "updateCustomer";
            this.updateCustomer.Size = new System.Drawing.Size(99, 23);
            this.updateCustomer.TabIndex = 7;
            this.updateCustomer.Text = "Update Customer";
            this.updateCustomer.UseVisualStyleBackColor = true;
            this.updateCustomer.Click += new System.EventHandler(this.UpdateCustomer_Click);
            // 
            // addCustomer
            // 
            this.addCustomer.Location = new System.Drawing.Point(498, 353);
            this.addCustomer.Name = "addCustomer";
            this.addCustomer.Size = new System.Drawing.Size(99, 23);
            this.addCustomer.TabIndex = 8;
            this.addCustomer.Text = "Add Customer";
            this.addCustomer.UseVisualStyleBackColor = true;
            this.addCustomer.Click += new System.EventHandler(this.AddCustomer_Click);
            // 
            // CustomerGrid
            // 
            this.CustomerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerGrid.Location = new System.Drawing.Point(498, 81);
            this.CustomerGrid.Name = "CustomerGrid";
            this.CustomerGrid.Size = new System.Drawing.Size(419, 249);
            this.CustomerGrid.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(665, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Customer View";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(818, 526);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.dateTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeStart.Location = new System.Drawing.Point(229, 20);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(200, 20);
            this.dateTimeStart.TabIndex = 12;
            // 
            // AllButton
            // 
            this.AllButton.AutoSize = true;
            this.AllButton.Location = new System.Drawing.Point(26, 24);
            this.AllButton.Name = "AllButton";
            this.AllButton.Size = new System.Drawing.Size(36, 17);
            this.AllButton.TabIndex = 13;
            this.AllButton.TabStop = true;
            this.AllButton.Text = "All";
            this.AllButton.UseVisualStyleBackColor = true;
            this.AllButton.CheckedChanged += new System.EventHandler(this.AllButton_CheckedChanged);
            // 
            // ReportButton
            // 
            this.ReportButton.Location = new System.Drawing.Point(316, 399);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(113, 23);
            this.ReportButton.TabIndex = 19;
            this.ReportButton.Text = "Reports";
            this.ReportButton.UseVisualStyleBackColor = true;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(498, 55);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(154, 20);
            this.SearchBox.TabIndex = 20;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(668, 53);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 21;
            this.Search.Text = "Search ID";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // AllCustomersButton
            // 
            this.AllCustomersButton.Location = new System.Drawing.Point(766, 53);
            this.AllCustomersButton.Name = "AllCustomersButton";
            this.AllCustomersButton.Size = new System.Drawing.Size(96, 23);
            this.AllCustomersButton.TabIndex = 22;
            this.AllCustomersButton.Text = "All Customers";
            this.AllCustomersButton.UseVisualStyleBackColor = true;
            this.AllCustomersButton.Click += new System.EventHandler(this.AllCustomersButton_Click);
            // 
            // UserSearchBox
            // 
            this.UserSearchBox.Location = new System.Drawing.Point(275, 53);
            this.UserSearchBox.Name = "UserSearchBox";
            this.UserSearchBox.Size = new System.Drawing.Size(154, 20);
            this.UserSearchBox.TabIndex = 23;
            // 
            // SearchUserButton
            // 
            this.SearchUserButton.Location = new System.Drawing.Point(178, 51);
            this.SearchUserButton.Name = "SearchUserButton";
            this.SearchUserButton.Size = new System.Drawing.Size(75, 23);
            this.SearchUserButton.TabIndex = 24;
            this.SearchUserButton.Text = "Search User";
            this.SearchUserButton.UseVisualStyleBackColor = true;
            this.SearchUserButton.Click += new System.EventHandler(this.SearchUserButton_Click);
            // 
            // AllUserButton
            // 
            this.AllUserButton.Location = new System.Drawing.Point(91, 51);
            this.AllUserButton.Name = "AllUserButton";
            this.AllUserButton.Size = new System.Drawing.Size(75, 23);
            this.AllUserButton.TabIndex = 25;
            this.AllUserButton.Text = "All Users";
            this.AllUserButton.UseVisualStyleBackColor = true;
            this.AllUserButton.Click += new System.EventHandler(this.AllUserButton_Click);
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 563);
            this.Controls.Add(this.AllUserButton);
            this.Controls.Add(this.SearchUserButton);
            this.Controls.Add(this.UserSearchBox);
            this.Controls.Add(this.AllCustomersButton);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.ReportButton);
            this.Controls.Add(this.AllButton);
            this.Controls.Add(this.dateTimeStart);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomerGrid);
            this.Controls.Add(this.addCustomer);
            this.Controls.Add(this.updateCustomer);
            this.Controls.Add(this.deleteCustomer);
            this.Controls.Add(this.AppointmentGrid);
            this.Controls.Add(this.WeekButton);
            this.Controls.Add(this.MonthButton);
            this.Controls.Add(this.DeleteEvntBtn);
            this.Controls.Add(this.UpdateEvntBtn);
            this.Controls.Add(this.AddEvntBtn);
            this.Name = "Calendar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendar";
            this.Load += new System.EventHandler(this.Calendar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddEvntBtn;
        private System.Windows.Forms.Button UpdateEvntBtn;
        private System.Windows.Forms.Button DeleteEvntBtn;
        private System.Windows.Forms.RadioButton MonthButton;
        private System.Windows.Forms.RadioButton WeekButton;
        private System.Windows.Forms.DataGridView AppointmentGrid;
        private System.Windows.Forms.Button deleteCustomer;
        private System.Windows.Forms.Button updateCustomer;
        private System.Windows.Forms.Button addCustomer;
        private System.Windows.Forms.DataGridView CustomerGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.RadioButton AllButton;
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button AllCustomersButton;
        private System.Windows.Forms.TextBox UserSearchBox;
        private System.Windows.Forms.Button SearchUserButton;
        private System.Windows.Forms.Button AllUserButton;
    }
}