using AmazingChess.Game.Constants;

namespace AmazingChess.Game.PieceLogic
{
    public class QueenMoveSetBuilder : IMoveSetBuilder
    {
        private MoveSet _moveSet = new();

        private readonly int[] _fullMovementRange = new[] { 1, 2, 3, 4, 5, 6, 7 };

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

        public void SetTotalMovementRange()
        {
            _moveSet.TotalMovementRange = _fullMovementRange;
        }

        public void BuildDiagonalMoveLimit()
        {
            _moveSet.DiagonalMoveLimit = new MoveLimit
            {
                BoardDimension = BoardDimension.Diagonal,
                IncrementalMovementRange = _fullMovementRange,
                DecrementalMovementRange = _fullMovementRange,
            };
        }

        public void BuildHorizontalMoveLimit()
        {
            _moveSet.DiagonalMoveLimit = new MoveLimit
            {
                BoardDimension = BoardDimension.Horizontal,
                IncrementalMovementRange = _fullMovementRange,
                DecrementalMovementRange = _fullMovementRange,
            };
        }

        public void BuildVerticalMoveLimit()
        {
            _moveSet.DiagonalMoveLimit = new MoveLimit
            {
                BoardDimension = BoardDimension.Diagonal,
                IncrementalMovementRange = _fullMovementRange,
                DecrementalMovementRange = _fullMovementRange,
            };
        }
    }
}
