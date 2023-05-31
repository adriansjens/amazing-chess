using AmazingChess.GameMenu;
using AmazingChess.GameMenu.Constants;
using Moq;

namespace AmazingChessTest
{
    public class ConsoleChessGameInterfaceTests
    {

        [Test]
        public void RenderMenu_RendersCorrectOutput()
        {
            //Arrange
            var mockConsoleInterface = new Mock<IConsoleInterface>();
            var gameInterface = new ConsoleChessGameInterface(mockConsoleInterface.Object);

            var correctStartupMessage = "Welcome to Amazing Chess " +
                                                "\nWould you like to: " +
                                                "\n1: Start a new game" +
                                                "\n2: Exit";

            //Act
            gameInterface.RenderMenu();

            //Assert
            mockConsoleInterface.Verify(mockInterface => mockInterface.WriteLine(correctStartupMessage));
        }

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
            mockConsoleInterface.Verify(mockInterface => mockInterface.WriteLine("0" + ConsoleChessGameMenuResponses.WrongOptionMessage));
        }

        [Test]
        public void ExitApplication_RendersCorrectOutput()
        {
            //Arrange
            var mockConsoleInterface = new Mock<IConsoleInterface>();
            var gameInterface = new ConsoleChessGameInterface(mockConsoleInterface.Object);

            var correctExitMessage = "Bye!";

            //Act
            gameInterface.ExitApplication();

            //Assert
            mockConsoleInterface.Verify(mockInterface => mockInterface.WriteLine(correctExitMessage));
        }
    }
}