using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Homework
{
    public class HomeworkLoops
    {
        public static void Exercise1()
        {
            // Napisz program, który sprawdzi ile jest liczb pierwszych w zakresie 0 – 100.
            // Liczba pierwsza dzieli się przez 1 i przez siebie

            Console.WriteLine("Liczby pierwsze w zakresie 0 - 100: ");

            for (int i = 0; i <= 100; i++)
            {
                int numberOfDivisors = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        numberOfDivisors++;
                    }
                }
                if (numberOfDivisors == 2)
                {
                    Console.Write(i + " ");
                }
            }
        }
        public static void Exercise2()
        {
            //Napisz program, w którym za pomocą pętli do…while znajdziesz wszystkie liczby parzyste z zakresu 0 – 1000.

            Console.WriteLine("Liczby parzyste w zakresie 0 - 1000: ");

            int a = 0;

            do
            {
                if (a % 2 == 0)
                {
                    Console.Write(a + " ");
                }
                a++;

            } while (a <= 1000);
        }

        public static void Exercise3()
        {
            //Napisz program, który zaimplementuje ciąg Fibonacciego i wyświetli go na ekranie.

            Console.WriteLine("Napisz liczbę do której ma wykonać się ciąg Fibonacciego.");
            Int32.TryParse(Console.ReadLine(), out int n);

            int f1 = 0;
            int f2 = 1;

            for (int i = 0; i < n; i++)
            {
                Console.Write(f1 + " ");
                int fn = f1;
                f1 = f2;
                f2 = fn + f2;
            }
        }

        public static void Exercise4()
        {
            //Napisz program, który po podaniu liczby całkowitej wyświetli piramidę liczb od 1 do podanej liczby w formie jak poniżej:
            //1
            //2 3
            //4 5 6
            //7 8 9 10
            Console.WriteLine("Podaj liczbę całkowitą.");
            Int32.TryParse(Console.ReadLine(), out int a);

            int b = 0;

            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (b == a)
                    {
                        break;
                    }
                    b++;
                    Console.Write(b + " ");
                }
                Console.WriteLine();
            }
        }

        public static void Exercise5()
        {
            //Napisz program, który dla liczb od 1 do 20 wyświetli na ekranie ich 3 potęgę.

            Console.WriteLine("Potęgi 3 krotności liczb w zakresie od 1 do 20: ");
            for (int i = 1; i <= 20; i++)
            {
                Console.Write($"{Math.Pow(i, 3)}" + " ");
            }
        }

        public static void Exercise6()
        {
            //6.Napisz program, który dla liczb od 0 do 20 obliczy sumę wg wzoru: 1 + ½ +1 / 3 + ¼ itd.

            double result = 0;
            for (double i = 0; i <= 20; i++)
            {
                if (i != 0)
                {
                    result += (1 / i);
                }
            }
            Console.WriteLine("Wynik wg powyższego wzoru od 0 do 20: " + result);
        }

        public static void Exercise7()
        {

            //Napisz program, który dla liczby zadanej przez użytkownika narysuje diament o krótszej
            //przekątnej o długości wprowadzonej przez użytkownika i wg wzoru:

            Console.WriteLine("Podaj długość przekątnej.");
            Int32.TryParse(Console.ReadLine(), out int diagonalLenght);
            
                for (int i = 1; i <= diagonalLenght; i += 2)
                {

                    string star = new string('*', i);
                    string pauze = new string(' ', (diagonalLenght - i) / 2);
                    Console.WriteLine(pauze + star + pauze);
                }
                for (int i = diagonalLenght; i >= 0; i -= 2)
                {
                    if (i == diagonalLenght)
                        continue;
                    string star = new string('*', i);
                    string pauze = new string(' ', (diagonalLenght - i) / 2);
                    Console.WriteLine(pauze + star + pauze);
                }
        }

        public static void Exercise8()
        {
            //Napisz program, który odwróci wprowadzony przez użytkownika ciąg znaków. Np.
            //Testowe dane:
            //Abcdefg
            //Rezultat
            //Gfedcba
            Console.WriteLine("Napisz ciąg znaków: ");
            string text = Console.ReadLine();
            int length = text.Length - 1;
            int b = text.Length;
            for (int i = 0; i < b; i++)
            {
                Console.Write(text[length--]);
            }
        }

        public static void Exercise9()
        {
            //Napisz program, który zamieni liczbę dziesiętną na liczbę binarną.

            Console.WriteLine("Podaj liczbę dziesiętną, którą chcesz zamienić na zapis binarny.");
            Int32.TryParse(Console.ReadLine(), out int n);

            string binaryNumber = "";

            if (n == 0)
            {
                binaryNumber = "0";
            }
            else
            {
                while (n > 0)
                {
                    int rest = n % 2;
                    binaryNumber = rest + binaryNumber;
                    n = n / 2;
                }
            }
            Console.WriteLine($"Liczba binarna: {binaryNumber}");
        }

        public static void Exercise10()
        {
            //Napisz program, który znajdzie najmniejszą wspólną wielokrotność dla zadanych 2 liczb.

            Console.WriteLine("Podaj pierwszą liczbę.");
            Int32.TryParse(Console.ReadLine(), out int n1);
            Console.WriteLine("Podaj drugą liczbę.");
            Int32.TryParse(Console.ReadLine(), out int n2);

            int nww = 0;
            int higherNumber = Math.Max(n1, n2);


            for (int i = higherNumber; true; i++)
            {
                if ((i % n1 == 0) && (i % n2 == 0))
                {
                    nww = i;
                    break;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Największa wspólna wielokrotność liczb {n1} i {n2} to: {nww}");
        }


        // DODATKOWE ZADANIA


        public static void Exercise11()
        {
            //Napisz program, który wypisze liczby od 0 do podanej przez użytkownika. Pamiętaj o zachowaniu odpowiednich odstępów pomiędzy poszczególnymi liczbami.

            Console.WriteLine("Napisz cyfrę: ");
            Int32.TryParse(Console.ReadLine(), out int n);
            Console.WriteLine($"Oto twoje liczby w zakresie od 0 do {n}:");

            for (int i = 0; i <= n; i++)
            {
                Console.Write(i + " ");
            }
        }

        public static void Exercise12()
        {
            //Zmodyfikuj poprzedni program tak, żeby tym razem użytkownik mógł wybrać także liczbę początkową. Zwróć uwagę, czy wypisane są także liczby graniczne.

            do
            {
                Console.WriteLine("Podaj liczbę od której chcesz zacząć: ");
                Int32.TryParse(Console.ReadLine(), out int a);
                Console.WriteLine("Podaj liczbę na której chcesz skończyć: ");
                Int32.TryParse(Console.ReadLine(), out int b);


                if (a > b)
                {
                    Console.WriteLine("Podano zły zakres. Spróbój ponownie");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"Liczby w zakresie od {a} do {b}:");
                    for (int i = a; i <= b; i++)
                    {
                        Console.Write(i + " ");
                    }
                    break;
                }
            } while (true);
        }

        public static void Exercise13()
        {
            //Zmodyfikuj program z zad. 9. tak, żeby zamiast wypisywać liczby od 0, zaczął odliczać od liczby podanej przez użytkownika do zera.

            Console.WriteLine("Napisz cyfrę: ");
            Int32.TryParse(Console.ReadLine(), out int n);
            Console.WriteLine($"Oto twoje liczby w zakresie od 0 do {n}:");
            for (int i = n; i >= 0; i--)
            {
                Console.Write(i + " ");
            }
        }

        public static void Exercise14()
        {
            //Przerób poprzedni program tak, żeby odliczał tylko w obrębie zakresu podanego jak w zad. 10

            do
            {
                Console.WriteLine("Podaj początkową liczbę: ");
                Int32.TryParse(Console.ReadLine(), out int a);
                Console.WriteLine("Podaj końcową liczbę: ");
                Int32.TryParse(Console.ReadLine(), out int b);

                if (a < b)
                {
                    Console.WriteLine("Podano błędny zakres! Spróbuj ponownie.");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"Liczby w zakresie od {a} do {b}:");

                    for (int i = a; i >= b; i--)
                    {
                        Console.Write(i + " ");
                    }
                    break;
                }
            } while (true);
        }

        public static void Exercise15()
        {
            //Napisz program, który w konsoli wypisze tabliczkę mnożenia liczb od 1 do podanej liczby przez uzytkownika.

            Console.WriteLine("Podaj liczbę do, której będzie wykonywać się tabliczka mnożenia.");
            Int32.TryParse(Console.ReadLine(), out int n);
            Console.WriteLine($"Tabliczka mnożenia od 1 do {n}:");
            Console.WriteLine();
            Console.Write("       ");

            string podłoga = new string('_', (6 * n));

            //kolumna

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{i}".PadRight(6));
            }
            Console.WriteLine();
            Console.WriteLine("      " + podłoga);


            for (int i = 1; i <= n; i++)
            {
                Console.Write("  " + $"{i}".PadRight(4));
                for (int j = 1; j <= n; j++)
                {
                    Console.Write("|" + $"{i * j}".PadRight(5));
                }
                Console.WriteLine();
            }
        }
    }
}