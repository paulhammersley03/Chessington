using Chessington.GameEngine.Pieces;
using System.Collections.Generic;

namespace Chessington.GameEngine
{
    public class MoveDirection
    {
        public static List<Square> MoveUpDownLeftRight(Board board, Piece piece)
        {
            List<Square> availableMoves = new List<Square>();
            var currentSquare = board.FindPiece(piece);
            for (int i = 0; i < GameSettings.BoardSize; i++)
            {
                availableMoves.Add(Square.At(currentSquare.Row, i));
                availableMoves.Add(Square.At(i, currentSquare.Col));
            }
            availableMoves.RemoveAll(x => x == currentSquare);
            return availableMoves;
        }
        public static List<Square> Diagonal(Board board, Piece piece)
        {
            List<Square> availableMoves = new List<Square>();
            var currentSquare = board.FindPiece(piece);
            for (int i = 0; i < GameSettings.BoardSize; i++)
            {
                availableMoves.Add(Square.At(currentSquare.Row + i, currentSquare.Col + i));
                availableMoves.Add(Square.At(currentSquare.Row - i, currentSquare.Col - i));
                availableMoves.Add(Square.At(currentSquare.Row + i, currentSquare.Col - i));
                availableMoves.Add(Square.At(currentSquare.Row - i, currentSquare.Col + i));
            }
            availableMoves.RemoveAll(x => x == currentSquare);
            availableMoves.RemoveAll(x => x.Row < 0 || x.Col < 0 || x.Row > 7 || x.Col > 7);
            return availableMoves;
        }
        public static IEnumerable<Square> AllDirections(Board board, Piece piece)
        {
            var moves = MoveUpDownLeftRight(board, piece);
            var diagonalMoves = Diagonal(board, piece);
            moves.AddRange(diagonalMoves);
            return moves;
        }
    }
}
