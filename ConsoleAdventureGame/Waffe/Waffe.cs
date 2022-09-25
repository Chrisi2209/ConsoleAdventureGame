using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAdventureGame
{
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
