/* Stilvorschriften
 * 
 * Variablen: klein anfangen, weitere Wörter aneinander mit Großbuchstaben (camelcase) bsp: ichBinCool
 * Methoden, Klassen: Groß anfangen, weitere Wörter aneinander mit Großbuchstaben (pascalcase) bsp: IchBinCool
 * eigene Zeile für geschwungene Klammern (außer bei do while Schleifen, da ist das while in derselben Zeile wie das }.)
 * 
 * 
 * 
 * 
 * Game design
 * Biome:
 * - Wald
 * - Wüste
 * - Sumpf
 * - Flachland
 * - Vulkan
 * - Höhle
 * - Verließ
 * - Friedhof
 * 
 * Gegner:
 * - Schleim, verschiedene Farben und Namen für verschiedene Biome (Sumpf, Flachland)
 * - Oger  - Ork ?
 * - Goblins
 * - Fledermaus (Höhle)
 * - Skelette (Höhle, Verließ, Friedhof)
 * - Magier (Wald)
 * - Hexe, spawnt Skelette (Wald, Fridhof, Verließ)
 * - 
 * 
 * Waffen:
 * - Axt
 * - Schwert (verschiedene Arten z.B.: Langschwert)
 * - Dolch
 * - Fäuste
 * - Steinschleuder
 * - Bogen
 * - Krallenhamdschuhe
 * 
 * Rüstungen
 * - Teile:
 * -- Rüstung
 * -- Schuhe
 * 
 * - Kettenrüstung
 * - 
*/

using System;

namespace ConsoleAdventureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            if (false)
            {
                SpielStart();
                while (true)
                {
                    // out: quest
                    QuestAuswahl();

                    // in: quest, spielerNeu
                    QuestAbspielen();

                    // spieler = spielerNeu
                }
            }


            /* Test für Biomraumanordnung
            do
            {
                Biom a = new Biom("Grasland", new Gegner[] { new Gegner(10, "hi", new Waffe[2], new double[1], new string[1]) }, new Waffe[] { new Waffe("", 0, 1, 1, 1, 1) },
                    new Raum[] {new Raum("a", 1, 1), new Raum("a", 1, 1), new Raum("a", 1, 1), new Raum("a", 1, 1), new Raum("a", 1, 1), new Raum("a", 1, 1),
                new Raum("a", 1, 1), new Raum("a", 1, 1), new Raum("a", 1, 1), new Raum("a", 1, 1), new Raum("a", 1, 1), new Raum("a", 1, 1) });
                Console.ReadKey();
            }
            while (true);
            /**/


            // Test für Asuwahltexte
            /*
            Console.WriteLine(Auswahltexte(new string[] { "a", "b", "c", "d" }, "Hallo, jemand geift \n dich an, was machst \n du?"));
            */

            // Test für ZufälligerWertAusArray
            /*
            string[] obstSorten = { "Apfel", "Birne", "Kiwi", "Orange", "Weintraube", "Himbere" };
            int[] häufigkeiten = { 3, 3, 1, 2, 4, 5 };
            int[] anzahlen = new int[obstSorten.Length];
            for (int i = 0; i < 18000; i++)
            {
                string obst = ZufälligerWertAusArray(obstSorten, häufigkeiten);
                for (int j = 0; j < obstSorten.Length; j++)
                {
                    if (obst == obstSorten[j])
                    {
                        anzahlen[j]++;
                        break;
                    }
                }
            }

            for (int i = 0; i < obstSorten.Length; i++)
            {
                Console.WriteLine(obstSorten[i] + ": " + anzahlen[i]);
            }
            */
        }

        static void SpielStart()
        {
            string anfangstext = "";  // Anfangstext einsetzen
            Console.WriteLine(anfangstext);
        }

        static void QuestAuswahl()
        {

        }

        static void QuestAbspielen()
        {
            
        }

        // Gibt die Auswahlmöglichkeiten aus und lässt den Benutzer eine auswählen.
        // Gibt als returnwert den Index des ausgewählten Textes zurück.
        // frageText gibt an, was gerade auf dem Bildschirm steht.
        static int Auswahltexte(string[] auswahlmöglichkeiten, string frageText)
        {
            // returnwert
            int ausgewählterText = 0;

            // hierdrin wird gespeichert, welcher Knopf gefrückt wurde
            ConsoleKey gedrückterKnopf;

            do
            {
                // Bei jedem Durchlauf muss alles von neu geschrieben werden
                Console.Clear();
                Console.WriteLine(frageText);

                // Auswahlmöglichkeiten ausgeben (ausgewähltes ist weiß hinterlegt)
                for (int i = 0; i < auswahlmöglichkeiten.Length; i++)
                {
                    if (i == ausgewählterText)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.WriteLine(auswahlmöglichkeiten[i]);
                }
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;

                do
                {
                    gedrückterKnopf = Console.ReadKey(true).Key;
                } while (gedrückterKnopf != ConsoleKey.Enter && gedrückterKnopf != ConsoleKey.UpArrow && gedrückterKnopf != ConsoleKey.DownArrow);

                // Auswirkungen des Knopfdrucks berechnen
                // Der ausgewählteText verhält sich modularisch
                switch (gedrückterKnopf)
                {
                    case ConsoleKey.UpArrow:
                        if (ausgewählterText != 0)
                        {
                            ausgewählterText--;
                        }
                        else
                        {
                            ausgewählterText = auswahlmöglichkeiten.Length - 1;
                        }
                        break;

                    case ConsoleKey.DownArrow:
                        if (ausgewählterText != auswahlmöglichkeiten.Length - 1)
                        {
                            ausgewählterText++;
                        }
                        else
                        {
                            ausgewählterText = 0;
                        }
                        break;
                }

            } while (gedrückterKnopf != ConsoleKey.Enter);

            return ausgewählterText;
        }

    }
}