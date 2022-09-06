using Oracle.ManagedDataAccess.Client;
using System.Configuration;
using System.Data;

namespace FirmaTikTak
{
    static public class Core
    {
        static private OracleConnection connection = new OracleConnection(ConfigurationManager.ConnectionStrings["Con1"].ConnectionString);
        static private OracleDataAdapter adapter;
        static private OracleCommand cmd;

        // Обновление или инициализация таблицы в DataGrid
        public static void Update_DataTable(System.Windows.Forms.DataGridView Grid, string nameTable)
        {
            adapter = new OracleDataAdapter("SELECT * FROM " + nameTable, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            Grid.DataSource = dataTable;
        }

        public static void JoinTables(System.Windows.Forms.DataGridView Grid)
        {
            adapter = new OracleDataAdapter("SELECT * FROM PRODUCT LEFT OUTER JOIN TOVAR ON ID_TOVAR=TOVAR.ID",connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            Grid.DataSource = dataTable;
        }

        // Удаление строки из столбца по айдишнику
        public static void Delete_Row(object id_row, string nameTable)
        {
            connection.Open();
            cmd = connection.CreateCommand();
            cmd.CommandText = "DELETE FROM " + nameTable + " WHERE ID=" + id_row;
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public static void Update_Values(string table, string col, object value, object id)
        {
            connection.Open();
            cmd = connection.CreateCommand();
            cmd.CommandText = "UPDATE " + table + " SET " + col + "=" + value + " WHERE" +
                " ID=" + id;
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
