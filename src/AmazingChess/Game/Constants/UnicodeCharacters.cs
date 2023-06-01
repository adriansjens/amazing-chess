namespace AmazingChess.Game.Constants
{
    public static class UnicodeCharacters
    {
        public static readonly List<UnicodeMapping> UnicodeMappings = new() 
        {
            new UnicodeMapping()
            {
                Color = ChessColor.Black,
                PieceName = PieceName.Pawn,
                UnicodeCharacter = "♟︎"
            },
            new UnicodeMapping()
            {
                Color = ChessColor.Black,
                PieceName = PieceName.Rook,
                UnicodeCharacter = "♜"
            },
            new UnicodeMapping()
            {
                Color = ChessColor.Black,
                PieceName = PieceName.Knight,
                UnicodeCharacter = "♞"
            },
            new UnicodeMapping()
            {
                Color = ChessColor.Black,
                PieceName = PieceName.Bishop,
                UnicodeCharacter = "♝"
            },
            new UnicodeMapping()
            {
                Color = ChessColor.Black,
                PieceName = PieceName.Queen,
                UnicodeCharacter = "♛"
            },
            new UnicodeMapping()
            {
                Color = ChessColor.Black,
                PieceName = PieceName.King,
                UnicodeCharacter = "♚"
            },
            new UnicodeMapping()
            {
                Color = ChessColor.White,
                PieceName = PieceName.Pawn,
                UnicodeCharacter = "♙"
            },
            new UnicodeMapping()
            {
                Color = ChessColor.White,
                PieceName = PieceName.Rook,
                UnicodeCharacter = "♖"
            },
            new UnicodeMapping()
            {
                Color = ChessColor.White,
                PieceName = PieceName.Knight,
                UnicodeCharacter = "♘"
            },
            new UnicodeMapping()
            {
                Color = ChessColor.White,
                PieceName = PieceName.Bishop,
                UnicodeCharacter = "♗"
            },
            new UnicodeMapping()
            {
                Color = ChessColor.White,
                PieceName = PieceName.Queen,
                UnicodeCharacter = "♕"
            },
            new UnicodeMapping()
            {
                Color = ChessColor.White,
                PieceName = PieceName.King,
                UnicodeCharacter = "♔"
            }
        };
    }

    public class UnicodeMapping
    {
        public ChessColor Color { get; set; }
        public PieceName PieceName { get; set; }
        public string UnicodeCharacter { get; set; }
    }
}
