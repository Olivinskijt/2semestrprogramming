using Practical2_Events_ClimateControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical2_Events_ClimateControl;

public class Conditioner
{
    public void Subscribe(TemperatureSensor sensor)
    {
        sensor.TemperatureChanged += OnTemperatureChanged;
    }

    private void OnTemperatureChanged(object? sender, TemperatureChangedEventArgs e)
    {
        if (e.Temperature < 17)
        {
            Console.WriteLine("[AirConditioner] Режим: ОБІГРІВ увімкнено.");
        }
        else if (e.Temperature <= 25)
        {
            Console.WriteLine("[AirConditioner] Режим: ВИМКНЕНО (комфортна температура).");
        }
        else
        {
            Console.WriteLine("[AirConditioner] Режим: ОХОЛОДЖЕННЯ увімкнено.");
        }
    }
}
