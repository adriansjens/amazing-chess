using AmazingChess.Game.Constants;
using AmazingChess.Game.Models;
using AmazingChess.Game.PieceLogic;
using AmazingChess.Game.Pieces;

namespace AmazingChessTest.PieceLogicTests
{
    public class ChessPieceFactoryTests
    {
        private Dictionary<PieceName, IMoveSetBuilder> _moveSetBuilders;

        [SetUp]
        public void SetUp()
        {
            _moveSetBuilders = new Dictionary<PieceName, IMoveSetBuilder>() { { PieceName.Pawn, new WhitePawnMoveSetBuilder() } };
        }

        [Test]
        public void GetChessPieceForSquare_OneChessPieceOneMapping_ReturnsCorrectPieceForSquare()
        {
            //Arrange
            var squareToPieceMappings = new List<DefaultSquarePieceMapping>()
            {
                new DefaultSquarePieceMapping() {
                    PieceName = PieceName.Pawn,
                    ChessColor = ChessColor.White,
                    SquareDesignation = "a2"
                }
            };

            var factory = new ChessPieceFactory(_moveSetBuilders, squareToPieceMappings);

            //Act
            var result = factory.GetChessPieceForSquare("a2");

            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.Multiple(() =>
            {
                Assert.That(result.Name, Is.EqualTo(PieceName.Pawn));
                Assert.That(result.Color, Is.EqualTo(ChessColor.White));
            });
        }

        [Test]
        public void GetChessPieceForSquare_TwoMappings_ReturnsCorrectPieceForSquare()
        {
            //Arrange
            var squareToPieceMappings = new List<DefaultSquarePieceMapping>()
            {
                new DefaultSquarePieceMapping() {
                    PieceName = PieceName.Pawn,
                    ChessColor = ChessColor.White,
                    SquareDesignation = "a2"
                },
                new DefaultSquarePieceMapping() {
                    PieceName = PieceName.Rook,
                    ChessColor = ChessColor.White,
                    SquareDesignation = "a1"
                }
            };

            var factory = new ChessPieceFactory(_moveSetBuilders, squareToPieceMappings);

            //Act
            var result = factory.GetChessPieceForSquare("a2");

            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.Multiple(() =>
            {
                Assert.That(result.Name, Is.EqualTo(PieceName.Pawn));
                Assert.That(result.Color, Is.EqualTo(ChessColor.White));
            });
        }

        [Test]
        public void GetChessPieceForSquare_IncorrectSquare_ReturnsNull()
        {
            //Arrange
            var moveSetBuilders = new Dictionary<PieceName, IMoveSetBuilder>() { { PieceName.Pawn, new WhitePawnMoveSetBuilder() } };
            var squareToPieceMappings = new List<DefaultSquarePieceMapping>()
            {
                new DefaultSquarePieceMapping() {
                    PieceName = PieceName.Pawn,
                    ChessColor = ChessColor.White,
                    SquareDesignation = "a2"
                },
                new DefaultSquarePieceMapping() {
                    PieceName = PieceName.Rook,
                    ChessColor = ChessColor.White,
                    SquareDesignation = "a1"
                }
            };

            var factory = new ChessPieceFactory(moveSetBuilders, squareToPieceMappings);

            //Act
            var result = factory.GetChessPieceForSquare("a3");

            //Assert
            Assert.That(result, Is.Null);
        }

        [Test]
        public void GetChessPieceForSquare_FaultyMapping_ThrowsException()
        {
            //Arrange
            var moveSetBuilders = new Dictionary<PieceName, IMoveSetBuilder>() { { PieceName.Pawn, new WhitePawnMoveSetBuilder() } };
            var squareToPieceMappings = new List<DefaultSquarePieceMapping>()
            {
                new DefaultSquarePieceMapping() {
                    PieceName = PieceName.Pawn,
                    ChessColor = null,
                    SquareDesignation = "a2"
                },
            };

            var factory = new ChessPieceFactory(moveSetBuilders, squareToPieceMappings);

            //Act
            var exception = Assert.Throws<Exception>(() => factory.GetChessPieceForSquare("a2"));

            //Assert
            Assert.That(exception.Message, Is.EqualTo("square to piece mapping for piece at square designation a2 is not mapped correctly"));
        }
    }
}
