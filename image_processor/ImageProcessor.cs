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
        
        using (Bitmap image1 = new Bitmap(name))
        {
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
        
        using (Bitmap image1 = new Bitmap(name))
        {
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

    /// <summary>
    /// Sends filenames to bw helper in threads.
    /// </summary>
    public static void BlackWhite(string[] filenames, double threshold)
    {
        foreach(string name in filenames)
        {
            Thread t = new Thread (()=>BlackWhiteHelper(name, threshold));
            t.Start();
        }
    }

    /// <summary>
    /// Copies and saves an image in bw.
    /// </summary>
    private static void BlackWhiteHelper(string name, double threshold)
    {
        string file = Path.GetFileNameWithoutExtension(name);
        string extension = Path.GetExtension(name);
        
        using (Bitmap image1 = new Bitmap(name))
        {
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
/*
    /// <summary>
    /// Sends filenames and height to helper function in threads.
    /// </summary>
    public static void Thumbnail(string[] filenames, int height)
    {
        foreach(string name in filenames)
        {
            Bitmap image1 = new Bitmap(name);
            string file = Path.GetFileNameWithoutExtension(name);
            string extension = Path.GetExtension(name);
            int width = height * image1.Width / image1.Height;
            Thread t = new Thread (()=>ImageResizer(image1, height, width, file, extension));
            t.Start();
        }
    }

        /// <summary>
        /// Resizes an image to the specified height and width. Saves it.
        /// </summary>
        public static void ImageResizer(Image image, int height, int width, string file, string extension)
    {
        var destRect = new Rectangle(0, 0, width, height);
        var destImage = new Bitmap(width, height);

        destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

        using (var graphics = Graphics.FromImage(destImage))
        {
            graphics.CompositingMode = CompositingMode.SourceCopy;
            graphics.CompositingQuality = CompositingQuality.HighQuality;
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

            using (var wrapMode = new ImageAttributes())
            {
                wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                graphics.DrawImage(image, destRect, 0, 0, image.Width,image.Height, GraphicsUnit.Pixel, wrapMode);
            }
        }

        destImage.Save($"{file}_th{extension}");
    }
    */
}