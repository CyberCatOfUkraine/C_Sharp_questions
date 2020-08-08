using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Main_PL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetStringFromTwoValues("Lebovsky","No Money"));
            Console.ReadKey(); 
        }

        private static string GetStringFromTwoValues(object ObjectName, object Value)
        {
            return $"{{\"{ObjectName}\": {Value} }}";
        }
        
    }
}