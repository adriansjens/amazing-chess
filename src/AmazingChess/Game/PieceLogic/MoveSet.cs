namespace AmazingChess.Game.PieceLogic
{
    public class MoveSet
    {
        public MoveLimit VerticalMoveLimit { get; set; }
        public MoveLimit HorizontalMoveLimit { get; set; }
        public MoveLimit DiagonalMoveLimit { get; set; }
    }
}
