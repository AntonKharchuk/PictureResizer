using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace PictureResizer
{
    public class ImageResizeSettings
    {
        public InterpolationMode InterpolationMode { get; set; } = InterpolationMode.Default;
        public SmoothingMode SmoothingMode { get; set; } = SmoothingMode.Default;
        public PixelOffsetMode PixelOffsetMode { get; set; } = PixelOffsetMode.Default;
        public CompositingQuality CompositingQuality { get; set; } = CompositingQuality.Default;
        public CompositingMode CompositingMode { get; set; } = CompositingMode.SourceOver;
    }

}
