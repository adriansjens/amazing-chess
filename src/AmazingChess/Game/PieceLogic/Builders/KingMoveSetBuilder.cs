using AmazingChess.Game.Constants;

namespace AmazingChess.Game.PieceLogic
{
    public class KingMoveSetBuilder : IMoveSetBuilder
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

        public void SetTotalMovementRange()
        {
            _moveSet.TotalMovementRange = new[] { 1 };
        }

        public void BuildDiagonalMoveLimit()
        {
            _moveSet.DiagonalMoveLimit = new MoveLimit
            {
                BoardDimension = BoardDimension.Diagonal,
                DecrementalMovementRange = new[] { 1 },
                IncrementalMovementRange = new[] { 1 }
            };
        }

        public void BuildHorizontalMoveLimit()
        {
            _moveSet.HorizontalMoveLimit = new MoveLimit
            {
                BoardDimension = BoardDimension.Horizontal,
                DecrementalMovementRange = new[] { 1 },
                IncrementalMovementRange = new[] { 1 }
            };
        }

        public void BuildVerticalMoveLimit()
        {
            _moveSet.VerticalMoveLimit = new MoveLimit
            {
                BoardDimension = BoardDimension.Vertical,
                DecrementalMovementRange = new[] { 1 },
                IncrementalMovementRange = new[] { 1 }
            };
        }
    }
}
