using System;
using Xunit;
using WarriorsBattle;
using Moq;

namespace WarriorsBattleTests
{
    public class EndToEndTests
    {

        [Fact]
        public void GameShouldSetWinnerAfterGameHasEnded()
        {
            Random random = new Random();
            Warrior ted = new Warrior(random, "ted", 1000, 120, 111);
            Warrior bob = new Warrior(random, "bob", 1000, 120, 140);

            Game game = new Game(ted, bob);
            game.Play();

            Assert.NotNull(game.Winner);
        }

        [Fact]
        public void GameShouldSetWinnerCorrectly()
        {
            var random = new Mock<Random>();
            random.SetupSequence(x => x.Next(1, 21)).Returns(5)
                                                .Returns(2)
                                                .Returns(10)
                                                .Returns(2)
                                                .Returns(12)
                                                .Returns(4)
                                                .Returns(19)
                                                .Returns(1);

            Warrior ted = new Warrior(random.Object, "ted", 20, 20, 20);
            Warrior bob = new Warrior(random.Object, "bob", 20, 20, 20);

            Game game = new Game(ted, bob);
            game.Play();

            Assert.Equal("bob", game.Winner.Name);
        }
    }
}
