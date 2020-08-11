using System;
using System.Threading.Tasks;

namespace Main
{
    public interface IMatrixOperations
    {
        void SaveMatrixToFile(string[] matrix);
        Task<string[]> ReadMatrixFromFile();
        Task<string[]> GetRotatedMatrix(string[] matrix);
        string[] GetGeneratedRandomMatrix(int columnsValue, int rowsValue);
    }
}