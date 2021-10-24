using System;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Výpočet BMI");
            while (true)
            {
                 double weight;
                 double height;
    
                
                vaha:
                Console.WriteLine("Zadej váhu (kg)");
                weight = double.Parse(Console.ReadLine());
            if (weight >= 200)
            {
               Console.WriteLine("Jsi příliš těžký, zadej váhu znovu!");
               goto vaha;
            }
               
               vyska:
                Console.WriteLine("Zadej výšku(m)");
                height = double.Parse(Console.ReadLine());
            if (height >= 3)
            {
                Console.WriteLine("Jsi příliš vysoký, zadej výšku znovu!");
                   goto vyska;

            }

                var celkem = weight / (height * height);
                Console.WriteLine($"Vaše BMI je {celkem} ");
                Console.WriteLine();

            }
           
        }
    }
}
