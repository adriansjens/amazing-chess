namespace AmazingChess.Game.PieceLogic
{
    public interface IMoveSetBuilder
    {
        MoveSet GetMoveSet();
        void BuildHorizontalMoveLimit();
        void BuildVerticalMoveLimit();
        void BuildDiagonalMoveLimit();
    }
}
