using AmazingChess.Game.Constants;
using AmazingChess.Game.PieceLogic;

namespace AmazingChessTest.ConsoleChessGameInterfaceTests
{
    public class MoveSetBuilderTests
    {
        private WhitePawnMoveSetBuilder _builder;

        [SetUp]
        public void SetUp()
        {
            //Arrange
            _builder = new WhitePawnMoveSetBuilder();
        }

        [Test]
        public void BuildDiagonalMoveLimit_SetsCorrectValues()
        {
            //Act
            _builder.BuildDiagonalMoveLimit();
            _builder.SetTotalMovementRange();
            var moveSet = _builder.GetMoveSet();

            //Assert
            Assert.Multiple(() =>
            {
                //given that these builder methods are never called, make sure the corresponding properties are null
                Assert.That(moveSet.HorizontalMoveLimit, Is.Null);
                Assert.That(moveSet.VerticalMoveLimit, Is.Null);

                //verify that the resulting move limit properties are populated correctly
                Assert.That(moveSet.DiagonalMoveLimit.BoardDimension, Is.EqualTo(BoardDimension.Diagonal));
                Assert.That(moveSet.TotalMovementRange, Is.EqualTo(new int[] { 1 }));
                Assert.That(moveSet.DiagonalMoveLimit.IncrementalMovementRange, Is.EqualTo(new int[] { 1 }));
                Assert.That(moveSet.DiagonalMoveLimit.DecrementalMovementRange, Is.EqualTo(new int[] { 0 }));
                Assert.That(moveSet.DiagonalMoveLimit.CanCapture, Is.True);
            });
        }

        [Test]
        public void BuildHorizontalMoveLimit_SetsCorrectValues()
        {
            //Act
            _builder.BuildHorizontalMoveLimit();
            _builder.SetTotalMovementRange();
            var moveSet = _builder.GetMoveSet();

            //Assert
            Assert.Multiple(() =>
            {
                //given that these builder methods are never called, make sure the corresponding properties are null
                Assert.That(moveSet.DiagonalMoveLimit, Is.Null);
                Assert.That(moveSet.VerticalMoveLimit, Is.Null);

                //given that a pawn is unable to move horizontally, verify that the default move limit property values are correctly populated
                Assert.That(moveSet.HorizontalMoveLimit.BoardDimension, Is.EqualTo(BoardDimension.Horizontal));
                Assert.That(moveSet.TotalMovementRange, Is.EqualTo(new int[] { 1 }));
                Assert.That(moveSet.HorizontalMoveLimit.IncrementalMovementRange, Is.EqualTo(new int[] { 0 }));
                Assert.That(moveSet.HorizontalMoveLimit.DecrementalMovementRange, Is.EqualTo(new int[] { 0 }));
                Assert.That(moveSet.HorizontalMoveLimit.CanCapture, Is.False);
                Assert.That(moveSet.HorizontalMoveLimit.CanCombineMoveLimits, Is.False);
            });
        }
    }
}