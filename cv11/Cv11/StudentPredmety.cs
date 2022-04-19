using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv11
{
    class StudentPredmety
    {
        DataClasses1DataContext dc = new DataClasses1DataContext();
        public IEnumerable<Student> StudentiPredmetu(string id)
        {
            var result = dc.StudentPredmets.Where(d => d.ZkratkaPredmet.Equals(id));
            IEnumerable<Student> students = Enumerable.Empty<Student>();
            foreach (var obj in result)
            {
                IEnumerable<Student> local = dc.Students.Where(d => d.Id.Equals(obj.IdStudent));
                if (local != null)
                    students = students.Concat(local);
              
            }
            return students;
           

        }
        public IEnumerable<Predmet> PredmetyStudenta(int id)
        {
            var result = dc.StudentPredmets.Where(d => d.IdStudent.Equals(id));
            IEnumerable<Predmet> predmets = Enumerable.Empty<Predmet>();
            foreach (var obj in result)
            {
                IEnumerable<Predmet> local = dc.Predmets.Where(d => d.Zkratka.Equals(obj.ZkratkaPredmet));
                if (local != null)
                    predmets = predmets.Concat(local);

            }
            return predmets;
        }
    }
}
