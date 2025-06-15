using Assets.Gameplay.Enemies.Scripts;
using NUnit.Framework;

namespace Tests
{
  public class EnemyStatsTests
  {
    [Test]
    public void TakeDamage_LessThanHealth_ShouldSurvive()
    {
      var stats = new EnemyStats(100f);
      bool died = stats.TakeDamage(30f);

      Assert.False(died);
      Assert.AreEqual(70f, stats.CurrentHealth, 0.01f);
    }

    [Test]
    public void TakeDamage_EqualOrGreaterThanHealth_ShouldDie()
    {
      var stats = new EnemyStats(100f);
      bool died = stats.TakeDamage(150f);

      Assert.True(died);
      Assert.AreEqual(-50f, stats.CurrentHealth, 0.01f);
    }
  }
}
