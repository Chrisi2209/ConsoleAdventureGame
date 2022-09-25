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


    static class Mathe
    {
        static public string ZufälligerWertAusArray(string[] array)
        {
            //Ausnahmen
            if (array.Length == 0) throw new Exception("Es wurde ein leeres Array eingegeben!");

            Random random = new Random();
            int index = random.Next(array.Length);
            return array[index];
        }
        static public double ZufälligerWertAusArray(double[] array)
        {
            //Ausnahmen
            if (array.Length == 0) throw new Exception("Es wurde ein leeres Array eingegeben!");

            Random random = new Random();
            int index = random.Next(array.Length);
            return array[index];
        }
        static public int[] ZufälligerWertAusArray(int[][] array)
        {
            //Ausnahmen
            if (array.Length == 0) throw new Exception("Es wurde ein leeres Array eingegeben!");

            Random random = new Random();
            int index = random.Next(array.Length);
            return array[index];
        }
        static public int ZufälligerWertAusArray(int[] array)
        {
            //Ausnahmen
            if (array.Length == 0) throw new Exception("Es wurde ein leeres Array eingegeben!");

            Random random = new Random();
            int index = random.Next(array.Length);
            return array[index];
        }
        static public string ZufälligerWertAusArray(string[] array, double[] häufigkeiten)
        {
            //Ausnahmen
            if (array.Length == 0) throw new Exception("Es wurde ein leeres Array eingegeben!");

            Random random = new Random();

            double zufallsWert = random.NextDouble();
            if (zufallsWert == 0) return array[0];
            zufallsWert *= Summe(häufigkeiten);
            if (zufallsWert == 0) throw new Exception("Die Summe der Häufigkeiten darf nicht 0 sein!");

            int index = 0;
            double summe = 0;
            while (summe < zufallsWert) summe += häufigkeiten[index++];
            return array[index - 1];
        }
        static public string ZufälligerWertAusArray(string[] array, int[] häufigkeiten)
        {
            //Ausnahmen
            if (array.Length == 0) throw new Exception("Es wurde ein leeres Array eingegeben!");

            Random random = new Random();

            double zufallsWert = random.NextDouble();
            if (zufallsWert == 0) return array[0];
            zufallsWert *= Summe(häufigkeiten);
            if (zufallsWert == 0) throw new Exception("Die Summe der Häufigkeiten darf nicht 0 sein!");

            int index = 0;
            int summe = 0;
            while (summe < zufallsWert) summe += häufigkeiten[index++];
            return array[index - 1];
        }
        static public double ZufälligerWertAusArray(double[] array, double[] häufigkeiten)
        {
            //Ausnahmen
            if (array.Length == 0) throw new Exception("Es wurde ein leeres Array eingegeben!");

            Random random = new Random();

            double zufallsWert = random.NextDouble();
            if (zufallsWert == 0) return array[0];
            zufallsWert *= Summe(häufigkeiten);
            if (zufallsWert == 0) throw new Exception("Die Summe der Häufigkeiten darf nicht 0 sein!");

            int index = 0;
            double summe = 0;
            while (summe < zufallsWert) summe += häufigkeiten[index++];
            return array[index - 1];
        }
        static public double ZufälligerWertAusArray(double[] array, int[] häufigkeiten)
        {
            //Ausnahmen
            if (array.Length == 0) throw new Exception("Es wurde ein leeres Array eingegeben!");

            Random random = new Random();

            double zufallsWert = random.NextDouble();
            if (zufallsWert == 0) return array[0];
            zufallsWert *= Summe(häufigkeiten);
            if (zufallsWert == 0) throw new Exception("Die Summe der Häufigkeiten darf nicht 0 sein!");

            int index = 0;
            int summe = 0;
            while (summe < zufallsWert) summe += häufigkeiten[index++];
            return array[index - 1];
        }
        static public int ZufälligerWertAusArray(int[] array, double[] häufigkeiten)
        {
            //Ausnahmen
            if (array.Length == 0) throw new Exception("Es wurde ein leeres Array eingegeben!");

            Random random = new Random();

            double zufallsWert = random.NextDouble();
            if (zufallsWert == 0) return array[0];
            zufallsWert *= Summe(häufigkeiten);
            if (zufallsWert == 0) throw new Exception("Die Summe der Häufigkeiten darf nicht 0 sein!");

            int index = 0;
            double summe = 0;
            while (summe < zufallsWert) summe += häufigkeiten[index++];
            return array[index - 1];
        }
        static public int ZufälligerWertAusArray(int[] array, int[] häufigkeiten)
        {
            //Ausnahmen
            if (array.Length == 0) throw new Exception("Es wurde ein leeres Array eingegeben!");

            Random random = new Random();

            double zufallsWert = random.NextDouble();
            if (zufallsWert == 0) return array[0];
            zufallsWert *= Summe(häufigkeiten);
            if (zufallsWert == 0) throw new Exception("Die Summe der Häufigkeiten darf nicht 0 sein!");

            int index = 0;
            int summe = 0;
            while (summe < zufallsWert) summe += häufigkeiten[index++];
            return array[index - 1];
        }
        static public double ZufallsGeneratorMitNormalverteilung(double min, double max, double erwartungsWert, double standartAbweichung)
        {
            Random random = new Random();
            double r = random.NextDouble();

            double a = min;
            double b = max;
            double m = erwartungsWert;
            double n = standartAbweichung;

            double sqrt_pi = Math.Sqrt(Math.PI);
            double erf_f_a = erf((a - m) / (n * sqrt_pi));
            double erf_f_b = erf((b - m) / (n * sqrt_pi));
            double p = 2 * (erf_f_b - erf_f_a);
            double y = m + n * sqrt_pi * InversErf(p * r / 2 + erf_f_a);
            if (y < a) y = a;
            if (b < y) y = b;
            return y;
        }
        static public double erf(double x)
        {
            if (x == 0) return 0;

            double t = 2 / (2 + Math.Abs(x));

            double[] lambda = new double[10] { -1.26551223, 1.00002368, 0.37409196, 0.09678418, -0.18628806, 0.27886807, -1.13520398, 1.48851587, -0.82215223, 0.17087277 };
            double summe = -x * x;
            for (int i = 0; i < lambda.Length; i++) summe += lambda[i] * Math.Pow(t, i);
            double tau = t * Math.Exp(summe);

            if (0 <= x) return 1 - tau;
            else return tau - 1;
        }
        static public double InversErf(double x)
        {
            if (x == 0) return 0;

            double faktor = 2 / Math.Sqrt(Math.PI);
            double y = 1 - 2 / (1 + Math.Pow(11, x));
            double erf_y = erf(y);
            double zwischenErgebnis = erf_y - x;

            while (Math.Pow(10, -12) < Math.Abs(zwischenErgebnis / erf_y))
            {
                y = y - zwischenErgebnis / (faktor * Math.Exp(-y * y));
                erf_y = erf(y);
                zwischenErgebnis = erf_y - x;
            }
            return y;
        }
        static public string Summe(string[] doubleArray)
        {
            string summe = "";
            for (int i = 0; i < doubleArray.Length; i++) summe += doubleArray[i];
            return summe;
        }
        static public double Summe(double[] doubleArray)
        {
            double summe = 0;
            for (int i = 0; i < doubleArray.Length; i++) summe += doubleArray[i];
            return summe;
        }
        static public int Summe(int[] doubleArray)
        {
            int summe = 0;
            for (int i = 0; i < doubleArray.Length; i++) summe += doubleArray[i];
            return summe;
        }
    }

    static class SpielDaten
    {
        /*
         * Hier werden alle größeren Datenmengen erstellt
         * (alle möglichen Quests/Biome/Gegner/Waffen)
         * 
         * Das level gibt hier nur an welches level der Spieler benötigt, um es freizuschalten, 
         * muss aber nichts mit dem level des Objektes zu tun haben. (Bsp. Waffe-Level)
         */

        //quests[level][nummer]
        static public Quest[][] quests =
        {
            new Quest[]
            {
                //Beispiel
                new Quest(1,0,"Hallo"),
                new Quest(2,1,"Jetzt geht es los")
            }
        };

        //biome[nummer]
        static public Biom[] biome =
        {
            //Beispiel
            new Biom("Wald", new int[] {3,4,5 }, new int[] {3,4,5 },3)
        };

        //gegner[nummer]
        static public Gegner[] gegner =
        {

        };

        //waffen[level][nummer]
        static public Waffe[][] waffen =
        {
            new Waffe[]
            {

            }
        };

    }


    class Spieler
    {
        public int maxLeben { get; set; }
        public double level { get; set; }

        public Spieler()
        {
            maxLeben = 10;
            level = 1;
        }
    }

    //Jede Quest Spielt sich in einem bestimmten Biom ab.
    //Beim spielen von einer Quest spielt man auf einer Karte mit mehreren Räumen
    //Die Karte mit den Räumen wird im Biom-Objekt gespeichert
    class Quest
    {
        public int level { get; set; }
        public string text { get; set; }
        public int biomNummer { get; set; }

        public Quest(int minSpielerLevel, int biomNummer, string text)
        {
            this.level = minSpielerLevel;
            this.text = text;
            this.biomNummer = biomNummer;
        }
    }

    class Biom
    {
        public string BiomName { get; set; }
        public int[] gegnerNummer { get; set; }
        public int[] waffenNummer { get; set; }
        public int KartenGröße { get; set; }
        public Raum[] räume { get; set; }
        public bool[,] Karte { get; set; }

        public Biom(string BiomName, int[] gegnerNumer, int[] waffenNummer, int KartenGröße)
        {
            this.BiomName = BiomName;
            this.gegnerNummer = gegnerNumer;
            this.waffenNummer = waffenNummer;
            this.KartenGröße = KartenGröße;
            KarteGenerieren();
        }

        /*
         * Methode, um das Layout der Räume in einem Biom zu erstellen
         * ein walker geht immer in eine zufällige Richtung und setzt dort einen
         * Raum hin, bis er alle Räume platziert hat.
         */
        private void KarteGenerieren()
        {
            // in diesem array steht 1 für hier ist ein Raum und 0 für hier ist kein raum.
            Karte = new bool[räume.Length, räume.Length];

            // Diese Variablen geben an, wo sich der Generator gerade bedindet.
            int x = räume.Length / 2;
            int y = räume.Length / 2;

            // In der Mitte kommt erstmal ein Raum
            Karte[x, y] = true;

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
                if (x == Karte.GetLength(0)) x--;
                else if (x == -1) x++;

                if (y == Karte.GetLength(1)) y--;
                else if (y == -1) y++;

                // Raum eintragen
                if (!Karte[x, y])
                {
                    Karte[x, y] = true;
                    raumzähler++;
                }
            }

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

    class Gegner
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

    class Waffe
    {
        public string name { get; set; }
        public int stufe { get; set; }
        public double schadenProStufe { get; set; }
        public double maxSchadensAbweichung { get; set; }
        public double durchschnittlicheSchadensAbweichung { get; set; }
        public double schaden { get; set; }
        public Waffe(string name, int stufe, double schadenProStufe, double maxSchadensAbweichung, double durchschnittlicheSchadensAbweichung, double schaden)
        {
            schaden = Mathe.ZufallsGeneratorMitNormalverteilung(stufe * schadenProStufe - maxSchadensAbweichung, stufe * schadenProStufe + maxSchadensAbweichung, stufe * schadenProStufe, durchschnittlicheSchadensAbweichung);

        }
    }
}