using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Capstone.Services.ShouldntBeHere.DB
{
    public static class DataAccessor
    {
        public static string ConnStr = ConfigurationManager.ConnectionStrings["AssDb"].ConnectionString;

        public static List<T> RunProc<T>(string procName, params SqlParameter[] parameters) where T : new()
        {
            return RunProc<T>(procName, CommandType.StoredProcedure, parameters);
        }
        
        public static List<T> RunProc<T>(string procName, CommandType commandType, params SqlParameter[] parameters) where T : new() 
        {
            var retval = new List<T>();
            
            using (var conn = new SqlConnection(ConnStr))
            {
                conn.Open();
                using (var cmd = new SqlCommand(procName, conn))
                {
                    cmd.CommandType = commandType;

                    foreach (var p in parameters)
                    {
                        cmd.Parameters.Add(p);
                    }

                    using (var rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            var resultRow = new T();

                            foreach (var prop in resultRow.GetType().GetProperties())
                            {
                                if (VerifyField(rdr, prop.Name) && !rdr[prop.Name].Equals(DBNull.Value))
                                {
                                    prop.SetValue(resultRow, rdr[prop.Name], null);
                                }
                            }
                            retval.Add(resultRow);
                        }
                        rdr.Close();
                    }
                }
                conn.Close();
            }
            return retval;
        }

        public static object GetScalar(string procName, params SqlParameter[] parameters)
        {
            return GetScalar(procName, CommandType.StoredProcedure, parameters);
        }

        public static object GetScalar(string procName, CommandType commandType, params SqlParameter[] parameters)
        {
            object retval;
            using (var conn = new SqlConnection(ConnStr))
            {
                conn.Open();
                using (var cmd = new SqlCommand(procName, conn))
                {
                    cmd.CommandType = commandType;

                    foreach (var p in parameters)
                    {
                        cmd.Parameters.Add(p);
                    }

                    retval = cmd.ExecuteScalar();
                }
                conn.Close();
            }
            return retval;
        }

        public static int ExecuteNonQuery(string procName, params SqlParameter[] parameters)
        {
            return ExecuteNonQuery(procName, CommandType.StoredProcedure, parameters);
        }

        public static int ExecuteNonQuery(string procName, CommandType commandType, params SqlParameter[] parameters)
        {
            int retval;
            using (var conn = new SqlConnection(ConnStr))
            {
                conn.Open();
                using (var cmd = new SqlCommand(procName, conn))
                {
                    cmd.CommandType = commandType;

                    foreach (var p in parameters)
                    {
                        cmd.Parameters.Add(p);
                    }

                    retval = cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
            return retval;
        }

        private static bool VerifyField(IDataReader rdr, string field)
        {
            for (int i = 0; i < rdr.FieldCount; i++)
            {
                if (rdr.GetName(i).Equals(field, StringComparison.InvariantCultureIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
