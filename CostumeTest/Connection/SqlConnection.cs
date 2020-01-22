﻿using System.Data;
using MySql.Data.MySqlClient;


namespace ReservationGuest
{
    public class SqlConnection
    {

        private MySqlConnection _con;
        public MySqlCommand Cmd;
        private MySqlDataAdapter _da;
        private DataTable _dt;


        //Query wordt gemaakt naar command
        public void SqlQuery(string queryText)
        {
            //lokale database
            //_con = new MySqlConnection("Server=localhost;  Database=reservationsystem; username=root; password=");
            //online database
            _con = new MySqlConnection("Server=remotemysql.com; port=3306;  Database=uGoauhO5db; username=uGoauhO5db; password=jqH0eS2CJW");
            _con.Open();
            Cmd = new MySqlCommand(queryText, _con);
        }
        //Query wordt uitgevoerd en krijgt informatie terug
        public DataTable QueryEx()
        {
            _da = new MySqlDataAdapter(Cmd);
            _dt = new DataTable();
            _da.Fill(_dt);

            return _dt;
        }
        //Query wordt uitgevoerd met geen resultaat
        public void NonQueryEx()
        {
            Cmd.ExecuteNonQuery();
        }
    }
}
