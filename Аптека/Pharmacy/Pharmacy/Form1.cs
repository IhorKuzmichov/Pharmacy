using MySql.Data.MySqlClient;
using Pharmacy.Properties;
using System;
using System.Data;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class Form1 : Form
    {
        DataGridView currentDGV; // поточний dataGridView

        public Form1()
        {
            InitializeComponent();
            
            currentDGV = DGV_Drug;

            FillDGV(DGV_Drug);
            FillDGV(DGV_Category);
            FillDGV(DGV_Manufacturer);
        }

        // заповнюємо dataGridView даними з бази даних
        void FillDGV(DataGridView dataGridVeiw)
        {
            try
            {
                if (dataGridVeiw == DGV_Drug)
                {
                    // отримуємо таблицю drug                    
                    dataGridVeiw.DataSource = DrugForm.SELECTQuery();

                    // ховаємо непотрібні користовачу стопчики
                    dataGridVeiw.Columns["id"].Visible              = false;
                    dataGridVeiw.Columns["description"].Visible     = false;
                    dataGridVeiw.Columns["manufacturer_id"].Visible = false;
                    dataGridVeiw.Columns["category_id"].Visible     = false;

                    // перейменовуємо заголовки
                    dataGridVeiw.Columns["name"].HeaderText             = "Назва препарату";
                    dataGridVeiw.Columns["quantity"].HeaderText         = "Ціна (грн.)";
                    dataGridVeiw.Columns["price"].HeaderText = "Кількість (шт.)";
                    dataGridVeiw.Columns["manufacture_date"].HeaderText = "Дата виготовлення";
                    dataGridVeiw.Columns["expiration_date"].HeaderText  = "Строк придатності до";
                    dataGridVeiw.Columns["cname"].HeaderText            = "Категорія";
                }
                else if (dataGridVeiw == DGV_Category)
                {
                    // отримуємо таблицю category                    
                    dataGridVeiw.DataSource = CategoryForm.SELECTQuery();

                    // ховаємо непотрібні користовачу стопчики
                    dataGridVeiw.Columns["id"].Visible = false;

                    // перейменовуємо заголовки
                    dataGridVeiw.Columns["name"].HeaderText = "Назва категорії";
                }
                else if (dataGridVeiw == DGV_Manufacturer)
                {
                    // отримуємо таблицю manufacturer
                    dataGridVeiw.DataSource = ManufacturerForm.SELECTQuery();

                    // ховаємо непотрібні користовачу стопчики
                    dataGridVeiw.Columns["id"].Visible = false;

                    // перейменовуємо заголовки
                    dataGridVeiw.Columns["name"].HeaderText         = "Назва організації";
                    dataGridVeiw.Columns["country"].HeaderText      = "Країна";
                    dataGridVeiw.Columns["address"].HeaderText      = "Адреса";
                    dataGridVeiw.Columns["phone_number"].HeaderText = "Телефонний номер";
                    dataGridVeiw.Columns["site"].HeaderText         = "Сайт";
                }
            }
            catch (Exception ex) { }
        }

        // кнопка "видалити"
        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            var currentRow = currentDGV.CurrentRow;

            if (currentRow != null) // чи обран рядок
            {
                // підтвердження видалення
                DialogResult dialogResult = MessageBox.Show("Ви точно хочете видалити цей рядок?", "Підтвердження видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    if (currentDGV == DGV_Drug)
                    {
                        DrugForm.DELETEQuery((int)currentRow.Cells["id"].Value);
                    }
                    else if (currentDGV == DGV_Category)
                    {
                        CategoryForm.DELETEQuery((int)currentRow.Cells["id"].Value);
                    }
                    else if (currentDGV == DGV_Manufacturer)
                    {
                        ManufacturerForm.DELETEQuery((int)currentRow.Cells["id"].Value);
                    }

                    FillDGV(currentDGV);
                }
            }
            else
            {
                MessageBox.Show("Спочатку оберіть рядок для видалення!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // кнопка "змінити"
        private void BTN_Update_Click(object sender, EventArgs e)
        {
            var currentRow = currentDGV.CurrentRow;

            if (currentRow != null) // чи обран рядок
            {
                if (currentDGV == DGV_Drug)
                {
                    DrugForm drugForm = new DrugForm(currentRow.Cells["name"].Value.ToString(),
                                                     (int)currentRow.Cells["quantity"].Value,
                                                     (float)currentRow.Cells["price"].Value,
                                                     currentRow.Cells["description"].Value.ToString(),
                                                     (DateTime)currentRow.Cells["manufacture_date"].Value,
                                                     (DateTime)currentRow.Cells["expiration_date"].Value,
                                                     (int)currentRow.Cells["manufacturer_id"].Value,
                                                     (int)currentRow.Cells["category_id"].Value);
                    drugForm.UPDATEQuery((int)currentRow.Cells["id"].Value);
                }
                else if (currentDGV == DGV_Category)
                {
                    CategoryForm categoryForm = new CategoryForm(currentRow.Cells["name"].Value.ToString());
                    categoryForm.UPDATEQuery((int)currentRow.Cells["id"].Value);
                }
                else if (currentDGV == DGV_Manufacturer)
                {
                    ManufacturerForm manufacturerForm = new ManufacturerForm(currentRow.Cells["name"].Value.ToString(),
                                                                             currentRow.Cells["country"].Value.ToString(),
                                                                             currentRow.Cells["address"].Value.ToString(),
                                                                             currentRow.Cells["phone_number"].Value.ToString(),
                                                                             currentRow.Cells["site"].Value.ToString());
                    manufacturerForm.UPDATEQuery((int)currentRow.Cells["id"].Value);
                }

                FillDGV(currentDGV);
            }
        }
        
        // кнопка "додати"
        private void BTN_Insert_Click(object sender, EventArgs e)
        {
            if (currentDGV == DGV_Drug)
            {
                DrugForm drugForm = new DrugForm();
                drugForm.INSERTQuery();
            }
            else if (currentDGV == DGV_Category)
            {
                CategoryForm categoryForm = new CategoryForm();
                categoryForm.INSERTQuery();
            }
            else if (currentDGV == DGV_Manufacturer)
            {
                ManufacturerForm manufacturerForm = new ManufacturerForm();
                manufacturerForm.INSERTQuery();
            }

            FillDGV(currentDGV);
        }

        // зміна поточної клітинки
        private void DGV_Drug_CurrentCellChanged(object sender, EventArgs e)
        {
            // заповнюємо даними textBox-и
            try
            {
                var currentRow = DGV_Drug.CurrentRow;

                if (currentRow != null) // чи обран рядок
                {
                    int tmp;
                    object manufacturer_id = currentRow.Cells["manufacturer_id"].Value;

                    // заповнюємо даними textBox-и
                    TB_Drug_Description.Text = currentRow.Cells["description"].Value.ToString();

                    if (int.TryParse(manufacturer_id.ToString(), out tmp)) // чи має препарат виробника
                    {
                        // отримуємо дані з таблиці manufacturer
                        DataRow[] rows = ManufacturerForm.SELECTQuery().Select($"id = {(int)manufacturer_id}");

                        // заповнюємо даними textBox-и
                        TB_Manufacturer_Name.Text        = rows[0]["name"].ToString();
                        TB_Manufacturer_Country.Text     = rows[0]["country"].ToString();
                        TB_Manufacturer_Address.Text     = rows[0]["address"].ToString();
                        TB_Manufacturer_PhoneNumber.Text = rows[0]["phone_number"].ToString();
                        TB_Manufacturer_Site.Text        = rows[0]["site"].ToString();
                    }
                }
                else
                {
                    // очищаємо textBox-и
                    TB_Drug_Description.Text = "";

                    TB_Manufacturer_Name.Text        = "";
                    TB_Manufacturer_Country.Text     = "";
                    TB_Manufacturer_Address.Text     = "";
                    TB_Manufacturer_PhoneNumber.Text = "";
                    TB_Manufacturer_Site.Text        = "";
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        // переміщення по вкладинкам
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                currentDGV = DGV_Drug;
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                currentDGV = DGV_Category;
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                currentDGV = DGV_Manufacturer;
            }            
        }


        // кнопка в меню "строка підключення" (потрібна для настроювання підключення до БД)
        private void MI_ConnectionString_Click(object sender, EventArgs e)
        {
            ConnectionStringForm connectionStringForm = new ConnectionStringForm();
            if (connectionStringForm.ShowDialog() == DialogResult.OK)
            {
                FillDGV(currentDGV);
            }            
        }

        // кнопка в меню "про программу"
        private void MI_About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа \"Аптека\"");
        }
    }
}
