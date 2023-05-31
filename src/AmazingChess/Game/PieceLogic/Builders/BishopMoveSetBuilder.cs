using AmazingChess.Game.Constants;

namespace AmazingChess.Game.PieceLogic
{
    public class BishopMoveSetBuilder : IMoveSetBuilder
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
            _moveSet.TotalMovementRange = new[] { 1, 2, 3, 4, 5, 6, 7 };
        }

        public void BuildDiagonalMoveLimit()
        {
            var fullMovementRange = new[] { 1, 2, 3, 4, 5, 6, 7 };

            _moveSet.DiagonalMoveLimit = new MoveLimit
            {
                BoardDimension = BoardDimension.Diagonal,
                IncrementalMovementRange = fullMovementRange,
                DecrementalMovementRange = fullMovementRange,
            };
        }

        public void BuildHorizontalMoveLimit()
        {
            _moveSet.HorizontalMoveLimit = new MoveLimit
            {
                BoardDimension = BoardDimension.Horizontal,
            };
        }

        public void BuildVerticalMoveLimit()
        {
            _moveSet.VerticalMoveLimit = new MoveLimit
            {
                BoardDimension = BoardDimension.Vertical,
            };
        }
    }
}
