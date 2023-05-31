using AmazingChess.Game.Constants;

namespace AmazingChess.Game.PieceLogic
{
    public class QueenMoveSetBuilder : IMoveSetBuilder
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
                UpperLimit = 8,
                LowerLimit = 8,
                IncrementalMoveLimit = 8,
                DecrementalMoveLimit = 8,
            };
        }

        public void BuildHorizontalMoveLimit()
        {
            _moveSet.HorizontalMoveLimit = new MoveLimit
            {
                BoardDimension = BoardDimension.Horizontal,
                UpperLimit = 8,
                LowerLimit = 8,
                IncrementalMoveLimit = 8,
                DecrementalMoveLimit = 8,
            };
        }

        public void BuildVerticalMoveLimit()
        {
            _moveSet.VerticalMoveLimit = new MoveLimit
            {
                BoardDimension = BoardDimension.Vertical,
                UpperLimit = 8,
                LowerLimit = 8,
                IncrementalMoveLimit = 8,
                DecrementalMoveLimit = 8,
            };
        }
    }
}
