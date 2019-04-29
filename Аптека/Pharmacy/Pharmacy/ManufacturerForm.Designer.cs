namespace Pharmacy
{
    partial class ManufacturerForm
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
            this.TB_Manufacturer_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Manufacturer_Country = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Manufacturer_Address = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Manufacturer_PhoneNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_Manufacturer_Site = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_OK
            // 
            this.BTN_OK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_OK.Location = new System.Drawing.Point(12, 142);
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
            this.BTN_Cancel.Location = new System.Drawing.Point(117, 142);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(99, 42);
            this.BTN_Cancel.TabIndex = 6;
            this.BTN_Cancel.Text = "Відміна";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            this.BTN_Cancel.Click += new System.EventHandler(this.BTN_Cancel_Click);
            // 
            // TB_Manufacturer_Name
            // 
            this.TB_Manufacturer_Name.Location = new System.Drawing.Point(64, 12);
            this.TB_Manufacturer_Name.Name = "TB_Manufacturer_Name";
            this.TB_Manufacturer_Name.Size = new System.Drawing.Size(151, 20);
            this.TB_Manufacturer_Name.TabIndex = 5;
            this.TB_Manufacturer_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Manufacturer_Name_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Назва:";
            // 
            // TB_Manufacturer_Country
            // 
            this.TB_Manufacturer_Country.Location = new System.Drawing.Point(64, 38);
            this.TB_Manufacturer_Country.Name = "TB_Manufacturer_Country";
            this.TB_Manufacturer_Country.Size = new System.Drawing.Size(151, 20);
            this.TB_Manufacturer_Country.TabIndex = 9;
            this.TB_Manufacturer_Country.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Manufacturer_Country_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Країна:";
            // 
            // TB_Manufacturer_Address
            // 
            this.TB_Manufacturer_Address.Location = new System.Drawing.Point(64, 64);
            this.TB_Manufacturer_Address.Name = "TB_Manufacturer_Address";
            this.TB_Manufacturer_Address.Size = new System.Drawing.Size(151, 20);
            this.TB_Manufacturer_Address.TabIndex = 11;
            this.TB_Manufacturer_Address.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Manufacturer_Address_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Адреса:";
            // 
            // TB_Manufacturer_PhoneNumber
            // 
            this.TB_Manufacturer_PhoneNumber.Location = new System.Drawing.Point(64, 90);
            this.TB_Manufacturer_PhoneNumber.Name = "TB_Manufacturer_PhoneNumber";
            this.TB_Manufacturer_PhoneNumber.Size = new System.Drawing.Size(151, 20);
            this.TB_Manufacturer_PhoneNumber.TabIndex = 13;
            this.TB_Manufacturer_PhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Manufacturer_PhoneNumber_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Тел.:";
            // 
            // TB_Manufacturer_Site
            // 
            this.TB_Manufacturer_Site.Location = new System.Drawing.Point(64, 116);
            this.TB_Manufacturer_Site.Name = "TB_Manufacturer_Site";
            this.TB_Manufacturer_Site.Size = new System.Drawing.Size(151, 20);
            this.TB_Manufacturer_Site.TabIndex = 15;
            this.TB_Manufacturer_Site.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Manufacturer_Site_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Сайт:";
            // 
            // ManufacturerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 196);
            this.ControlBox = false;
            this.Controls.Add(this.TB_Manufacturer_Site);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_Manufacturer_PhoneNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_Manufacturer_Address);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_Manufacturer_Country);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTN_OK);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.TB_Manufacturer_Name);
            this.Controls.Add(this.label1);
            this.Name = "ManufacturerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Виробник";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_OK;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.TextBox TB_Manufacturer_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_Manufacturer_Country;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_Manufacturer_Address;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_Manufacturer_PhoneNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_Manufacturer_Site;
        private System.Windows.Forms.Label label5;
    }
}