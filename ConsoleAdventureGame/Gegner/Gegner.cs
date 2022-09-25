using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAdventureGame
{
    internal class Gegner
    {
        // vielleicht verschiedene Gegner verschiedene Unterklassen

        public int maxLeben { get; set; }
        public int leben { get; set; }
        public string name { get; set; }
        public Waffe waffe { get; set; }
        public string[] angriffstexte { get; set; }

        public Gegner(int maxLeben, string name, Waffe[] verfügbareWaffen, double[] waffenHäufigkeit, string[] angriffstexte)
        {
            this.maxLeben = maxLeben;
            leben = maxLeben;
            this.name = name;
            // this.waffe = ; Mit zufallswerten und verfügbareWaffen und waffenHäufigkeit ausrechnen
            this.angriffstexte = angriffstexte;
        }
    }
}
