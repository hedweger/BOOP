namespace cv05
{
    public class AutoRadio
    {
        private enum RadioStatus{
            Off = 0, On = 1
        }
        private double SetFrequency;
        private Dictionary<int,double> Presets;
        public SavePreset(int number, double Frequency) {

                Presets.Add(this.number, this.Frequency);
        }
        public PlayPreset(int number) {
            if (Presets.ContainsKey(number)) {
            SetFrequency = Presets[number];
            }
            else {throw new System.Exception("Předvolba neexistuje");}
        }
        public override string ToString()
        {
            return string.Format("Radio {0} ; Naladěná frekvence: {1}", RadioStatus, SetFrequency);
        }
    }
}