using AmazingChess.Game.ChessPieceLogic;
using AmazingChess.Game.Constants;
using AmazingChess.Game.Models;
using AmazingChess.Game.PieceLogic;

namespace AmazingChess.Game.Pieces
{
    public class ChessPieceFactory
    {
        private readonly Dictionary<PieceName, IMoveSetBuilder> _moveSetBuilders;
        private readonly List<DefaultSquarePieceMapping> _squareToPieceMappings;

        public ChessPieceFactory(Dictionary<PieceName, IMoveSetBuilder> moveSetBuilders, List<DefaultSquarePieceMapping> squareToPieceMappings)
        {
            _moveSetBuilders = moveSetBuilders;
            _squareToPieceMappings = squareToPieceMappings;
        }

        public IChessPiece? GetChessPieceForSquare(string squareDesignation)
        {
            var squareToPieceMapping = _squareToPieceMappings.FirstOrDefault(mappingObject => mappingObject.SquareDesignation == squareDesignation);
            if (squareToPieceMapping == null) return null;

            if (squareToPieceMapping.PieceName == null || squareToPieceMapping.ChessColor == null) 
                throw new Exception($"square to piece mapping for piece at square designation {squareDesignation} is not mapped correctly");

            return CreateChessPiece(squareToPieceMapping.PieceName.Value, squareToPieceMapping.ChessColor.Value);
        }

        private IChessPiece CreateChessPiece(PieceName pieceName, ChessColor color)
        {
            var moveSet = CreateMoveSet(pieceName);
            var unicodeCharacter = GetUnicodeCharacter(color, pieceName);

            return new ChessPiece(pieceName, color, unicodeCharacter, moveSet);
        }

        private MoveSet CreateMoveSet(PieceName pieceName)
        {
            var moveSetBuilder = _moveSetBuilders.First(keyValuePair => keyValuePair.Key == pieceName).Value;

            moveSetBuilder.SetTotalMovementRange();
            moveSetBuilder.BuildDiagonalMoveLimit();
            moveSetBuilder.BuildHorizontalMoveLimit();
            moveSetBuilder.BuildVerticalMoveLimit();

            return moveSetBuilder.GetMoveSet();
        }

        private string GetUnicodeCharacter(ChessColor color, PieceName pieceName)
        {
            var unicodeCharacter = UnicodeCharacters.UnicodeMappings
                .FirstOrDefault(mapping => mapping.Color == color && mapping.PieceName == pieceName)?.UnicodeCharacter;

            return unicodeCharacter ?? throw new Exception($"Unable to resolve unicode character for piece name with enum {pieceName}");
        }
    }
}
