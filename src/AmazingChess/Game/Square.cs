using AmazingChess.Game.ChessPieceLogic;
using AmazingChess.Game.Constants;

namespace AmazingChess.Game
{
    public class Square
    {
        public string Designation { get; }
        public ChessColor Color { get; }
        public IChessPiece? CurrentPiece { get; set; }

        public Square(string designation, ChessColor color, IChessPiece? chessPiece)
        {
            Designation = designation;
            CurrentPiece = chessPiece;
            Color = color;
        }
    }
}
