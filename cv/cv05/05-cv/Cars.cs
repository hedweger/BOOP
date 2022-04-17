using System;
using System.Collections.Generic;

namespace cv05
{
    public class FuelUpException : Exception
    {
        public FuelUpException(string message) : base(message) { }
    }
  
    public class Cars
    {
         public enum Fuel {
            Benzin, Nafta
        }
        protected double MaxTankSize;
        protected double Tank;
        protected Fuel fuel;

        public void FuelUp(Fuel Fuel, double amount) {
            if ( fuel.Equals(Fuel) && (MaxTankSize - Tank) > amount) { Tank += amount; }           
           else { throw new FuelUpException("Nespravne zadane hodnoty"); }
        }
        public AutoRadio Radio = new AutoRadio();
        
        public void TurnOn (bool status)
        {
            Radio.TurnOnMess(status);
        }
        public void PresetInput (int number, double frequency)
        {
            Radio.SavePreset(number, frequency);
        }
        public void Play(int number)
        {
            Radio.PlayPreset(number);
        }

    }
}