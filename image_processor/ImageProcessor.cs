using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;

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
        Parallel.ForEach(filenames, name =>
        {
            using (Bitmap image1 = new Bitmap(name))
            {
                string file = Path.GetFileNameWithoutExtension(name);
                string extension = Path.GetExtension(name);
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
        );
    }

    /// <summary>
    /// Sends filenames to Grayscale helper in threads.
    /// </summary>
    public static void Grayscale(string[] filenames)
    {
        Parallel.ForEach(filenames, name =>
        {
            //GrayscaleHelper(name);
            using (Bitmap image1 = new Bitmap(name))
            {
                string file = Path.GetFileNameWithoutExtension(name);
                string extension = Path.GetExtension(name);

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
        );
    }

    /// <summary>
    /// Sends filenames to bw helper in threads.
    /// </summary>
    public static void BlackWhite(string[] filenames, double threshold)
    {
        Parallel.ForEach(filenames, name =>
        {
            using (Bitmap image1 = new Bitmap(name))
            {
                string file = Path.GetFileNameWithoutExtension(name);
                string extension = Path.GetExtension(name);
                
                for (int i = 0; i < image1.Height; i++)
                {
                    for (int j = 0; j < image1.Width; j++)
                    {
                        Color pixel = image1.GetPixel(j, i);
                        
                        double sum = pixel.R + pixel.G + pixel.B;
                        int bw = 0;
                        if (sum >= threshold)
                        {
                            bw = 255;
                        }
                        image1.SetPixel(j, i, Color.FromArgb(bw, bw, bw));
                    }
                }
                image1.Save($"{file}_bw{extension}");
            }
        }
        );
    }
    /// <summary>
    /// Sends filenames and height to helper function in threads.
    /// </summary>
    public static void Thumbnail(string[] filenames, int height)
    {
        Parallel.ForEach(filenames, name =>
        {
            using (Bitmap image1 = new Bitmap(name))
            {
                string file = Path.GetFileNameWithoutExtension(name);
                string extension = Path.GetExtension(name);
                int width = height * image1.Width / image1.Height;
                
                Image thumbnail = image1.GetThumbnailImage(width, height, null, IntPtr.Zero);
                
                thumbnail.Save($"{file}_th{extension}");
            }
        }
        );
    }
}