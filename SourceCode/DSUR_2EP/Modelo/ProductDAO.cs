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
                p.idBusiness = idBusiness;
                lista.Add(p);
            }
            return lista;
        }
        public static void CreateProduct(int idBusiness, string name)
        {
            string sql = String.Format("INSERT INTO PRODUCT(idBusiness, name) " +
                                       "VALUES({0}, '{1}');", idBusiness, name);
            ConexionDB.ExecuteNonQuery(sql);
        }
        public static void delateproduct(int idProduct)
        {
            string sql = String.Format(
                "DELETE FROM PRODUCT WHERE idProduct ={0};",
                idProduct);
            
            ConexionDB.ExecuteNonQuery(sql);
        }
    }
}