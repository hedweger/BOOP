using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv11
{
    class Views
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public void ShowView()
        {
            var result = from View in db.Views
                         select new
                         {
                             col1 = View.ZkratkaPredmet,
                             col2 = View.PocetStudent.ToString()
                         };
            var sorted = result.OrderByDescending(ps => ps.col2);
            foreach (var predmet in sorted)
            {
               Console.WriteLine(predmet.col1 + ": " + predmet.col2);
            }
        }
    }
}
