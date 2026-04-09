using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical2_Events_Damage;

public class DamageReceivedEventArgs : EventArgs
{
    public int Damage { get; }
    public int CurrentHp { get; }

    public DamageReceivedEventArgs(int damage, int currentHp)
    {
        Damage = damage;
        CurrentHp = currentHp;
    }
}