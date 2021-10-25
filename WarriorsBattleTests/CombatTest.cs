using Xunit;
using WarriorsBattle;
using Moq;

namespace WarriorsBattleTests
{
    public class CombatTest
    {
        [Fact]
        public void DamageShouldBeZeroWhenBlockPointsAreGreaterThanAttackPoints()
        {
            int attack = 100;
            int block = 150;

            var AttackerMock = new Mock<IWarrior>();
            AttackerMock.Setup(x => x.Attack()).Returns(attack);

            var DefenderMock = new Mock<IWarrior>();
            DefenderMock.Setup(x => x.Block()).Returns(block);

            Combat testCombat = new Combat(AttackerMock.Object, DefenderMock.Object);
            testCombat.Execute();

            Assert.Equal(0, testCombat.Damage);
        }

        [Fact]
        public void DamageShouldEqualToAttackPointsMinusBlockPointsWhenAttackPointsAreGreaterThanBlockPoints()
        {
            int attack = 150;
            int block = 100;

            var AttackerMock = new Mock<IWarrior>();
            AttackerMock.Setup(x => x.Attack()).Returns(attack);

            var DefenderMock = new Mock<IWarrior>();
            DefenderMock.Setup(x => x.Block()).Returns(block);

            Combat testCombat = new Combat(AttackerMock.Object, DefenderMock.Object);
            testCombat.Execute();

            Assert.Equal(attack-block, testCombat.Damage);
        }

        [Fact]
        public void DefendersHealthShouldBeDecreasedByDamage()
        {
            int attack = 150;
            int block = 100;
            int expectedDamage = attack - block;
            int initialHealth = 100;

            var AttackerMock = new Mock<IWarrior>();
            AttackerMock.Setup(x => x.Attack()).Returns(attack);

            var DefenderMock = new Mock<IWarrior>();
            DefenderMock.Setup(x => x.Block()).Returns(block);
            DefenderMock.SetupGet(x => x.Health).Returns(initialHealth);

            Combat testCombat = new Combat(AttackerMock.Object, DefenderMock.Object);
            testCombat.Execute();

            DefenderMock.VerifySet(x => x.Health = initialHealth-expectedDamage);
        }
    }
}
