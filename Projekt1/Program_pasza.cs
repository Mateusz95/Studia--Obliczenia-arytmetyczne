using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1_Grzegrzółka46792
{
    class Program
    {
        //---------------------------------------------METODY DO OBLICZEŃ---------------------------------------------------------
        //---------------------------------------------SUMA---------------------------------------------------------
        static float mgObliczenieSumy() //metoda do obliczenia sumy
        {
            int mgi, mgn, mgwynik;
            
            Console.WriteLine("\nPodaj liczbe skladnikow do sumowania:");
            while (!int.TryParse(Console.ReadLine(), out mgn))
                Console.WriteLine("Podany skladnik nie jest liczba, podaj wartosc jeszcze raz: ");
            int []mga = new int[mgn];
            for (mgi = 0; mgi < mgn; mgi++)
            {
                Console.WriteLine("Podaj skladnik [" + (mgi+1) + "]");
                while (!int.TryParse(Console.ReadLine(), out mga[mgi]))
                    Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");
            }
            mgwynik = 0;
            for (mgi = 0; mgi < mgn; mgi++)
            {
                mgwynik += mga[mgi];
            }
            return mgwynik; // zwracanie wyniku

        }
        //---------------------------------------------ILOCZYN---------------------------------------------------------
        static float mgObliczenieIloczynu()
        {
            int mgi, mgn, mgwynik;

            Console.WriteLine("\nPodaj liczbe skladnikow do mnozenia:");
            while (!int.TryParse(Console.ReadLine(), out mgn))
                Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");
            int[] mga = new int[mgn];
            for (mgi = 0; mgi < mgn; mgi++)
            {
                Console.WriteLine("Podaj skladnik [" + (mgi + 1) + "]");
                while (!int.TryParse(Console.ReadLine(), out mga[mgi]))
                    Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");
            }
            mgwynik = 1;
            for (mgi = 0; mgi < mgn; mgi++)
            {
                mgwynik *= mga[mgi];
            }
            return mgwynik; // zwracanie wyniku
        }
        //------------------------------------------ŚREDNIA ARYTMETYCZNA---------------------------------------------------------
       static float mgSredniaArytmetyczna()
        {
            int mga, mgn, mgi;
            float mgs = 0.0f;
            float mgsra;
            Console.WriteLine("\nPodaj liczbe skladnikow do obliczenia sredniej arytmetycznej:");
            while (!int.TryParse(Console.ReadLine(), out mgn))
                Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");

            for (mgi = 0; mgi < mgn; mgi++)
            {
                Console.WriteLine("Podaj skladnik [" + (mgi + 1) + "]");
                while (!int.TryParse(Console.ReadLine(), out mga))
                    Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");
                mgs += mga;
            }
            mgsra = mgs / mgn;
            return mgsra;

        }
        //------------------------------------------ŚREDNIA WAŻONA---------------------------------------------------------
static float mgSredniaWazona()
        {
            int mga, mgn, mgi, mgw;
            float mgilo = 0.0f;
            float mgsumwaz = 0.0f;
            float mgsrw;
            Console.WriteLine("\nPodaj liczbe skladnikow do obliczenia sredniej wazonej:");
            while (!int.TryParse(Console.ReadLine(), out mgn))
                Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");

            for (mgi = 0; mgi < mgn; mgi++)
            {
                Console.WriteLine("Podaj skladnik [" + (mgi + 1) + "]");
                while (!int.TryParse(Console.ReadLine(), out mga))
                    Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");
                Console.WriteLine("Podaj wage tego skladnika [" + (mgi + 1) + "]");
                while (!int.TryParse(Console.ReadLine(), out mgw))
                    Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");
                mgilo += mga*mgw ;
                mgsumwaz += mgw;
            }
            mgsrw = mgilo / mgsumwaz;
            return mgsrw;

        }
        //------------------------------------------CENA JEDNOSTKI PASZY---------------------------------------------------------
        static float mgJednostkaPaszy()
        {
            ConsoleKeyInfo mgzboze;
            int mgn, mgi, mgprocent;
            float mgilo = 0.0f;
            float mgcena = 0.0f;
            float mgpsum = 0.0f;
            Console.WriteLine("\nPodaj liczbe skladnikow (od 1 do 5) do obliczenia jednostki paszy:");
            while (!int.TryParse(Console.ReadLine(), out mgn))
                Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");
            Console.WriteLine("Skladniki paszy: ");
            Console.WriteLine("A. Zyto");
            Console.WriteLine("B. Jeczmien");
            Console.WriteLine("C. Owies");
            Console.WriteLine("D. Pszenica");
            Console.WriteLine("E. Kukurydza");
            do
            {
                for (mgi = 0; mgi < mgn; mgi++)
                {

                    Console.WriteLine("Wybierz skladnik paszy za pomoca litery [" + (mgi + 1) + "]");
                    mgzboze = Console.ReadKey();
                    if (mgzboze.Key == ConsoleKey.A)
                    {
                        mgcena = 540;
                        Console.WriteLine("\nWybrales zyto, jego cena za tone to: " + mgcena + " zl.");
                    }
                    else if (mgzboze.Key == ConsoleKey.B)
                    {
                        mgcena = 590;
                        Console.WriteLine("\nWybrales jeczmien, jego cena za tone to: " + mgcena + " zl.");
                    }
                    else if (mgzboze.Key == ConsoleKey.C)
                    {
                        mgcena = 500;
                        Console.WriteLine("\nWybrales owies, jego cena za tone to: " + mgcena + " zl.");
                    }
                    else if (mgzboze.Key == ConsoleKey.D)
                    {
                        mgcena = 650;
                        Console.WriteLine("\nWybrales pszenice, jej cena za tone to: " + mgcena + " zl.");
                    }
                    else if (mgzboze.Key == ConsoleKey.E)
                    {
                        mgcena = 360;
                        Console.WriteLine("\nWybrales kukurydze, jej cena za tone to: " + mgcena + " zl.");
                    }
                    Console.WriteLine("Podaj zawartosc skladnika w procentach [" + (mgi + 1) + "]");
                    while (!int.TryParse(Console.ReadLine(), out (mgprocent)))
                        Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");
                    /*Console.WriteLine("Podaj cene za 1 KG tego skladnika [" + (mgi + 1) + "]");
                    while (!int.TryParse(Console.ReadLine(), out mgcena))
                        Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");*/
                    mgilo += ((mgprocent/100) * mgcena);
                    mgpsum += mgprocent;
                }
            } while (mgpsum != 100);
            return mgilo;
        }


        //---------------------------------------KONIEC METOD---------------------------------------------------------------
        static void Main(string[] args)
        {
            ConsoleKeyInfo mgWyborFunkcjonalnosci;
            //-------------------WYPISANIE DZIAŁAŃ DO WYBORU------------------------------------------------------
            do
            {

                Console.WriteLine("Wybierz działanie ktore chcesz wykonac: ");
                Console.WriteLine("A. Obliczenie sumy <in-line>");
                Console.WriteLine("B. Obliczenie sumy <method-call>");
                Console.WriteLine("C. Obliczenie iloczynu <in-line>");
                Console.WriteLine("D. Obliczenie iloczynu <method-call>");
                Console.WriteLine("E. Obliczenie sredniej arytmetycznej <in-line>");
                Console.WriteLine("F. Obliczenie sredniej arytmetycznej <method-call>");
                Console.WriteLine("G. Obliczenie sredniej wazonej <in-line>");
                Console.WriteLine("H. Obliczenie sredniej wazonej <method-call>");
                Console.WriteLine("I. Obliczenie ceny jednostki paszy <in-line>");
                Console.WriteLine("J. Obliczenie ceny jednostki paszy <method-call>");
                Console.WriteLine("K. Obliczenie sredniej harmonicznej <in-line>");
                Console.WriteLine("L. Obliczenie sredniej harmonicznej <method-call>");
                Console.WriteLine("M. Obliczenie sredniej geometrycznej <in-line>");
                Console.WriteLine("N. Obliczenie sredniej geometrycznej <method-call>");
                Console.WriteLine("O. Obliczenie sredniej kwadratowej <in-line>");
                Console.WriteLine("P. Obliczenie sredniej kwadratowej <method-call>");
                Console.WriteLine("Q. Obliczenie sredniej potegowej <sredniej uogolnionej> <in-line>");
                Console.WriteLine("R. Obliczenie sredniej potegowej <sredniej uogolnionej> <method-call>");
                Console.WriteLine("X. Zakonczenie (wyjscie z) programu");
                //-------------------KONIEC DZIAŁAŃ DO WYBORU------------------------------------------------------
                
                
                //-------------------WYBÓR FUNKCJONALNOŚCI------------------------------------------------------
                mgWyborFunkcjonalnosci = Console.ReadKey();

                if (mgWyborFunkcjonalnosci.Key == ConsoleKey.A)
                {
                    int mgi, mgn, mgwynik;

                    Console.WriteLine("\nPodaj liczbe skladnikow do sumowania:");
                    while (!int.TryParse(Console.ReadLine(), out mgn))
                        Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");
                    int[] mga = new int[mgn];
                    for (mgi = 0; mgi < mgn; mgi++)
                    {
                        Console.WriteLine("Podaj skladnik [" + (mgi + 1) + "]");
                        while (!int.TryParse(Console.ReadLine(), out mga[mgi]))
                            Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");
                    }
                    mgwynik = 0;
                    for (mgi = 0; mgi < mgn; mgi++)
                    {
                        mgwynik += mga[mgi];
                    }
                    Console.WriteLine("Wynik sumowania to: " + mgwynik);
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------");


                }
                else if (mgWyborFunkcjonalnosci.Key == ConsoleKey.B)
                {

                    Console.WriteLine("Wynik sumowania to: " + mgObliczenieSumy());
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------");

                }
                else if (mgWyborFunkcjonalnosci.Key == ConsoleKey.C)
                {

                    int mgi, mgn, mgwynik;

                    Console.WriteLine("\nPodaj liczbe skladnikow do mnozenia:");
                    while (!int.TryParse(Console.ReadLine(), out mgn))
                        Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");
                    int[] mga = new int[mgn];
                    for (mgi = 0; mgi < mgn; mgi++)
                    {
                        Console.WriteLine("Podaj skladnik [" + (mgi + 1) + "]");
                        while (!int.TryParse(Console.ReadLine(), out mga[mgi]))
                            Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");
                    }
                    mgwynik = 1;
                    for (mgi = 0; mgi < mgn; mgi++)
                    {
                        mgwynik *= mga[mgi];
                    }
                    Console.WriteLine("Wynik mnozenia to: " +mgwynik);
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------");

                }
                else if (mgWyborFunkcjonalnosci.Key == ConsoleKey.D)
                {
                    Console.WriteLine("Wynik mnozenia to: " + mgObliczenieIloczynu());
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
                }
                else if (mgWyborFunkcjonalnosci.Key == ConsoleKey.E)
                {
                    int mga, mgn, mgi;
                    float mgs = 0.0f;
                    float mgsra;
                    Console.WriteLine("\nPodaj liczbe skladnikow do obliczenia sredniej arytmetycznej:");
                    while (!int.TryParse(Console.ReadLine(), out mgn))
                        Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");

                    for (mgi = 0; mgi < mgn; mgi++)
                    {
                        Console.WriteLine("Podaj skladnik [" + (mgi + 1) + "]");
                        while (!int.TryParse(Console.ReadLine(), out mga))
                            Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");
                        mgs += mga;
                    }
                    mgsra = mgs / mgn;
                    Console.WriteLine("\nSrednia Arytmetyczna podanych skladnikow to: " + mgsra);
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
                }
                else if (mgWyborFunkcjonalnosci.Key == ConsoleKey.F)
                {
                    Console.WriteLine("\nSrednia Arytmetyczna podanych skladnikow to: " + mgSredniaArytmetyczna());
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
                }
                else if (mgWyborFunkcjonalnosci.Key == ConsoleKey.G)
                {
                    int mga, mgn, mgi, mgw;
                    float mgilo = 0.0f;
                    float mgsumwaz = 0.0f;
                    float mgsrw;
                    Console.WriteLine("\nPodaj liczbe skladnikow do obliczenia sredniej wazonej:");
                    while (!int.TryParse(Console.ReadLine(), out mgn))
                        Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");

                    for (mgi = 0; mgi < mgn; mgi++)
                    {
                        Console.WriteLine("Podaj skladnik [" + (mgi + 1) + "]");
                        while (!int.TryParse(Console.ReadLine(), out mga))
                            Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");
                        Console.WriteLine("Podaj wage tego skladnika [" + (mgi + 1) + "]");
                        while (!int.TryParse(Console.ReadLine(), out mgw))
                            Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");
                        mgilo += mga * mgw;
                        mgsumwaz += mgw;
                    }
                    mgsrw = mgilo / mgsumwaz;
                    Console.WriteLine("\nSrednia Arytmetyczna podanych skladnikow to: " + mgsrw );
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
                }
                else if (mgWyborFunkcjonalnosci.Key == ConsoleKey.H)
                {
                    Console.WriteLine("\nSrednia Arytmetyczna podanych skladnikow to: " + mgSredniaWazona());
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
                }
                else if (mgWyborFunkcjonalnosci.Key == ConsoleKey.I)
                {
                    Console.WriteLine("\nSrednia Arytmetyczna podanych skladnikow to: " );
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
                }
                else if (mgWyborFunkcjonalnosci.Key == ConsoleKey.J)
                {
                    Console.WriteLine("\nCena jednostki paszy podanych skladnikow to: " + mgJednostkaPaszy()+ " za KG");
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
                }
            } while (mgWyborFunkcjonalnosci.Key != ConsoleKey.X);
            Console.WriteLine("Działanie programu zostało zakończone"); //koniec programu.
        }
        //-------------------KONIEC WYBORU FUNKCJONALNOŚCI------------------------------------------------------
    }

}
