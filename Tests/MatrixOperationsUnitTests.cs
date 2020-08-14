using System.IO;
using System.Linq;
using Main;
using NUnit.Framework;

namespace Tests
{
    public class MatrixOperationsUnitTests
    {
        [Test]
        public void NUnitTest()
        {
            Assert.Pass();
        }

        [Test]
        public void ReadWriteTest()
        {
            var path = "ReadWriteTest.txt";
            var matrixOperations = new MatrixOperations(path, ',');
            var text = new[] {new[] {"Hello", "World!"}};
            matrixOperations.SaveMatrixToFile(text);
            var matrix = matrixOperations.ReadMatrixFromFile();
            var testPhrase = matrix.First().First() + matrix.First().Last();
            Assert.AreEqual("HelloWorld!", testPhrase);
            File.Delete(path);
        }

        [Test] 
        public void GenerateMatrixTest()
        {
            var matrixOperations = new MatrixOperations(',');
            var matrix = matrixOperations.GetGeneratedRandomMatrix(10, 10);
            Assert.AreEqual(matrix.Length, 10);
        }

        [Test]
        public void RotateMatrixTest()
        {
            var symbol = ',';
            var matrixOperations = new MatrixOperations(symbol);
            var matrix = new[]
            {
                 new[] {"25","38","12"}
                ,new[]{"1","7","76"}
                ,new[]{"21","64","54"}
            };
            var matrix90 = matrixOperations.GetRotatedMatrix(matrix);
            var matrix180 = matrixOperations.GetRotatedMatrix(matrix90);
            var rotatedMatrix = matrixOperations.GetRotatedMatrix(matrix180);
            var expextedMatrix= new[]
            {
                new[] {"12","76","54"}
                ,new[]{"38","7","64"}
                ,new[]{"25","1","21"}
            };
            
            
            Assert.AreEqual(rotatedMatrix,expextedMatrix);
        }
    }
}