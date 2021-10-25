using Xunit;
using WarriorsBattle;
using Moq;

namespace WarriorsBattleTests
{
    public class GameTest
    {
        [Fact]
        public void GameShouldSetFirstWarriorAsAWinnerWhenSecondWarriorDies()
        {
            var FirstWarriorMock = new Mock<IWarrior>();
            FirstWarriorMock.SetupGet(x => x.Name).Returns("FirstWarriorMock");

            var SecondWarriorMock = new Mock<IWarrior>();
            SecondWarriorMock.Setup(x => x.IsAlive()).Returns(false);
            SecondWarriorMock.SetupGet(x => x.Name).Returns("SecondWarriorMock");

            Game game = new Game(FirstWarriorMock.Object, SecondWarriorMock.Object);
            game.Play();

            Assert.Equal("FirstWarriorMock", game.Winner.Name);
        }

        [Fact]
        public void GameShouldSetSecondWarriorAsAWinnerWhenFirstWarriorDies()
        {
            var FirstWarriorMock = new Mock<IWarrior>();
            FirstWarriorMock.SetupGet(x => x.Name).Returns("FirstWarriorMock");
            FirstWarriorMock.SetupSequence(x => x.IsAlive()).Returns(true)
                                                            .Returns(false);

            var SecondWarriorMock = new Mock<IWarrior>();
            SecondWarriorMock.SetupGet(x => x.Name).Returns("SecondWarriorMock");
            SecondWarriorMock.SetupSequence(x => x.IsAlive()).Returns(true)
                                                            .Returns(true);

            Game game = new Game(FirstWarriorMock.Object, SecondWarriorMock.Object);
            game.Play();

            Assert.Equal("SecondWarriorMock", game.Winner.Name);
        }
    }
}
