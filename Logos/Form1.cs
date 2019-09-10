using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.Red);
            Pen DrawPen = new Pen(Color.Yellow);
            SolidBrush drawBrush = new SolidBrush(Color.Yellow);
          // Font Drawfont = new Font ("Arial", 60, FontStyle.Bold);
            SolidBrush Drawrectangle = new SolidBrush(Color.Blue);
            g.FillRectangle (Drawrectangle, this.Width / 2 - 100, this.Height / 2 - 50, 200, 100);
            g.DrawEllipse(DrawPen, this.Width/2 - 100 , this.Height/2 - 50, 200, 100);
            g.FillEllipse(drawBrush, this.Width / 2 - 100, this.Height / 2 - 50, 200, 100);
            Font drawFont = new Font("Times New Roman", 40, FontStyle.Bold);

            SolidBrush DrawBrush = new SolidBrush(Color.Blue);

            // this writes the logo to the screen

            g.DrawString("IKEA", drawFont, DrawBrush, this.Width / 2-70, this.Height / 2- 30);
            //this is a test
        }
    }
}
