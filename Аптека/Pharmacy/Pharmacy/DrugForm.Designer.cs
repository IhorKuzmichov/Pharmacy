namespace Pharmacy
{
    partial class DrugForm
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
            this.BTN_OK = new System.Windows.Forms.Button();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.TB_Drug_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Drug_Quantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DTP_Drug_ManufactureDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DTP_Drug_ExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.CB_Drug_Manufacturer = new System.Windows.Forms.ComboBox();
            this.CB_Drug_Category = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_Drug_Price = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_Drug_Description = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_OK
            // 
            this.BTN_OK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_OK.Location = new System.Drawing.Point(12, 289);
            this.BTN_OK.Name = "BTN_OK";
            this.BTN_OK.Size = new System.Drawing.Size(99, 42);
            this.BTN_OK.TabIndex = 7;
            this.BTN_OK.Text = "ОК";
            this.BTN_OK.UseVisualStyleBackColor = true;
            this.BTN_OK.Click += new System.EventHandler(this.BTN_OK_Click);
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Cancel.Location = new System.Drawing.Point(117, 289);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(99, 42);
            this.BTN_Cancel.TabIndex = 6;
            this.BTN_Cancel.Text = "Відміна";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            this.BTN_Cancel.Click += new System.EventHandler(this.BTN_Cancel_Click);
            // 
            // TB_Drug_Name
            // 
            this.TB_Drug_Name.Location = new System.Drawing.Point(99, 12);
            this.TB_Drug_Name.Name = "TB_Drug_Name";
            this.TB_Drug_Name.Size = new System.Drawing.Size(117, 20);
            this.TB_Drug_Name.TabIndex = 5;
            this.TB_Drug_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Drug_Name_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Назва:";
            // 
            // TB_Drug_Quantity
            // 
            this.TB_Drug_Quantity.Location = new System.Drawing.Point(99, 38);
            this.TB_Drug_Quantity.Name = "TB_Drug_Quantity";
            this.TB_Drug_Quantity.Size = new System.Drawing.Size(117, 20);
            this.TB_Drug_Quantity.TabIndex = 9;
            this.TB_Drug_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Drug_Quantity_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Кількість (шт.):";
            // 
            // DTP_Drug_ManufactureDate
            // 
            this.DTP_Drug_ManufactureDate.CustomFormat = "dd.MM.yy";
            this.DTP_Drug_ManufactureDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_Drug_ManufactureDate.Location = new System.Drawing.Point(99, 90);
            this.DTP_Drug_ManufactureDate.Name = "DTP_Drug_ManufactureDate";
            this.DTP_Drug_ManufactureDate.Size = new System.Drawing.Size(117, 20);
            this.DTP_Drug_ManufactureDate.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Виготовлений:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Придатний до:";
            // 
            // DTP_Drug_ExpirationDate
            // 
            this.DTP_Drug_ExpirationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_Drug_ExpirationDate.Location = new System.Drawing.Point(99, 116);
            this.DTP_Drug_ExpirationDate.Name = "DTP_Drug_ExpirationDate";
            this.DTP_Drug_ExpirationDate.Size = new System.Drawing.Size(117, 20);
            this.DTP_Drug_ExpirationDate.TabIndex = 12;
            // 
            // CB_Drug_Manufacturer
            // 
            this.CB_Drug_Manufacturer.FormattingEnabled = true;
            this.CB_Drug_Manufacturer.Location = new System.Drawing.Point(99, 142);
            this.CB_Drug_Manufacturer.Name = "CB_Drug_Manufacturer";
            this.CB_Drug_Manufacturer.Size = new System.Drawing.Size(117, 21);
            this.CB_Drug_Manufacturer.TabIndex = 14;
            // 
            // CB_Drug_Category
            // 
            this.CB_Drug_Category.FormattingEnabled = true;
            this.CB_Drug_Category.Location = new System.Drawing.Point(99, 169);
            this.CB_Drug_Category.Name = "CB_Drug_Category";
            this.CB_Drug_Category.Size = new System.Drawing.Size(117, 21);
            this.CB_Drug_Category.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Категорія:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Виробник:";
            // 
            // TB_Drug_Price
            // 
            this.TB_Drug_Price.Location = new System.Drawing.Point(99, 64);
            this.TB_Drug_Price.Multiline = true;
            this.TB_Drug_Price.Name = "TB_Drug_Price";
            this.TB_Drug_Price.Size = new System.Drawing.Size(117, 20);
            this.TB_Drug_Price.TabIndex = 19;
            this.TB_Drug_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Drug_Price_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Ціна:";
            // 
            // TB_Drug_Description
            // 
            this.TB_Drug_Description.Location = new System.Drawing.Point(62, 196);
            this.TB_Drug_Description.Multiline = true;
            this.TB_Drug_Description.Name = "TB_Drug_Description";
            this.TB_Drug_Description.Size = new System.Drawing.Size(162, 87);
            this.TB_Drug_Description.TabIndex = 21;
            this.TB_Drug_Description.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Drug_Description_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Опис:";
            // 
            // DrugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 343);
            this.ControlBox = false;
            this.Controls.Add(this.TB_Drug_Description);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TB_Drug_Price);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CB_Drug_Category);
            this.Controls.Add(this.CB_Drug_Manufacturer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DTP_Drug_ExpirationDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DTP_Drug_ManufactureDate);
            this.Controls.Add(this.TB_Drug_Quantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTN_OK);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.TB_Drug_Name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DrugForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лікарський препарат";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_OK;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.TextBox TB_Drug_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_Drug_Quantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DTP_Drug_ManufactureDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DTP_Drug_ExpirationDate;
        private System.Windows.Forms.ComboBox CB_Drug_Manufacturer;
        private System.Windows.Forms.ComboBox CB_Drug_Category;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_Drug_Price;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_Drug_Description;
        private System.Windows.Forms.Label label8;
    }
}