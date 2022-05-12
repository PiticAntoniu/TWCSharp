using System.Collections.Generic;

namespace TWCSharp
{
    internal class Game
    {
        Map map = new Map();
        Minimap minimap = new Minimap();
        List<Unit> unitList = new List<Unit>();
        public Game() {
            unitList.Add(new Tank(100,120,"",1200,30,100,120,7,50));
            unitList.Add(new Wizard());
            unitList.Add(new Camion());
            unitList.Add(new Inginer());

        }

        public void Play()
        {
            foreach (Unit unit in unitList)
            {
                unit.Show();
            }
        }

    }
}