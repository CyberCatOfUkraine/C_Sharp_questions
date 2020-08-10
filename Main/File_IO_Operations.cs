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

        public async Task<string> GetFromFile()
        {
            var result="";
            var streamReader =new StreamReader(_path);
            while (!streamReader.EndOfStream)
            {
                result +=await streamReader.ReadLineAsync();
            }
            return result;
        }

        public async Task SetToFile(object data)
        {
            var streamWriter = new StreamWriter(_path);
            await streamWriter.WriteLineAsync(data.ToString());
            streamWriter.Close();
        }
    }
}