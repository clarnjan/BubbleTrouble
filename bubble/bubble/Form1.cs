using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bubble
{
    public partial class Form1 : Form
    {
        Bubble topche;
        Bubble topche1;
        Bubble topche2;
        Character karakter;

        public Form1()
        {
            InitializeComponent();
            topche = new Bubble(100, 100, 80, Color.Blue);
            topche1 = new Bubble(600, 100, 40, Color.Blue);
            topche2 = new Bubble(300, 100, 10, Color.Blue);
            DoubleBuffered = true;
            karakter =new Character(Properties.Resources.desnoT,Width/2);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            Image brick = new Bitmap(Properties.Resources.bricks);
            TextureBrush tb = new TextureBrush(brick);
            e.Graphics.FillRectangle(tb, 0, 0, Width, 50);
            e.Graphics.FillRectangle(tb, 0, Height-70, Width, 50);
            TextureBrush tb2 = new TextureBrush(Properties.Resources.brick2);
            e.Graphics.FillRectangle(tb2, 0, 0,35,Height);
            e.Graphics.FillRectangle(tb2, Width-50, 0, 50, Height);

            karakter.Draw(e.Graphics,Height);
            topche.Draw(e.Graphics);
            topche1.Draw(e.Graphics);
            topche2.Draw(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            topche.Move(Width);
            topche.Gravity(Height);
            topche1.Move(Width);
            topche1.Gravity(Height);
            topche2.Move(Width);
            topche2.Gravity(Height);
            MessageBox.Show(Height.ToString());
            Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            karakter.Move(e.KeyData);
            Invalidate();
        }
    }
}
