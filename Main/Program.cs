using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BeforeCreateMatrix");
           
            var originalSymbol = ",";
            Console.WriteLine("Вас вітає програма для перевернення матриць на 90 градусів (проти годинникової стрілки)\"Задание на дом\" ");
            Console.WriteLine($"Введіть символ для розділення стовпців матриці або залишіть це поле пустим для автоматичного вибору \"{originalSymbol}\" та натисніть Enter");
            var symbol = Console.ReadLine();
            try
            {
                if (symbol.Length==0)
                {
                    symbol = originalSymbol;
                }
            }
            catch (Exception e)
            {
                symbol = originalSymbol;
            }
            Console.WriteLine($"Вибрано \"{symbol}\" символ");


            Console.WriteLine("Для перевернення матриці  введіть адресу вхідного файла що знаходиться в поточному каталозі чи іншого файла з повною його адресою та натисніть Enter\n Файл повинен містити в собі матрицю.");

            var path = /*@"/home/kit/RiderProjects/C_Sharp_questions/Main/bin/Debug/netcoreapp3.1/path (копія).txt";//*/Console.ReadLine();
            var matrixOperations = new MatrixOperations(path,symbol.First());
            var matrix = matrixOperations.ReadMatrixFromFile();
            Console.WriteLine("Для перевернення матриці  введіть адресу вихідного файла що знаходиться в поточному каталозі чи іншого файла з повною його адресою та натисніть Enter");
            var nameOfNewFile = Console.ReadLine();
            matrixOperations=new MatrixOperations(nameOfNewFile,symbol.First());
            matrixOperations.SaveMatrixToFile(matrixOperations.GetRotatedMatrix(matrixOperations.GetRotatedMatrix(matrixOperations.GetRotatedMatrix(matrix))));

        }
    }
}