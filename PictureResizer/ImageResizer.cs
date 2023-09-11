using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureResizer
{
    public class ImageResizer: IImageResizer
    {
        public ImageResizeSettings ResizeSettings { get; set; }

        public ImageResizer()
        {
            ResizeSettings = new ImageResizeSettings();
        }
        public ImageResizer(ImageResizeSettings imageResizeSettings)
        {
            ResizeSettings = imageResizeSettings;
        }

        public void ResizeImage(string imagePath, int targetWidth, int targetHeight, string outputPath)
        {
            // Load the original image
            Image originalImage = Image.FromFile(imagePath);

            // Create a new Bitmap with the desired size for resizing
            Bitmap resizedImage = new Bitmap(targetWidth, targetHeight);

            // Create a Graphics object from the resized image
            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                // Configure the Graphics object using the provided settings
                graphics.InterpolationMode = ResizeSettings.InterpolationMode;
                graphics.SmoothingMode = ResizeSettings.SmoothingMode;
                graphics.PixelOffsetMode = ResizeSettings.PixelOffsetMode;
                graphics.CompositingQuality = ResizeSettings.CompositingQuality;
                graphics.CompositingMode = ResizeSettings.CompositingMode;


                // Resize the original image to fit the new dimensions
                graphics.DrawImage(originalImage, 0, 0, targetWidth, targetHeight);
            }
            switch (outputPath)
            {
                case string d when d.EndsWith("png"):
                    resizedImage.Save(outputPath, System.Drawing.Imaging.ImageFormat.Png);
                    break;
                case string d when d.EndsWith("bmp"):
                    resizedImage.Save(outputPath, System.Drawing.Imaging.ImageFormat.Bmp);
                    break;
                case string d when d.EndsWith("icon"):
                    resizedImage.Save(outputPath, System.Drawing.Imaging.ImageFormat.Icon);
                    break;

                default:
                    resizedImage.Save(outputPath, System.Drawing.Imaging.ImageFormat.Jpeg);
                    break;
            }
        }
    }
}
