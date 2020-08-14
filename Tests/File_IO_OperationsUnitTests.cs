using System.IO;
using System.Linq;
using Main;
using NUnit.Framework;

namespace Tests
{
    public class File_IO_OperationsUnitTests
    {
        const string Path = "IOTests.txt";
        private const string Text = "123";

        public File_IO_OperationsUnitTests()
        {
            if (File.Exists(Path))
            {
                File.Delete(Path);
            }
        }
        [Test]
        public void FileWriteTest()
        {
            var fileOperations = new File_IO_Operations(Path);
            fileOperations.SetToFile(Text);
            Assert.AreEqual(File.Exists(Path),true);
          
        }

        [Test]
        public void FileReadTest()
        {
            var fileOperations = new File_IO_Operations(Path);
            if (File.Exists(Path))
            {
                File.Delete(Path);
            }
            fileOperations.SetToFile(Text);
            var testItem = fileOperations.GetAllLineFromFile().First();
            Assert.AreEqual(Text,testItem);
        }

        ~File_IO_OperationsUnitTests()
        {
            if (File.Exists(Path))
            {
                File.Delete(Path);
            }
        }
    }
}