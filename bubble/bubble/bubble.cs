using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble
{
    class Bubble
    {
        public double x { get; set; }
        public double y { get; set; }
        public int radius { get; set; }
        public bool nasoka { get; set; }
        public bool bounce { get; set; }
        public double  zabrzuvanje { get; set; }
        public Color boja { get; set; }
        
        public Bubble(int xx,int yy,int r,Color c)
        {
            x = xx;
            y = yy;
            radius = r;
            boja = c;
            nasoka = true;
            bounce = true;
            zabrzuvanje = 0;
        }
        public void Draw(Graphics g)
        {
            Brush chetka = new SolidBrush(boja);
            g.FillEllipse(chetka, (int)x - radius, (int)y - radius, radius * 2, radius * 2);
        }

        public void Move(int width)
        {
            
            if (nasoka)
            {
                x += 4;
                if (x + radius >= width - 50)
                {
                    nasoka = false;
                }
            }
            else
            {
                x -= 4;
                if (x - radius <= 35)
                {
                    nasoka = true;
                }
            }
        }

        public void Gravity(int height)
        {
            if (bounce)
            {
                double ynext = y;
                ynext += 0.5*zabrzuvanje;
                zabrzuvanje +=1;
                if (ynext + radius > height - 60 )
                {
                    zabrzuvanje = 2*Math.Sqrt(radius)+20;
                    bounce = false;
                }
                else
                {
                    y = ynext;
                }
            }
            else
            {
                double ynext = y;
                ynext -= 0.5 * zabrzuvanje;
                zabrzuvanje -= 1 ;
                if (zabrzuvanje<=0)
                {
                    bounce = true;
                }
                else
                {
                    y = ynext;
                }
            }
        }

        public bool kolizija(int height)
        {
            Character sb = InGame.karakter;
            if (y >= height - 190)
            {
                //kolizija od levo
                if (x <= sb.x && x + radius >= sb.x - 40)
                    return true;
                //kolizija od desno
                if (x >= sb.x && x - radius <= sb.x + 40)
                    return true;
            }
            //kolizija od lev kjosh
            if (Math.Sqrt((x - (sb.x - 40)) * (x - (sb.x - 40)) + (y - (height - 190)) * (y - (height - 190))) <= radius)
                return true;
            //kolizija od desen kjosh
            if (Math.Sqrt((x - (sb.x + 40)) * (x - (sb.x + 40)) + (y - (height - 190)) * (y - (height - 190))) <= radius)
                return true;
            //kolizija od gore
            if (x >= sb.x - 40 && x <= sb.x + 40 && y + radius >= height - 190)
                return true;
            return false;
        }

        public bool checkPop()
        {
            Rectangle strela = InGame.strela;
            if (y >= strela.Top)
            {
                //kolizija od levo
                if (x <= strela.Left && x + radius >= strela.Left)
                    return true;
                //kolizija od desno
                if (x >= strela.Left && x - radius <= strela.Left+5)
                    return true;
            }
            //kolizija od lev kjosh
            if (Math.Sqrt((x - strela.Left) * (x - strela.Left) + (y - strela.Top) * (y - strela.Top)) <= radius)
                return true;
            //kolizija od desen kjosh
            if (Math.Sqrt((x - strela.Left+5) * (x - strela.Left + 5) + (y - strela.Top) * (y - strela.Top)) <= radius)
                return true;
            //kolizija od gore
            if (x >= strela.Left && x <= strela.Left+5 && y + radius >= strela.Top)
                return true;
            return false;
        }
    }
}
