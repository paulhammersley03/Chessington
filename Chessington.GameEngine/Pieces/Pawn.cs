using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Pawn : Piece
    {
        public Pawn(Player player) 
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            List<Square> availableMoves = new List<Square>();

            availableMoves.Add(Square.At(6, 0));
            availableMoves.Add(Square.At(2, 0));

            return availableMoves;
        }
    }
}