using System;

namespace cv05
{
    
    public class TruckErrorException : Exception
    {
        public TruckErrorException(string message) : base(message) { }
    }
    public class Truck : Cars
    {
        private int MaxLoad;
        public int TransLoad;
        public Truck(int TransLoad, double Tank, Fuel fuel) {
            MaxLoad = 100;
            MaxTankSize = 70;
            
            if (TransLoad > MaxLoad || Tank > MaxTankSize) {throw new TruckErrorException("Error: Zadej hodnoty mensi nez maximalni.");}
            else {this.TransLoad = TransLoad; this.Tank = Tank;}
        }
        public override string ToString() { return string.Format("Tank: {0}/{1} ; Load: {2}/{3}", Tank, MaxTankSize, TransLoad, MaxLoad); }
    }
}