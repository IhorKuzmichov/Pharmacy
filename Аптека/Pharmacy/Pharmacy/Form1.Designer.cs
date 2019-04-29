namespace Pharmacy
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DGV_Drug = new System.Windows.Forms.DataGridView();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.MI_ConnectionString = new System.Windows.Forms.MenuItem();
            this.MI_About = new System.Windows.Forms.MenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TP_Drug = new System.Windows.Forms.TabPage();
            this.TB_Drug_Description = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_Manufacturer_Site = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_Manufacturer_PhoneNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_Manufacturer_Address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_Manufacturer_Country = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Manufacturer_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TP_Category = new System.Windows.Forms.TabPage();
            this.DGV_Category = new System.Windows.Forms.DataGridView();
            this.TP_Manufacturer = new System.Windows.Forms.TabPage();
            this.DGV_Manufacturer = new System.Windows.Forms.DataGridView();
            this.BTN_Delete = new System.Windows.Forms.Button();
            this.BTN_Insert = new System.Windows.Forms.Button();
            this.BTN_Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Drug)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.TP_Drug.SuspendLayout();
            this.TP_Category.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Category)).BeginInit();
            this.TP_Manufacturer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Manufacturer)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Drug
            // 
            this.DGV_Drug.AllowUserToAddRows = false;
            this.DGV_Drug.AllowUserToDeleteRows = false;
            this.DGV_Drug.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Drug.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DGV_Drug.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Drug.Location = new System.Drawing.Point(6, 6);
            this.DGV_Drug.MultiSelect = false;
            this.DGV_Drug.Name = "DGV_Drug";
            this.DGV_Drug.ReadOnly = true;
            this.DGV_Drug.Size = new System.Drawing.Size(450, 392);
            this.DGV_Drug.TabIndex = 2;
            this.DGV_Drug.CurrentCellChanged += new System.EventHandler(this.DGV_Drug_CurrentCellChanged);
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MI_ConnectionString,
            this.MI_About});
            // 
            // MI_ConnectionString
            // 
            this.MI_ConnectionString.Index = 0;
            this.MI_ConnectionString.Text = "Строка підключення";
            this.MI_ConnectionString.Click += new System.EventHandler(this.MI_ConnectionString_Click);
            // 
            // MI_About
            // 
            this.MI_About.Index = 1;
            this.MI_About.Text = "Про програму";
            this.MI_About.Click += new System.EventHandler(this.MI_About_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TP_Drug);
            this.tabControl1.Controls.Add(this.TP_Category);
            this.tabControl1.Controls.Add(this.TP_Manufacturer);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(670, 430);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // TP_Drug
            // 
            this.TP_Drug.Controls.Add(this.TB_Drug_Description);
            this.TP_Drug.Controls.Add(this.label8);
            this.TP_Drug.Controls.Add(this.label7);
            this.TP_Drug.Controls.Add(this.TB_Manufacturer_Site);
            this.TP_Drug.Controls.Add(this.label6);
            this.TP_Drug.Controls.Add(this.TB_Manufacturer_PhoneNumber);
            this.TP_Drug.Controls.Add(this.label5);
            this.TP_Drug.Controls.Add(this.TB_Manufacturer_Address);
            this.TP_Drug.Controls.Add(this.label4);
            this.TP_Drug.Controls.Add(this.TB_Manufacturer_Country);
            this.TP_Drug.Controls.Add(this.label3);
            this.TP_Drug.Controls.Add(this.TB_Manufacturer_Name);
            this.TP_Drug.Controls.Add(this.label2);
            this.TP_Drug.Controls.Add(this.DGV_Drug);
            this.TP_Drug.Location = new System.Drawing.Point(4, 22);
            this.TP_Drug.Name = "TP_Drug";
            this.TP_Drug.Padding = new System.Windows.Forms.Padding(3);
            this.TP_Drug.Size = new System.Drawing.Size(662, 404);
            this.TP_Drug.TabIndex = 0;
            this.TP_Drug.Text = "Лікарьські препарати";
            this.TP_Drug.UseVisualStyleBackColor = true;
            // 
            // TB_Drug_Description
            // 
            this.TB_Drug_Description.Location = new System.Drawing.Point(465, 182);
            this.TB_Drug_Description.Multiline = true;
            this.TB_Drug_Description.Name = "TB_Drug_Description";
            this.TB_Drug_Description.ReadOnly = true;
            this.TB_Drug_Description.Size = new System.Drawing.Size(191, 216);
            this.TB_Drug_Description.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(462, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Опис:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(476, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Сайт:";
            // 
            // TB_Manufacturer_Site
            // 
            this.TB_Manufacturer_Site.Location = new System.Drawing.Point(529, 129);
            this.TB_Manufacturer_Site.Name = "TB_Manufacturer_Site";
            this.TB_Manufacturer_Site.ReadOnly = true;
            this.TB_Manufacturer_Site.Size = new System.Drawing.Size(127, 20);
            this.TB_Manufacturer_Site.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(476, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Тел.:";
            // 
            // TB_Manufacturer_PhoneNumber
            // 
            this.TB_Manufacturer_PhoneNumber.Location = new System.Drawing.Point(529, 103);
            this.TB_Manufacturer_PhoneNumber.Name = "TB_Manufacturer_PhoneNumber";
            this.TB_Manufacturer_PhoneNumber.ReadOnly = true;
            this.TB_Manufacturer_PhoneNumber.Size = new System.Drawing.Size(127, 20);
            this.TB_Manufacturer_PhoneNumber.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(476, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Адреса:";
            // 
            // TB_Manufacturer_Address
            // 
            this.TB_Manufacturer_Address.Location = new System.Drawing.Point(529, 77);
            this.TB_Manufacturer_Address.Name = "TB_Manufacturer_Address";
            this.TB_Manufacturer_Address.ReadOnly = true;
            this.TB_Manufacturer_Address.Size = new System.Drawing.Size(127, 20);
            this.TB_Manufacturer_Address.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(476, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Країна:";
            // 
            // TB_Manufacturer_Country
            // 
            this.TB_Manufacturer_Country.Location = new System.Drawing.Point(529, 51);
            this.TB_Manufacturer_Country.Name = "TB_Manufacturer_Country";
            this.TB_Manufacturer_Country.ReadOnly = true;
            this.TB_Manufacturer_Country.Size = new System.Drawing.Size(127, 20);
            this.TB_Manufacturer_Country.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(476, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Назва:";
            // 
            // TB_Manufacturer_Name
            // 
            this.TB_Manufacturer_Name.Location = new System.Drawing.Point(529, 25);
            this.TB_Manufacturer_Name.Name = "TB_Manufacturer_Name";
            this.TB_Manufacturer_Name.ReadOnly = true;
            this.TB_Manufacturer_Name.Size = new System.Drawing.Size(127, 20);
            this.TB_Manufacturer_Name.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(462, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Про виробника:";
            // 
            // TP_Category
            // 
            this.TP_Category.Controls.Add(this.DGV_Category);
            this.TP_Category.Location = new System.Drawing.Point(4, 22);
            this.TP_Category.Name = "TP_Category";
            this.TP_Category.Padding = new System.Windows.Forms.Padding(3);
            this.TP_Category.Size = new System.Drawing.Size(662, 404);
            this.TP_Category.TabIndex = 1;
            this.TP_Category.Text = "Категорії";
            this.TP_Category.UseVisualStyleBackColor = true;
            // 
            // DGV_Category
            // 
            this.DGV_Category.AllowUserToAddRows = false;
            this.DGV_Category.AllowUserToDeleteRows = false;
            this.DGV_Category.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Category.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DGV_Category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Category.Location = new System.Drawing.Point(6, 6);
            this.DGV_Category.MultiSelect = false;
            this.DGV_Category.Name = "DGV_Category";
            this.DGV_Category.ReadOnly = true;
            this.DGV_Category.Size = new System.Drawing.Size(650, 392);
            this.DGV_Category.TabIndex = 7;
            // 
            // TP_Manufacturer
            // 
            this.TP_Manufacturer.Controls.Add(this.DGV_Manufacturer);
            this.TP_Manufacturer.Location = new System.Drawing.Point(4, 22);
            this.TP_Manufacturer.Name = "TP_Manufacturer";
            this.TP_Manufacturer.Size = new System.Drawing.Size(662, 404);
            this.TP_Manufacturer.TabIndex = 2;
            this.TP_Manufacturer.Text = "Виробники";
            this.TP_Manufacturer.UseVisualStyleBackColor = true;
            // 
            // DGV_Manufacturer
            // 
            this.DGV_Manufacturer.AllowUserToAddRows = false;
            this.DGV_Manufacturer.AllowUserToDeleteRows = false;
            this.DGV_Manufacturer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Manufacturer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DGV_Manufacturer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Manufacturer.Location = new System.Drawing.Point(6, 6);
            this.DGV_Manufacturer.MultiSelect = false;
            this.DGV_Manufacturer.Name = "DGV_Manufacturer";
            this.DGV_Manufacturer.ReadOnly = true;
            this.DGV_Manufacturer.Size = new System.Drawing.Size(650, 392);
            this.DGV_Manufacturer.TabIndex = 8;
            // 
            // BTN_Delete
            // 
            this.BTN_Delete.Location = new System.Drawing.Point(688, 125);
            this.BTN_Delete.Name = "BTN_Delete";
            this.BTN_Delete.Size = new System.Drawing.Size(100, 40);
            this.BTN_Delete.TabIndex = 4;
            this.BTN_Delete.Text = "Видалити";
            this.BTN_Delete.UseVisualStyleBackColor = true;
            this.BTN_Delete.Click += new System.EventHandler(this.BTN_Delete_Click);
            // 
            // BTN_Insert
            // 
            this.BTN_Insert.Location = new System.Drawing.Point(688, 33);
            this.BTN_Insert.Name = "BTN_Insert";
            this.BTN_Insert.Size = new System.Drawing.Size(100, 40);
            this.BTN_Insert.TabIndex = 5;
            this.BTN_Insert.Text = "Додати";
            this.BTN_Insert.UseVisualStyleBackColor = true;
            this.BTN_Insert.Click += new System.EventHandler(this.BTN_Insert_Click);
            // 
            // BTN_Update
            // 
            this.BTN_Update.Location = new System.Drawing.Point(688, 79);
            this.BTN_Update.Name = "BTN_Update";
            this.BTN_Update.Size = new System.Drawing.Size(100, 40);
            this.BTN_Update.TabIndex = 6;
            this.BTN_Update.Text = "Змінити";
            this.BTN_Update.UseVisualStyleBackColor = true;
            this.BTN_Update.Click += new System.EventHandler(this.BTN_Update_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN_Update);
            this.Controls.Add(this.BTN_Insert);
            this.Controls.Add(this.BTN_Delete);
            this.Controls.Add(this.tabControl1);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аптека";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Drug)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.TP_Drug.ResumeLayout(false);
            this.TP_Drug.PerformLayout();
            this.TP_Category.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Category)).EndInit();
            this.TP_Manufacturer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Manufacturer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DGV_Drug;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TP_Drug;
        private System.Windows.Forms.TabPage TP_Category;
        private System.Windows.Forms.Button BTN_Delete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_Manufacturer_Site;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_Manufacturer_PhoneNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_Manufacturer_Address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_Manufacturer_Country;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_Manufacturer_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_Insert;
        private System.Windows.Forms.Button BTN_Update;
        private System.Windows.Forms.TabPage TP_Manufacturer;
        private System.Windows.Forms.DataGridView DGV_Category;
        private System.Windows.Forms.DataGridView DGV_Manufacturer;
        private System.Windows.Forms.MenuItem MI_ConnectionString;
        private System.Windows.Forms.MenuItem MI_About;
        private System.Windows.Forms.TextBox TB_Drug_Description;
        private System.Windows.Forms.Label label8;
    }
}

