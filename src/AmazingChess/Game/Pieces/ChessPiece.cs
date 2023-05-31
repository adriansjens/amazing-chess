using AmazingChess.Game.ChessPieceLogic;
using AmazingChess.Game.Constants;
using AmazingChess.Game.PieceLogic;

namespace AmazingChess.Game.Pieces
{
    public class ChessPiece : IChessPiece
    {
        public PieceName Name { get; set; }
        public ChessColor Color { get; set; }
        public string UnicodeCharacter { get; set; }
        public MoveSet MoveSet { get; set; }
    }
}
