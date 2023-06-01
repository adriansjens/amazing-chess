using AmazingChess.Game.ChessPieceLogic;

namespace AmazingChess.Game.Pieces
{
    public interface IChessPieceFactory
    {
        public IChessPiece? GetChessPieceForSquare(string squareDesignation);
    }
}
