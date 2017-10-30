using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication34
{
    class Osoba
    {
        protected string imie;
        protected string nazwisko;
        protected int rokUrodzenia;
        private string miejsceZamieszkania;

        public string MiejsceZamieszkania
        {
            get { return miejsceZamieszkania; }
            set { miejsceZamieszkania = value; }
        }



        public Osoba()
        {

        }

        public Osoba(string imie, string nazwisko, int rokUrodzenia)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.rokUrodzenia = rokUrodzenia;
        }

        public void WypiszInfo()
        {
            Console.WriteLine("Imię i nazwisko: {0} {1}", imie, nazwisko);
            Console.WriteLine("Rok urodzenia: {0}", rokUrodzenia);
        }

        public int ObliczWiek()
        {
            return DateTime.Now.Year - rokUrodzenia;
        }
    }
}
