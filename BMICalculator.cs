using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedenKitleEndeksi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your weight (kg):");
            int weight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your height (m):");
            double height = Convert.ToDouble(Console.ReadLine());

            double bmi = weight / (height * height);

           if (bmi <= 18)
           {
               Console.WriteLine("UNDERWEIGHT");
               Console.ReadLine();
           }
           else if (bmi > 18 && bmi < 25)
           {
               Console.WriteLine("NORMAL");
               Console.ReadLine();
           }
           else if (bmi > 25)
           {
               Console.WriteLine("OBESE");
               Console.ReadLine();
           }

           


            
        }
    }
}
