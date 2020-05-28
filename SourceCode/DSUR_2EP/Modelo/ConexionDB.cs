using System.Data;
using Npgsql;

namespace DSUR_2EP.Modelo
{
    public class ConexionDB
    {
        private static readonly string host = "127.0.0.1";

        private static readonly string database = "2EP Data Base";

        private static readonly string userId = "postgres";

        private static readonly string password = "diana";

        private static readonly string sConnection =
            $"Host={host};Port=5432;User Id={userId};Password={password};Database={database};";

        //realizar consulta
        public static DataTable ExecuteQuery(string query)
        {
            NpgsqlConnection connection = new NpgsqlConnection(sConnection);
            DataSet ds = new DataSet();

            connection.Open();

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
            da.Fill(ds);

            connection.Close();
            return ds.Tables[0];
        }
        // realizar accion 
        public static void ExecuteNonQuery(string act)
        { 
            NpgsqlConnection conn = new NpgsqlConnection(sConnection);
            conn.Open();

            NpgsqlCommand nc = new NpgsqlCommand(act, conn);
            nc.ExecuteNonQuery();
            conn.Close();
        }
    }
}