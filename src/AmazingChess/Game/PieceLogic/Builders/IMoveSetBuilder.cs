namespace AmazingChess.Game.PieceLogic
{
    public interface IMoveLimitBuilder
    {
        MoveSet GetMoveSet();
        void BuildHorizontalMoveLimit();
        void BuildVerticalMoveLimit();
        void BuildDiagonalMoveLimit();
    }
}
