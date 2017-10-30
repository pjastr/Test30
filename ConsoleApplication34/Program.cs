using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication34
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student student1 = new Student("Jan", "Nowak", 1992, 3, 2, 56789);
            //Console.WriteLine(student1.ObliczWiek());
            //student1.MiejsceZamieszkania = "Olsztyn";
            //Osoba student2 = new Student("Jan", "Nowak", 1992, 3, 2, 56789);
            //student2.WypiszInfo();

            Student student3 = new Student("Jan", "Nowak", 1992, 3, 2, 56789);
            Osoba osoba3 = student3;
            Student student4 = (Student)osoba3;
            student4.WypiszInfo();
            Console.ReadKey();
        }
    }
}
