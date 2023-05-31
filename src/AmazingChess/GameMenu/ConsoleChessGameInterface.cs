using AmazingChess.GameMenu.Constants;

namespace AmazingChess.GameMenu
{
    public class ConsoleChessGameInterface : IChessGameInterface
    {
        private readonly IConsoleInterface _consoleInterface;
        
        public ConsoleChessGameInterface(IConsoleInterface consoleInterface)
        {
            _consoleInterface = consoleInterface;
        }

        public void RenderMenu()
        {
            _consoleInterface.WriteLine(ConsoleChessGameMenuResponses.StartupMessage);
        }

        public string GetMenuChoiceFromUser()
        {
            var menuChoiceObtained = false;

            var userMenuChoice = "";
            while (!menuChoiceObtained)
            {
                userMenuChoice = _consoleInterface.ReadLine() ?? "";
                if (!IsValidMenuChoice(userMenuChoice))
                {
                    _consoleInterface.WriteLine($"{userMenuChoice}" + ConsoleChessGameMenuResponses.WrongOptionMessage);
                    continue;
                }

                menuChoiceObtained = true;
            }

            return userMenuChoice;
        }

        public void ExitGame()
        {
            throw new NotImplementedException();
        }

        private bool IsValidMenuChoice(string userMenuChoice)
        {
            return userMenuChoice == ConsoleChessGameMenuChoices.NewGame || userMenuChoice == ConsoleChessGameMenuChoices.Exit;
        }
    }
}
