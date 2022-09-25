using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAdventureGame
{
    internal class Biom
    {
        public string name { get; set; }
        public Gegner[] gegner { get; set; }
        public Waffe[] waffenGegner { get; set; }
        public int größe { get; set; }
        public Raum[] räume { get; set; }
        public bool[,] raumanordnung { get; set; }

        public Biom(string name, Gegner[] gegner, Waffe[] waffen, int größe)
        {
            this.name = name;
            this.gegner = gegner;
            this.waffenGegner = waffen;
            this.größe = größe;
            RaumanordnungBerechnen();
        }

        /*
         * Methode, um das Layout der Räume in einem Biom zu erstellen
         * ein walker geht immer in eine zufällige Richtung und setzt dort einen
         * Raum hin, bis er alle Räume platziert hat.
         */
        private void RaumanordnungBerechnen()
        {
            // in diesem array steht 1 für hier ist ein Raum und 0 für hier ist kein raum.
            raumanordnung = new bool[räume.Length, räume.Length];

            // Diese Variablen geben an, wo sich der Generator gerade bedindet.
            int x = räume.Length / 2;
            int y = räume.Length / 2;

            // In der Mitte kommt erstmal ein Raum
            raumanordnung[x, y] = true;

            // Zählt wie viele Räume schon gebaut wurden, um die Schleife im richtigen Zeitpunkt zu beenden
            int raumzähler = 1;

            // ein Array für die deltawerte von nach oben, unten, rechts und links gehen
            int[][] deltaArray = new int[][] { new int[] { 0, -1 }, new int[] { 1, 0 }, new int[] { 0, -1 }, new int[] { -1, 0 } };
            int[] delta;
            Random random = new Random();

            while (raumzähler < räume.Length)
            {
                // neues x und y berechnen
                delta = Mathe.ZufälligerWertAusArray(deltaArray);
                x += delta[0];
                y += delta[1];

                // out of bounds check
                if (x == raumanordnung.GetLength(0)) x--;
                else if (x == -1) x++;

                if (y == raumanordnung.GetLength(1)) y--;
                else if (y == -1) y++;

                // Raum eintragen
                if (!raumanordnung[x, y])
                {
                    raumanordnung[x, y] = true;
                    raumzähler++;
                }
            }

            // Ausgabe
            /*
            for (int i = 0; i < raumanordnung.GetLength(0); i++)
            {
                for (int j = 0; j < raumanordnung.GetLength(1); j++)
                {
                    Console.Write(Convert.ToInt32(raumanordnung[i, j]) + " ");
                }
                Console.WriteLine();
            }
            /**/
        }
    }
}
