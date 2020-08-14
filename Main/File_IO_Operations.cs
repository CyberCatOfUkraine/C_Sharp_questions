using System;
using System.IO;
using System.Threading;

namespace Main
{
    public class File_IO_Operations
    {
        private static string _path;

        public File_IO_Operations(string path)
        {
            _path = path;
        }

        public string[] GetAllLineFromFile()
        {
            var sr = File.OpenText(_path);
            return sr.ReadToEnd().Split("\n");
        }
        
        public void SetToFile(object data)
        {
            var thread=new Thread(() =>
            {
                File.AppendAllText(_path,data.ToString());
            });
        thread.Start();
        while (thread.IsAlive)
        {
            thread.Interrupt();
        }

        }
    }
}