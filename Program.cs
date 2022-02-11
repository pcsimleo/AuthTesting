using System;

namespace AuthTesting
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static string Something() 
        {
            return "Algo";
        }


        public static bool login(string user, string pass) =>
            user == "Mleon" && pass == "123456" ? true : false;
    }
    //comentario 01
    //comentario 02
}
