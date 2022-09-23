using System;

namespace ConsoleAdventureGame
{
    class Program
    {
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
        static void Main(string[] args)
        {
            // Test für Asuwahltexte
            Console.WriteLine(Auswahltexte(new string[] { "a", "b", "c", "d" }, "Hallo, jemand geift \n dich an, was machst \n du?"));
        }


        static double ZufallsGeneratorMitNormalverteilung(double min, double max, double erwartungsWert, double standartAbweichung)
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
        static double erf(double x)
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
        static double InversErf(double x)
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

        // Gibt die Auswahlmöglichkeiten aus und lässt den Benutzer eine auswählen.
        // Gibt als returnwert den Index des ausgewählten Textes zurück.
        // frageText gibt an, was gerade auf dem Bildschirm steht.
        static int Auswahltexte(string[] auswahlmöglichkeiten, string frageText)
        {
            int ausgewählterText = 0;
            ConsoleKey gedrückterKnopf;
            
            do
            {
                Console.Clear();
                Console.WriteLine(frageText);

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


                gedrückterKnopf = Console.ReadKey(false).Key;

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
        public Waffe(double stufe)
        {

        }
    }
}