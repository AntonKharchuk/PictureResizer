using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureResizer
{
    public class ConsoleResizeDemo
    {
        private IImageResizer _imageResizer;

        public ConsoleResizeDemo(IImageResizer imageResizer)
        {
            _imageResizer = imageResizer;
        }

        public void Run () 
        {
            string originalImagePath;
            int targetWidth;
            int targetHeight;
            string resizedImagePath;

            originalImagePath = GetInputFromUser("originalImagePath: ", Validations.UserImageExists);
            targetWidth = int.Parse(GetInputFromUser("targetWidth: ", Validations.IsSizeCorrect));
            targetHeight = int.Parse(GetInputFromUser("targetHeight: ", Validations.IsSizeCorrect));
            resizedImagePath = GetInputFromUser("resizedImagePath: ", Validations.CanCreateFile);

            _imageResizer.ResizeImage(originalImagePath, targetWidth, targetHeight, resizedImagePath);

            Console.WriteLine("Your image with size {0}x{1} is saved at {2}", targetWidth, targetHeight, resizedImagePath);
        }

        private string GetInputFromUser(string askUserForInput, Func<string,bool> validationOnUserInput) 
        {
            string input;
            do
            {
                Console.Write(askUserForInput);
                input = Console.ReadLine();

                var isCorrectData = validationOnUserInput.Invoke(input);
            } while (!validationOnUserInput.Invoke(input));

            return input;
        }
    }
}
