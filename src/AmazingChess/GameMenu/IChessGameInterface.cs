namespace AmazingChess.GameMenu
{
    public interface IChessGameInterface
    {
        public void RenderMenu();
        public string GetMenuChoiceFromUser();
        public void ExitApplication();
    }
}
