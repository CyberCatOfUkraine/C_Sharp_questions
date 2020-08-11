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
            var matrixOperations = new MatrixOperations(path, ",");
            var text = new[] {"Hello", "World!"};
            matrixOperations.SaveMatrixToFile(text);
            var matrix = matrixOperations.ReadMatrixFromFile().Result;
            File.Delete(path);
            Assert.AreEqual("HelloWorld!", matrix[0] + matrix[1]);
        }

        [Test]
        public void GenerateMatrixTest()
        {
            var matrixOperations = new MatrixOperations(",");
            var matrix = matrixOperations.GetGeneratedRandomMatrix(10, 10);
            Assert.AreEqual(matrix.Length, 10);
        }

        [Test]
        public void RotateMatrixTest()
        {
            var symbol = ",";
            var matrixOperations = new MatrixOperations(symbol);
            var matrix = matrixOperations.GetGeneratedRandomMatrix(10, 10);
            
            var firstTheoreticRotatedColumnItem= matrix[0].Split(symbol).Last();
            var lastTheoreticRotatedRowItem = matrix[0].Split(symbol).First();
            
            var rotatedMatrix = matrixOperations.GetRotatedMatrix(matrix).Result;
            
            var firstRotatedColumnItem = rotatedMatrix[0].Split(symbol).First();
            var lastRotatedColumnItem = rotatedMatrix.Last().Split(symbol).First();
            
            Assert.AreEqual(firstTheoreticRotatedColumnItem,firstRotatedColumnItem);
            Assert.AreEqual(lastTheoreticRotatedRowItem,lastRotatedColumnItem);
        }
    }
}