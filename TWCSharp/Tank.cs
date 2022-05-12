using System;

namespace TWCSharp
{
    internal class Tank : Motorizat
    {

        int obuze;
        int damage;

        public Tank() {
            obuze = 7;
            damage = 1120;
        }

        public Tank(int x, int y, string p, int h, 
                    int v, int a, int f, int o, int d):
            base(x,y,p,h,v,a,f)
        {
            obuze = o;
            damage = d;
        }
        internal override void Show()
        {
            Console.WriteLine("Sunt un tank la coordonate " +
                X.ToString() + "," + Y.ToString() + " si viata "
                + health.ToString());
        }
    }
}