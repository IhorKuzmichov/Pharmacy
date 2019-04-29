using System.Windows.Forms;
using System;
using System.Linq;
using System.Data;
using MySql.Data.MySqlClient;
using Pharmacy.Properties;

namespace Pharmacy
{
    public partial class ManufacturerForm : Form
    {
        public string manufacturerName;
        public string manufacturerCountry;
        public string manufacturerAddress;
        public string manufacturerPhoneNumber;
        public string manufacturerSite;

        public ManufacturerForm(string _manufacturerName = "", string _manufacturerCountry = "", string _manufacturerAddress = "",
                                string _manufacturerPhoneNumber = "", string _manufacturerSite = "")
        {
            InitializeComponent();


            manufacturerName        = _manufacturerName;
            manufacturerCountry     = _manufacturerCountry;
            manufacturerAddress     = _manufacturerAddress;
            manufacturerPhoneNumber = _manufacturerPhoneNumber;
            manufacturerSite        = _manufacturerSite;

            FillInputBoxes();
        }

        // заповнення полей
        void FillInputBoxes()
        {
            TB_Manufacturer_Name.Text        = manufacturerName;
            TB_Manufacturer_Country.Text     = manufacturerCountry;
            TB_Manufacturer_Address.Text     = manufacturerAddress;
            TB_Manufacturer_PhoneNumber.Text = manufacturerPhoneNumber;
            TB_Manufacturer_Site.Text        = manufacturerSite;
        }

        private void BTN_OK_Click(object sender, EventArgs e)
        {
            foreach (TextBox tb in Controls.OfType<TextBox>())
            {
                tb.Text.Trim();

                if (string.IsNullOrEmpty(tb.Text) || string.IsNullOrWhiteSpace(tb.Text)) // чи пуста строка
                {
                    MessageBox.Show("Назва не має бути пустою");
                    return;
                }
            }

            manufacturerName        = TB_Manufacturer_Name.Text;
            manufacturerCountry     = TB_Manufacturer_Country.Text;
            manufacturerAddress     = TB_Manufacturer_Address.Text;
            manufacturerPhoneNumber = TB_Manufacturer_PhoneNumber.Text;
            manufacturerSite        = TB_Manufacturer_Site.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public static DataTable SELECTQuery()
        {
            string query = "SELECT * FROM manufacturer";
            return DBQueries.ExecuteQuery(query, new MySqlConnection(Settings.Default.connectionString));
        }

        public static void DELETEQuery(int id)
        {
            string query = $"DELETE FROM manufacturer WHERE id = {id} ";
            DBQueries.ExecuteNonQuery(query, new MySqlConnection(Settings.Default.connectionString));
        }

        public void UPDATEQuery(int id)
        {
            if (ShowDialog() == DialogResult.OK)
            {
                string query = "UPDATE manufacturer " +
                                       $"SET name         = '{manufacturerName}', " +
                                       $"    country      = '{manufacturerCountry}', " +
                                       $"    address      = '{manufacturerAddress}', " +
                                       $"    phone_number = '{manufacturerPhoneNumber}', " +
                                       $"    site         = '{manufacturerSite}' " +
                                       $"WHERE id = {id} ";
                DBQueries.ExecuteNonQuery(query, new MySqlConnection(Settings.Default.connectionString));
            }
        }

        public void INSERTQuery()
        {
            if (ShowDialog() == DialogResult.OK)
            {
                string query = "INSERT INTO manufacturer (name, country, address, phone_number, site) " +
                                   $"VALUES ('{manufacturerName}'," +
                                   $"        '{manufacturerCountry}', " +
                                   $"        '{manufacturerAddress}', " +
                                   $"        '{manufacturerPhoneNumber}', " +
                                   $"        '{manufacturerSite}') ";
                DBQueries.ExecuteNonQuery(query, new MySqlConnection(Settings.Default.connectionString));
            }
        }

        /* обмеження вводу */
        private void TB_Manufacturer_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyChar = e.KeyChar;

            if (keyChar == '\'' || keyChar == '`' || keyChar == ';')
            {
                e.Handled = true;
            }
        }

        private void TB_Manufacturer_Country_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyChar = e.KeyChar;

            if (!char.IsLetter(keyChar) && !Char.IsControl(keyChar))
            {
                e.Handled = true;
            }
        }

        private void TB_Manufacturer_Address_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyChar = e.KeyChar;

            if (keyChar == '\'' || keyChar == '`' || keyChar == ';')
            {
                e.Handled = true;
            }
        }

        private void TB_Manufacturer_PhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyChar = e.KeyChar;

            if (!char.IsDigit(keyChar) && !Char.IsControl(keyChar) &&
                !(keyChar == '+' && ((TextBox)sender).SelectionStart == 0 && !((TextBox)sender).Text.Contains('+')))
            {
                e.Handled = true;
            }
        }

        private void TB_Manufacturer_Site_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyChar = e.KeyChar;

            if (keyChar == '\'' || keyChar == '`' || keyChar == ';' || keyChar == ' ')
            {
                e.Handled = true;
            }
        }
    }
}
