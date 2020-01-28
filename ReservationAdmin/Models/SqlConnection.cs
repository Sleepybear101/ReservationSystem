using MySql.Data.MySqlClient;
using System.Data;

namespace ReservationAdmin.Models
{
    public class SqlConnection
    {

        private MySqlConnection _con;
        public MySqlCommand Cmd;
        private MySqlDataAdapter _da;
        private DataTable _dt;
        private bool IsConnectionopen = false;

        //Query wordt gemaakt naar command
        public void SqlQuery(string queryText)
        {
            //lokale database
           // _con = new MySqlConnection("Server=localhost;  Database=reservationsystem; username=root; password=");
            //online database
            _con = new MySqlConnection("Server=remotemysql.com; port=3306;  Database=uGoauhO5db; username=uGoauhO5db; password=jqH0eS2CJW");
            if (!IsConnectionopen)
            {
                _con.Open();
                IsConnectionopen = true;
            }
            Cmd = new MySqlCommand(queryText, _con);
        }
        //Query wordt uitgevoerd en krijgt informatie terug
        public DataTable QueryEx()
        {
            _da = new MySqlDataAdapter(Cmd);
            _dt = new DataTable();
            _da.Fill(_dt);
            _con.Close();
            IsConnectionopen = false;
            return _dt;
         
        }
        //Query wordt uitgevoerd met geen resultaat
        public void NonQueryEx()
        {
            Cmd.ExecuteNonQuery();
            _con.Close();
            IsConnectionopen = false;
        }
    }
}
