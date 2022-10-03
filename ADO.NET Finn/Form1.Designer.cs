using System;

namespace ADO.NET_Finn
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.СостояниеБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подключениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отключениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersListView = new System.Windows.Forms.ListView();
            this.CustomerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Country = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.City = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.loadDataButton = new System.Windows.Forms.Button();
            this.ordersListView = new System.Windows.Forms.ListView();
            this.OrderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Discount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.СостояниеБДToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(597, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // СостояниеБДToolStripMenuItem
            // 
            this.СостояниеБДToolStripMenuItem.BackColor = System.Drawing.Color.Bisque;
            this.СостояниеБДToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.подключениеToolStripMenuItem,
            this.отключениеToolStripMenuItem});
            this.СостояниеБДToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.СостояниеБДToolStripMenuItem.Name = "СостояниеБДToolStripMenuItem";
            this.СостояниеБДToolStripMenuItem.Size = new System.Drawing.Size(121, 27);
            this.СостояниеБДToolStripMenuItem.Text = "Состояние БД";
            // 
            // подключениеToolStripMenuItem
            // 
            this.подключениеToolStripMenuItem.Name = "подключениеToolStripMenuItem";
            this.подключениеToolStripMenuItem.Size = new System.Drawing.Size(170, 28);
            this.подключениеToolStripMenuItem.Text = "Подключение";
            this.подключениеToolStripMenuItem.Click += new System.EventHandler(this.подключитьсяToolStripMenuItem_Click);
            // 
            // отключениеToolStripMenuItem
            // 
            this.отключениеToolStripMenuItem.Name = "отключениеToolStripMenuItem";
            this.отключениеToolStripMenuItem.Size = new System.Drawing.Size(170, 28);
            this.отключениеToolStripMenuItem.Text = "Отключение";
            this.отключениеToolStripMenuItem.Click += new System.EventHandler(this.отключитьсяToolStripMenuItem_Click);
            // 
            // customersListView
            // 
            this.customersListView.BackColor = System.Drawing.Color.LightSalmon;
            this.customersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CustomerID,
            this.FirstName,
            this.LastName,
            this.Country,
            this.City});
            this.customersListView.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customersListView.HideSelection = false;
            this.customersListView.Location = new System.Drawing.Point(1, 27);
            this.customersListView.Name = "customersListView";
            this.customersListView.Size = new System.Drawing.Size(333, 321);
            this.customersListView.TabIndex = 1;
            this.customersListView.UseCompatibleStateImageBehavior = false;
            this.customersListView.View = System.Windows.Forms.View.Details;
            // 
            // CustomerID
            // 
            this.CustomerID.Text = "CustomerID";
            this.CustomerID.Width = 85;
            // 
            // FirstName
            // 
            this.FirstName.Text = "FirstName";
            this.FirstName.Width = 72;
            // 
            // LastName
            // 
            this.LastName.Text = "LastName";
            this.LastName.Width = 68;
            // 
            // Country
            // 
            this.Country.Text = "Country";
            this.Country.Width = 65;
            // 
            // City
            // 
            this.City.Text = "City";
            this.City.Width = 75;
            // 
            // loadDataButton
            // 
            this.loadDataButton.BackColor = System.Drawing.Color.Wheat;
            this.loadDataButton.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.loadDataButton.Font = new System.Drawing.Font("Segoe Script", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadDataButton.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.loadDataButton.Location = new System.Drawing.Point(1, 680);
            this.loadDataButton.Name = "loadDataButton";
            this.loadDataButton.Size = new System.Drawing.Size(589, 123);
            this.loadDataButton.TabIndex = 2;
            this.loadDataButton.Text = "Загрузить данные";
            this.loadDataButton.UseVisualStyleBackColor = false;
            this.loadDataButton.Click += new System.EventHandler(this.loadDataButton_Click);
            // 
            // ordersListView
            // 
            this.ordersListView.BackColor = System.Drawing.Color.LightSalmon;
            this.ordersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OrderID,
            this.CustID,
            this.Product,
            this.Number,
            this.Price,
            this.Discount});
            this.ordersListView.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ordersListView.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.ordersListView.HideSelection = false;
            this.ordersListView.Location = new System.Drawing.Point(1, 354);
            this.ordersListView.Name = "ordersListView";
            this.ordersListView.Size = new System.Drawing.Size(397, 320);
            this.ordersListView.TabIndex = 3;
            this.ordersListView.UseCompatibleStateImageBehavior = false;
            this.ordersListView.View = System.Windows.Forms.View.Details;
            // 
            // OrderID
            // 
            this.OrderID.Text = "OrderID";
            this.OrderID.Width = 66;
            // 
            // CustID
            // 
            this.CustID.Text = "CustomerID";
            this.CustID.Width = 85;
            // 
            // Product
            // 
            this.Product.Text = "Product";
            // 
            // Number
            // 
            this.Number.Text = "Number";
            // 
            // Price
            // 
            this.Price.Text = "Price";
            // 
            // Discount
            // 
            this.Discount.Text = "Discount";
            this.Discount.Width = 64;
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.customerIDTextBox.Location = new System.Drawing.Point(340, 75);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(165, 20);
            this.customerIDTextBox.TabIndex = 4;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.firstNameTextBox.Location = new System.Drawing.Point(340, 108);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(165, 20);
            this.firstNameTextBox.TabIndex = 5;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lastNameTextBox.Location = new System.Drawing.Point(340, 142);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(165, 20);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // countryTextBox
            // 
            this.countryTextBox.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.countryTextBox.Location = new System.Drawing.Point(340, 176);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(165, 20);
            this.countryTextBox.TabIndex = 7;
            // 
            // cityTextBox
            // 
            this.cityTextBox.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.cityTextBox.Location = new System.Drawing.Point(340, 212);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(165, 20);
            this.cityTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(338, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Вставить данные в таблицу Customers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label2.Location = new System.Drawing.Point(506, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "CustomerID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label3.Location = new System.Drawing.Point(506, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "FirstName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label4.Location = new System.Drawing.Point(506, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "LastName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label5.Location = new System.Drawing.Point(506, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Country";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label6.Location = new System.Drawing.Point(506, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "City";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightPink;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.button1.Location = new System.Drawing.Point(333, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(257, 100);
            this.button1.TabIndex = 15;
            this.button1.Text = "Вставить в табл. Customer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label7.Location = new System.Drawing.Point(420, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 21);
            this.label7.TabIndex = 16;
            this.label7.Text = "Вставить в таблицу Orders";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox1.Location = new System.Drawing.Point(404, 389);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(107, 20);
            this.textBox1.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox2.Location = new System.Drawing.Point(404, 429);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(107, 20);
            this.textBox2.TabIndex = 18;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox3.Location = new System.Drawing.Point(404, 468);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(107, 20);
            this.textBox3.TabIndex = 19;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox4.Location = new System.Drawing.Point(404, 505);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(107, 20);
            this.textBox4.TabIndex = 20;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox5.Location = new System.Drawing.Point(404, 540);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(107, 20);
            this.textBox5.TabIndex = 21;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox6.Location = new System.Drawing.Point(404, 578);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(107, 20);
            this.textBox6.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Print", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label8.Location = new System.Drawing.Point(517, 392);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 21);
            this.label8.TabIndex = 23;
            this.label8.Text = "OrderID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe Print", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label9.Location = new System.Drawing.Point(517, 432);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 21);
            this.label9.TabIndex = 24;
            this.label9.Text = "CustomerID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe Print", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label10.Location = new System.Drawing.Point(521, 478);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 21);
            this.label10.TabIndex = 25;
            this.label10.Text = "Product";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe Print", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label11.Location = new System.Drawing.Point(517, 508);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 21);
            this.label11.TabIndex = 26;
            this.label11.Text = "Number";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe Print", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label12.Location = new System.Drawing.Point(517, 543);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 21);
            this.label12.TabIndex = 27;
            this.label12.Text = "Price";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe Print", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label13.Location = new System.Drawing.Point(517, 581);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 21);
            this.label13.TabIndex = 28;
            this.label13.Text = "Discount";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightPink;
            this.button2.Font = new System.Drawing.Font("Segoe Print", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.button2.Location = new System.Drawing.Point(404, 610);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 64);
            this.button2.TabIndex = 29;
            this.button2.Text = "Вставить в табл. Orders";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(597, 803);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.customerIDTextBox);
            this.Controls.Add(this.ordersListView);
            this.Controls.Add(this.loadDataButton);
            this.Controls.Add(this.customersListView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма подключения";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem СостояниеБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подключениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отключениеToolStripMenuItem;
        private System.Windows.Forms.ListView customersListView;
        private System.Windows.Forms.Button loadDataButton;
        private System.Windows.Forms.ColumnHeader CustomerID;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader Country;
        private System.Windows.Forms.ColumnHeader City;
        private System.Windows.Forms.ListView ordersListView;
        private System.Windows.Forms.ColumnHeader OrderID;
        private System.Windows.Forms.ColumnHeader CustID;
        private System.Windows.Forms.ColumnHeader Product;
        private System.Windows.Forms.ColumnHeader Number;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Discount;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button2;
    }
}