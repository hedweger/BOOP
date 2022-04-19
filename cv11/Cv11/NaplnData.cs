using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv11
{
    class NaplnData
    {
        DataClasses1DataContext dc = new DataClasses1DataContext();
        public void AddStudent(int id, string name, string surname, DateTime date)
        {
            if (!dc.Students.Any(u => u.Id == id))
            {
                dc.Students.InsertOnSubmit(new Student() { Id = id, Jmeno = name, Prijmeni = surname, DatumNarozeni = date });
            }
            else
                Console.WriteLine("Student uz existuje");
            dc.SubmitChanges();
        }
        public void AddClass(string name, string fullname)
        {
            if (!dc.Predmets.Any(u => u.Zkratka == name))
            {
                dc.Predmets.InsertOnSubmit(new Predmet() { Zkratka = name, Nazev = fullname });
            }
            else
                Console.WriteLine("Predmet uz existuje");
            dc.SubmitChanges();
        }
    }
}
