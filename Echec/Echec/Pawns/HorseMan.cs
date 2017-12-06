using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echec.Pawns
{
    class HorseMan : Pawn
    {
        public HorseMan(Color c ) : base(c)
        {
            color = c;
            signe = "C";
        }

        public override List<Coordone> GetUsuableCoordinate(Coordone PieceCoord, Pawn[,] Board)
        {
            List<Coordone> Coords = new List<Coordone>();

            Color adversaire = Color.White;
            if (color == Color.White)
            {
                
                adversaire = Color.Black;
            }

            
            if (this.TestBoardLimit(PieceCoord.x - 2, PieceCoord.y + 1))
            {
                Pawn PieceCaseDeplacement = Board[PieceCoord.x - 2, PieceCoord.y + 1];

                if (PieceCaseDeplacement == null && this.TestBoardLimit(PieceCoord.x - 2, PieceCoord.y + 1))
                {
                    Coords.Add(new Coordone(PieceCoord.x - 2, PieceCoord.y + 1));
                }
                if (PieceCaseDeplacement != null && PieceCaseDeplacement.color == adversaire)
                {
                    Coords.Add(new Coordone(PieceCoord.x - 2, PieceCoord.y + 1));
                }
            }

            //Attack 2 
            if ((this.TestBoardLimit(PieceCoord.x - 1, PieceCoord.y + 2)))
            {
                Pawn PieceCaseDeplacement2 = Board[PieceCoord.x - 1, PieceCoord.y + 2];
                if (PieceCaseDeplacement2 == null && this.TestBoardLimit(PieceCoord.x - 1, PieceCoord.y + 2))
                {
                    Coords.Add(new Coordone(PieceCoord.x - 1, PieceCoord.y + 2));
                }
                if (PieceCaseDeplacement2 != null && PieceCaseDeplacement2.color == adversaire)
                {
                    Coords.Add(new Coordone(PieceCoord.x - 1, PieceCoord.y + 2));
                }
            }
            //Attack 3 
            if ((this.TestBoardLimit(PieceCoord.x + 1, PieceCoord.y + 2)))
            {
                Pawn PieceCaseDeplacement3 = Board[PieceCoord.x + 1, PieceCoord.y + 2];

                if (PieceCaseDeplacement3 == null && this.TestBoardLimit(PieceCoord.x + 1, PieceCoord.y + 2))
                {
                    Coords.Add(new Coordone(PieceCoord.x + 1, PieceCoord.y + 2));
                }

                if (PieceCaseDeplacement3 != null && PieceCaseDeplacement3.color == adversaire)
                {
                    Coords.Add(new Coordone(PieceCoord.x + 1, PieceCoord.y + 2));
                }
            }
            //Attack 4
            if (this.TestBoardLimit(PieceCoord.x + 2, PieceCoord.y + 1))
            {
                Pawn PieceCaseDeplacement4 = Board[PieceCoord.x + 2, PieceCoord.y + 1];
                if (PieceCaseDeplacement4 == null && this.TestBoardLimit(PieceCoord.x + 2, PieceCoord.y + 1))
                {
                    Coords.Add(new Coordone(PieceCoord.x + 2, PieceCoord.y + 1));
                }
                if (PieceCaseDeplacement4 != null && PieceCaseDeplacement4.color == adversaire)
                {
                    Coords.Add(new Coordone(PieceCoord.x + 2, PieceCoord.y + 1));
                }

            }
            //Attack 5
            if (this.TestBoardLimit(PieceCoord.x - 2, PieceCoord.y - 1))
            {
                Pawn PieceCaseDeplacement5 = Board[PieceCoord.x - 2, PieceCoord.y - 1];
                if (PieceCaseDeplacement5 == null && this.TestBoardLimit(PieceCoord.x - 2, PieceCoord.y - 1))
                {
                    Coords.Add(new Coordone(PieceCoord.x - 2, PieceCoord.y - 1));
                }
                if (PieceCaseDeplacement5 != null && PieceCaseDeplacement5.color == adversaire)
                {
                    Coords.Add(new Coordone(PieceCoord.x - 2, PieceCoord.y - 1));
                }
            }
            //Attack 6
            if (this.TestBoardLimit(PieceCoord.x - 1, PieceCoord.y - 2))
            {
                Pawn PieceCaseDeplacement6 = Board[PieceCoord.x - 1, PieceCoord.y - 2];
                if (PieceCaseDeplacement6 == null && this.TestBoardLimit(PieceCoord.x - 1, PieceCoord.y - 2))
                {
                    Coords.Add(new Coordone(PieceCoord.x - 1, PieceCoord.y - 2));
                }
                if (PieceCaseDeplacement6 != null && PieceCaseDeplacement6.color == adversaire)
                {
                    Coords.Add(new Coordone(PieceCoord.x - 1, PieceCoord.y - 2));
                }
            }
            //Attack 7
            if (this.TestBoardLimit(PieceCoord.x + 1, PieceCoord.y - 2))
            {
                Pawn PieceCaseDeplacement7 = Board[PieceCoord.x + 1, PieceCoord.y - 2];
                if (PieceCaseDeplacement7 == null && this.TestBoardLimit(PieceCoord.x + 1, PieceCoord.y - 2))
                {
                    Coords.Add(new Coordone(PieceCoord.x + 1, PieceCoord.y - 2));
                }

                if (PieceCaseDeplacement7 != null && PieceCaseDeplacement7.color == adversaire)
                {
                    Coords.Add(new Coordone(PieceCoord.x + 1, PieceCoord.y - 2));
                }
            }
            //Attack 8
            if (this.TestBoardLimit(PieceCoord.x + 2, PieceCoord.y - 1))
            {
                Pawn PieceCaseDeplacement8 = Board[PieceCoord.x + 2, PieceCoord.y - 1];
                if (PieceCaseDeplacement8 == null && this.TestBoardLimit(PieceCoord.x + 2, PieceCoord.y - 1))
                {
                    Coords.Add(new Coordone(PieceCoord.x + 2, PieceCoord.y - 1));
                }
                if (PieceCaseDeplacement8 != null && PieceCaseDeplacement8.color == adversaire)
                {
                    Coords.Add(new Coordone(PieceCoord.x + 2, PieceCoord.y - 1));
                }
            }

            return Coords;
        }
    }
}
