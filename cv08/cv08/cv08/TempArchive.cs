using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace cv08
{
    class TempArchive
    {
        private SortedDictionary<double, YearTemp> _archiv;
        public void Load(string filename)
        {
            StreamReader reader = new StreamReader(filename);
            _archiv = new SortedDictionary<double, YearTemp>();
            string line = null;
            while ((line = reader.ReadLine()) != null)
            {
                double year = 0;
                double number;
                List<double> temp = new List<double>();
                line = line.Replace(" ", "");
                var values = line.Split(':',';').ToList();
                foreach (string word in values)
                {
                    if (!word.Contains(",")) { 
                        year = Convert.ToDouble(word); 
                    }
                    else
                    {
                        number = Convert.ToDouble(word);
                        temp.Add(number);
                    }   
                }
                _archiv.Add(year, new YearTemp(year, temp));
            }

        }
        public void Save(string filename)
        {
            StreamWriter writer = File.CreateText(filename);
            foreach (var item in _archiv.Values)
            {
                writer.Write("{0}: ", item.year);
                for (int i = 0; i < item.monthTemp.Count; i++)
                {
                    if (i + 1 == item.monthTemp.Count)
                        writer.Write("{0} ", item.monthTemp[i]);
                    else
                        writer.Write("{0}; ", item.monthTemp[i]);
                }
                writer.WriteLine();
            }
            writer.Close();
            Console.WriteLine("Saved!");
        }
        public void PrintTemps()
        {
            foreach (var item in _archiv.Values)
            {
                Console.Write("{0}: ", item.year);
                for (int i = 0; i < item.monthTemp.Count; i++)
                {
                    if (i + 1 == item.monthTemp.Count)
                        Console.Write("{0} ", item.monthTemp[i]);
                    else
                        Console.Write("{0}; ", item.monthTemp[i]);
                }
                Console.WriteLine();
            }
        }
        public void PrintAverageTemps()
        {
            foreach (var item in _archiv.Values)
            {
                Console.Write("{0}: ", item.year);        
                Console.Write("{0} ", item.AverageYearTemp());
                Console.WriteLine();
            }
        }
        public void PrintAverageMonthlyTemps()
        {
            List<double> AverageMonthly = new List<double>() { 0,1,2,3,4,5,6,7,8,9,10,11 };
            foreach (var item in _archiv.Values)
            {
                for (int i = 0; i < item.monthTemp.Count; i++)
                {
                    AverageMonthly[i] += item.monthTemp[i];
                }
            }
            for (int i = 0; i < AverageMonthly.Count; i++)
            {
                AverageMonthly[i] = AverageMonthly[i] / _archiv.Keys.Count;
                Console.Write("{0} ", AverageMonthly[i]);
            }
        }
        public void Calibrate(double calibration)
        {
            foreach (var item in _archiv.Values)
            {
                for (int i = 0; i < item.monthTemp.Count; i++)
                {
                    item.monthTemp[i] += calibration;
                }
            }
            PrintTemps();
        }
        public void Find (int year)
        {
            if (_archiv.ContainsKey(year))
            {
                Console.Write("{0}: ", year);
                foreach (var item in _archiv[year].monthTemp)
                {
                    Console.Write("{0}; ", item);
                }
            }
            else
                Console.Write("Not found");
        }
        
    } 
}
