using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv11
{
    class HodnoceniData
    {
        DataClasses1DataContext dc = new DataClasses1DataContext();
        public void VypisHodnoceni()
        {
            var result = from Hodnoceni in dc.Hodnocenis
                         group Hodnoceni by Hodnoceni.ZkratkaPredmet into newGroup
                         orderby newGroup.Key
                         select newGroup;
                         
            
            foreach (var obj in result)
            {
                var avg = obj.Average(r => r.Znamka);
                foreach (var key in obj)
                {
                    Console.WriteLine(key.ZkratkaPredmet + "; " + avg.ToString());
                }
            }
        }
                        
    }
}
