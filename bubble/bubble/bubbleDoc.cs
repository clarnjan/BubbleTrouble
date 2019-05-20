using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble
{
    class bubbleDoc
    {
        public List<Bubble> lista;
        public bubbleDoc(int level)
        {
            lista = new List<Bubble>();
            if (level == 1)
            {

                Bubble topche = new Bubble(100, 100, 80, Color.Blue);
                Bubble topche1 = new Bubble(600, 100, 40, Color.Blue);
                Bubble topche2 = new Bubble(300, 100, 10, Color.Blue);
                lista.Add(topche);
                lista.Add(topche1);
                lista.Add(topche2);
            }
        }
        public void Draw(Graphics g)
        {
            foreach(Bubble b in lista)
            {
                b.Draw(g);
            }
        }
        public void Move(int width,int height)
        {
            foreach(Bubble b in lista)
            {
                b.Move(width);
                b.Gravity(height);
            }

        }
    }
}
