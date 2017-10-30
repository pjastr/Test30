using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication34
{
    class Student:Osoba
    {
        private int rok;
        private int numerGrupy;
        private int numerAlbumu;

        public Student()
        {
            
        }

        public Student(string imie, string nazwisko, int rokUrodzenia, int rok, int numerGrupy, int numerAlbumu)
            
        {
            this.numerAlbumu = numerAlbumu;
            this.numerGrupy = numerGrupy;
            this.rok = rok;
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.rokUrodzenia = rokUrodzenia;
        }

        public void WypiszInfo()
        {
            Console.WriteLine("Imię i nazwisko: {0} {1}", imie, nazwisko);
            Console.WriteLine("Rok urodzenia: {0}", rokUrodzenia);
            Console.WriteLine("Numer grupy {0}", numerGrupy);
        }
    }
}
