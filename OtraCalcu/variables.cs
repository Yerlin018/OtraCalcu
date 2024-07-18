using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Web;

namespace OtraCalcu
{
    internal class variables
    {
        public static decimal num1=0;
        public static decimal num2 = 0;
        public static decimal resultado = 0;
        public static string  operador = "";
        public static int num = 0;
        public static double numero = 10f;
        public static double numero1 = 10f;

        List<variables> variable = new List<variables>();
        public variables(decimal Num1, decimal Num2, decimal Resultado)
        {
            num1 = Num1;
            num2 = Num2;
            resultado = Resultado;
        }


    }
}
