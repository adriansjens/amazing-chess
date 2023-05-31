using AmazingChess.GameMenu;
using AmazingChess.GameMenu.Constants;
using Moq;

namespace AmazingChessTest
{
    public class ConsoleChessGameInterfaceTests
    {
        [Test]
        public void GetMenuChoiceFromUser_ValidInput_ReturnsCorrectChoice()
        {
            //Arrange
            var mockConsoleInterface = new Mock<IConsoleInterface>();
            mockConsoleInterface.Setup(mockConsole => mockConsole.ReadLine()).Returns("1");

            var gameInterface = new ConsoleChessGameInterface(mockConsoleInterface.Object);

            //Act
            var result = gameInterface.GetMenuChoiceFromUser();

            //Assert
            Assert.That(result, Is.EqualTo("1"));
        }

        [Test]
        public void GetMenuChoiceFromUser_InvalidInitialInput_PrintsErrorMessage()
        {
            //Arrange
            var mockConsoleInterface = new Mock<IConsoleInterface>();
            mockConsoleInterface.SetupSequence(mockConsole => mockConsole.ReadLine())
                .Returns("0")
                .Returns("1");

            var gameInterface = new ConsoleChessGameInterface(mockConsoleInterface.Object);

            //Act
            var result = gameInterface.GetMenuChoiceFromUser();

            //Assert
            mockConsoleInterface.Verify(x => x.WriteLine("0" + ConsoleChessGameMenuResponses.WrongOptionMessage));
        }
    }
}