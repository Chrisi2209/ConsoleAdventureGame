using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAdventureGame
{
    // Das ist ein Raum, aus ihnen bestehen Biome
    class Raum
    {
        // Beschreibungstext für den Raum, wird beim eintreten ausgegeben
        public string beschreibung { get; set; }
        // Chance, dass ein Gegner beim eintreten auftritt
        public double chanceGegner { get; set; }
        public double chanceLoot { get; set; }
        public Raum(string beschreibung, double chanceGegner, double chanceLoot)
        {

        }

        // Methode, um den Raum zu betreten
        public void RaumBetreten()
        {
            Console.WriteLine(beschreibung);
        }
    }
}
