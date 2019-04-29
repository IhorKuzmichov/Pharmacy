using Pharmacy.Properties;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class ConnectionStringForm : Form
    {
        public ConnectionStringForm()
        {
            InitializeComponent();

            TB_ConnectionString.Text = Settings.Default.connectionString;
        }

        private void BTN_OK_Click(object sender, System.EventArgs e)
        {
            TB_ConnectionString.Text.Trim();

            if (string.IsNullOrEmpty(TB_ConnectionString.Text) || string.IsNullOrWhiteSpace(TB_ConnectionString.Text)) // чи пуста строка
            {
                MessageBox.Show("Строка не має бути пустою");
                return;
            }

            Settings.Default.connectionString = TB_ConnectionString.Text;
            Settings.Default.Save();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void BTN_Cancel_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
