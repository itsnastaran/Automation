using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyProjectt.Utility.Files
{
    public static class SaveFiles
    {
        public static bool SaveFile(string filename, byte[] filedate)
        {
            try
            {
                using (FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write))
                {
                    fs.Write(filedate, 0, filedate.Length);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    
    }
}
