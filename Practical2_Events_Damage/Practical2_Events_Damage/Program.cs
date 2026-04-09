using System.Numerics;

namespace Practical2_Events_Damage;

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player();

        UiHealthBar healthBar = new UiHealthBar();
        SoundSystem soundSystem = new SoundSystem();
        AchievementSystem achievementSystem = new AchievementSystem();
        GameLogger gameLogger = new GameLogger();

        healthBar.Subscribe(player);
        soundSystem.Subscribe(player);
        achievementSystem.Subscribe(player);
        gameLogger.Subscribe(player);

        player.TakeDamage(10);
        player.TakeDamage(15);
        player.TakeDamage(20);
        player.TakeDamage(30);
        player.TakeDamage(15);
        player.TakeDamage(10);

        healthBar.Unsubscribe(player);
        soundSystem.Unsubscribe(player);
        achievementSystem.Unsubscribe(player);
        gameLogger.Unsubscribe(player);

    }
}