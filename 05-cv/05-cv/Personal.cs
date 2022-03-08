using System;

namespace cv05
{
    public class PersonalErrorException : Exception
    {
        public PersonalErrorException(string message) : base(message) { }
    }
    public class Personal : Cars
    {
        private int MaxPersons;
        public int TransPersons;
        public Personal(int TransPersons, double Tank, Fuel fuel) {
            MaxPersons = 5;
            MaxTankSize = 70;
            if (TransPersons > MaxPersons || Tank > MaxTankSize) {throw new PersonalErrorException("Error: Zadej hodnoty mensi nez maximalni.");}
            else {this.TransPersons = TransPersons; this.Tank = Tank;}
        }
        public override string ToString() {return string.Format("Tank: {0}/{1} ; People: {2}/{3}", Tank, MaxTankSize, TransPersons, MaxPersons);}
    }
}