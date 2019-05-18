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

        public Character(Image i,int x)
        {
            this.x = x;
            slika = i;
        }

        public void Draw(Graphics g,int Height)
        {
            g.DrawImageUnscaled(slika, x - 63, Height - 180);
        }

        public void Move(Keys keydata)
        {
            if (keydata == Keys.Right)
            {
                x += 10;
                slika = Properties.Resources.desnoT;
            }
            if (keydata == Keys.Left)
            {
                x -= 10;
                slika = Properties.Resources.levoT;
            }
        }


    }
}
