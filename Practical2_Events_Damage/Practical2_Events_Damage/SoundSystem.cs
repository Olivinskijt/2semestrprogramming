using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical2_Events_Damage;

public class SoundSystem
{
    public void Subscribe(Player player)
    {
        player.DamageReceived += OnDamageReceived;
    }

    public void Unsubscribe(Player player)
    {
        player.DamageReceived -= OnDamageReceived;
    }

    private void OnDamageReceived(object? sender, DamageReceivedEventArgs e)
    {
        Console.WriteLine($"Звук: отримання урону!");
        if (e.CurrentHp <= 20)
            Console.WriteLine($"Звук: КРИТИЧНИЙ СТАН, ви скоро помрете якщо не вилікуєтеся!");
    }
}
