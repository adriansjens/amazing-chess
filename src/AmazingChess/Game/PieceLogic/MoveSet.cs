namespace AmazingChess.Game.PieceLogic
{
    public class MoveSet
    {
        public int[] TotalMovementRange { get; set; } = { 0 };
        public MoveLimit VerticalMoveLimit { get; set; }
        public MoveLimit HorizontalMoveLimit { get; set; }
        public MoveLimit DiagonalMoveLimit { get; set; }
    }
}
