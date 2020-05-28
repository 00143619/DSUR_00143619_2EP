using System;
using System.Collections.Generic;
using System.Data;

namespace DSUR_2EP.Modelo
{
    public class BussinessDAO
    {
        public static List<Business> getLista()
        {
            string sql = "SELECT * FROM BUSINESS";

            DataTable dt = ConexionDB.ExecuteQuery(sql);

            List<Business> lista = new List<Business>();
            foreach (DataRow fila in dt.Rows)
            {
                Business b = new Business();
                b.idBusiness = Convert.ToInt32(fila[0].ToString());
                b.name = fila[1].ToString();
                b.description = fila[2].ToString();
                lista.Add(b);
            }
            return lista;
        }
    }
}