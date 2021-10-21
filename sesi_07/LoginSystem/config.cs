using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;//MessageBox
using System.Data;//function classes

namespace LoginSystem
{
    class config
    {
        string ConnectionString = "";
        public MySqlConnection connection = null;
        public string server = "127.0.0.1";
        public string user = "root";
        public string pass = "root";
        DataSet ds;
        DataTable dt;
        public string Table = "user_info";
        public string ConnectionType = "";
        string RecordSource = "";

        DataGridView tempdata;

        public config()
        {

        }

        public void Connect(string database_name)
        {
            try
            {
                ConnectionString = "SERVER=" + server + ";" + "DATABASE=" + database_name + ";" + "UID=" + user + ";" + "PASSWORD=" + pass + ";";
                connection = new MySqlConnection(ConnectionString);
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                //throw;
            }
        }

        //function execute select statements
        public void ExecuteSql(string Sql_command)
        {
            nowquiee(Sql_command);
        }

        //koneksi sebelum execute
        public void nowquiee(string sql_comm)
        {
            try
            {
                MySqlConnection cs = new MySqlConnection(ConnectionString);
                cs.Open();
                MySqlCommand myc = new MySqlCommand(sql_comm, cs);
                myc.ExecuteNonQuery();
                cs.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                //throw;
            }
        }
        public void Execute(string Sql_command)
        {
            RecordSource = Sql_command;
            ConnectionType = Table;
            dt = new DataTable(ConnectionType);
            try
            {
                string command = RecordSource.ToUpper();
                MySqlDataAdapter da2 = new MySqlDataAdapter(RecordSource, connection);

                DataSet tempds = new DataSet();
                da2.Fill(tempds, ConnectionType);
                //da2.Fill(tempds);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                //throw;
            }
        }

        public string Results(int row, string column_name)
        {
            try
            {
                return dt.Rows[row][column_name].ToString(); 
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return "";
                //throw;
            }
        }

        public string Results(int row, int column_name)
        {
            try
            {

                return dt.Rows[row][column_name].ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return dt.Rows[row][column_name].ToString();
                //throw;
            }
        }

        public void ExecutedSelect(string Sql_command)
        {
            RecordSource = Sql_command;
            ConnectionType = Table;
            dt = new DataTable(ConnectionType);

            try
            {
                string command = RecordSource.ToUpper();
                MySqlDataAdapter da = new MySqlDataAdapter(RecordSource, connection);
                ds = new DataSet();
                da.Fill(ds, ConnectionType);
                da.Fill(dt);
                tempdata = new DataGridView();
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
                //throw;
            }
        }
        public int Count()
        {
            return dt.Rows.Count;
        }
    }
}
