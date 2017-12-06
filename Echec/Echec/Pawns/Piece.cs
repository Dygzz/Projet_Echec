using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Echec.Pawns
{
    class Piece : Pawn
    {
        
        public Piece(Color c) : base(c)
        {
            color = c;
            signe = "P";
        }
        public override List<Coordone> GetUsuableCoordinate(Coordone PieceCoord, Pawn[,] Board)
        {
            List<Coordone> Coords = new List<Coordone>();
            int a = 1;
            Color adversaire = Color.White;
            if (color == Color.White)
            {
                adversaire = Color.Black;
                a = -1;
            }
            //Deplacement
            if (this.TestBoardLimit(PieceCoord.x, PieceCoord.y + a))
            {
                Pawn pieceCaseDeplacement = Board[PieceCoord.x, PieceCoord.y + a];
                if (pieceCaseDeplacement == null)
                {
                    Coords.Add(new Coordone(PieceCoord.x, PieceCoord.y + a));
                }
            }

            //Attack 1
            if (this.TestBoardLimit(PieceCoord.x + 1, PieceCoord.y + a))
            {
                Pawn PieceAttaks = Board[PieceCoord.x + 1, PieceCoord.y + a];
                if (PieceAttaks != null && PieceAttaks.color == adversaire)
                {
                    Coords.Add(new Coordone(PieceCoord.x + 1, PieceCoord.y + a));
                }
            }
            
            //Attack 2
            if (this.TestBoardLimit(PieceCoord.x - 1, PieceCoord.y + a))
            {
                Pawn PieceAttaks2 = Board[PieceCoord.x - 1, PieceCoord.y + a];

                if (PieceAttaks2 != null && PieceAttaks2.color == adversaire)
                {
                    Coords.Add(new Coordone(PieceCoord.x - 1, PieceCoord.y + a));
                }
            }

            return Coords;
        }
    }
}

