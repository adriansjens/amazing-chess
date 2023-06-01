using AmazingChess.Game.ChessPieceLogic;
using AmazingChess.Game.Constants;
using AmazingChess.Game.PieceLogic;

namespace AmazingChess.Game.Pieces
{
    public class ChessPieceFactory
    {
        private readonly Dictionary<PieceName, IMoveSetBuilder> _moveSetBuilders;
        private readonly Dictionary<string, PieceName?> _squareToPieceMappings;
        private readonly Dictionary<string, ChessColor> _squareToPieceColorMappings;

        public ChessPieceFactory(Dictionary<PieceName, IMoveSetBuilder> moveSetBuilders,
            Dictionary<string, PieceName?> squareToPieceMappings, Dictionary<string, ChessColor> squareToPieceColorMappings)
        {
            _moveSetBuilders = moveSetBuilders;
            _squareToPieceMappings = squareToPieceMappings;
            _squareToPieceColorMappings = squareToPieceColorMappings;
        }

        public IChessPiece? GetChessPieceForSquare(string squareDesignation)
        {
            var chessPieceName = _squareToPieceMappings.FirstOrDefault(keyValuePair => keyValuePair.Key == squareDesignation).Value;
            if (chessPieceName == null) return null;

            var colorOfPiece = _squareToPieceColorMappings.FirstOrDefault(keyValuePair => keyValuePair.Key == squareDesignation).Value;
            if (colorOfPiece == 0) throw new Exception($"color for piece at square designation {squareDesignation} is not mapped correctly");

            return CreateChessPiece(chessPieceName.Value, colorOfPiece);
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
