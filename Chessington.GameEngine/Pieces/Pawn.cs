using System;
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
            List<Square> availableMoves = new List<Square>();//Creates List

            var currentSquare = board.FindPiece(this);//Gets Current Position

            var actualMoveWhite = currentSquare.Row - 1;
            var actualMoveBlack = currentSquare.Row + 1;

            var playerColor = this.Player;

            if (pieces moved == false)
            {
                actualMoveWhite = currentSquare.Row - 2;
            }
            if else(pieces moved = true)
            {
                actualMoveBlack = currentSquare.Row + 2;
            }
            if else (playerColor == Player.White)
            {
                availableMoves.Add(Square.At(actualMoveWhite, currentSquare.Col ));
            }
            else
            {
                availableMoves.Add(Square.At(actualMoveBlack, currentSquare.Col));
            }

            return availableMoves;
        }
    }
}