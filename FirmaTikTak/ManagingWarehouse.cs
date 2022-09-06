using Oracle.ManagedDataAccess.Client;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace FirmaTikTak
{
    public partial class ManagingWarehouse : Form
    {
        private OracleConnection connection = new OracleConnection(ConfigurationManager.ConnectionStrings["Con1"].ConnectionString);
        private object _idEmp;
        public ManagingWarehouse(object id_emp)
        {
            InitializeComponent();
            _idEmp = id_emp;
            Core.Update_DataTable(ListOrdersGrid, "MAINORDERS");
            Core.Update_DataTable(MatGrid, "MATERIALS");
            Core.Update_DataTable(InstGrid, "INSTRUMENTS");
            Core.Update_DataTable(LogsGrid, "LOG_CUSTOM");
            Core.Update_DataTable(triggerGrid, "PSS");
        }

        private void CreateLogButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            OracleCommand cmd2 = connection.CreateCommand();
            string date = dateTimePicker1.Value.Day + "." + dateTimePicker1.Value.Month
                        + "." + dateTimePicker1.Value.Year;
            if (TypeInst.Checked)
            {
                cmd2.CommandText = "INSERT INTO LOG_CUSTOM(COUNT,NUMBER_ORDER,RESPONSIBLE,DATEOFISSUE, ID_INST) VALUES(" +
                ":count,:n1,:n_emp,:dat,:id_zhopa)";
            }
            else
            {
                cmd2.CommandText = "INSERT INTO LOG_CUSTOM(COUNT,NUMBER_ORDER,RESPONSIBLE,DATEOFISSUE, ID_MAT) VALUES(" +
                ":count,:n1,:n_emp,:dat,:id_zhopa)";
            }
            cmd2.Parameters.Add("count", CountVid.Text);
            cmd2.Parameters.Add("n1", NumberOrder.Text);
            cmd2.Parameters.Add("n_emp", _idEmp);
            cmd2.Parameters.Add("dat", date);
            cmd2.Parameters.Add("id_zhopa", IDvid.Text);
            cmd2.ExecuteNonQuery();

            // Изменение кол-ва
            if (TypeInst.Checked)
            {
                cmd2.CommandText = "UPDATE INSTRUMENTS SET LEFT_COUNT = LEFT_COUNT-" + CountVid.Text + " WHERE ID=" + IDvid.Text;
                cmd2.ExecuteNonQuery();
                Core.Update_DataTable(InstGrid, "INSTRUMENTS");
            }
            else
            {
                cmd2.CommandText = "UPDATE MATERIALS SET LEFT_COUNT = LEFT_COUNT-" + CountVid.Text + " WHERE ID=" + IDvid.Text;
                cmd2.ExecuteNonQuery();
                Core.Update_DataTable(MatGrid, "MATERIALS");
            }
            MessageBox.Show("Запись успешно добавлена");
            connection.Close();
            Core.Update_DataTable(LogsGrid, "LOG_CUSTOM");
        }


        private void ManagingWarehouse_Load(object sender, EventArgs e)
        {

        }





        // * Events

        private void ListOrdersGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            NumberOrder.Text = ListOrdersGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void InstGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            IDvid.Text = InstGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void MatGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            IDvid.Text = MatGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void InstGrid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e) =>
            Core.Delete_Row(e.Row.Cells[0].Value, "INSTRUMENTS");

        private void InstGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string NameColumn = InstGrid.Columns[e.ColumnIndex].HeaderText;
            object value = InstGrid[e.ColumnIndex, e.RowIndex].Value;
            object id = InstGrid.Rows[e.RowIndex].Cells[0].Value;
            Core.Update_Values("INSTRUMENTS", NameColumn, value, id);
            Core.Update_DataTable(triggerGrid, "PSS");
        }

        private void MatGrid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e) =>
            Core.Delete_Row(e.Row.Cells[0].Value, "MATERIALS");


        private void MatGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string NameColumn = MatGrid.Columns[e.ColumnIndex].HeaderText;
            object value = MatGrid[e.ColumnIndex, e.RowIndex].Value;
            object id = MatGrid.Rows[e.RowIndex].Cells[0].Value;
            Core.Update_Values("MATERIALS", NameColumn, value, id);
        }

        private void TypeMat_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            OracleCommand cmd3 = connection.CreateCommand();
            if (radioButton1.Checked)
            {
                cmd3.CommandText = "BEGIN AddInst(:nam, :dedsss, :count_my); END;"; 
            }
            else
            {
                cmd3.CommandText = "BEGIN AddMat(:nam, :dedsss, :count_my); END;";
            }
            cmd3.Parameters.Add("nam", nameBox.Text);
            cmd3.Parameters.Add("dedsss", richTextBox1.Text);
            cmd3.Parameters.Add("count_my", countBox2.Text);
            cmd3.ExecuteNonQuery();

            MessageBox.Show("Объект успешно добавлен");
            connection.Close();
            Core.Update_DataTable(InstGrid, "INSTRUMENTS");
            Core.Update_DataTable(MatGrid, "MATERIALS");

        }
    }
}
