using System;

namespace TWCSharp
{
    public class Unit
    {
        protected int X, Y;
        protected string poza;
        protected int health;
        protected int viteza;

        public Unit() {
            X = 0;Y = 0;
            poza = "";
            health = 100;
            viteza = 1;
        }
        public Unit(int x, int y, string p, int h, int v) {
            X = x;Y = y;
            poza = p;
            health = h;
            viteza = v;
        }        internal virtual void Show()
        {
            Console.WriteLine("Sunt o unitate");
        }
    }
}