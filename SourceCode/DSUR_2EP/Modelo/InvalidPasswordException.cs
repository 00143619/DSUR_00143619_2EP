using System;

namespace DSUR_2EP.Modelo
{
    public class InvalidPasswordException: Exception
    {
        public InvalidPasswordException() : base("the password is to short!")
        {
        }
    }
}