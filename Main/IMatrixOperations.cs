using System;
using System.Threading.Tasks;

namespace Main
{
    public interface IMatrixOperations
    {
        void SaveMatrixToFile(string[][] matrix);
        string[][] ReadMatrixFromFile();
        string[][] GetRotatedMatrix(string[][] matrix);
        string[][] GetGeneratedRandomMatrix(int columnsValue, int rowsValue);
    }
}