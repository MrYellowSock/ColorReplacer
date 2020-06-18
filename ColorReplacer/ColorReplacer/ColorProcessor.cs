using System;
using System.Drawing;
using System.Drawing.Imaging;
namespace ColorReplacer
{
    class PicProcessor
    {
        public struct RangeChecker
        {
            byte a1 ;
            byte r1 ;
            byte g1;
            byte b1 ;


            byte a2 ;
            byte r2 ;
            byte g2 ;
            byte b2;
            public RangeChecker(Color main, byte r_alp, byte r_red, byte r_green, byte r_blue)
            {
                 a1 = (byte)((main.A - r_alp < 0) ? 0 : (main.A - r_alp));
                 r1 = (byte)((main.R - r_red < 0) ? 0 : (main.R - r_red));
                g1 = (byte)((main.G - r_green < 0) ? 0 : (main.G - r_green));
                 b1 = (byte)((main.B - r_blue < 0) ? 0 : (main.B - r_blue));


                 a2 = (byte)((main.A + r_alp > 255) ? 255 : (main.A + r_alp));
                 r2 = (byte)((main.R + r_red > 255) ? 255 : (main.R + r_red));
                 g2 = (byte)((main.G + r_green > 255) ? 255 : (main.G + r_green));
                 b2 = (byte)((main.B + r_blue > 255) ? 255 : (main.B + r_blue));
            }

            public bool IsColInrange (Color targ)
            {
                if ((a1 <= targ.A) && (targ.A <= a2))
                {
                    if ((r1 <= targ.R) && (targ.R <= r2))
                    {
                        if ((g1 <= targ.G) && (targ.G <= g2))
                        {
                            if ((b1 <= targ.B) && (targ.B <= b2))
                            {
                                return true;

                            }
                        }
                    }
                }
                return false;
            }
        }
        static public Bitmap CreateNonIndexedImage(Image src)
        {
            Bitmap newBmp = new Bitmap(src.Width, src.Height, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);

            using (Graphics gfx = Graphics.FromImage(newBmp))
            {
                gfx.DrawImage(src,0,0);
            }

            return newBmp;
        }
        public unsafe delegate void DataCallback(int x, int y, byte* data);
        public static unsafe void LockDaPic(Bitmap img, DataCallback callback)
        {
            BitmapData bData = img.LockBits(new Rectangle(0, 0, img.Width, img.Height), ImageLockMode.ReadWrite, img.PixelFormat);

            byte bitsPerPixel = (byte)Image.GetPixelFormatSize(img.PixelFormat);
            //RGB == 24 bits
            //ARGB == 32 bits

            byte* scan0 = (byte*)bData.Scan0.ToPointer();

            for (int y = 0; y < bData.Height; y++)
            {
                for (int x = 0; x < bData.Width; x++)
                {
                    byte* data = scan0 + y * bData.Stride + x * bitsPerPixel / 8;

                    callback(x, y, data);//optional callback

                }
            }

            img.UnlockBits(bData);//unlock from memory

        }
        public static unsafe Color ColorFrompointer(byte* data, byte bpp)
        {
            int byteperpix = bpp / 8;
            if (byteperpix == 3)
            {
                return Color.FromArgb(byte.MaxValue, data[2], data[1], data[0]);
            }
            if (byteperpix == 4)
            {
                return Color.FromArgb(data[3], data[2], data[1], data[0]);
            }
            else
            {
                throw new Exception("Not supported");
            }
        }
    }
}
