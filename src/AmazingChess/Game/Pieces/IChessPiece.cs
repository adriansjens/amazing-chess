using AmazingChess.Game.Constants;
using AmazingChess.Game.PieceLogic;

namespace AmazingChess.Game.ChessPieceLogic
{
    //evaluate whether this interface is necessary

    public interface IChessPiece
    {
        public PieceName Name { get; }
        public ChessColor Color { get; }
        public string UnicodeCharacter { get; }
        public MoveSet MoveSet { get; }
    }
}
