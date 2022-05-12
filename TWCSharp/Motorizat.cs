namespace TWCSharp
{
    public class Motorizat: Unit
    {
        int armor;
        int fuel;

        public Motorizat(): base()
        {
            armor = 10;
            fuel = 50;
        }

        public Motorizat(int x, int y, string p, int h, int v,int a, int f)
            : base(x, y, p, h, v)
        {
            armor = a;
            fuel = f;
        }
    }
}