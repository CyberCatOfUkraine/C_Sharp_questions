using System;
using System.IO;
using System.Threading.Tasks;

namespace Main
{
    public class File_IO_Operations
    {
        private static string _path;
        public File_IO_Operations(string path)
        {
            _path = path;
        }

        public async Task<string[]> GetAllLineFromFile()
        {
            return await File.ReadAllLinesAsync(_path);;
        }
        
        public async Task SetToFile(object data)
        {
            await File.AppendAllTextAsync(_path,data.ToString());
        }
    }
}