using System;

namespace TWCSharp
{
    internal class Camion : Motorizat
    {
        int soldati;
        internal override void Show()
        {
            Console.WriteLine("Sunt un csmion");
        }
    }
}