using System.Configuration;
using System.Data.OracleClient;
using System.Windows.Forms;

namespace FirmaTikTak
{
    public partial class ManagerFirm : Form
    {
        private OracleConnection connection = new OracleConnection(ConfigurationManager.ConnectionStrings["Con1"].ConnectionString);
        public ManagerFirm()
        {
            InitializeComponent();
            Core.Update_DataTable(OperationsGrid, "OPERATION");
            Core.Update_DataTable(OrdersGrid, "MAINORDERS");
            Core.Update_DataTable(InstrumentsGrid, "INSTRUMENTS");
            Core.Update_DataTable(MatGrid, "MATERIALS");
        }

        private void OrdersGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idorder.Text = OrdersGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void MatGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (checkBox1.Checked)
            {
                idmat.Text = MatGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void InstrumentsGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (checkBox2.Checked)
            {
                idinst.Text = InstrumentsGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void OperationsGrid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            Core.Delete_Row(e.Row.Cells[0].Value, "OPERATION");
        }

        private void OperationsGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string NameColumn = OperationsGrid.Columns[e.ColumnIndex].HeaderText;
            object value = OperationsGrid[e.ColumnIndex, e.RowIndex].Value;
            object id = OperationsGrid.Rows[e.RowIndex].Cells[0].Value;
            Core.Update_Values("OPERATION", NameColumn, value, id);
        }

        // Создание операции
        [System.Obsolete]
        private void button1_Click(object sender, System.EventArgs e)
        {
            connection.Open();
            OracleCommand cmd = connection.CreateCommand();

            cmd.CommandText = "INSERT INTO OPERATION(DESCRIPTION, ID_MAT,COUNT_MAT,ID_INST,COUNT_INST,ID_ORDER)" +
                " VALUES(:descV, :id1, :count1, :id2, :count2, :id3)";
            cmd.Parameters.Add("descV", richTextBox1.Text);
            cmd.Parameters.Add("id1", idmat.Text);
            cmd.Parameters.Add("count1", countmat.Text);
            cmd.Parameters.Add("id2", idinst.Text);
            cmd.Parameters.Add("count2", countnst.Text);
            cmd.Parameters.Add("id3", idorder.Text);

            cmd.ExecuteNonQuery();

            Core.Update_DataTable(OperationsGrid, "OPERATION");

            connection.Close();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Имитация производства");
        }

        private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkBox1.Checked)
            {
                idmat.ReadOnly = false;
                countmat.ReadOnly = false;
            }
            else
            {
                idmat.ReadOnly = true;
                countmat.ReadOnly = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkBox2.Checked)
            {
                idinst.ReadOnly = false;
                countnst.ReadOnly = false;
            }
            else
            {
                idinst.ReadOnly = true;
                countnst.ReadOnly = true;
            }
        }
    }
}
