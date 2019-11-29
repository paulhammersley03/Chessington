using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Bishop : Piece
    {
        public Bishop(Player player)
            : base(player)
        {
        }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            List<Square> availableMoves = new List<Square>();
            var currentSquare = board.FindPiece(this);
            for (int i = 0; i < GameSettings.BoardSize; i++)
            {
                availableMoves.Add(Square.At(currentSquare.Row + i, currentSquare.Col + i));
                availableMoves.Add(Square.At(currentSquare.Row - i, currentSquare.Col - i));
                availableMoves.Add(Square.At(currentSquare.Row + i, currentSquare.Col - i));
                availableMoves.Add(Square.At(currentSquare.Row - i, currentSquare.Col + i));
            }
            availableMoves.RemoveAll(x => x == currentSquare);
            availableMoves.RemoveAll(x => x.Row < 0 || x.Col <0 || x.Row > 7 || x.Col > 7);
            return availableMoves;
        }
    }
}
