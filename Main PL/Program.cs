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
            var stringsOne = new[] {"aaa", "bbb", "ccc"}; 
            Console.WriteLine( GetStringFromStringQueue(new Queue<string>(stringsOne)));
            Console.ReadKey(); 
        }

        private static string GetStringFromStringQueue(Queue<string> queue)
        {
            if (queue == null)
                throw new ArgumentNullException(nameof(queue));
  
            if (queue.Count >=1)
                return queue.Dequeue() + " " + GetStringFromStringQueue(queue);
            return "";
        }
    }
}