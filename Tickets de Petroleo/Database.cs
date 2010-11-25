using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Tickets_de_Petroleo
{
    class Database : IDisposable
    {
        private SqlConnection con;
        private string sql;
        private List<SqlParameter> parameters;
        private CommandType commandType;

        public Database(string sql, CommandType commandType)
        {
            this.sql = sql;
            this.commandType = commandType;
            this.parameters = new List<SqlParameter>();

            this.con = new SqlConnection(Properties.Settings.Default.db);
            con.Open();
        }
        public Database(string sql)
            : this(sql, CommandType.Text)
        { }

        public void addParameter(string name, SqlDbType type, object value)
        {
            SqlParameter param = new SqlParameter(name, type);
            param.Value = value;
            parameters.Add(param);
        }

        public void updateParameter(string name, object value)
        {
            foreach (SqlParameter param in parameters)
            {
                if (param.ParameterName.Equals(name))
                {
                    param.Value = value;
                    break;
                }
            }
        }

        public void execute()
        {
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = commandType;

            foreach (SqlParameter param in parameters)
            {
                cmd.Parameters.Add(param);
            }

            cmd.ExecuteNonQuery();
        }

        public DataTable getData()
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.SelectCommand.CommandType = commandType;

            foreach (SqlParameter param in parameters)
            {
                da.SelectCommand.Parameters.Add(param);
            }

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        #region IDisposable Members

        public void Dispose()
        {
            con.Close();
        }

        #endregion
    }
}
