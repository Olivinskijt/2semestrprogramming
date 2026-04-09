using Practical2_Events_ClimateControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical2_Events_ClimateControl;

public class ResultShow
{
    public void Subscribe(TemperatureSensor sensor)
    {
        sensor.TemperatureChanged += OnTemperatureChanged;
    }

    private void OnTemperatureChanged(object? sender, TemperatureChangedEventArgs e)
    {
        Console.WriteLine($"Поточна температура: {e.Temperature} градусів");
    }
}
