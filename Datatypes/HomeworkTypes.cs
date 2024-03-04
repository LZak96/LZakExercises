using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Datatypes
{
    public static class HomeworkTypes
    {
        public static void Exercise1()
        {
            // 1. Stwórz program, w którym zadeklarujesz zmienne dotyczące danych pracownika firmy. Dane które chcesz przetrzymywać to:
            // a.Imię, b.Nazwisko c.Wiek d.Płeć(‘m’ albo ‘k’) e.PESEL f.Numer pracownika(np. 2509324094)

            string name = "Łukasz";
            string surname = "Żak";
            int age = 28;
            char sex = 'm';
            string nrPesel = "12141256474";
            string employerNumber = "2509324094";

            Console.WriteLine("Imię: " + name);
            Console.WriteLine("Nazwisko: " + surname);
            Console.WriteLine("Płeć: " + sex);
            Console.WriteLine("Wiek: " + age);
            Console.WriteLine("Nr Pesel: " + nrPesel);
            Console.WriteLine("Nr Pracownika: " + employerNumber);
        }

        public static void Exercise2() 
        {
            //Napisz program, w którym stworzysz 3 zmienne z jedną literą, a następnie wypiszesz je w odwrotnej kolejności niż zostały zadeklarowane.

            char char1 = 'a';
            char char2 = 'b';
            char char3 = 'c';

            Console.WriteLine("Odwrotna kolejność liczb: " + char3 + char2 + char1);
        }


        public static void Exercise3()
        {
            //Napisz program, który na podstawie podanej szerokości i długości prostokąta wyliczy długość przekątnej. (Aby, obliczyć kwadrat liczby użyj metody Math.Pow())

            Console.WriteLine("Witam w programie, który oblicza długość przekątnej prostokąta.");
            Console.WriteLine("Podaj szerokość prostokąta");
            string fromConsole1 = Console.ReadLine();
            double width1 = double.Parse (fromConsole1);

            Console.WriteLine("Podaj długość prostokąta");
            string fromConsole2 = Console.ReadLine();
            double length1 = double.Parse (fromConsole2);

            double answer1 = Math.Sqrt(Math.Pow(width1, 2) + Math.Pow(length1, 2));
            Console.WriteLine("Obliczona długość przekątnej wynosi: " +answer1);
        }

        public static void Exercise4()
        {
            // Napisz program w którym stworzysz 2 zmienne liczbowe, oraz jedną tekstową, a następnie przypiszesz im następujące wartości: a. 10 b.Szkoła Dotneta c. 12,5
            // Pamiętaj o użyciu poprawnych typów danych.

            int variable1 = 10;
            string variable2 = "Szkoła Dotneta";
            double variable3 = 12.5;

            Console.Write($"Oto twoje dane: \r\n {variable1} \r\n {variable2} \r\n {variable3}");
        }


        public static void Exercise5()
        {
            // Napisz program w którym poprosisz użytkownika o jego dane personalne tj. Imię, nazwisko, numer telefonu, adres email, wzrost, waga(np. 85, 7), itp(postaraj się wymyślić jak najwięcej)
            // i spróbuj przekonwertować odpowiedź do odpowiedniego typu danych używając metody: typDanych.Parse(odpowiedźOdUżytkownika).

            Console.WriteLine("Dzień dobry, poniżej proszę uzupełnić swoje dane personalne.");
            Console.WriteLine("Podaj imię: ");
            string name = Console.ReadLine();

            Console.WriteLine("Podaj nazwisko: ");
            string surname = Console.ReadLine();

            int chosenOption;
            double chosenOption1;

            Console.WriteLine("Podaj wiek");
            string age = Console.ReadLine();
            Int32.TryParse (age, out chosenOption);

            Console.WriteLine("Podaj numer pesel: ");
            string nrPesel = Console.ReadLine();
            Int32.TryParse (nrPesel, out chosenOption);

            Console.WriteLine("Podaj numer telefonu: ");
            string nrPhone = Console.ReadLine();
            Int32.TryParse (nrPhone, out chosenOption);

            Console.WriteLine("Podaj email: ");
            string email = Console.ReadLine();

            Console.WriteLine("Podaj wzrost: ");
            string height = Console.ReadLine();
            Int32.TryParse (height, out chosenOption);

            Console.WriteLine("Podaj wagę: ");
            string weight = Console.ReadLine();
            double.TryParse(weight, out chosenOption1);

            Console.WriteLine("Podaj wykształcenie: ");
            string education = Console.ReadLine();
        }
    }
}