using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections;


namespace Kapitel2Beispiele
{

    class Program
    {
        //Kapitel 2 Summe der Zahlen 6,8,12 und 16
        public void summe()
        {
            int a = 6 + 8 + 12 + 16;
            Console.WriteLine(a);
        }
        //Kapitel 3 Fakultät der Zahl 9
        public static int fak(int zahl)
        {
            int wert = 1;
            int i = 2;
            while (i <= zahl)
            {
                wert = wert * i;
                i++;
            }
            return wert;
        }
        //Kapitel 4
        public static void fak1020()
        {
            int i = 10;
            while (i <= 20)
            {
                Console.WriteLine(fak(i));
                i++;
            }
        }
        //Kapitel 5
        public static double div(int dividend, int divisor)
        {
            double x = (double)dividend;
            double y = (double)divisor;
            double erg = x / y;

            return erg;
        }

        public static void split()
        {
            double erg = 1 * 2;
            double i = 3;
            double j = 4;
            while (i <= 99)
            {
                erg = erg / i * j;
                i = i + 2;
                j = j + 2;
            }
            Console.WriteLine(erg);
        }

        //Kapitel 6
        public static bool floatingEquality(double a, double b)
        {
            double a1 = a - 0.001;
            double a2 = a + 0.001;
            double b1 = b - 0.001;
            double b2 = b + 0.001;
            if (a == b || a1 == b || a2 == b || a == b1 || a == b2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        void charToAscii(char c)
        {
            //if()
        }

        bool simpleBoolDecider(double arg1, double arg2)
        {
            if ((arg1 < 5) && (arg1 + arg2 > 100))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        bool simpleBoolDecider2(double arg1, double arg2)
        {
            if ((arg1 > arg2) && (simpleBoolDecider(arg1, arg2) == true))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int maximumSum(int arg1)
        {
            int wert = 0;
            int i = 1;
            if (arg1 < 0)
            {
                wert = 0;
                return wert;
            }
            else
            {
                while (wert < arg1)
                {
                    wert = wert + i;
                    i++;
                }
                wert = wert - (i - 1);
                return wert;
            }
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Hier Wert eingeben: ");
            //string eingabe = Console.ReadLine();
            //double r = strToDouble(eingabe);
            //Console.WriteLine("Wert in double = " + r);
            //double percent = (r / 100) * 7;
            //double wachstum = percent + r;
           // Console.WriteLine("Wachstum = " + percent);
            //Console.WriteLine("Neu Gesamt = " + wachstum);

            //double[] geld = new double[31];

            //geld[0] = r;

           /* for(int i = 1; i < geld.Length; i++)
            {
                double p = (geld[i-1] / 100) * 7;
                double w = geld[i-1] + p;
                geld[i] = w;

            }*/
            //Console.WriteLine("Nach 4 Jahren: " + geld[3]);

            ArrayList warteliste = new ArrayList();
            warteliste.Add("Heinz");
            warteliste.Add("Dieter");
            warteliste.Add("Dirk");
            warteliste.Add("Bernd");
            warteliste.Add("Fritz");

            iOS iphone7 = new iOS("iPhone", 32, 10.1);
            iphone7.anrufen("iOS iPhone 7");

            Android galaxyS9 = new Android("galaxy", 16, "Samsung");
            galaxyS9.anrufen("Android Galaxy S9");
            Console.ReadLine();

            Console.WriteLine("How old are you?");
            string inp = Console.ReadLine();

            try
            {
                int alter = Int32.Parse(inp);
                Console.WriteLine("You are " + alter + " years old.");
            }
            catch(Exception e)
            {
                Console.WriteLine("You had not write down a number.");
            }
            finally
            {
                Console.WriteLine("Finish!");
            }
            Console.ReadLine();
                                    
        }
        public static double strToDouble(string x)
        {
            double wert;
            wert = Convert.ToDouble(x);
            return wert;
        }
    }

    class Mitarbeiter
    {
        private string name;
        private string vorname;
        private int gehalt;

        public Mitarbeiter(string name, string vorname, int gehalt)
        {
            this.name = name;
            this.vorname = vorname;
            this.gehalt = gehalt;
        }

        public void arbeiten()
        {
            Console.WriteLine("Ich arbeite!");
        }
        public void pausieren()
        {
            Console.WriteLine("Ich chille!");
        }
    }
    class Boss : Mitarbeiter
    {
        private string firmenwagen;

        public Boss(string firmenwagen, string name, string vorname, int gehalt) : base(name, vorname, gehalt)
        {
            this.firmenwagen = firmenwagen;
        }

        public void fuehren()
        {
            Console.WriteLine("Ich führe!");
        }
    }

    class Azubi : Mitarbeiter 
    {
        private int arbeitsstunden;
        private int schulstunden;

        public Azubi(int arbeitsstunden, int schulstunden, string name, string vorname, int gehalt) : base(name, vorname, gehalt) 
        {
            this.arbeitsstunden = arbeitsstunden;
            this.schulstunden = schulstunden;
        }

        public void lernen()
        {
            Console.WriteLine("Ich lerne " + schulstunden + "!");
        }
        public void arbeiten()
        {
            Console.WriteLine("Ich arbeite " + arbeitsstunden + "!");
        }
    }

    class Smartphone
    {
        string modell;
        int speicher;

        public Smartphone(string modell, int speicher)
        {
            this.modell = modell;
            this.speicher = speicher;
        }

        public void anrufen()
        {
            Console.WriteLine("Anruf läuft mit Smartphone.");
        }
    }

    class iOS : Smartphone
    {
        double version;
        public iOS(string modell, int speicher, double version) : base(modell, speicher)
        {
            this.version = version;
        }

        public void anrufen(string geraet)
        {
            Console.WriteLine("Anruf laeuft mit " + geraet + "-Smartphone.");
        }
    }

    class Android : Smartphone
    {
        string hersteller;
        public Android(string modell, int speicher, string hersteller):base(modell, speicher)
        {
            this.hersteller = hersteller;
        }
        public void anrufen(string geraet)
        {
            Console.WriteLine("Anruf laueft mit " + geraet + "-Smartphone");
        }
    }

    public class Kaffeemaschine
    {

        public double wasser
        {
            get;
            private set;
        }
        public double bohnen
        {
            get;
            private set;
        }
        public double gesamt
        {
            get;
            private set;
        }
        private static double maxWasser = 2.5;
        private static double maxBohnen = 2.5;


        public double wasserAuffuellen(double menge)
        {
            double fuellen = 0;
            if (menge <= maxWasser)
            {
                fuellen = maxWasser - menge;
            }
            return fuellen;

        }
        public double bohnenAuffuellen(double menge)
        {
            double fuellen = 0;
            if (menge < maxBohnen)
            {
                fuellen = maxBohnen - menge;
            }
            return fuellen;
        }
        public bool macheKaffee(double menge, double verhaeltnisWasserBohnen)
        {
            if (menge <= 0 || verhaeltnisWasserBohnen <= 0)
                return false;
            double bohnenAnteil = menge / (verhaeltnisWasserBohnen + 1);
            double wasserAnteil = menge - bohnenAnteil;

            if (bohnenAnteil > bohnen || wasserAnteil > wasser)
                return false;

            bohnen -= bohnenAnteil;
            wasser -= wasserAnteil;

            gesamt *= menge;
            return true;
        }

        public Kaffeemaschine()
        {
            wasser = 0;
            bohnen = 0;
            gesamt = 0;
        }

    }
}
