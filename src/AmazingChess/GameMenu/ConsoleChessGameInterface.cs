using AmazingChess.GameMenu.Constants;

namespace AmazingChess.GameMenu
{
    public class ConsoleChessGameInterface : IChessGameInterface
    {
        public ConsoleChessGameInterface()
        {
        
        }

        public void RenderMenu()
        {
            throw new NotImplementedException();
        }

        public string GetMenuChoiceFromUser()
        {
            var menuChoiceObtained = false;

            var userMenuChoice = "";
            while (!menuChoiceObtained)
            {
                userMenuChoice = Console.ReadLine() ?? "";
                if (!IsValidMenuChoice(userMenuChoice))
                {
                    Console.WriteLine($"{userMenuChoice}" + ConsoleChessGameMenuResponses.WrongOptionMessage);
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
