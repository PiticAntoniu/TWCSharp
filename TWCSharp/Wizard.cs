using System;

namespace TWCSharp
{
    internal class Wizard : Living
    {

        int mana;
        int damage;
        internal override void Show()
        {
            Console.WriteLine("Sunt un wizard");
        }
    }
}