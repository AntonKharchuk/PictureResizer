using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureResizer
{
    public interface IImageResizer
    {
        ImageResizeSettings ResizeSettings { get; }

        public void ResizeImage(string imagePath, int targetWidth, int targetHeight, string outputPath);
    }
}
