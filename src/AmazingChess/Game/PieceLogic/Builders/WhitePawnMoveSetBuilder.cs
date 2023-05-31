using AmazingChess.Game.Constants;

namespace AmazingChess.Game.PieceLogic
{
    public class WhitePawnMoveSetBuilder : IMoveSetBuilder
    {
        private MoveSet _moveSet = new();

        public MoveSet GetMoveSet()
        {
            var result = _moveSet;

            Reset();

            return result;
        }

        public void Reset()
        {
            _moveSet = new MoveSet();
        }

        public void BuildDiagonalMoveLimit()
        {
            _moveSet.DiagonalMoveLimit = new MoveLimit
            {
                BoardDimension = BoardDimension.Diagonal,
                UpperLimit = 1,
                LowerLimit = 1,
                IncrementalMoveLimit = 1,
                CanCapture = true
            };
        }

        public void BuildHorizontalMoveLimit()
        {
            _moveSet.HorizontalMoveLimit = new MoveLimit
            {
                BoardDimension = BoardDimension.Horizontal,
                CanCapture = false
            };
        }

        public void BuildVerticalMoveLimit()
        {
            _moveSet.VerticalMoveLimit = new MoveLimit
            {
                BoardDimension = BoardDimension.Vertical,
                UpperLimit = 1,
                LowerLimit = 1,
                IncrementalMoveLimit = 1,
                CanCapture = false
            };
        }
    }
}
