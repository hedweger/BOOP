namespace cv05
{
    public class Personal : Cars
    {
        private int MaxPersons;
        public int TransPersons;
        public Personal(int TransPersons, double Tank, Fuel fuel) {
            MaxPersons = 5;
            MaxTankSize = 70;
            TransPersons = 0;
            if (TransPersons > MaxPersons || Tank > MaxTankSize) {throw new System.Exception("Improper arguments, make sure they don't exceed the maximum.");}
            else {this.TransPersons = TransPersons; this.Tank = Tank;}
        }
        public override string ToString() {return string.Format("Tank:{0}/{1} ; People:{2}/{3}", Tank, MaxTankSize, TransPersons, MaxPersons);}
    }
}