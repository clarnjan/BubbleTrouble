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
                Bubble topche = new Bubble(600, 150, 80, Color.Blue);
                lista.Add(topche);
            }
            else if (level == 2)
            {
                Bubble topche = new Bubble(400, 150, 80, Color.Blue);
                Bubble topche1 = new Bubble(800, 150, 80, Color.Blue);
                topche.nasoka = false;
                lista.Add(topche);
                lista.Add(topche1);
            }
            else if (level == 3)
            {
                for(int i =0; i <5; i++)
                {
                    Bubble topche = new Bubble(100+i*40, 400, 10, Color.Blue);
                    lista.Add(topche);
                }
                for (int i = 0; i < 5; i++)
                {
                    Bubble topche = new Bubble(900 + i * 40, 400, 10, Color.Blue);
                    topche.nasoka = false;
                    lista.Add(topche);
                }
            }
            else if (level == 4)
            {
                Bubble topche = new Bubble(600, 150, 80, Color.Blue);
                Bubble topche1 = new Bubble(400, 150, 40, Color.Blue);
                Bubble topche2 = new Bubble(800, 150, 40, Color.Blue);
                topche1.nasoka = false;
                topche2.nasoka = false;
                lista.Add(topche);
                lista.Add(topche1);
                lista.Add(topche2);
            }
            else if (level == 5)
            {
                Bubble topche = new Bubble(400, 150, 80, Color.Blue);
                Bubble topche1 = new Bubble(600, 150, 80, Color.Blue);
                Bubble topche2 = new Bubble(800, 150, 80, Color.Blue);
                lista.Add(topche);
                lista.Add(topche1);
                lista.Add(topche2);
            }
            else if (level == 6)
            {
                Bubble topche = new Bubble(100, 150, 40, Color.Blue);
                Bubble topche1 = new Bubble(250, 150, 40, Color.Blue);
                Bubble topche2 = new Bubble(400, 150, 40, Color.Blue);
                lista.Add(topche);
                lista.Add(topche1);
                lista.Add(topche2);
                Bubble topche3 = new Bubble(700, 150, 40, Color.Blue);
                Bubble topche4 = new Bubble(850, 150, 40, Color.Blue);
                Bubble topche5 = new Bubble(1000, 150, 40, Color.Blue);
                topche.nasoka = false;
                topche1.nasoka = false;
                topche2.nasoka = false;
                lista.Add(topche3);
                lista.Add(topche4);
                lista.Add(topche5);

            }
        }
        public void Draw(Graphics g)
        {
            foreach(Bubble b in lista)
            {
                b.Draw(g);
            }
        }
        public bool Move(int width,int height)
        {
            foreach(Bubble b in lista)
            {
                b.Move(width);
                b.Gravity(height);
                if (b.kolizija(height))
                {
                    return true;
                }
            }
            return false;
        }
        public bool checkPop()
        {
            foreach(Bubble b in lista)
            {
                if (b.checkPop())
                {
                    InGame.score+=5;
                    if (b.radius == 10)
                        lista.Remove(b);
                    if (b.radius == 80)
                    {
                        Bubble b1= new Bubble((int)b.x+40,(int)b.y,40,Color.Blue);
                        Bubble b2 = new Bubble((int)b.x-40, (int)b.y, 40, Color.Blue);
                        b2.nasoka = false;
                        b1.zabrzuvanje = 15;
                        b2.zabrzuvanje = 15;
                        b1.bounce = false;
                        b2.bounce = false;
                        lista.Add(b1);
                        lista.Add(b2);
                        lista.Remove(b);
                    }
                    if (b.radius == 40)
                    {
                        Bubble b1 = new Bubble((int)b.x + 20, (int)b.y, 10, Color.Blue);
                        Bubble b2 = new Bubble((int)b.x - 20, (int)b.y, 10, Color.Blue);
                        b2.nasoka = false;
                        b1.zabrzuvanje = 15;
                        b2.zabrzuvanje = 15;
                        b1.bounce = false;
                        b2.bounce = false;
                        lista.Add(b1);
                        lista.Add(b2);
                        lista.Remove(b);
                    }

                    return true;
                }
            }
            return false;
        }
    }
}
