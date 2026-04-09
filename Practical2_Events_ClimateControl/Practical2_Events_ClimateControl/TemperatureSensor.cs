using Practical2_Events_ClimateControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical2_Events_ClimateControl;

public class TemperatureSensor
{
    private double _temperature;

    public event EventHandler<TemperatureChangedEventArgs>? TemperatureChanged;

    public double Temperature
    {
        get => _temperature;
        set
        {
            _temperature = value;
            OnTemperatureChanged(value);
        }
    }

    protected virtual void OnTemperatureChanged(double temperature)
    {
        TemperatureChanged?.Invoke(this, new TemperatureChangedEventArgs(temperature));
    }
}
