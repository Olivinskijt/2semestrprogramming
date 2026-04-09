using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical2_Events_ClimateControl;

public class TemperatureChangedEventArgs : EventArgs
{
    public double Temperature { get; }

    public TemperatureChangedEventArgs(double temperature)
    {
        Temperature = temperature;
    }
}
