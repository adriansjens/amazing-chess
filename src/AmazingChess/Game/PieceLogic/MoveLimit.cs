using AmazingChess.Game.Constants;

namespace AmazingChess.Game.PieceLogic
{
    public class MoveLimit
    {
        public BoardDimension BoardDimension { get; set; }
        public int IncrementalMoveLimit { get; set; } = 0;
        public int DecrementalMoveLimit { get; set; } = 0;
        public int UpperLimit { get; set; } = 0;
        public int LowerLimit { get; set; } = 0;
        public bool CanCapture { get; set; } = true;
        public bool CanCombineWithOtherDimensions { get; set; } = false;
    }
}
