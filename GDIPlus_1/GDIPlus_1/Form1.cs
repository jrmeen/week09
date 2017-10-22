using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace GDIPlus_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Bitmap bmp = new Bitmap("D:\\Capture.PNG");
            this.SetClientSizeCore(bmp.Width, bmp.Height);
            Rectangle destRect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            Brush myBrush = new SolidBrush(Color.Coral);
            g.DrawImage(bmp, destRect);
            g.DrawString("Hello world",
            new Font("Verdana", 30, FontStyle.Bold), myBrush, 0, 0);
            g.Dispose();
        }

    }
}
