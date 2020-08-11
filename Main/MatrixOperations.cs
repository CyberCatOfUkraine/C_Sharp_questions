using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Main
{
    public class MatrixOperations:IMatrixOperations
    {
        private File_IO_Operations _fileIoOperations;
        private static string _symbol;
        private static string _newLine="\n";
        public MatrixOperations(string path,string symbol)
        {
            _fileIoOperations=new File_IO_Operations(path);
            if (symbol=="\n")
            {
                symbol = ",";
            }
            _symbol = symbol;
            
        }
        public MatrixOperations(string symbol)
        {
            _fileIoOperations=null;
            if (symbol=="\n")
            {
                symbol = ",";
            }
            _symbol = symbol;
            
        }
        public  void SaveMatrixToFile(string[] matrix)
        {
            var thread=new Thread((() =>
            {
                for (var matrixRowIndex = 0; matrixRowIndex < matrix.Length; matrixRowIndex++)
                {
                    var line = matrix[matrixRowIndex]+_newLine;
                    _fileIoOperations.SetToFile(line);
                }
            }));
             thread.Start();
        }

        public async Task<string[]> ReadMatrixFromFile()
        {
            return await _fileIoOperations.GetAllLineFromFile();
        }
        public async Task<string[]> GetRotatedMatrix(string[] matrix)
        {
            var temporaryItem="";
            //
            return matrix;
        }

        public string[] GetGeneratedRandomMatrix(int columnsValue, int rowsValue)
        {
            var randomExample=new Random();
                var array=new string[rowsValue];

                    for (var rowIndex = 0; rowIndex < array.Length; rowIndex++)
                    {
                        for (var columnIndex=0;columnIndex<columnsValue;columnIndex++)
                        {
                            if (columnIndex==columnsValue-1)
                            {
                                array[rowIndex] += $"{randomExample.Next()}";
                            }
                            else
                            {
                                array[rowIndex] += $"{randomExample.Next()}{_symbol}";
                            }
                        }
                    }
                return array;
        }
        
        
         
    }
}