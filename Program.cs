using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Laver objekter
            Aircraft PIA = new Aircraft();
            PIA.Model = 7773;
            PIA.Passengers = 300;
            PIA.Airline = "Pakistan International Airlines";

            //Printer ud
            Console.WriteLine("Model: " + PIA.Model + " Max Passengers: " + PIA.Passengers + " Airline: " + PIA.Airline);

            Console.ReadKey();
        }
    }
}
