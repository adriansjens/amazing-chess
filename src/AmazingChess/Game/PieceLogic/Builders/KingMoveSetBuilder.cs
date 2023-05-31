﻿using AmazingChess.Game.Constants;

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

        public void BuildDiagonalMoveLimit()
        {
            _moveSet.DiagonalMoveLimit = new MoveLimit
            {
                BoardDimension = BoardDimension.Diagonal,
                UpperLimit = 1,
                LowerLimit = 1,
                IncrementalMoveLimit = 1,
                DecrementalMoveLimit = 1,
            };
        }

        public void BuildHorizontalMoveLimit()
        {
            _moveSet.HorizontalMoveLimit = new MoveLimit
            {
                BoardDimension = BoardDimension.Horizontal,
                UpperLimit = 1,
                LowerLimit = 1,
                IncrementalMoveLimit = 1,
                DecrementalMoveLimit = 1,
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
                DecrementalMoveLimit = 1,
            };
        }
    }
}
