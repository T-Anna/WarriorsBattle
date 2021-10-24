using System;
using Xunit;
using WarriorsBattle;

namespace WarriorsBattleTests
{
    public class WarriorTest
    {
        private Random random = new Random();

        [Fact]
        public void WarriorsHealthDefaultsToZeroWhenHealthDecreasesToNegativeNumber()
        {
            Warrior testWarrior = new Warrior(random, "testWarrior", 10, 100, 200);
            testWarrior.Health -= 20;
            Assert.Equal(0, testWarrior.Health);
        }

        [Fact]
        public void WarriorsHealthDecreasesByGivenValueWhenHealthDecreasesToPositiveNumber()
        {
            Warrior testWarrior = new Warrior(random, "testWarrior", 10, 100, 200);
            testWarrior.Health -= 9;
            Assert.Equal(1, testWarrior.Health);
        }

        [Fact]
        public void IsAliveReturnsTrueWhenHealthIsBiggerThan0()
        {
            Warrior testWarrior = new Warrior(random, "testWarrior", 10, 100, 200);
            Assert.True(testWarrior.IsAlive());
        }

        [Fact]
        public void IsAliveReturnsFalseWhenHealthIs0()
        {
            Warrior testWarrior = new Warrior(random, "testWarrior", 0, 100, 200);
            Assert.False(testWarrior.IsAlive());
        }
    }
}
