using System;

namespace garment_abstract
{
  public abstract class Clothing
    {
        public abstract void Sales();
     
        public void Materials()
        {
            Console.WriteLine("Cotton");
            Console.WriteLine("Linen");
            Console.WriteLine("Polyster");
            Console.WriteLine("Ryan");
            Console.WriteLine("Georgette");
        }
        public void CommonWear()
        {
            Console.WriteLine("Skirts");
            Console.WriteLine("Shorts");
            Console.WriteLine("Tops");
            Console.WriteLine("Blouses");
            Console.WriteLine("Shirts");

        }


        class TrendSetting : Clothing
        {
            public override void Sales()
            {
                Console.WriteLine("A:For Higher sales");
                Console.WriteLine("B:For Higher sales");
                Console.WriteLine("C:For Higher sales");
            }
        }
        class ClimateControl : Clothing
        {
            public override void Sales()
            {
                Console.WriteLine("A:Heat Resisted Clothing");
                Console.WriteLine("B:Cool resisted");
                
            }
        }
        class Sports : Clothing
        {
            public override void Sales()
            {
                Console.WriteLine("A:Viscose Cotton");
                Console.WriteLine("B:Flex");
                Console.WriteLine("C:Heated Clothing");
            }
        }

        public static void Main(string[] args)
        {
            Sports s = new Sports();
            s.Sales();
            TrendSetting t = new TrendSetting();
            t.Sales();
            ClimateControl c = new ClimateControl();
            c.Sales();
        }


    }
}
