using System.IO;
using System.Linq;
using Main;
using NUnit.Framework;

namespace Tests
{
    public class File_IO_OperationsUnitTests
    {
        [Test]
        public void FileCreateTest()
        {
            const string path = "createTest.txt";
            var fileOperations = new File_IO_Operations(path);
            fileOperations.SetToFile(123);
            if (File.Exists(path))
            {
                File.Delete(path);
                Assert.Pass();
            }
            File.Delete(path);
            Assert.Fail();
        }

        [Test]
        public void FileReadAndWriteTest()
        {
            const string testValue = "123";
            const string path = "rwTest.txt";
            var fileOperations = new File_IO_Operations(path);
            fileOperations.SetToFile(testValue);
            Assert.AreEqual(testValue,fileOperations.GetAllLineFromFile().Result.First());
            File.Delete(path);
        }
    }
}