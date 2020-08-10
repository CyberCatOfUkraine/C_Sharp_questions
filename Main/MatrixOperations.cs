using System.Threading.Tasks;

namespace Main
{
    public class MatrixOperations<T>:IMatrixOperations<T>
    {
        public Task SaveMatrixToFile(T[][] matix)
        {
            throw new System.NotImplementedException();
        }

        public Task<T[][]> ReadMatrixFromFile()
        {
            throw new System.NotImplementedException();
        }

        public Task<T[][]> GetRotatedMatrix(T[][] matrix)
        {
            throw new System.NotImplementedException();
        }
    }
}