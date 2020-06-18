using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace ColorReplacer
{
    public partial class Form1 : Form
    {
        Bitmap Display;
        public Form1()
        {
            InitializeComponent();

            Display = new Bitmap(ColorDisplay.Width , ColorDisplay.Height );
            ColorDisplay.Image = Display;
            ColorDisplay2.Image = Display;
        }
        List<int> location = new List<int>();
        Color main;
        Color replacement;
        private unsafe void Replace(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                return;
            }
            if (ColorDisplay.Image == null || ColorDisplay2.Image == null)
            {
                MessageBox.Show("Please pick a color!");
                return;
            }
            byte a1 = (byte)(alp1.Value );
            byte r1 = (byte)(red1.Value );
            byte g1 = (byte)(green1.Value );
            byte b1 = (byte)(blue1.Value );

            Bitmap b = (Bitmap)pictureBox1.Image;

            PicProcessor.RangeChecker RC = new PicProcessor.RangeChecker(main,a1,r1,g1,b1);


            PicProcessor.LockDaPic(b, (x, y, data) =>
            {
                if (RC.IsColInrange(PicProcessor.ColorFrompointer(data, 32))){
                    data[0] = replacement.B;
                    data[1] = replacement.G;
                    data[2] = replacement.R;
                    data[3] = replacement.A;
                }
            });

            pictureBox1.Image = b;

        }

    
        private void OnOpen(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            try
            {
                Bitmap local = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = PicProcessor.CreateNonIndexedImage(local);
            }
            catch (Exception)
            {

                MessageBox.Show("Unable to open such file");
            }
        }

        private void OnSave(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Save("Result2.png");

            }
        }

        private void OnMumericchange (object sen,EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Replace(null,null);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            if (colorDialog1.Color != null)
            {
                replacement = colorDialog1.Color;
                Bitmap display = (Bitmap)ColorDisplay.Image;
                for (int x = 0; x < display.Width; x++)
                {
                    for (int y = 0; y < display.Height; y++)
                    {
                        display.SetPixel(x,y,colorDialog1.Color);
                    }
                }
                ColorDisplay.Image = display;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            if (colorDialog1.Color != null)
            {
                main = colorDialog1.Color;
                Bitmap display = (Bitmap)ColorDisplay2.Image;
                for (int x = 0; x < display.Width; x++)
                {
                    for (int y = 0; y < display.Height; y++)
                    {
                        display.SetPixel(x, y, colorDialog1.Color);
                    }
                }
                ColorDisplay2.Image = display;
            }
        }
    }
}
