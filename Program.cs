using System;
using System.Collections.Generic;
using System.Linq;


namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            string nombres = "ave, banco, comida, duda, ejercicio, fuente, girasol";
            //FUENTE;EJERCICIO;DUDA;COMIDA;BANCO

            string[] nombresArray = nombres.Split(", ");

            List<string> nombresList = new List<string>(nombresArray);

            string nombresJoined = String.Join(";", nombresList);

            string mayusculas = nombresJoined.ToUpper();

            string[] nombreA = mayusculas.Split(", ");

            List<string> list = new List<string>(nombreA);            
          
            foreach (string i in list)
            {
                Console.WriteLine(i);
            }

        }
    }
}