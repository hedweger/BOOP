using System;
using cv05;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            var tr = new Truck(50, 45, Cars.Fuel.Nafta);
            Console.WriteLine(tr);

            var per = new Personal(2, 45, Cars.Fuel.Benzin);
            Console.WriteLine("Pred tankovanim: " + per);

            per.FuelUp(Cars.Fuel.Benzin, 5);
            Console.WriteLine("Po tankovani: " + per);

            
            per.TurnOn(true);
            per.PresetInput(1, 826);
            per.Play(1);
            Console.WriteLine(per.Radio);
        }
        catch (TruckErrorException e) { Console.WriteLine("Chyba: {0}", e); }
        catch (PersonalErrorException e) { Console.WriteLine("Chyba: {0}", e); }   
        catch (FuelUpException e) { Console.WriteLine("Chyba: {0}", e); }
        catch (NoPresetException e) { Console.WriteLine("Chyba: {0}", e); }
        
    }
}