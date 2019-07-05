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
        public static Rectangle strela;
        bubbleDoc lista;
        bool desno = false;
        bool levo = false;
        int shot = 0;
        int startTicks;
        int lives = 3;
        int level;
        public static int score = 0;

        public InGame()
        {
            InitializeComponent();
            DoubleBuffered = true;
            lives = 3;
            level = 1;
            score = 0;
            newGame();
        }

        public void newGame()
        {
            lista = new bubbleDoc(level);
            if(level==1)
                this.BackgroundImage = Properties.Resources.krustySmall;
            else if (level==2)
                this.BackgroundImage = Properties.Resources.level2;
            else if (level == 3)
                this.BackgroundImage = Properties.Resources.level3;
            else if (level == 4)
                this.BackgroundImage = Properties.Resources.level4;
            else if (level == 5)
                this.BackgroundImage = Properties.Resources.level5;
            else if (level == 6)
                this.BackgroundImage = Properties.Resources.level6;

            startTicks = 2;
            shot = 0;
            desno = false;
            levo = false;
            strela = new Rectangle();
            lbInfo.Visible = true;
            lbInfo.Text = "3";
            karakter = new Character(Properties.Resources.SBTDesno, Width / 2);
            pbTime.Value = 0;
            timerStart.Start();
            Invalidate();
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
                Pen p = new Pen(Color.Black);
                e.Graphics.FillRectangle(b, strela);
                e.Graphics.DrawRectangle(p, strela);
            }

            karakter.Draw(e.Graphics,Height);
            lista.Draw(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lista.checkPop())
            {
                karakter.ammo++;
                shot = 0;
                strela = new Rectangle();
            }
            if (lista.Move(Width, Height))
            {
                Invalidate();
                die();
            }
            if (desno && !levo)
                karakter.Move(Keys.Right, Width);
            else if (levo && !desno)
                karakter.Move(Keys.Left, Width);
            if (shot != 0)
            {
                if (strela.Y >= 52)
                {
                    strela.Y -= 9;
                    strela.Height += 9;
                }
                else
                {
                    karakter.ammo++;
                    shot = 0;
                    strela = new Rectangle();
                }
            }
            if (win())
            {
                Time.Stop();
                timer1.Stop();
                level += 1;
                lbLevel.Text = "LEVEL " + level.ToString();
                score += 100 - pbTime.Value;
                if(level<7)
                newGame();
                else
                {
                    DialogResult d = MessageBox.Show("Your score: " + score.ToString(), "YOU WON !", MessageBoxButtons.OK);
                    if (d == DialogResult.OK)
                        MyMenu();
                }
            }
            lbScore.Text = "SCORE: " + score.ToString();
            Invalidate();
        }

        private bool win()
        {
            if (lista.lista.Count == 0)
                return true;
            return false;
        }

        private void die()
        {
            timer1.Stop();
            Time.Stop();
            lives--;
            if (lives == 2)
                pictureBox3.Visible = false;
            else if (lives == 1)
                pictureBox2.Visible = false;
            if (lives == 0)
            {
                pictureBox1.Visible = false;
                DialogResult d=MessageBox.Show("Your score: "+score.ToString(),"GAME OVER",MessageBoxButtons.OK);
                if (d == DialogResult.OK)
                    MyMenu();
            }
            else
                newGame();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.KeyData == Keys.Right)
                    desno = true;
                else if (e.KeyData == Keys.Left)
                    levo = true;
                else if (e.KeyData == Keys.Space && timer1.Enabled==true)
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
            MyMenu();
        }

        private void MyMenu()
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
            else
            {
                die();
            }
        }
        private void timerStart_Tick(object sender, EventArgs e)
        {
            lbInfo.Text = startTicks.ToString();
            if (startTicks == 0)
            {
                lbInfo.Text = "GO!";
                timer1.Start();
                Time.Start();
            }
            if (startTicks == -1)
            {
                lbInfo.Visible = false;
                timerStart.Stop();
            }
            startTicks--;
        }
    }
}
