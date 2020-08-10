using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrixOperations=new MatrixOperations<int>();
            Console.WriteLine(GetStringFromTwoValues("Lebovsky","No Money"));
            Console.ReadKey(); 
        }

        private static string GetStringFromTwoValues(object ObjectName, object Value)
        {
            return $"{{\"{ObjectName}\": {Value} }}";
        }
        
    }
}