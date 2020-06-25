using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace QLSVsw
{
    public class Database
    {
        private string connectionString = @"Data Source= localhost\SQLEXPRESS; Initial Catalog= QuanliSinhVien;Integrated Security=SSPI";

        private SqlConnection conn;
       // private string sql;
        private DataTable dt;
        private SqlCommand cmd;


        public Database()
        {
            try {
                conn = new SqlConnection(connectionString);
                conn.Open();
              //  MessageBox.Show("Done!!!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Connection Fail: " + ex.Message);
            }
          

        }


        public DataTable XoaSV(string sql)
        {
            try
            {

                if (conn.State == ConnectionState.Open)
                    conn.Close();


                conn.Open();
                // sql = "exec SelectAllSinhVien";
                cmd = new SqlCommand(sql, conn);
                //cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());


                //    MessageBox.Show("delete");
                return dt;
            }
            catch (Exception ex)

            {
                MessageBox.Show("Delete Error: " + ex.Message);
                return null;
            }

            finally
            {
                conn.Close();

            }

        }


        public DataTable SelectData(string sql, List<CustomParameter> lstPara)
        {
            try
            {

                if (conn.State == ConnectionState.Open)
                    conn.Close();


                conn.Open();
               // sql = "exec SelectAllSinhVien";
                cmd = new SqlCommand(sql, conn);
                //cmd.CommandText = sql;
                cmd.CommandType = CommandType.StoredProcedure;
                foreach(var para in lstPara)
                {
                    cmd.Parameters.AddWithValue(para.key, para.value);
                }

                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch(Exception ex)

            {
                MessageBox.Show("Load Error: "+ ex.Message);
                return null;
            }

            finally
            {
                conn.Close();

            }

        }




        public DataRow Select(string sql)
        {
            try {

                if (conn.State == ConnectionState.Open)
                    conn.Close();


                conn.Open();
                cmd = new SqlCommand(sql, conn);

               // cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("#tukhoa", tukhoa);

                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt.Rows[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show("Load Error: " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close()
;
            }
        }



        public int ExCute(string sql, List<CustomParameter> lstPara)
        {
            try
            {


                if (conn.State == ConnectionState.Open)
                    conn.Close();


                conn.Open();
                cmd = new SqlCommand(sql, conn);

                cmd.CommandType = CommandType.StoredProcedure;
                foreach ( var p in lstPara)
                { cmd.Parameters.AddWithValue(p.key, p.value); }


                var rs = cmd.ExecuteNonQuery();
                return (int)rs;

                // return (int)cmd.ExecuteScalar();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Commands Error: " + ex.Message);
                return -100;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
