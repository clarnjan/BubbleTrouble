using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bubble
{
    public class Character
    {
        public int x { get; set; }
        public Image slika;
        public int ammo { get; set; }
        public int lives { get; set; }

        public Character(Image i,int x)
        {
            this.x = x;
            slika = i;
            ammo = 1;
            lives = 3;
        }

        public void Draw(Graphics g,int Height)
        {
            g.DrawImageUnscaled(slika, x-40, Height - 190);
        }

        public void Move(Keys keydata,int Width)
        {
            if (keydata == Keys.Right)
            {
                int xnext = x;
                xnext += 10;
                if (xnext < Width -90)
                    x = xnext;
                slika = Properties.Resources.SBTDesno;
            }
            if (keydata == Keys.Left)
            {
                int xnext = x;
                xnext -= 10;
                if (xnext > 75)
                    x = xnext;
                slika = Properties.Resources.SBTLevo;
            }
        }
        public int Shoot()
        {
            if (ammo > 0)
            {
                ammo--;
                return x;
            }
            return 0;
        }

    }
}
