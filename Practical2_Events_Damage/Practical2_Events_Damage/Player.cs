using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical2_Events_Damage;

public class Player
{
    private static int _hp = 100;

    public event EventHandler<DamageReceivedEventArgs>? DamageReceived;

    public void TakeDamage(int damage)
    {
        _hp = Math.Max(0, _hp - damage);
        Console.WriteLine($"\nГравець отримав {damage} урону");
        DamageReceived?.Invoke(this, new DamageReceivedEventArgs(damage, _hp));
    }
}
