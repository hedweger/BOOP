namespace cv05
{
    public class Cars : AutoRadio
    {
         public enum Fuel {
            Benzin = 1, Nafta
        }
        protected double MaxTankSize;
        protected double Tank;
        protected Fuel fuel;

        public void FuelUp(Fuel fuel, double amount) {
            if (this.fuel != fuel) {throw new System.Exception("Incorrect fuel type.");}
            if (amount > (MaxTankSize - Tank)) {throw new System.Exception("Too much fuel: not enough room in the tank.");}
            else { Tank += amount; }
        }
       
    }
}