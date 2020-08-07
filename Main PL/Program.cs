using System;
using System.Linq;
using System.Text;

namespace Main_PL
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello World!");*/
            var stringsOne = new[] {"aaa", "bbb", "ccc"}; 
            /*var sb = new StringBuilder(); 
            foreach (var s in stringsOne) 
            { 
                sb.Append(s + " "); 
            } 
            var concat = sb.ToString(); 
 
            Console.WriteLine(concat.Substring(0,concat.Length-1)); */
            var s = stringsOne.ToString();
            /*foreach (var str in stringsOne)
            {
                s +=str +" ";
            }*/
            Console.WriteLine( s.ToList());
            Console.ReadKey(); 
        }

        private static string GetStringFromStringArray(string[] array)
        {
            return "Get me by recursion";
        }
    }
}