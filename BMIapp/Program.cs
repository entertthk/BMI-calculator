using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIapp
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name;
            int Age;

            Start:
            Console.WriteLine("Hello, whats your name: ");
            Name = Console.ReadLine();
            Console.WriteLine($"{Name}! How old are you?");
            Age = Int32.Parse(Console.ReadLine());

            if (Age >= 20 && Age <=60)
            {
                int Weight;
                double Height;
                double Bmi;
                Console.WriteLine($"{Name} How much do you weigh(kg)? ");
                Weight = Int32.Parse(Console.ReadLine());
                Console.WriteLine("And how tall are you(meters)? ");
                Height = Convert.ToDouble(Console.ReadLine());
                Bmi = (Weight / (Height * Height));
               

                    if (Bmi < 16)
                        {
                        Console.WriteLine($"{Name},  your BMI is {Math.Round(Bmi, 1)}, it is dangerous underweigh!");
                        }

                    else if (Bmi >= 16 && Bmi <= 18.5)
                        {
                        Console.WriteLine($"{Name},  your BMI is {Math.Round(Bmi, 1)}, you have underweight!");
                        }

                    else if (Bmi >= 18.6 && Bmi <= 25)
                        {
                        Console.WriteLine($"{Name},  your BMI is {Math.Round(Bmi, 1)}, you have normal weight!");
                        }

                    else if (Bmi >= 25.1 && Bmi <= 30)
                        {
                        Console.WriteLine($"{Name},  your BMI is {Math.Round(Bmi, 1)}, you have overweight!");
                        }

                    else if (Bmi >= 30.1 && Bmi <= 35)
                        {
                        Console.WriteLine($"{Name},  your BMI is {Math.Round(Bmi, 1)}, you have symptoms of obesity!");
                        }

                    else if (Bmi >= 35.1 && Bmi <= 40)
                        {
                        Console.WriteLine($"{Name},  your BMI is {Math.Round(Bmi, 1)}, you have heavy obesity!");
                        }

                    else if (Bmi >= 40.1)
                        {
                        Console.WriteLine($"{Name},  your BMI is {Math.Round(Bmi, 1)}, you have dangerous obesity!");
                        
                        }


            }   


            else
                {
                Console.WriteLine($"{Name} BMI calculator works correctly only between ages 20 to 60");
                }


            goto Start;
            Console.ReadLine();


        }
    }
}
