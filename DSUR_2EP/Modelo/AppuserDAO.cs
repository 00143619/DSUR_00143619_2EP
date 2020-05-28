using System;
using System.Collections.Generic;
using System.Data;

namespace DSUR_2EP.Modelo
{
    public static class AppuserDAO
    {
        public static List<Appuser> getLista()
        {
            string sql = "SELECT * FROM APPUSER";

            DataTable dt = ConexionDB.ExecuteQuery(sql);

            List<Appuser> lista = new List<Appuser>();
            foreach (DataRow fila in dt.Rows)
            {
                Appuser a = new Appuser();
                a.idUser = Convert.ToInt32(fila[0].ToString());
                a.fullname = fila[1].ToString();
                a.username = fila[2].ToString();
                a.password = fila[3].ToString();
                a.userType = Convert.ToBoolean(fila[4].ToString());
                lista.Add(a);
            }
            return lista;
        }
        public static void updatePassword(int idUser, string newPassword)
        {
            string sql = String.Format(
                "UPDATE APPUSER SET password='{0}' where idUser='{1}';",
                newPassword, idUser);
            
            ConexionDB.ExecuteNonQuery(sql);
        }
        
    }
}