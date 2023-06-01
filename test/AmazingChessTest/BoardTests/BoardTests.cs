using AmazingChess.Game;
using AmazingChess.Game.ChessPieceLogic;
using AmazingChess.Game.Constants;
using AmazingChess.Game.Pieces;
using Moq;

namespace AmazingChessTest.BoardTests
{
    public class BoardTests
    {
        [Test]
        public void PerformGameSetup_ReturnsCorrectBoardState()
        {
            //Arrange
            var pieceFactoryMock = new Mock<IChessPieceFactory>();
            pieceFactoryMock.Setup(pieceFactoryMock => pieceFactoryMock.GetChessPieceForSquare(It.IsAny<string>())).Returns((IChessPiece?) null);

            var board = new Board(pieceFactoryMock.Object);

            //Act
            var result = board.PerformGameSetup();

            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.Multiple(() =>
            {
                Assert.That(result.Count(), Is.EqualTo(64));
                Assert.That(result.Count(square => square.Color == ChessColor.White), Is.EqualTo(32));
                Assert.That(result.Count(square => square.Color == ChessColor.Black), Is.EqualTo(32));
            });
        }
    }
}
