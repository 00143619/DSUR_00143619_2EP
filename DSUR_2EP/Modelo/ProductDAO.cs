using System;
using System.Collections.Generic;
using System.Data;

namespace DSUR_2EP.Modelo
{
    public class ProductDAO
    {
        public static List<Product> getLista(int idBusiness)
        {
            string sql = String.Format(
                "SELECT p.idProduct, p.name FROM PRODUCT p WHERE idBusiness = {0};",
                idBusiness);

            DataTable dt = ConexionDB.ExecuteQuery(sql);

            List<Product> lista = new List<Product>();
            foreach (DataRow fila in dt.Rows)
            {
                Product p = new Product();
                p.idProduct = Convert.ToInt32(fila[0].ToString());
                p.name = fila[1].ToString();
                lista.Add(p);
            }
            return lista;
        }
    }
}