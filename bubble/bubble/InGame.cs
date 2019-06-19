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
    public partial class InGame : Form
    {
        public static Character karakter;
        Rectangle strela;
        bubbleDoc lista;
        bool desno = false;
        bool levo = false;
        int shot = 0;

        public InGame()
        {
            InitializeComponent();
            DoubleBuffered = true;
            newGame();
            karakter = new Character(Properties.Resources.SBTDesno, Width / 2);
        }

        public void newGame()
        {
            lista = new bubbleDoc(1);
            Time.Start();
            timer1.Start();
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
            if (lista.Move(Width, Height) == false)
            {
                if (desno && !levo)
                    karakter.Move(Keys.Right, Width);
                else if (levo && !desno)
                    karakter.Move(Keys.Left, Width);
                if (shot != 0)
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
                        strela = new Rectangle(0, 0, 0, 0);
                    }
                }
            }
            else
            {
                timer1.Stop();
                Time.Stop();
                karakter.lives--;
                if (karakter.lives == 0)
                {
                    MessageBox.Show("GAME OVER");
                }
                else
                newGame();
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

        private void label2_Click(object sender, EventArgs e)
        {
            Starting menu = new Starting();
            this.Visible = false;
            Starting.level = 0;
            this.Close();
            menu.ShowDialog();
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            if (pbTime.Value < 100)
                pbTime.Value += 1;
        }
    }
}
