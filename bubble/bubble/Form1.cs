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
        Character karakter;
        Rectangle strela;
        bubbleDoc lista;
        bool desno = false;
        bool levo = false;
        int shot = 0;

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            karakter =new Character(Properties.Resources.SBTDesno,Width/2);
            lista = new bubbleDoc(1);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
            Image brick = new Bitmap(Properties.Resources.brick2);
            TextureBrush tb = new TextureBrush(brick);

            e.Graphics.FillRectangle(tb, 0, 0, Width, 50);
            e.Graphics.FillRectangle(tb, 0, Height - 70, Width, 50);
            e.Graphics.FillRectangle(tb, 0, 0,35,Height);
            e.Graphics.FillRectangle(tb, Width-50, 0, 50, Height);

            if (strela != null)
            {
                Brush b = new SolidBrush(Color.Yellow);
                e.Graphics.FillRectangle(b, strela);
            }

            karakter.Draw(e.Graphics,Height);
            lista.Draw(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lista.Move(Width, Height);
            if (desno && !levo)
                karakter.Move(Keys.Right,Width);
            else if (levo && !desno)
                karakter.Move(Keys.Left,Width);
            if (shot!=0)
            {
                if (strela.Y >= 53)
                {
                    strela.Y -= 8;
                    strela.Height += 8;
                }
                else
                {
                    karakter.ammo++;
                    shot = 0;
                    strela =new Rectangle(0,0,0,0);
                }
            }
            
            Invalidate();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Right)
                desno = true;
            else if (e.KeyData == Keys.Left)
                levo = true;

            else if(e.KeyData == Keys.Up)
            {
                int pom = karakter.Shoot();
                if (pom != 0)
                {
                    strela = new Rectangle(pom, Height - 170, 5, 100);
                    shot = pom;
                }
            }
            Invalidate();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Right && desno)
                desno = false;
            if (e.KeyData == Keys.Left && levo)
                levo = false;
            Invalidate();
        }
    }
}
