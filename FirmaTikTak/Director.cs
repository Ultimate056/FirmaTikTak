using Oracle.ManagedDataAccess.Client;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace FirmaTikTak
{
    public partial class Director : Form
    {
        private OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["Con1"].ConnectionString);
        OracleCommand cmd;
        public Director()
        {
            InitializeComponent();
            Core.Update_DataTable(ListTovarsGrid, "TOVAR");
            Core.Update_DataTable(ListOrdersGrid, "MAINORDERS");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = con.CreateCommand();
            string d1 = DateTime.Now.Day + "." + DateTime.Now.Month
                        + "." + DateTime.Now.Year;
            string d2 = dateTimePicker1.Value.Day + "." + dateTimePicker1.Value.Month
                        + "." + dateTimePicker1.Value.Year;
            cmd.CommandText = "INSERT INTO MAINORDERS(CREATE_DATE, DEADLINE, COUNT_ORDER, ID_TOVAR) VALUES(" +
                ":date1, :date2,:count, :id)";
            cmd.Parameters.Add("date1", d1);
            cmd.Parameters.Add("date2", d2);
            cmd.Parameters.Add("count", countBox1.Text);
            cmd.Parameters.Add("id", IdPickerBox1.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Заказ успешно добавлен");
            con.Close();
            Core.Update_DataTable(ListOrdersGrid, "MAINORDERS");
        }

        private void ListOrdersGrid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            Core.Delete_Row(e.Row.Cells[0].Value, "MAINORDERS");
        }
            

        private void ListOrdersGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string NameColumn = ListOrdersGrid.Columns[e.ColumnIndex].HeaderText;
            object value = ListOrdersGrid[e.ColumnIndex, e.RowIndex].Value;
            object id = ListOrdersGrid.Rows[e.RowIndex].Cells[0].Value;
            Core.Update_Values("MAINORDERS", NameColumn, value, id);
        }

        private void ListTovarsGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)=>
            IdPickerBox1.Text = ListTovarsGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
    }
}
