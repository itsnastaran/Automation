using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectt.Utility.Convert
{
    public class FilesRead
    {
        public static byte[] GetReadFiles(out int Filesize, out string Filename, string Filenames)
        {
            using (FileStream Fs = new FileStream(Filenames, FileMode.Open, FileAccess.Read))
            {
                byte[] b = new byte[Fs.Length];
                Filename = Path.GetFileName(Filenames);
                Filesize = b.Length / 1024;
                Fs.Read(b, 0, b.Length);
                return b;
            }
        }
        public static byte[] GetReadFiles(string Filenames)
        {
            using (FileStream Fs = new FileStream(Filenames, FileMode.Open, FileAccess.Read))
            {
                byte[] b = new byte[Fs.Length];
                Fs.Read(b, 0, b.Length);
                return b;
            }
        }
    
    }
}
