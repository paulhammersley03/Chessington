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

            int actualMoveWhite;//Initialises variable
            int actualMoveBlack;//Initialises variable

            var playerColor = this.Player;//Returns what color pieces the player is

            if (board.PiecesMoved == false)
            {
                actualMoveWhite = currentSquare.Row - 2;
                actualMoveBlack = currentSquare.Row + 2;
            }
            else
            {
                actualMoveWhite = currentSquare.Row - 1;
                actualMoveBlack = currentSquare.Row + 1;
            }
            if (playerColor == Player.White)//Could possible simplify
            {
                availableMoves.Add(Square.At(actualMoveWhite, currentSquare.Col));
            }
            else
            {
                availableMoves.Add(Square.At(actualMoveBlack, currentSquare.Col));
            }

            return availableMoves;
        }
    }
}