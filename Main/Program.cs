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
            var matrixOperations=new MatrixOperations("www0",",");
            Console.WriteLine("BeforeCreateMatrix");
            var matrix= matrixOperations.GetGeneratedRandomMatrix(10, 10);
            Console.WriteLine("After create matrix");
            //matrixOperations.SaveMatrixToFile(new []{"HelloWorld","1","2344","s"});
            foreach (var VARIABLE in matrix)
            {
                Console.WriteLine(VARIABLE);
            }
            Console.WriteLine(GetStringFromTwoValues("Lebovsky","No Money"));
            Console.ReadKey();
        }

        private static string GetStringFromTwoValues(object ObjectName, object Value)
        {
            return $"{{\"{ObjectName}\": {Value} }}";
        }
        
    }
}