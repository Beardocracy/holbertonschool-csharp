using System;
using System.Drawing;
using System.IO;
using System.Threading;

/// <summary>
/// Contains the Inverse function
/// </summary>
class ImageProcessor
{
    /// <summary>
    /// Calls inversehelper in threads.
    /// </summary>
    public static void Inverse(string[] filenames)
    {
        foreach(string name in filenames)
        {
            Thread t = new Thread (()=>InverseHelper(name));
            t.Start();
        }
    }

    /// <summary>
    /// Creates and saves an inverse copy of an image.
    /// </summary>
    private static void InverseHelper(string name)
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

    /// <summary>
    /// Sends filenames to Grayscale helper in threads.
    /// </summary>
    public static void Grayscale(string[] filenames)
    {
        foreach(string name in filenames)
        {
            Thread t = new Thread (()=>GrayscaleHelper(name));
            t.Start();
        }
    }

    /// <summary>
    /// Copies and saves an image in grayscale.
    /// </summary>
    private static void GrayscaleHelper(string name)
    {
        string file = Path.GetFileNameWithoutExtension(name);
        string extension = Path.GetExtension(name);
        
        Bitmap image1 = new Bitmap(name);

        for (int i = 0; i < image1.Height; i++)
        {
            for (int j = 0; j < image1.Width; j++)
            {
                Color pixel = image1.GetPixel(j, i);
                int gray = pixel.R + pixel.G + pixel.B;
                gray = gray / 3;
                image1.SetPixel(j, i, Color.FromArgb(gray, gray, gray));
            }
        }
        image1.Save($"{file}_grayscale{extension}");
    }
}