namespace Database_Shop_Manager
{
    partial class Form2
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
            this.pbxBanner = new System.Windows.Forms.PictureBox();
            this.Pnl_widokDanych = new System.Windows.Forms.Panel();
            this.dGv_dane_z_bazy = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pnl_Szczegóły = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_AddNewCustomer = new System.Windows.Forms.Button();
            this.btn_SaveChanges = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cBx_deleteCustomer = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txB_Name = new System.Windows.Forms.TextBox();
            this.txB_Surname = new System.Windows.Forms.TextBox();
            this.dTP_Birthday = new System.Windows.Forms.DateTimePicker();
            this.txB_City = new System.Windows.Forms.TextBox();
            this.txB_Country = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBanner)).BeginInit();
            this.Pnl_widokDanych.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGv_dane_z_bazy)).BeginInit();
            this.Pnl_Szczegóły.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxBanner
            // 
            this.pbxBanner.Location = new System.Drawing.Point(12, 12);
            this.pbxBanner.Name = "pbxBanner";
            this.pbxBanner.Size = new System.Drawing.Size(900, 57);
            this.pbxBanner.TabIndex = 0;
            this.pbxBanner.TabStop = false;
            // 
            // Pnl_widokDanych
            // 
            this.Pnl_widokDanych.Controls.Add(this.dGv_dane_z_bazy);
            this.Pnl_widokDanych.Location = new System.Drawing.Point(12, 75);
            this.Pnl_widokDanych.Name = "Pnl_widokDanych";
            this.Pnl_widokDanych.Size = new System.Drawing.Size(573, 435);
            this.Pnl_widokDanych.TabIndex = 1;
            // 
            // dGv_dane_z_bazy
            // 
            this.dGv_dane_z_bazy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGv_dane_z_bazy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Surname});
            this.dGv_dane_z_bazy.Location = new System.Drawing.Point(3, 3);
            this.dGv_dane_z_bazy.Name = "dGv_dane_z_bazy";
            this.dGv_dane_z_bazy.Size = new System.Drawing.Size(567, 429);
            this.dGv_dane_z_bazy.TabIndex = 0;
            this.dGv_dane_z_bazy.SelectionChanged += new System.EventHandler(this.dGv_dane_z_bazy_SelectionChanged);
            // 
            // Name
            // 
            this.Name.HeaderText = "Imię";
            this.Name.Name = "Name";
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Nazwisko";
            this.Surname.Name = "Surname";
            // 
            // Pnl_Szczegóły
            // 
            this.Pnl_Szczegóły.Controls.Add(this.tableLayoutPanel3);
            this.Pnl_Szczegóły.Location = new System.Drawing.Point(591, 75);
            this.Pnl_Szczegóły.Name = "Pnl_Szczegóły";
            this.Pnl_Szczegóły.Size = new System.Drawing.Size(321, 435);
            this.Pnl_Szczegóły.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.505747F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.49426F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(321, 435);
            this.tableLayoutPanel3.TabIndex = 16;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btn_AddNewCustomer, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_SaveChanges, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(315, 30);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // btn_AddNewCustomer
            // 
            this.btn_AddNewCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_AddNewCustomer.Location = new System.Drawing.Point(3, 3);
            this.btn_AddNewCustomer.Name = "btn_AddNewCustomer";
            this.btn_AddNewCustomer.Size = new System.Drawing.Size(151, 24);
            this.btn_AddNewCustomer.TabIndex = 10;
            this.btn_AddNewCustomer.Text = "Nowy klient";
            this.btn_AddNewCustomer.UseVisualStyleBackColor = true;
            this.btn_AddNewCustomer.Click += new System.EventHandler(this.btn_AddNewCustomer_Click);
            // 
            // btn_SaveChanges
            // 
            this.btn_SaveChanges.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_SaveChanges.Location = new System.Drawing.Point(160, 3);
            this.btn_SaveChanges.Name = "btn_SaveChanges";
            this.btn_SaveChanges.Size = new System.Drawing.Size(152, 24);
            this.btn_SaveChanges.TabIndex = 12;
            this.btn_SaveChanges.Text = "Zapisz zmiany";
            this.btn_SaveChanges.UseVisualStyleBackColor = true;
            this.btn_SaveChanges.Click += new System.EventHandler(this.btn_SaveChanges_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.cBx_deleteCustomer, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.label5, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label4, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label3, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txB_Name, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txB_Surname, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.dTP_Birthday, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txB_City, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txB_Country, 0, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 39);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.98039F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.01961F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(312, 159);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // cBx_deleteCustomer
            // 
            this.cBx_deleteCustomer.AutoSize = true;
            this.cBx_deleteCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cBx_deleteCustomer.Location = new System.Drawing.Point(159, 125);
            this.cBx_deleteCustomer.Name = "cBx_deleteCustomer";
            this.cBx_deleteCustomer.Size = new System.Drawing.Size(150, 31);
            this.cBx_deleteCustomer.TabIndex = 13;
            this.cBx_deleteCustomer.Text = "Usuń klienta";
            this.cBx_deleteCustomer.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kraj";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Miasto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data urodzenia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nazwisko";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Imię";
            // 
            // txB_Name
            // 
            this.txB_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txB_Name.Location = new System.Drawing.Point(3, 3);
            this.txB_Name.Name = "txB_Name";
            this.txB_Name.Size = new System.Drawing.Size(150, 20);
            this.txB_Name.TabIndex = 0;
            // 
            // txB_Surname
            // 
            this.txB_Surname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txB_Surname.Location = new System.Drawing.Point(3, 29);
            this.txB_Surname.Name = "txB_Surname";
            this.txB_Surname.Size = new System.Drawing.Size(150, 20);
            this.txB_Surname.TabIndex = 2;
            // 
            // dTP_Birthday
            // 
            this.dTP_Birthday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dTP_Birthday.Location = new System.Drawing.Point(3, 54);
            this.dTP_Birthday.Name = "dTP_Birthday";
            this.dTP_Birthday.Size = new System.Drawing.Size(150, 20);
            this.dTP_Birthday.TabIndex = 4;
            // 
            // txB_City
            // 
            this.txB_City.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txB_City.Location = new System.Drawing.Point(3, 78);
            this.txB_City.Name = "txB_City";
            this.txB_City.Size = new System.Drawing.Size(150, 20);
            this.txB_City.TabIndex = 6;
            // 
            // txB_Country
            // 
            this.txB_Country.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txB_Country.Location = new System.Drawing.Point(3, 102);
            this.txB_Country.Name = "txB_Country";
            this.txB_Country.Size = new System.Drawing.Size(150, 20);
            this.txB_Country.TabIndex = 7;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(924, 522);
            this.Controls.Add(this.Pnl_Szczegóły);
            this.Controls.Add(this.Pnl_widokDanych);
            this.Controls.Add(this.pbxBanner);
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbxBanner)).EndInit();
            this.Pnl_widokDanych.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGv_dane_z_bazy)).EndInit();
            this.Pnl_Szczegóły.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxBanner;
        private System.Windows.Forms.Panel Pnl_widokDanych;
        private System.Windows.Forms.Panel Pnl_Szczegóły;
        private System.Windows.Forms.DataGridView dGv_dane_z_bazy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txB_Country;
        private System.Windows.Forms.TextBox txB_City;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dTP_Birthday;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txB_Surname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txB_Name;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_AddNewCustomer;
        private System.Windows.Forms.Button btn_SaveChanges;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox cBx_deleteCustomer;
    }
}