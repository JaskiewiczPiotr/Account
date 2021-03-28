using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Hours
    {
        private int hour; // ta zmienna posiada właściwość
        private int second;
        private String zone;

        public int Hour // Definicja właściwość
        {
            get
            { return hour; }

            set
            {
                if ( value <= 12)
                {
                    hour = value;
                    second = value * 3600;
                    zone = "AM";
                }


                if (value >= 12)
                {
                    hour = value - 12;
                    second = value * 3600;
                    zone = "PM";
                }
                if (value == 24)
                {
                    hour = value - 12;
                    second = value * 3600;
                    zone = "AM";
                }
                if(value == 12)
                {
                    hour = value;
                    second = value * 3600;
                    zone = "PM";
                }
                if (value < 1 || value > 24)
                {
                    Console.WriteLine("Podana wartosc przekracza zakres");              
                }
            }

        }

        public string Info()
        {
            return "Godzina " + hour 
                + zone + " oraz " + second + " sekunda tej doby.";
        }
    }
}
