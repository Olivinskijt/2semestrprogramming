using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical2_Events_Damage;

public class AchievementSystem
{
    private bool _halfHealthUnlocked = false;
    private bool _firstDeathUnlocked = false;

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
        if (e.CurrentHp <= 50 && !_halfHealthUnlocked)
        {
            _halfHealthUnlocked = true;
            Console.WriteLine("Досягнення отримано: \"Half Health\"");
        }

        if (e.CurrentHp <= 0 && !_firstDeathUnlocked)
        {
            _firstDeathUnlocked = true;
            Console.WriteLine("Досягнення отримано: \"First Death\"");
        }
    }
}
