using AmazingChess.Game.ChessPieceLogic;
using AmazingChess.Game.Constants;
using AmazingChess.Game.PieceLogic;

namespace AmazingChess.Game.Pieces
{
    public class ChessPiece : IChessPiece
    {
        public PieceName Name { get; }
        public ChessColor Color { get; }
        public string UnicodeCharacter { get; }
        public MoveSet MoveSet { get; }

        public ChessPiece(PieceName name, ChessColor color, string unicodeCharacter, MoveSet moveSet)
        {
            Name = name;
            Color = color;
            UnicodeCharacter = unicodeCharacter;
            MoveSet = moveSet;
        }
    }
}
