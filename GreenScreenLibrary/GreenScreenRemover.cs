using System;
using System.Drawing;

namespace GreenScreenLibrary
{
    public class GreenScreenRemover
    {
        public static Bitmap RemoveGreenScreen(Bitmap image, int tolerance = 50)
        {
            if (image == null) throw new ArgumentNullException(nameof(image));

            Bitmap result = new Bitmap(image.Width, image.Height);
            Color green = Color.FromArgb(0, 255, 0); // Zielony kolor

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixelColor = image.GetPixel(x, y);

                    if (Math.Abs(pixelColor.G - green.G) < tolerance)
                    {
                        result.SetPixel(x, y, Color.Transparent);
                    }
                    else
                    {
                        result.SetPixel(x, y, pixelColor);
                    }
                }
            }

            return result;
        }
    }
}
