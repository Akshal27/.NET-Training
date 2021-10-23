using System;

namespace Partial_Interface
{
    public delegate void PartialMethoDelegate();
    public partial interface ITropCyclone
    {

         void Composition(string componentOne, string ComponentTwo, string componentThree);
       
         void WarningCentres(string warnCentre);

         void Factors(string factorOne,string factorTwo, string factorThree, string factorFour, string factorFive, string factorSix);
         void Speed(int knots);
         void Effects(string effectOne, string effectTwo, string effectThree, string effectFour, string effectFive);
    
    }

    class TropicalCyclone : ITropCyclone
    {
        public void Composition(string componentOne, string ComponentTwo, string componentThree)
        {
            
            Console.WriteLine("componentOne is {0}", componentOne);
            Console.WriteLine("componentTwo is {0}", ComponentTwo);
            Console.WriteLine("componentThree is {0}", componentThree);
            //throw new NotImplementedException();
        }

        public void Effects(string effectOne, string effectTwo, string effectThree, string effectFour, string effectFive)
        {
            Console.WriteLine("effectOne is {0}",effectOne);
            Console.WriteLine("effectTwo is {0}", effectTwo);
            Console.WriteLine("effectThree is {0}", effectThree);
            Console.WriteLine("effectFour is {0}", effectFour);
            Console.WriteLine("effectFive is {0}", effectFive);
           //throw new NotImplementedException();
        }

        public void Factors(string factorOne, string factorTwo, string factorThree, string factorFour, string factorFive, string factorSix)
        {
            Console.WriteLine("factorOne is {0}", factorOne);
            Console.WriteLine("factorTwo is {0}", factorTwo);
            Console.WriteLine("factorThree is {0}", factorThree);
            Console.WriteLine("factorFour is {0}", factorFour);
            Console.WriteLine("factorFive is {0}", factorFive);
            Console.WriteLine("factorSix is {0}", factorSix);

            //throw new NotImplementedException();
        }

        public void Speed(int knots)
        {

            Console.WriteLine("The speed of a tropical cyclone will be > {0} knots",knots);
            //throw new NotImplementedException();
        }

        public void WarningCentres(string warnCentre)
        {
            Console.WriteLine("Warn Centre is {0}", warnCentre);
            //throw new NotImplementedException();
        }
    }





    class Program
    {
       
        static void Main(string[] args)
        {
            TropicalCyclone cyclone1 = new TropicalCyclone();
            cyclone1.Composition("Clouds", "Wind", "Thunderstorms");
            cyclone1.WarningCentres("Regional Specialized Meterological Centers");
            cyclone1.Factors("Water Temepratures", "Latent Heat", "Troposphere", "Wind Shear", "Equator", "Coriolis Force");
            cyclone1.Speed(68);
            cyclone1.Effects("Strong winds", "Storm Surge","Tornadoes","Eyewall Mesovortics","Percipitation");

           
        }
    }
}
