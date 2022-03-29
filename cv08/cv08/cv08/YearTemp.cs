using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cv08
{
    class YearTemp
    {
        public double year;
        public List<double> monthTemp = new List<double>();
        private double maxTemp;
        private double minTemp;
        private double averageYearTemp;

        public YearTemp(double year, List<double> monthTemp)
        {
            this.year = year;
            this.monthTemp = monthTemp;
        }
        public double MaxTemp()
        {
            foreach (double temp in monthTemp) { if (temp > maxTemp) { maxTemp = temp; } } return maxTemp; 
        }
        public double MinTemp()
        {
             foreach (double temp in monthTemp) { if (temp < minTemp) { minTemp = temp; } } return minTemp; 
        }
        public double AverageYearTemp()
        {
            averageYearTemp = monthTemp.Average();
            return averageYearTemp;
         
        }

    }
}
