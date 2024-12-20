using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modern_Pharmacy_Managment_System.Database;
namespace Modern_Pharmacy_Managment_System
{
    class Functions
    {
        private SqlConnection Con;
        private SqlCommand Cmd;
        private DataTable dt;
        private SqlDataAdapter sda;
        private string ConStr;

       


        public Functions()
        {
           // ConStr = @"Data Source=DESKTOP-VQFABNK;Initial Catalog=PMS;Integrated Security=True";
            //Con = new SqlConnection(ConStr);
           Con = DatabaseConnection.databaseConnect();
            Cmd = new SqlCommand();
            Cmd.Connection = Con;
            
        }


        public SqlConnection Connection { get; private set; }

        public DataTable GetData(string Query)
        {
            dt = new DataTable();
            sda = new SqlDataAdapter(Query, Con);
            sda.Fill(dt);
            return dt;
        }

        public void CloseConnection()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }

        public int SetData(string Query)
        {
            int Cnt = 0;
            if(Con.State==ConnectionState.Closed)
            {
                Con.Open();

            }
            Cmd.CommandText = Query;
            Cnt = Cmd.ExecuteNonQuery();
            return Cnt;
        }


        public object ExecuteScalar(string query)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand(query, Con);
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Con.Close();
            }
        }
        public int insertData(SqlCommand cmd)
        {
            int rowsAffected = 0;
            try
            {
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }
                cmd.Connection = Con;
                rowsAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
            return rowsAffected;

        }
    }
}
