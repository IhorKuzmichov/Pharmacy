using MySql.Data.MySqlClient;
using Pharmacy.Properties;
using System;
using System.Data;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class CategoryForm : Form
    {
        public string categoryName;

        public CategoryForm(string _categoryName = "")
        {
            InitializeComponent();

            categoryName = _categoryName;

            FillInputBoxes();
        }

        // заповнення полей
        void FillInputBoxes()
        {
            TB_Category_Name.Text = categoryName;
        }

        private void BTN_OK_Click(object sender, EventArgs e)
        {
            TB_Category_Name.Text.Trim();

            if (string.IsNullOrEmpty(TB_Category_Name.Text) || string.IsNullOrWhiteSpace(TB_Category_Name.Text)) // чи пуста строка
            {
                MessageBox.Show("Назва не має бути пустою");
                return;
            }

            categoryName = TB_Category_Name.Text;

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
            string query = "SELECT * FROM category";
            return DBQueries.ExecuteQuery(query, new MySqlConnection(Settings.Default.connectionString));
        }

        public static void DELETEQuery(int id)
        {
            string query = $"DELETE FROM category WHERE id = {id} ";
            DBQueries.ExecuteNonQuery(query, new MySqlConnection(Settings.Default.connectionString));
        }

        public void UPDATEQuery(int id)
        {
            if (ShowDialog() == DialogResult.OK)
            {
                string query = $"UPDATE category SET name = '{categoryName}' " +
                               $"WHERE id = {id} ";
                DBQueries.ExecuteNonQuery(query, new MySqlConnection(Settings.Default.connectionString));
            }
        }

        public void INSERTQuery()
        {
            if (ShowDialog() == DialogResult.OK)
            {
                string query = $"INSERT INTO category (name) VALUES ('{categoryName}') ";
                DBQueries.ExecuteNonQuery(query, new MySqlConnection(Settings.Default.connectionString));
            }
        }


        /* обмеження вводу */
        private void TB_Category_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyChar = e.KeyChar;

            if (keyChar == '\"' || keyChar == '\'' || keyChar == '`' || keyChar == ';')
            {
                e.Handled = true;
            }
        }
    }
}
