using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace TicketBook.DAO
{
    class BaseDAO
    {
        public static SqlConnection conn;
        //下面填入SQLSERVER相关信息
        public static string connstr = @"Data Source=127.0.0.1;Initial Catalog=TicketBook;User ID=sa;Password=test123456.;Encrypt=False";

        //连接数据库
        public static SqlConnection getconn()
        {
            conn = new SqlConnection(connstr);
            conn.Open();
            return conn;
        }

        public void con_open()
        {
            getconn();
        }

        //关闭数据库连接
        public void conn_close()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
                conn.Dispose();
            }
        }

        //读取数据库
        public SqlDataReader getsdr(string sqlstr)
        {
            getconn();
            SqlCommand comm = conn.CreateCommand();
            comm.CommandText = sqlstr;
            SqlDataReader My_Reader = comm.ExecuteReader();
            return My_Reader;
        }

        //执行SQL操作
        public void dosqlcom(string sqlstr)
        {
            getconn();
            SqlCommand sqlcom = new SqlCommand(sqlstr, conn);
            sqlcom.ExecuteNonQuery();
            sqlcom.Dispose();
            conn_close();
        }

        //查询数据返回给DataSet
        public DataSet getDs(string sqlstr, string tableName)
        {
            getconn();
            SqlDataAdapter sqlda = new SqlDataAdapter(sqlstr, conn);
            DataSet My_DataSet = new DataSet();
            sqlda.Fill(My_DataSet, tableName);
            conn_close();
            return My_DataSet;
        }
    }
}
