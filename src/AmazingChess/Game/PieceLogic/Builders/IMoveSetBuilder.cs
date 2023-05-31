namespace AmazingChess.Game.PieceLogic
{
    public interface IMoveSetBuilder
    {
        MoveSet GetMoveSet();
        void SetTotalMovementRange();
        void BuildHorizontalMoveLimit();
        void BuildVerticalMoveLimit();
        void BuildDiagonalMoveLimit();
    }
}
