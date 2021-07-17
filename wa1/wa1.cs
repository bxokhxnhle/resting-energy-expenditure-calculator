using System;
using static System.Console;

namespace Bme121
{
    static class Program
    {
        static void Main( )
        {
             string name;
             double age;
             double height;
             double weight;
             string sex;
             double ree;
             
             WriteLine("Enter your name");
             name = ReadLine();
             WriteLine("Enter your age in years");
             age = double.Parse(ReadLine());
             WriteLine("Enter your height in centimetres");
             height = double.Parse(ReadLine());
             WriteLine("Enter your weight in kilograms");
             weight = double.Parse(ReadLine());
             WriteLine("Enter your sex");
             sex = ReadLine();
             
             if (sex == "female")
             {
                 ree = 10*weight + 6.25*height - 5*age -161;
             }
             else
             {
                 ree = 10*weight + 6.25*height - 5*age +5;
             }
    
             WriteLine("Name: " + name);
             WriteLine("Height(cm): " + height);
             WriteLine("Weight(kg): " + weight);
             WriteLine("Sex: " + sex);
             WriteLine("Resting energy expenditure (cal/day): " + ree);
        }
    }
}
