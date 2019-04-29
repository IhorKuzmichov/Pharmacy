using MySql.Data.MySqlClient;
using Pharmacy.Properties;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class DrugForm : Form
    {
        public string drugName;
        public int drugQuantity;
        public float drugPrice;
        public DateTime drugManufactureDate;
        public DateTime drugExpirationDate;
        public string drugDescription;
        public int drugManufacurerID;
        public int drugCategoryID;

        DataTable manufacturerTable;
        DataTable categoryTable;

        public DrugForm(string _drugName = "", int _drugQuantity = 0, float _drugPrice = 0f, string _drugDescription = "",
                        int _drugManufacurerID = 0, int _drugCategoryID = 0)

            : this(_drugName, _drugQuantity, _drugPrice, _drugDescription, DateTime.Today.AddYears(-1),
                   DateTime.Today.AddYears(1), _drugManufacurerID, _drugCategoryID)
        {
        }

        public DrugForm(string _drugName, int _drugQuantity, float _drugPrice, string _drugDescription, DateTime _drugManufactureDate,
                        DateTime _drugExpirationDate, int _drugManufacurerID, int _drugCategoryID)
        {
            InitializeComponent();

            drugName            = _drugName;
            drugQuantity        = _drugQuantity;
            drugPrice           = _drugPrice;
            drugDescription     = _drugDescription;
            drugManufactureDate = _drugManufactureDate;
            drugExpirationDate  = _drugExpirationDate;
            drugManufacurerID   = _drugManufacurerID;
            drugCategoryID      = _drugCategoryID;

            // заповнюємо manufacturerTable
            string query = "SELECT id, name FROM manufacturer";
            manufacturerTable = DBQueries.ExecuteQuery(query, new MySqlConnection(Settings.Default.connectionString));
            foreach (DataRow dr in manufacturerTable.Rows)
            {
                CB_Drug_Manufacturer.Items.Add(dr["name"]);
            }

            // заповнюємо categoryTable
            query = "SELECT id, name FROM category";
            categoryTable = DBQueries.ExecuteQuery(query, new MySqlConnection(Settings.Default.connectionString));
            foreach (DataRow dr in categoryTable.Rows)
            {
                CB_Drug_Category.Items.Add(dr["name"]);
            }

            FillInputBoxes();
        }

        // заповнення полей
        void FillInputBoxes()
        {
            TB_Drug_Name.Text              = drugName;
            TB_Drug_Quantity.Text          = drugQuantity.ToString();
            TB_Drug_Price.Text             = drugPrice.ToString();
            DTP_Drug_ManufactureDate.Value = drugManufactureDate;
            DTP_Drug_ExpirationDate.Value  = drugExpirationDate;
            TB_Drug_Description.Text       = drugDescription;

            var selectedRows = manufacturerTable.Select($"id = {drugManufacurerID}");
            if (selectedRows.Length > 0)
            {
                CB_Drug_Manufacturer.SelectedIndex = manufacturerTable.Rows.IndexOf(selectedRows[0]);
            }
            else if (manufacturerTable.Rows.Count > 0)
            {
                CB_Drug_Manufacturer.SelectedIndex = 0;
            }

            selectedRows = categoryTable.Select($"id = {drugCategoryID}");
            if (selectedRows.Length > 0)
            {
                CB_Drug_Category.SelectedIndex = categoryTable.Rows.IndexOf(selectedRows[0]);
            }
            else if (manufacturerTable.Rows.Count > 0)
            {
                CB_Drug_Category.SelectedIndex = 0;
            }
        }

        private void BTN_OK_Click(object sender, EventArgs e)
        {
            TB_Drug_Name.Text.Trim();

            if (string.IsNullOrEmpty(TB_Drug_Name.Text) || string.IsNullOrWhiteSpace(TB_Drug_Name.Text)) // чи пуста строка
            {
                MessageBox.Show("Назва не має бути пустою");
                return;
            }

            if (DTP_Drug_ManufactureDate.Value >= DTP_Drug_ExpirationDate.Value) // корректність дат
            {
                MessageBox.Show("Дата виробництва препарату не може дорівнювати чи бути пізнішою за дату закінчення сроку придатності");
                return;
            }

            if (int.Parse(TB_Drug_Quantity.Text) <= 0 ||
                int.Parse(TB_Drug_Price.Text) <= 0) // корректність ціни та кількості
            {
                MessageBox.Show("Ціна препарату та його кількість не мужуть дорівнювати нулю, або бути меншими за нуль");
                return;
            }

            drugName            = TB_Drug_Name.Text;
            drugQuantity        = int.Parse(TB_Drug_Quantity.Text);
            drugPrice           = int.Parse(TB_Drug_Price.Text);
            drugManufactureDate = DTP_Drug_ManufactureDate.Value;
            drugExpirationDate  = DTP_Drug_ExpirationDate.Value;
            drugDescription     = TB_Drug_Description.Text;
            drugManufacurerID   = (int)manufacturerTable.Select($"name = '{CB_Drug_Manufacturer.Text}'")[0]["id"];
            drugCategoryID      = (int)categoryTable.Select($"name = '{CB_Drug_Category.Text}'")[0]["id"];

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
            string query = "SELECT drug.*, category.name AS cname FROM drug " +
                                   "LEFT JOIN category ON drug.category_id = category.id ";
            return DBQueries.ExecuteQuery(query, new MySqlConnection(Settings.Default.connectionString));
        }

        public static void DELETEQuery(int id)
        {
            string query = $"DELETE FROM drug WHERE id = {id} ";
            DBQueries.ExecuteNonQuery(query, new MySqlConnection(Settings.Default.connectionString));
        }

        public void UPDATEQuery(int id)
        {
            if (ShowDialog() == DialogResult.OK)
            {
                string query = $"UPDATE drug " +
                               $"SET name             = '{drugName}', " +
                               $"    quantity         =  {drugQuantity}, " +
                               $"    price            =  {drugPrice}, " +
                               $"    manufacture_date = '{drugManufactureDate.Year}.{drugManufactureDate.Month}.{drugManufactureDate.Day}', " +
                               $"    expiration_date  = '{drugExpirationDate.Year}.{drugExpirationDate.Month}.{drugExpirationDate.Day}', " +
                               $"    description      = '{drugDescription}', " +
                               $"    manufacturer_id  =  {drugManufacurerID}, " +
                               $"    category_id      =  {drugCategoryID} " +
                               $"WHERE id = {id} ";
                DBQueries.ExecuteNonQuery(query, new MySqlConnection(Settings.Default.connectionString));
            }
        }

        public void INSERTQuery()
        {
            if (ShowDialog() == DialogResult.OK)
            {
                string query = $"INSERT INTO drug (name, quantity, price, manufacture_date, expiration_date, description, manufacturer_id, category_id) " +
                               $"VALUES ('{drugName}', " +
                               $"         {drugQuantity}, " +
                               $"         {drugPrice}, " +
                               $"        '{drugManufactureDate.Year}.{drugManufactureDate.Month}.{drugManufactureDate.Day}', " +
                               $"        '{drugExpirationDate.Year}.{drugExpirationDate.Month}.{drugExpirationDate.Day}', " +
                               $"        '{drugDescription}', " +
                               $"         {drugManufacurerID}, " +
                               $"         {drugCategoryID}) ";
                DBQueries.ExecuteNonQuery(query, new MySqlConnection(Settings.Default.connectionString));
            }
        }


        /* обмеження вводу */
        private void TB_Drug_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyChar = e.KeyChar;

            if (keyChar == '\'' || keyChar == '`' || keyChar == ';')
            {
                e.Handled = true;
            }
        }

        private void TB_Drug_Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyChar = e.KeyChar;

            if (!char.IsDigit(keyChar) && !Char.IsControl(keyChar))
            {
                e.Handled = true;
            }
        }

        private void TB_Drug_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyChar = e.KeyChar;

            if (!char.IsDigit(keyChar) && !Char.IsControl(keyChar) &&
                !(keyChar == '.' && !((TextBox)sender).Text.Contains('.')))
            {
                e.Handled = true;
            }
        }

        private void TB_Drug_Description_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyChar = e.KeyChar;

            if (keyChar == '\'' || keyChar == '`' || keyChar == ';' || ((TextBox)sender).Text.Length >= 200)
            {
                e.Handled = true;
            }
        }
    }
}
