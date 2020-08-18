using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

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
            Bitmap image1 = new Bitmap(name);

            Rectangle rect = new Rectangle(0, 0, image1.Width, image1.Height);
            BitmapData imgData = image1.LockBits(rect, ImageLockMode.ReadWrite, image1.PixelFormat);

            IntPtr ptr = imgData.Scan0;

            int bytes = Math.Abs(imgData.Stride) * image1.Height;
            byte[] rgbValues = new byte[bytes];

            Marshal.Copy(ptr, rgbValues, 0, bytes);

            for (int i = 0; i < rgbValues.Length; i++)
            {
                rgbValues[i] = (byte)(255 - rgbValues[i]);
            }

            Marshal.Copy(rgbValues, 0, ptr, bytes);

            image1.UnlockBits(imgData);

            string file = Path.GetFileNameWithoutExtension(name);
            string extension = Path.GetExtension(name);
            image1.Save($"{file}_inverse{extension}");
        }
        );
    }
    
        
    /// <summary>
    /// Copies and saves an image in grayscale.
    /// </summary>
    public static void Grayscale(string[] filenames)
    {
        int gray;

        Parallel.ForEach(filenames, name =>
        {
            Bitmap image1 = new Bitmap(name);

            Rectangle rect = new Rectangle(0, 0, image1.Width, image1.Height);
            BitmapData imgData = image1.LockBits(rect, ImageLockMode.ReadWrite, image1.PixelFormat);

            IntPtr ptr = imgData.Scan0;

            int bytes = Math.Abs(imgData.Stride) * image1.Height;
            byte[] rgbValues = new byte[bytes];

            Marshal.Copy(ptr, rgbValues, 0, bytes);

            for (int i = 0; i < rgbValues.Length; i = i + 3)
            {
                gray = rgbValues[i] + rgbValues[i + 1] + rgbValues[i + 2];
                gray = gray / 3;
                
                rgbValues[i] = (byte)gray;
                rgbValues[i + 1] = (byte)gray;
                rgbValues[i + 2] = (byte)gray;
            }

            Marshal.Copy(rgbValues, 0, ptr, bytes);

            image1.UnlockBits(imgData);

            string file = Path.GetFileNameWithoutExtension(name);
            string extension = Path.GetExtension(name);
            image1.Save($"{file}_grayscale{extension}");
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
            int bw;
            double sum;
            Bitmap image1 = new Bitmap(name);

            Rectangle rect = new Rectangle(0, 0, image1.Width, image1.Height);
            BitmapData imgData = image1.LockBits(rect, ImageLockMode.ReadWrite, image1.PixelFormat);

            IntPtr ptr = imgData.Scan0;

            int bytes = Math.Abs(imgData.Stride) * image1.Height;
            byte[] rgbValues = new byte[bytes];

            Marshal.Copy(ptr, rgbValues, 0, bytes);

            for (int i = 0; i < rgbValues.Length; i += 3)
            {
                sum = rgbValues[i] + rgbValues[i + 1] + rgbValues[i + 2];
                bw = 0;
                if (sum >= threshold)
                    bw = 255;
                rgbValues[i] = (byte)bw;
                rgbValues[i + 1] = (byte)bw;
                rgbValues[i + 2] = (byte)bw;
                
            }

            Marshal.Copy(rgbValues, 0, ptr, bytes);

            image1.UnlockBits(imgData);

            string file = Path.GetFileNameWithoutExtension(name);
            string extension = Path.GetExtension(name);
            image1.Save($"{file}_bw{extension}");
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