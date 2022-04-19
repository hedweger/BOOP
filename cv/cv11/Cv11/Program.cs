using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv11
{
    class Program
    {
        static void Main(string[] args)
        {
            Views view = new Views();
            view.ShowView();

            StudentPredmety sp = new StudentPredmety();
            Console.WriteLine("");
            var students = sp.StudentiPredmetu("BOOP");
            foreach (Student student in students)
            {
                Console.WriteLine(student.Id + "; " + student.Jmeno + "; " + student.Prijmeni);
            }
            Console.WriteLine("");
            var predmets = sp.PredmetyStudenta(1003);
            foreach (Predmet predmet in predmets)
            {
                Console.WriteLine(predmet.Zkratka + "; " + predmet.Nazev);
            }

            Console.WriteLine("");
            HodnoceniData hd = new HodnoceniData();
            hd.VypisHodnoceni();
        }
    }
}

