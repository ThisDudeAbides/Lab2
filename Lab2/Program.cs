using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)

        {
            while (true)
            {
                Console.WriteLine("Please enter the LENGTH of your room");
                double Length = double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the WIDTH of your room");
                double Width = double.Parse(Console.ReadLine());

                double Perimiter = 2 * (Length + Width);

                double Area = Length * Width;

                Console.WriteLine($" The Area of your room is {Area}");
                Console.WriteLine($"The Perimiter of your room is {Perimiter}");

                Console.WriteLine("Do you want to continue: y/n");
                string response = (Console.ReadLine());
                if (response.ToLower() == "n")
                {
                    break;

                }
                


                





            }
            

                

            


        }

    }
}
