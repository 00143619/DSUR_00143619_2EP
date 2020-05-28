using System;

namespace DSUR_2EP.Modelo
{
    public class AppOrder
    {
        public int idOrder { get; set; }
        public string createDate { get; set; }
        public string productname { get; set; } 
        public string fullname { get; set; }

        public AppOrder()
        {
            idOrder = 1;
            createDate = "";
            productname= "";
            fullname = "";
        }
    }
}