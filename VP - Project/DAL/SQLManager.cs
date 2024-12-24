using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace KhApi.Utilis
{
    public class SQLManager
    {
        private static SQLManager INSTANCE = null;
        public static string HOSTSERVER_NAME = "";
        public static int HOSTSERVER_PORT = 5000;
        public static string SQLSERVER_NAME = ".";
        public static string SQLSERVER_USERNAME = "DESKTOP-DONC46F\baraa";
        public static string SQLSERVER_PASSWORD = "";
        public static string MASTER_DATABASENAME = "master";
        public string DATABASENAME = "VP_Project";
        public static string PATH_LOG = "";
        public static bool EnableLog = true;

        public List<T> ConvertDataTable<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }
        public T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                        if (dr[column.ColumnName] == null || dr[column.ColumnName] == DBNull.Value)
                        {
                            pro.SetValue(obj, null, null);
                        }
                        else
                        {
                            pro.SetValue(obj, dr[column.ColumnName], null);
                        }

                    else
                        continue;
                }
            }
            return obj;
        }

        public static string ConnectionString { set; get; }
        //public RestaurantContext _Context;
        public SQLManager()
        {

        }
        public static SQLManager GetInstance()
        {
            if (INSTANCE == null)
                INSTANCE = new SQLManager();
            return INSTANCE;
        }
        public string GetHostId()
        {
            ConnectionString = @"Server=" + SQLSERVER_NAME + ";Database=master;ConnectRetryCount=0;User ID=" + SQLSERVER_USERNAME + "; password=" + SQLSERVER_PASSWORD + ";";
            SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT HOST_ID()", conn);
                cmd.CommandType = CommandType.Text;
                conn.Open();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt.Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public bool ExecStoredProcedureNonQuery(string databaseName, string storeProcedureName, SqlParameter[] parameters)
        {
            ConnectionString = @"Server=" + SQLSERVER_NAME + ";Database=" + databaseName + ";ConnectRetryCount=0;User ID=" + SQLSERVER_USERNAME + "; password=" + SQLSERVER_PASSWORD + ";";
            SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                SqlCommand cmd = new SqlCommand(storeProcedureName, conn);
                cmd.CommandTimeout = 15 * 60;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(parameters);
                conn.Open();
                return Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable ExecCommand(string databaseName, string queryStr, SqlParameter[] parameters)
        {
            ConnectionString = @"Data Source=.;Initial Catalog=VP_Project;Integrated Security=True";
            SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                SqlCommand cmd = new SqlCommand(queryStr, conn);
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 15 * 60;
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                conn.Open();
                DataTable dt = new DataTable();
                //cmd.CommandTimeout = 480;
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public bool ExecCommandNonQuery(string databaseName, string queryStr, SqlParameter[] parameters)
        {
            ConnectionString = @"Data Source=.;Initial Catalog=VP_Project;Integrated Security=True";
            SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                SqlCommand cmd = new SqlCommand(queryStr, conn);
                cmd.CommandTimeout = 15 * 60;
                cmd.CommandType = CommandType.Text;
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                conn.Open();
                return Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable Login(string databaseName, string userName, string password)
        {
                ConnectionString = @"Data Source=.;Initial Catalog=VP_Project;Integrated Security=True";
                SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                SqlCommand com = new SqlCommand("Stafflogin", conn);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Usename", userName);
                com.Parameters.AddWithValue("@word", password);
                conn.Open();
                SqlDataReader sdr = null;
                sdr = com.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sdr);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }

            
        }
    }
}

