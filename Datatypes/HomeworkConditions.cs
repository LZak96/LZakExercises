using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Datatypes
{
    public class HomeworkConditions
    {
        public static void Exercise1()
        {
            //Napisz program w C#, który stworzy dwie zmienne int i sprawdzi czy są one równe czy nie.
            //Dane testowe: a: 5 b: 5 Rezultat w terminalu: 5 i 5 są równe

            int a = 5;
            int b = 5;

            if (a == b)
            {
                Console.WriteLine($"Brawo, liczba {a} i {b} są równe.");
            }
            else
            {
                Console.WriteLine($"Liczby {a} i {b} różnią się od siebie.");
            }
        }

        public static void Exercise2()
        {

            // Napisz program w C#, który sprawdzi czy podana przez użytkownika liczb jest parzysta czy nieparzysta.
            // Dane testowe : 15
            // Rezultat w terminalu: 15 jest liczbą nieparzystą

            Console.WriteLine("Podaj liczbę.");
            string fromConsole = Console.ReadLine();
            Int32.TryParse(fromConsole, out int a);

            if (a % 2 == 0)
            {
                Console.WriteLine($"Liczba {a} jest parzysta.");
            }
            else
            {
                Console.WriteLine($"Liczba {a} jest nieparzysta.");
            }
        }
        public static void Exercise3()
        {
            // Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest dodatnia czy ujemna.
            // Dane testowe : 14
            // Rezultat w terminalu: 14 jest liczbą dodatnią

            Console.WriteLine("Podaj liczbę.");
            string fromConsole = Console.ReadLine();
            Int32.TryParse(fromConsole, out int a);

            if (a > 0)
            {
                Console.WriteLine($"Liczba {a} jest dodatnia.");
            }
            else if (a < 0)
            {
                Console.WriteLine($"Liczba {a} jest ujemna.");
            }
            else
            {
                Console.WriteLine($"Liczba {a} jest zerem.");
            }
        }

        public static void Exercise4()
        {
            // Napisz program w C#, który sprawdzi czy podany przez użytkownika rok jest rokiem przestępnym. Dane testowe : 2016
            // Rezultat w terminalu: 2016 jest rokiem przestępnym

            Console.WriteLine("Podaj rok.");
            string fromConsole = Console.ReadLine();
            Int32.TryParse(fromConsole, out int a);

            if ((a % 4 == 0 && a % 100 != 0) || a % 400 == 0)
            {
                Console.WriteLine($"{a} jest rokiem przestępnym.");
            }
            else
            {
                Console.WriteLine($"{a} nie jest rokiem przestępnym.");
            }
        }

        public static void Exercise5()
        {
            //Napisz program w C#, który sprawdzi czy podany przez użytkownika wiek uprawnia go do ubiegania się o stanowisko posła, premiera, sentarora, prezydenta.
            //Dane testowe : 21
            //Rezultat w terminalu: Możesz zostać posłem
            //poseł 21, prezydent 35, premier , senator 30

            Console.WriteLine("Podaj swój wiek.");
            Int32.TryParse(Console.ReadLine(), out int age);

            if (age >= 35)
            {
                Console.WriteLine("Możesz zostać prezydentem.");
            }
            else if (age >= 30)
            {
                Console.WriteLine("Mozesz zostać senatorem.");
            }
            else if (age >= 21)
            {
                Console.WriteLine("Mozesz zostać posłem i premierem.");
            }
            else
            {
                Console.WriteLine("Niestety, jesteś za młody");
            }
        }
        public static void Exercise6()
        {
            // Napisz program w C#, który pobierze wzrost użytkownika i przypisze mu wymyśloną kategorię wzrostu. Dane testowe : 140
            // Rezultat w terminalu: Jesteś krasnoludem

            Console.WriteLine("Podaj swój wzrost");
            Int32.TryParse(Console.ReadLine(), out int height);

            if (height >= 500 && height <= 700)
            {
                Console.WriteLine("Jesteś drzewcem");
            }
            else if (height >= 300 && height < 500)
            {
                Console.WriteLine("Jesteś trollem");
            }
            else if (height > 160 && height < 300)
            {
                Console.WriteLine("Możesz być elfem lub człowiekiem");
            }
            else if (height > 120 && height <= 160)
            {
                Console.WriteLine("Jesteś krasnoludem");
            }
            else if (height <= 120)
            {
                Console.WriteLine("Jesteś hobbitem");
            }
            else
            {
                Console.WriteLine("Nie zidentyfikowano takiej postaci.");
            }
        }

        public static void Exercise7()
        {
            // Napisz program w C#, który pobierze 3 liczby od użytkownika i sprawdzi która jest największa. Dane testowe: 25, 63 79
            // Rezultat w terminalu: 79 jest największa z podanych

            Console.WriteLine("Podaj pierwszą liczbę");
            Int32.TryParse(Console.ReadLine(), out int a);

            Console.WriteLine("Podaj drugą liczbę");
            Int32.TryParse(Console.ReadLine(), out int b);

            Console.WriteLine("Podaj trzeciom liczbę");
            Int32.TryParse(Console.ReadLine(), out int c);

            if (a >= b && a >= c)
            {
                Console.WriteLine($"{a} jest najwięszka z podanych");
            }
            else if (b >= a && b >= c)
            {
                Console.WriteLine($"{b} jest najwięszka z podanych");
            }
            else
            {
                Console.WriteLine($"{c} jest najwięszka z podanych");
            }
        }
        public static void Exercise8()
        {

            // Napisz program, który sprawdzi, czy kandydat może ubiegać się o miejsce na studiach wg.Następujących kryteriów:
            // Wynik z Matury z matematyki powyżej 70
            // Wynik z fizyki powyżej 55
            // Wynik z chemii powyżej 45
            // Łączny wynik z 3 przedmiotów powyżej 180
            // Albo
            // Wynik z matematyki i jednego przedmiotu powyżej 150
            // Dane testowe:
            // Matematyka 80
            // Fizyka 71
            // Chemia 0
            // Rezultat w terminalu:
            // Kandydat dopuszczony do rekrutacji

            Console.WriteLine("Podaj wynik z matematyki.");
            Int32.TryParse(Console.ReadLine(), out int a);

            Console.WriteLine("Podaj wynik z fizyki.");
            Int32.TryParse(Console.ReadLine(), out int b);

            Console.WriteLine("Podaj wynik z chemii.");
            Int32.TryParse(Console.ReadLine(), out int c);

            if ((a > 70 && b > 55 && c > 45 && a + b + c >= 180) || (a + b > 150 || a + c > 150))
            {
                Console.WriteLine("Brawo! Kandydat dopuszczony do rekrutacji.");
            }
            else
            {
                Console.WriteLine("Niestety, spróbuj za rok.");
            }
        }

        public static void Exercise9()
        {

            // 9. Napisz program, który odczyta temperaturę I zwróci nazwę jak w poniższych kryteriach
            // Temp < 0 – cholernie piździ
            // Temp 0 – 10 – zimno
            // Temp 10 – 20 – chłodno
            // Temp 20 – 30 – w sam raz
            // Temp 30 – 40 – zaczyna być słabo, bo gorąco
            // Temp >= 40 – a weź wyprowadzam się na Alaskę.
            // Dane testowe : 41
            // Rezultat w terminalu: a weź wyprowadzam się na Alaskę.

            Console.WriteLine("Podaj temperaturę.");
            Int32.TryParse(Console.ReadLine(), out int temperature);

            switch (temperature)
            {
                case int n when (n <= 0):
                    Console.WriteLine("Cholernie piździ");
                    break;
                case int n when (n > 0 && n <= 10):
                    Console.WriteLine("Zimno");
                    break;
                case int n when (n > 10 && n <= 20):
                    Console.WriteLine("Chłodno");
                    break;
                case int n when (n > 20 && n <= 30):
                    Console.WriteLine("W sam raz");
                    break;
                case int n when (n > 30 && n < 40):
                    Console.WriteLine("Zaczyna być słabo, bo gorąco");
                    break;
                case int n when (n >= 40):
                    Console.WriteLine("Za gorąco");
                    break;
            }
        }

        public static void Exercise10()
        {

            //Napisz program, który sprawdzi, czy z 3 podanych długości można stworzyć trójkąt.
            //Dane testowe : 40 55 65
            //Rezultat w terminalu: Można zbudować trójkąt

            Console.WriteLine("Podaj pierwszą długość.");
            Int32.TryParse(Console.ReadLine(), out int lenght1);

            Console.WriteLine("Podaj drugą długość.");
            Int32.TryParse(Console.ReadLine(), out int lenght2);

            Console.WriteLine("Podaj trzecią długość.");
            Int32.TryParse(Console.ReadLine(), out int lenght3);

            if (lenght1 < lenght2 + lenght3 && lenght2 < lenght3 + lenght1 && lenght3 < lenght1 + lenght2)
            {
                Console.WriteLine("Z podanych długości można zbudować trójkąt.");
            }
            else
            {
                Console.WriteLine("Z podanych długości nie można zbudować trójkąta.");
            }
        }
    }
}