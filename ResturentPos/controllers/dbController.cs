using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace ResturentPos.controllers
{
    class dbController
    {

        SqlConnection con;
        SqlDataAdapter adp;
        SqlCommand cmd;
        DataTable dt;

        public string conString()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ACER\source\repos\ResturentPos\ResturentPos\resturentPos.mdf;Integrated Security=True";
        }

        public void insert(string querry)
        {
            con = new SqlConnection(conString());
            con.Open();
            cmd = new SqlCommand(querry, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable select(String querry)
        {
                con = new SqlConnection(conString());
                adp = new SqlDataAdapter();
                con.Open();
                dt = new DataTable();
                adp = new SqlDataAdapter(querry, con);
                adp.Fill(dt);
                con.Close();


                return dt;
            
        }

        public Array getUser(String querry)
        {
            con = new SqlConnection(conString());
            adp = new SqlDataAdapter();
            con.Open();
            dt = new DataTable();
            adp = new SqlDataAdapter(querry, con);
            adp.Fill(dt);

            var result = new string[dt.Columns.Count];

            DataRow dr = dt.Rows[0];

            for (var i = 0; i < dr.ItemArray.Length; i++)
            {
                result[i] = dr[i].ToString();
            }

            con.Close();

            return result;
        }

        public void update(string querry)
        {
            con = new SqlConnection(conString());
            con.Open();
            cmd = new SqlCommand(querry, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void delete(string querry)
        {
            con = new SqlConnection(conString());
            cmd = new SqlCommand(querry, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}

