using System;
using System.Collections.Generic;

namespace cv05
{
    public class NoPresetException : Exception
    {
        public NoPresetException(string message) : base (message) { }
    }
    public class AutoRadio
    {
        protected bool RadioStatus;
        protected double SetFrequency;
        private Dictionary<int, double> Presets = new Dictionary<int, double>();

        public void TurnOnMess(bool RadioStatus)
        {
            Console.WriteLine("Radio je zapnuto: {0}", RadioStatus);
        }
        public void SavePreset(int number, double Frequency)
        {

            Presets.Add(number, Frequency);
        }
        public void PlayPreset(int number)
        {
            if (Presets.ContainsKey(number))
            {
                SetFrequency = Presets[number];
            }
            else { throw new NoPresetException("Předvolba neexistuje"); }
        }
        public override string ToString()
        {
            return string.Format("Naladěná frekvence: {1}", RadioStatus, SetFrequency);
        }
    }
}