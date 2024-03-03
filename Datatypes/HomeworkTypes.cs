using System;
using System.Collections.Generic;
using System.Linq;
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
            int width1 = Int32.Parse(fromConsole1);
            Console.WriteLine("Podaj długość prostokąta");
            string fromConsole2 = Console.ReadLine();
            int length1 = Int32.Parse(fromConsole2);

            Console.WriteLine("Obliczona długość przekątnej wynosi: ");
        }
    }
}