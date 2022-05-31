using System;

namespace CSharp_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
         string waltFirstName = ("Walter");
            char waltInitial = 'H';
            string waltLastName = ("White");
            decimal waltAge = 50.4m;
         double waltHouseNum = 308;
            var waltAddress = ("Negra Arroyo Lane");
                int waltZip = 87014;
            Console.WriteLine($"My name is {waltFirstName} {waltInitial}. {waltLastName}. I am {waltAge} years old. I live at {waltHouseNum} {waltAddress}, Albuquerque, New Mexico, {waltZip}");

        }
    }
}
