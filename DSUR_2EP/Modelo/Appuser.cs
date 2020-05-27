namespace DSUR_2EP.Modelo
{
    public class Appuser
    {
        public int idUser { get; set; }
        public string fullname { get; set; }
        public string username { get; set; } 
        public string password { get; set; }
        public bool userType { get; set; }
        
        public Appuser()
        {
            idUser = 1;
            fullname = "";
            username = "";
            password = "";
            userType = true;
        }
    }
}