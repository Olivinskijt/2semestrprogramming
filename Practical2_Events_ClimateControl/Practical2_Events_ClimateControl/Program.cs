using Practical2_Events_ClimateControl;
using System;

namespace Practical2_Events_ClimateControl;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        TemperatureSensor sensor = new TemperatureSensor();
        ResultShow resultshow = new ResultShow();
        Conditioner Conditioner = new Conditioner();
        SecuritySystem securitySystem = new SecuritySystem();

        resultshow.Subscribe(sensor);
        Conditioner.Subscribe(sensor);
        securitySystem.Subscribe(sensor);

        double[] temperatures = { 4, 12, 13, 24, 30 };

        foreach (double temp in temperatures)
        {
            Console.WriteLine($"\n--- Встановлення температури: {temp}°C ---");
            sensor.Temperature = temp;
        }
    }
}