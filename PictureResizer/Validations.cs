using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureResizer
{
    public class Validations
    {
        public static bool UserImageExists(string path) => new FileInfo(path).Exists;


        public static bool CanCreateFile(string path)
        {
            try
            {
                using (File.Create(path)) { }
                File.Delete(path);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsSizeCorrect(string sizeInput)
        {
            int sizeValue;

            if (!int.TryParse(sizeInput, out sizeValue))
                return false;
            return sizeValue > 0;
        }
    }
}
