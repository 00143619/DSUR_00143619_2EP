using System;
using System.Collections.Generic;
using System.Data;

namespace DSUR_2EP.Modelo
{
    public class AppOrderDAO
    {
        public static void Order(int idProduct, int idAddress)
        {
            string sql = String.Format(
                "INSERT INTO APPORDER(createDate, idProduct, idAddress) VALUES ('{0}', {1}, {2});", 
                DateTime.Now.ToString("yyyy-MM-dd"), idProduct, idAddress);
            ConexionDB.ExecuteNonQuery(sql);
        }
        public static DataTable orderuser(int idUser)
        {
            string sql =String.Format("SELECT ao.idOrder, ao.createDate, pr.name, au.fullname, "+
                                      "ad.address FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au "+
                                      "WHERE ao.idProduct = pr.idProduct AND ao.idAddress = ad.idAddress "+
                                      "AND ad.idUser = au.idUser AND au.idUser = {0};", idUser);
            DataTable dt = ConexionDB.ExecuteQuery(sql);
            return dt;
        }
        public static List<AppOrder> getListaforUser(int idUser)
        {
            string sql =String.Format("SELECT ao.idOrder, ao.createDate, pr.name, au.fullname, "+
                                                   "ad.address FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au "+
                                                   "WHERE ao.idProduct = pr.idProduct AND ao.idAddress = ad.idAddress "+
                                                   "AND ad.idUser = au.idUser AND au.idUser = {0};", idUser);
            DataTable dt = ConexionDB.ExecuteQuery(sql);

            List<AppOrder> lista = new List<AppOrder>();
            foreach (DataRow fila in dt.Rows)
            {
                AppOrder a =new AppOrder();
                a.idOrder = Convert.ToInt32(fila[0].ToString());
                a.createDate = fila[1].ToString();
                a.productname = fila[2].ToString();
                a.fullname = fila[2].ToString();
                lista.Add(a);
            }

            return lista;
        }
        public static void delateOrder(int idOrder)
        {
            string sql = String.Format(
                "DELETE FROM APPORDER WHERE idOrder ={0};",
                idOrder);
            
            ConexionDB.ExecuteNonQuery(sql);
        }
    }
}