using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static System.String;

namespace Main
{
    public class MatrixOperations:IMatrixOperations
    {
        private File_IO_Operations _fileIoOperations;
        private static char _symbol;
        private static string _newLine="\n";
        public MatrixOperations(string path,char symbol)
        {
            _fileIoOperations=new File_IO_Operations(path);
            if (symbol=='\n')
            {
                symbol = ',';
            }
            _symbol = symbol;
            
        }
       
        public MatrixOperations(char symbol)
        {
            _fileIoOperations=new File_IO_Operations("path.txt");
            if (symbol=='\n')
            {
                symbol = ',';
            }
            _symbol = symbol;
            
        }
    
        public void SaveMatrixToFile(string[][] matrix)
        {
            var thread=new Thread(() =>
            {
                for (var matrixRowIndex = 0; matrixRowIndex < matrix.Length; matrixRowIndex++)
                {
                    var line = Empty;
                    var matrixColumnsLength = matrix[matrixRowIndex].Length;
                    for (var matrixColumnIndex = 0; matrixColumnIndex < matrixColumnsLength; matrixColumnIndex++)
                    {
                        if (matrixColumnIndex<matrixColumnsLength-1)
                        {
                            line += matrix[matrixRowIndex][matrixColumnIndex]+_symbol;
                        }
                        else
                        {
                            line += matrix[matrixRowIndex][matrixColumnIndex];

                        }
                    }
                    line +=_newLine;
                    _fileIoOperations.SetToFile(line);
                }
                Console.WriteLine("Запис завершено");
            });
             thread.Start();
             while (!thread.IsAlive)
             {
                 thread.Interrupt();
             }
        }

        public string[][] ReadMatrixFromFile()
        {
            var file = _fileIoOperations.GetAllLineFromFile();
            var fileLength = file.Length-1;//Last item is NULL, remove it;
            var fileArray = new string[fileLength][];
            for (var rowsIndex = 0; rowsIndex <fileLength; rowsIndex++)
            {
                var columns = file[rowsIndex].Split(_symbol);
                fileArray[rowsIndex] = columns;
            }
            return fileArray;
        }
        public  string[][] GetRotatedMatrix(string[][] matrix)
        {
            var n = matrix.Length;
            for(int layer=0; layer < n/2; ++layer) {
                int first=layer;  
                int last=n-1-layer; 
                for(int i=first; i<last;++i){
                    int offset=i-first;

                    //save the top left of the matrix 
                    string top = matrix[first][i];
                    //shift left to top; 
                    matrix[first][i]=matrix[last-offset][first];
                    //shift bottom to left 
                    matrix[last-offset][first]=matrix[last][last-offset];
                    //shift right to bottom
                    matrix[last][last-offset]=matrix[i][last];
                    //rightmost top corner
                    matrix[i][last]=top;
                }
            }

            
            return matrix;
        }
        
        public string[][] GetGeneratedRandomMatrix(int columnsValue, int rowsValue)
        {
            var randomExample=new Random();
                var array=new string[rowsValue][];

                    for (var rowIndex = 0; rowIndex < array.Length; rowIndex++)
                    {
                        array[rowIndex]=new string[columnsValue];
                        for (var columnIndex=0;columnIndex<columnsValue;columnIndex++)
                        {
                                 array[rowIndex][columnIndex]= $"{randomExample.Next(100)}";
                        }
                    }
                return array;
        }
        
        
         
    }
}