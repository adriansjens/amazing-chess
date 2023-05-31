using AmazingChess.Game.Constants;

namespace AmazingChess.Game.PieceLogic
{
    public class KnightMoveSetBuilder : IMoveSetBuilder
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
            };

        }

        public void BuildHorizontalMoveLimit()
        {
            _moveSet.HorizontalMoveLimit = new MoveLimit
            {
                BoardDimension = BoardDimension.Horizontal,
                UpperLimit = 2,
                LowerLimit = 1,
                IncrementalMoveLimit = 2,
                DecrementalMoveLimit = 2,
                CanCombineWithOtherDimensions = true
            };
        }

        public void BuildVerticalMoveLimit()
        {
            _moveSet.VerticalMoveLimit = new MoveLimit
            {
                BoardDimension = BoardDimension.Vertical,
                UpperLimit = 2,
                LowerLimit = 1,
                IncrementalMoveLimit = 2,
                DecrementalMoveLimit = 2,
                CanCombineWithOtherDimensions = true
            };
        }
    }
}
