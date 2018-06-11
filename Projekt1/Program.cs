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
        //---------------------------------------------------SUMA---------------------------------------------------------
        static float mgObliczenieSumy() //metoda do obliczenia sumy
        {
            float mgi, mgn, mgskladnik;
            float mgwynik = 0;

            Console.WriteLine("\nPodaj liczbe skladnikow do sumowania: ");
            while (!float.TryParse(Console.ReadLine(), out mgn))
                Console.WriteLine("Podany skladnik nie jest liczba, podaj wartosc jeszcze raz: ");
            for (mgi = 0; mgi < mgn; mgi++)
            {
                Console.WriteLine("\nPodaj skladnik [" + (mgi + 1) + "]");
                while (!float.TryParse(Console.ReadLine(), out mgskladnik))
                    Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");
                mgwynik += mgskladnik;
            }

            return mgwynik; // zwracanie wyniku

        }
        //----------------------------------------------ILOCZYN---------------------------------------------------------
        static float mgObliczenieIloczynu()
        {
            int mgi, mgn, mgskladnik;
            int mgwynik = 1;

            Console.WriteLine("\nPodaj liczbe skladnikow do mnozenia: ");
            while (!int.TryParse(Console.ReadLine(), out mgn))
                Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");
            for (mgi = 0; mgi < mgn; mgi++)
            {
                Console.WriteLine("\nPodaj skladnik [" + (mgi + 1) + "]");
                while (!int.TryParse(Console.ReadLine(), out mgskladnik))
                    Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");
                mgwynik *= mgskladnik;
            }

            return mgwynik; // zwracanie wyniku

        }
        //------------------------------------------ŚREDNIA ARYTMETYCZNA---------------------------------------------------------
        static float mgSredniaArytmetyczna()
        {
            int mgskladnik, mgn, mgi;
            float mgsuma = 0.0f;//suma składników
            float mgsrednia;

            Console.WriteLine("\nPodaj liczbe skladnikow do obliczenia sredniej arytmetycznej: ");
            while (!int.TryParse(Console.ReadLine(), out mgn))
                Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");

            for (mgi = 0; mgi < mgn; mgi++)
            {
                Console.WriteLine("\nPodaj skladnik [" + (mgi + 1) + "]");
                while (!int.TryParse(Console.ReadLine(), out mgskladnik))
                    Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");
                mgsuma += mgskladnik;
            }

            mgsrednia = mgsuma / mgn;
            return mgsrednia;

        }
        //------------------------------------------ŚREDNIA WAŻONA---------------------------------------------------------
        static float mgSredniaWazona()
        {
            int mgskladnik, mgn, mgi, mgwaga;
            float mgilo = 0.0f;
            float mgsumawag = 0.0f;
            float mgsrednia;

            Console.WriteLine("\nPodaj liczbe skladnikow do obliczenia sredniej wazonej: ");
            while (!int.TryParse(Console.ReadLine(), out mgn))
                Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");

            for (mgi = 0; mgi < mgn; mgi++)
            {
                Console.WriteLine("\nPodaj skladnik [" + (mgi + 1) + "]");
                while (!int.TryParse(Console.ReadLine(), out mgskladnik))
                    Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");
                Console.WriteLine("\nPodaj wage tego skladnika [" + (mgi + 1) + "]");
                while (!int.TryParse(Console.ReadLine(), out mgwaga))
                    Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");
                mgilo += mgskladnik * mgwaga;
                mgsumawag += mgwaga;
            }

            mgsrednia = mgilo / mgsumawag;
            return mgsrednia;

        }
        //------------------------------------------CENA JEDNOSTKI PASZY---------------------------------------------------------
        static float mgJednostkaPaszy()
        {
            float mgzyto, mgpszenica, mgowies, mgjeczmien, mgkukurydza, mgcenazyta, mgcenapszenicy, mgcenaowsa, mgcenajeczmienia, mgcenakukurydzy;

            Console.WriteLine("\nZ ilu kilogramow zyta ma sie skladac pasza: ");
            while (!float.TryParse(Console.ReadLine(), out mgzyto))
                Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");

            Console.WriteLine("\nPodaj cene za kilogram zyta: ");
            while (!float.TryParse(Console.ReadLine(), out mgcenazyta))
                Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");

            Console.WriteLine("\nZ ilu kilogramow pszenicy ma sie skladac pasza: ");
            while (!float.TryParse(Console.ReadLine(), out mgpszenica))
                Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");

            Console.WriteLine("\nPodaj cene za kilogram pszenicy: ");
            while (!float.TryParse(Console.ReadLine(), out mgcenapszenicy))
                Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");

            Console.WriteLine("\nZ ilu kilogramow owsa ma sie skladac pasza: ");
            while (!float.TryParse(Console.ReadLine(), out mgowies))
                Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");

            Console.WriteLine("\nPodaj cene za kilogram owsa: ");
            while (!float.TryParse(Console.ReadLine(), out mgcenaowsa))
                Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");

            Console.WriteLine("\nZ ilu kilogramow jeczmienia ma sie skladac pasza: ");
            while (!float.TryParse(Console.ReadLine(), out mgjeczmien))
                Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");

            Console.WriteLine("\nPodaj cene za kilogram jeczmienia: ");
            while (!float.TryParse(Console.ReadLine(), out mgcenajeczmienia))
                Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");

            Console.WriteLine("\nZ ilu kilogramow kukurydzy ma sie skladac pasza: ");
            while (!float.TryParse(Console.ReadLine(), out mgkukurydza))
                Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");

            Console.WriteLine("\nPodaj cene za kilogram kukurydzy: ");
            while (!float.TryParse(Console.ReadLine(), out mgcenakukurydzy))
                Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");

            float mgcenapaszy = ((mgzyto * mgcenazyta) + (mgpszenica * mgcenapszenicy) + (mgowies * mgcenaowsa) + (mgjeczmien * mgcenajeczmienia) + (mgkukurydza * mgcenakukurydzy));
            float mgsumacen = (mgcenazyta + mgcenapszenicy + mgcenaowsa + mgcenajeczmienia + mgcenakukurydzy);
            float mgcenajednostkipaszy = (mgcenapaszy / mgsumacen);

            return mgcenajednostkipaszy;

        }
        //------------------------------------------ŚREDNIA HARMONICZNA---------------------------------------------------------
        static double mgSredniaHarmoniczna()
        {
            int mgi, mgn;
            double mgskladnik, mgsrednia;
            double mgmianownik = 0.0;

            Console.WriteLine("\nPodaj liczbe skladnikow do obliczenia sredniej harmonicznej: ");
            while (!int.TryParse(Console.ReadLine(), out mgn))
                Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");

            for (mgi = 0; mgi < mgn; mgi++)
            {
                Console.WriteLine("\nPodaj skladnik [" + (mgi + 1) + "]");
                while (!double.TryParse(Console.ReadLine(), out mgskladnik))
                    Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");
                mgmianownik += (1 / mgskladnik);
            }

            mgsrednia = mgn / mgmianownik;
            return mgsrednia;

        }
        //------------------------------------------ŚREDNIA GEOMETRYCZNA---------------------------------------------------------
        static double mgSredniaGeometryczna()
        {
            int mgskladnik, mgi;
            double mgn, mgsrednia;
            double mgilo = 1;

            Console.WriteLine("\nPodaj liczbe skladnikow do obliczenia sredniej geometrycznej: ");
            while (!double.TryParse(Console.ReadLine(), out mgn))
                Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");

            for (mgi = 0; mgi < mgn; mgi++)
            {
                Console.WriteLine("\nPodaj skladnik [" + (mgi + 1) + "]");
                while (!int.TryParse(Console.ReadLine(), out mgskladnik))
                    Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");
                mgilo *= mgskladnik;
            }

            mgsrednia = Math.Pow(mgilo, (1 / mgn));
            return mgsrednia;

        }
        //------------------------------------------ŚREDNIA KWADRATOWA---------------------------------------------------------

        static double mgSredniaKwadratowa()
        {
            int mgskladnik, mgi;
            double mgn, mgsrednia, mgulamek;
            double mgsuma = 0;

            Console.WriteLine("\nPodaj liczbe skladnikow do obliczenia sredniej kwadratowej: ");
            while (!double.TryParse(Console.ReadLine(), out mgn))
                Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");

            for (mgi = 0; mgi < mgn; mgi++)
            {
                Console.WriteLine("\nPodaj skladnik [" + (mgi + 1) + "]");
                while (!int.TryParse(Console.ReadLine(), out mgskladnik))
                    Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");
                mgsuma += Math.Pow(mgskladnik, 2);
            }

            mgulamek = mgsuma / mgn;
            mgsrednia = Math.Sqrt(mgulamek);
            return mgsrednia;

        }
        //------------------------------------------ŚREDNIA POTĘGOWA---------------------------------------------------------
        static double mgSredniaPotegowa()
        {
            int mgskladnik, mgi;
            double mgn, mgulamek, mgsrednia, mgrzad;
            double mgsuma = 0;

            Console.WriteLine("\nPodaj liczbe skladnikow do obliczenia sredniej potegowej: ");
            while (!double.TryParse(Console.ReadLine(), out mgn))
                Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");
            Console.WriteLine("\nPodaj rzad sredniej potegowej: ");
            while (!double.TryParse(Console.ReadLine(), out mgrzad))
                Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");

            for (mgi = 0; mgi < mgn; mgi++)
            {
                Console.WriteLine("\nPodaj skladnik [" + (mgi + 1) + "]");
                while (!int.TryParse(Console.ReadLine(), out mgskladnik))
                    Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");
                mgsuma += Math.Pow(mgskladnik, mgrzad);
            }

            mgulamek = mgsuma / mgn;
            mgsrednia = Math.Pow(mgulamek, (1 / mgrzad));
            return mgsrednia;

        }
        //-----------------------------------------KONIEC METOD---------------------------------------------------------------
        static void Main(string[] args)
        {
            ConsoleKeyInfo mgWyborFunkcjonalnosci;
            //---------------------------------WYPISANIE DZIAŁAŃ DO WYBORU------------------------------------------------------
            do
            {
                Console.WriteLine("");
                Console.WriteLine("Wybierz dzialanie ktore chcesz wykonac: ");
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
                //---------------------------------KONIEC DZIAŁAŃ DO WYBORU------------------------------------------------------


                //------------------------------------WYBÓR FUNKCJONALNOŚCI------------------------------------------------------
                mgWyborFunkcjonalnosci = Console.ReadKey();

                if (mgWyborFunkcjonalnosci.Key == ConsoleKey.A)//SUMA
                {
                    int mgi, mgn, mgskladnik;
                    int mgwynik = 0;

                    Console.WriteLine("\nPodaj liczbe skladnikow do sumowania: ");
                    while (!int.TryParse(Console.ReadLine(), out mgn))
                        Console.WriteLine("Podany skladnik nie jest liczba, podaj wartosc jeszcze raz: ");
                    for (mgi = 0; mgi < mgn; mgi++)
                    {
                        Console.WriteLine("\nPodaj skladnik [" + (mgi + 1) + "]");
                        while (!int.TryParse(Console.ReadLine(), out mgskladnik))
                            Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");
                        mgwynik += mgskladnik;

                    }
                    Console.WriteLine("Wynik sumowania to: " + mgwynik);
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------");


                }
                else if (mgWyborFunkcjonalnosci.Key == ConsoleKey.B)//SUMA METHOD
                {

                    Console.WriteLine("Wynik sumowania to: " + mgObliczenieSumy());
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------");

                }
                else if (mgWyborFunkcjonalnosci.Key == ConsoleKey.C)//ILOCZYN
                {

                    int mgi, mgn, mgskladnik;
                    int mgwynik = 1;

                    Console.WriteLine("\nPodaj liczbe skladnikow do mnozenia: ");
                    while (!int.TryParse(Console.ReadLine(), out mgn))
                        Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");
                    for (mgi = 0; mgi < mgn; mgi++)
                    {
                        Console.WriteLine("\nPodaj skladnik [" + (mgi + 1) + "]");
                        while (!int.TryParse(Console.ReadLine(), out mgskladnik))
                            Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");
                        mgwynik *= mgskladnik;

                    }

                    Console.WriteLine("Wynik mnozenia to: " + mgwynik);
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------");

                }
                else if (mgWyborFunkcjonalnosci.Key == ConsoleKey.D)//ILOCZYN METHOD
                {
                    Console.WriteLine("Wynik mnozenia to: " + mgObliczenieIloczynu());
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
                }
                else if (mgWyborFunkcjonalnosci.Key == ConsoleKey.E)//SREDNIA ARYTMETYCZNA
                {
                    int mgskladnik, mgn, mgi;
                    float mgsuma = 0.0f;//suma składników
                    float mgsrednia;

                    Console.WriteLine("\nPodaj liczbe skladnikow do obliczenia sredniej arytmetycznej: ");
                    while (!int.TryParse(Console.ReadLine(), out mgn))
                        Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");

                    for (mgi = 0; mgi < mgn; mgi++)
                    {
                        Console.WriteLine("\nPodaj skladnik [" + (mgi + 1) + "]");
                        while (!int.TryParse(Console.ReadLine(), out mgskladnik))
                            Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");
                        mgsuma += mgskladnik;
                    }

                    mgsrednia = mgsuma / mgn;

                    Console.WriteLine("Srednia Arytmetyczna podanych skladnikow to: " + mgsrednia);
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
                }
                else if (mgWyborFunkcjonalnosci.Key == ConsoleKey.F)//SREDNIA ARYTMETYCZNA METHOD
                {
                    Console.WriteLine("Srednia Arytmetyczna podanych skladnikow to: " + mgSredniaArytmetyczna());
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
                }
                else if (mgWyborFunkcjonalnosci.Key == ConsoleKey.G)//SREDNIA WAZONA
                {
                    int mgskladnik, mgn, mgi, mgwaga;
                    float mgilo = 0.0f;
                    float mgsumawag = 0.0f;
                    float mgsrednia;

                    Console.WriteLine("\nPodaj liczbe skladnikow do obliczenia sredniej wazonej: ");
                    while (!int.TryParse(Console.ReadLine(), out mgn))
                        Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");

                    for (mgi = 0; mgi < mgn; mgi++)
                    {
                        Console.WriteLine("\nPodaj skladnik [" + (mgi + 1) + "]");
                        while (!int.TryParse(Console.ReadLine(), out mgskladnik))
                            Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");
                        Console.WriteLine("\nPodaj wage tego skladnika [" + (mgi + 1) + "]");
                        while (!int.TryParse(Console.ReadLine(), out mgwaga))
                            Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");
                        mgilo += mgskladnik * mgwaga;
                        mgsumawag += mgwaga;
                    }

                    mgsrednia = mgilo / mgsumawag;

                    Console.WriteLine("Srednia Wazona podanych skladnikow to: " + mgsrednia);
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
                }
                else if (mgWyborFunkcjonalnosci.Key == ConsoleKey.H)//SREDNIA WAZONA METHOD
                {
                    Console.WriteLine("Srednia Wazona podanych skladnikow to: " + mgSredniaWazona());
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
                }
                else if (mgWyborFunkcjonalnosci.Key == ConsoleKey.I)//CENA JEDNOSTKI PASZY
                {
                    float mgzyto, mgpszenica, mgowies, mgjeczmien, mgkukurydza, mgcenazyta, mgcenapszenicy, mgcenaowsa, mgcenajeczmienia, mgcenakukurydzy;

                    Console.WriteLine("\nZ ilu kilogramow zyta ma sie skladac pasza: ");
                    while (!float.TryParse(Console.ReadLine(), out mgzyto))
                        Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");

                    Console.WriteLine("\nPodaj cene za kilogram zyta: ");
                    while (!float.TryParse(Console.ReadLine(), out mgcenazyta))
                        Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");

                    Console.WriteLine("\nZ ilu kilogramow pszenicy ma sie skladac pasza: ");
                    while (!float.TryParse(Console.ReadLine(), out mgpszenica))
                        Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");

                    Console.WriteLine("\nPodaj cene za kilogram pszenicy: ");
                    while (!float.TryParse(Console.ReadLine(), out mgcenapszenicy))
                        Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");

                    Console.WriteLine("\nZ ilu kilogramow owsa ma sie skladac pasza: ");
                    while (!float.TryParse(Console.ReadLine(), out mgowies))
                        Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");

                    Console.WriteLine("\nPodaj cene za kilogram owsa: ");
                    while (!float.TryParse(Console.ReadLine(), out mgcenaowsa))
                        Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");

                    Console.WriteLine("\nZ ilu kilogramow jeczmienia ma sie skladac pasza: ");
                    while (!float.TryParse(Console.ReadLine(), out mgjeczmien))
                        Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");

                    Console.WriteLine("\nPodaj cene za kilogram jeczmienia: ");
                    while (!float.TryParse(Console.ReadLine(), out mgcenajeczmienia))
                        Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");

                    Console.WriteLine("\nZ ilu kilogramow kukurydzy ma sie skladac pasza: ");
                    while (!float.TryParse(Console.ReadLine(), out mgkukurydza))
                        Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");

                    Console.WriteLine("\nPodaj cene za kilogram kukurydzy: ");
                    while (!float.TryParse(Console.ReadLine(), out mgcenakukurydzy))
                        Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");

                    float mgcenapaszy = ((mgzyto * mgcenazyta) + (mgpszenica * mgcenapszenicy) + (mgowies * mgcenaowsa) + (mgjeczmien * mgcenajeczmienia) + (mgkukurydza * mgcenakukurydzy));
                    float mgsumacen = (mgcenazyta + mgcenapszenicy + mgcenaowsa + mgcenajeczmienia + mgcenakukurydzy);
                    float mgcenajednostkipaszy = mgcenapaszy / mgsumacen;

                    Console.WriteLine("Cena jednostki paszy to: " + mgcenajednostkipaszy);
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
                }
                else if (mgWyborFunkcjonalnosci.Key == ConsoleKey.J)//CENA JEDNOSTKI PASZY METHOD
                {
                    Console.WriteLine("Cena jednostki paszy to: " + mgJednostkaPaszy());
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
                }
                else if (mgWyborFunkcjonalnosci.Key == ConsoleKey.K)//SREDNIA HARMONICZNA
                {
                    int mgi, mgn;
                    double mgskladnik, mgsrednia;
                    double mgmianownik = 0.0;

                    Console.WriteLine("\nPodaj liczbe skladnikow do obliczenia sredniej harmonicznej: ");
                    while (!int.TryParse(Console.ReadLine(), out mgn))
                        Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");

                    for (mgi = 0; mgi < mgn; mgi++)
                    {
                        Console.WriteLine("\nPodaj skladnik [" + (mgi + 1) + "]");
                        while (!double.TryParse(Console.ReadLine(), out mgskladnik))
                            Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");
                        mgmianownik += (1 / mgskladnik);
                    }

                    mgsrednia = mgn / mgmianownik;

                    Console.WriteLine("Srednia Harmoniczna podanych skladnikow to: " + mgsrednia);
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
                }
                else if (mgWyborFunkcjonalnosci.Key == ConsoleKey.L)//SREDNIA HARMONICZNA METHOD
                {
                    Console.WriteLine("Srednia Harmoniczna podanych skladnikow to: " + mgSredniaHarmoniczna());
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
                }
                else if (mgWyborFunkcjonalnosci.Key == ConsoleKey.M)//SREDNIA GEOMETRYCZNA
                {
                    int mgskladnik, mgi;
                    double mgn, mgsrednia;
                    double mgilo = 1;

                    Console.WriteLine("\nPodaj liczbe skladnikow do obliczenia sredniej geometrycznej: ");
                    while (!double.TryParse(Console.ReadLine(), out mgn))
                        Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");

                    for (mgi = 0; mgi < mgn; mgi++)
                    {
                        Console.WriteLine("\nPodaj skladnik [" + (mgi + 1) + "]");
                        while (!int.TryParse(Console.ReadLine(), out mgskladnik))
                            Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");
                        mgilo *= mgskladnik;
                    }

                    mgsrednia = Math.Pow(mgilo, (1 / mgn));

                    Console.WriteLine("Srednia Geometryczna podanych skladnikow to: " + mgsrednia);
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
                }
                else if (mgWyborFunkcjonalnosci.Key == ConsoleKey.N)//SREDNIA GEOMETRYCZNA METHOD
                {
                    Console.WriteLine("Srednia Geometryczna podanych skladnikow to: " + mgSredniaGeometryczna());
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
                }
                else if (mgWyborFunkcjonalnosci.Key == ConsoleKey.O)//SREDNIA KWADRATOWA
                {
                    int mgskladnik, mgi;
                    double mgn, mgsrednia, mgulamek;
                    double mgsuma = 0;

                    Console.WriteLine("\nPodaj liczbe skladnikow do obliczenia sredniej kwadratowej: ");
                    while (!double.TryParse(Console.ReadLine(), out mgn))
                        Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");

                    for (mgi = 0; mgi < mgn; mgi++)
                    {
                        Console.WriteLine("\nPodaj skladnik [" + (mgi + 1) + "]");
                        while (!int.TryParse(Console.ReadLine(), out mgskladnik))
                            Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");
                        mgsuma += Math.Pow(mgskladnik, 2);
                    }

                    mgulamek = mgsuma / mgn;
                    mgsrednia = Math.Sqrt(mgulamek);

                    Console.WriteLine("Srednia Kwadratowa podanych skladnikow to: " + mgsrednia);
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
                }
                else if (mgWyborFunkcjonalnosci.Key == ConsoleKey.P)//SREDNIA KWADRATOWA METHOD
                {
                    Console.WriteLine("Srednia Kwadratowa podanych skladnikow to: " + mgSredniaKwadratowa());
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
                }
                else if (mgWyborFunkcjonalnosci.Key == ConsoleKey.Q)//SREDNIA POTEGOWA
                {
                    int mgskladnik, mgi;
                    double mgn, mgulamek, mgsrednia, mgrzad;
                    double mgsuma = 0;

                    Console.WriteLine("\nPodaj liczbe skladnikow do obliczenia sredniej potegowej: ");
                    while (!double.TryParse(Console.ReadLine(), out mgn))
                        Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");
                    Console.WriteLine("\nPodaj rzad sredniej potegowej: ");
                    while (!double.TryParse(Console.ReadLine(), out mgrzad))
                        Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");

                    for (mgi = 0; mgi < mgn; mgi++)
                    {
                        Console.WriteLine("\nPodaj skladnik [" + (mgi + 1) + "]");
                        while (!int.TryParse(Console.ReadLine(), out mgskladnik))
                            Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz: ");
                        mgsuma += Math.Pow(mgskladnik, mgrzad);
                    }

                    mgulamek = mgsuma / mgn;
                    mgsrednia = Math.Pow(mgulamek, (1 / mgrzad));

                    Console.WriteLine("Srednia Potegowa podanych skladnikow to: " + mgsrednia);
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
                }
                else if (mgWyborFunkcjonalnosci.Key == ConsoleKey.R)//SREDNIA POTEGOWA METHOD
                {
                    Console.WriteLine("Srednia Potegowa podanych skladnikow to: " + mgSredniaPotegowa());
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
                }

            } while (mgWyborFunkcjonalnosci.Key != ConsoleKey.X);
            Console.WriteLine("\nDziałanie programu zostało zakończone."); //koniec programu.
            Console.WriteLine("Autorem programu jest Mateusz Grzegrzółka");
            Console.ReadKey();
        }   
    }
}


