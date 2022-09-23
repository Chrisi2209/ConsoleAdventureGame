using System;
using System.Collections.Generic;

namespace ConsoleAdventureGame
{
    class Program
    {
        /* Stilvorschriften
         * 
         * Variablen: klein anfangen, weitere Wörter aneinander mit Großbuchstaben (camelcase) bsp: ichBinCool
         * Methoden, Klassen: Groß anfangen, weitere Wörter aneinander mit Großbuchstaben (pascalcase) bsp: IchBinCool
         * eigene Zeile für geschwungene Klammern 
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
