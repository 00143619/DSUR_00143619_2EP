using System;
using System.Collections.Generic;
using System.Data;

namespace DSUR_2EP.Modelo
{
    public static class Address_DAO
    {
        public static List<Address> getListaforUser(int idUser)
        {
            string sql = String.Format(
                "SELECT ad.idAddress, ad.address FROM ADDRESS ad WHERE idUser = {0};",
                idUser);
            DataTable dt = ConexionDB.ExecuteQuery(sql);

            List<Address> lista = new List<Address>();
            foreach (DataRow fila in dt.Rows)
            {
                Address a = new Address();
                a.idAddress = Convert.ToInt32(fila[0].ToString());
                a.address = fila[1].ToString();
                lista.Add(a);
            }

            return lista;
        }

        public static void addAdress(int idUser, string Address)
        {
            string sql = String.Format(
                "INSERT INTO ADDRESS( idUser, address) " +
                "VALUES ({0}, '{1}');", idUser, Address);
            ConexionDB.ExecuteNonQuery(sql);
        }

        public static void updateAddress(int idAddress, string address)
        {
            string sql = String.Format(
                "UPDATE ADDRESS SET address='{1}' where idAddress={0};",
                idAddress, address);

            ConexionDB.ExecuteNonQuery(sql);
        }

        public static DataTable addressUser(int idUser)
        {
            string sql = String.Format(
                "SELECT ad.idAddress, ad.address FROM ADDRESS ad WHERE idUser = {0};",
                idUser);
            DataTable dt = ConexionDB.ExecuteQuery(sql);
            return dt;
        }
        public static void delateAddress(int idAddress)
        {
            string sql = String.Format(
                "DELETE FROM ADDRESS WHERE idAddress ={0};",
                idAddress);
            
            ConexionDB.ExecuteNonQuery(sql);
        }
    }
}
