using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.DAO
{
    public class DataProvider
    {
        public static SqlConnection Connection;

        public void Connect()
        {
            string chuoiKetNoi = @"Data Source = DESKTOP-3PPDG8S; Initial Catalog = QuanLyBanHang; Integrated Security = True";
            if ((Connection == null))
            {
                Connection = new SqlConnection(chuoiKetNoi);

            }
            if ((Connection.State != ConnectionState.Closed))
            {
                Connection.Close();
            }
            Connection.Open();
        }
        public void Disconnect()
        {
            if ((((Connection != null)) & Connection.State == ConnectionState.Open))
            {
                Connection.Close();
            }
        }

        public int ExecuteScalar(string strSql)
        {

                SqlCommand command = Connection.CreateCommand();
                command.CommandText = strSql;
                command.CommandType = CommandType.Text;
                int nRow = int.Parse(command.ExecuteScalar().ToString());
                return nRow;

        }
        public int ExecuteNonQuery(string strSql, CommandType cmdType, params SqlParameter[] parameters)
        {

                SqlCommand command = Connection.CreateCommand();
                command.CommandText = strSql;

                command.CommandType = cmdType;
                if (((parameters != null) & parameters.Length > 0))
                {
                    command.Parameters.AddRange(parameters);
                }

                int nRow = command.ExecuteNonQuery();
                return nRow;

        }

        public SqlDataReader GetReader(string strSql, CommandType cmdType, params SqlParameter[] parameters)
        {

                var command = Connection.CreateCommand();
                command.CommandText = strSql;
                command.CommandType = cmdType;
                if (((parameters != null) & parameters.Length > 0))
                {
                    command.Parameters.AddRange(parameters);
                }
                return command.ExecuteReader();
        }
        public DataTable SL(string strSql, CommandType cmdType, params SqlParameter[] parameters)
        {

                SqlCommand command = Connection.CreateCommand();
                command.CommandText = strSql;
                command.CommandType = cmdType;
                if (((parameters != null) & parameters.Length > 0))
                {
                    command.Parameters.AddRange(parameters);
                }
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
        }
    }

}
