using System;
using System.Drawing;
using System.IO;

/// <summary>
/// Contains the Inverse function
/// </summary>
class ImageProcessor
{
    /// <summary>
    /// Creates and saves a inverse copy of an image
    /// </summary>
    public static void Inverse(string[] filenames)
    {
        foreach(string name in filenames)
        {
            string file = Path.GetFileNameWithoutExtension(name);
            string extension = Path.GetExtension(name);

            Bitmap image1 = new Bitmap(name);

            for (int i = 0; i < image1.Height; i++)
            {
                for (int j = 0; j < image1.Width; j++)
                {
                    Color original = image1.GetPixel(j, i);
                    image1.SetPixel(j, i, Color.FromArgb(255 - original.R, 255 - original.G, 255 - original.B));

                }
            }
            image1.Save($"{file}_inverse{extension}");
        }
    }
}