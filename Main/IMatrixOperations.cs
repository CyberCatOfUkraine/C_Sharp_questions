using System.Threading.Tasks;

namespace Main
{
    public interface IMatrixOperations<T>
    {
        Task SaveMatrixToFile(T[][] matix);
        Task<T[][]> ReadMatrixFromFile();
        Task<T[][]> GetRotatedMatrix(T[][] matrix);
    }
}