using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Chessington.GameEngine.Pieces
{
    public class Pawn : Piece
    {
        public Pawn(Player player)
            : base(player)
        {
        }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            List<Square> availableMoves = new List<Square>();
            var currentSquare = board.FindPiece(this);
            if (this.HasMoved == false)
            {
                var actualMoveWhite = currentSquare.Row - 2;
                var actualMoveBlack = currentSquare.Row + 2;
                availableMoves.Add(Square.At(actualMoveWhite, currentSquare.Col));
                availableMoves.Add(Square.At(actualMoveBlack, currentSquare.Col));
            }
            if (this.Player == Player.White)
            {
                var actualMoveWhite = currentSquare.Row - 1;
                availableMoves.Add(Square.At(actualMoveWhite, currentSquare.Col));
            }
            else if (this.Player == Player.Black)
            {
                var actualMoveBlack = currentSquare.Row + 1;
                availableMoves.Add(Square.At(actualMoveBlack, currentSquare.Col));
            }
            return availableMoves;
        }

    }
}