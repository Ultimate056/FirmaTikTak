using Oracle.ManagedDataAccess.Client;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace FirmaTikTak
{
    public partial class Client : Form
    {
        private OracleConnection connection = new OracleConnection(ConfigurationManager.ConnectionStrings["Con1"].ConnectionString);
        public Client()
        {
            InitializeComponent();
            Core.JoinTables(ProductsGrid);
        }

        private void ListOrdersGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = ProductsGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            OracleCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT NAME FROM TOVAR WHERE ID=" + textBox1.Text;
            object name = cmd.ExecuteScalar();
            listView1.Items.Add(textBox1.Text + ". " + name.ToString() + " в количестве " + countBox.Text);
            MessageBox.Show("Успешное добавление товара в корзину");
            textBox1.Text = "";
            countBox.Text = "";
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ЗВАНИТЕ 8 800 355 55 35");
        }
    }
}
