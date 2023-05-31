using AmazingChess.Game.Constants;

namespace AmazingChess.Game.PieceLogic
{
    public class MoveLimit
    {
        public BoardDimension BoardDimension { get; set; }
        public int[] IncrementalMovementRange { get; set; } = { 0 };
        public int[] DecrementalMovementRange { get; set; } = { 0 };
        public bool CanCapture { get; set; } = true;
        public bool CanCombineMoveLimits { get; set; } = false;
    }
}
