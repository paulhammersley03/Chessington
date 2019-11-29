using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Rook : Piece
    {
        public Rook(Player player)
            : base(player)
        {
        }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            List<Square> availableMoves = new List<Square>();
            var currentSquare = board.FindPiece(this);
            for (int i = 0; i < GameSettings.BoardSize; i++)
            {
                availableMoves.Add(Square.At(currentSquare.Row, i));
                availableMoves.Add(Square.At(i, currentSquare.Col));
            }
            availableMoves.RemoveAll(x => x == currentSquare);
            return availableMoves;
        }
    }
}