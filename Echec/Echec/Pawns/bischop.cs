using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echec.Pawns
{
    class bischop : Pawn
    {
      public bischop(Color c) : base(c)
        {
            color = c;
            signe = "F";
        }

        public override List<Coordone> GetUsuableCoordinate(Coordone PieceCoord, Pawn[,] Board)
        {
            List<Coordone> Coords = new List<Coordone>();

            Color adversaire = Color.White;
            if (color == Color.White)
            {
               
                adversaire = Color.Black;
            }

            //Attack1
            for (int a = 1; a < 8; a++)
            {
                if (PieceCoord.x - a < 0 || PieceCoord.y + a > 7)
                {
                    break;
                }
                Pawn PieceCaseDeplacement = Board[PieceCoord.x - a, PieceCoord.y + a];

                if (PieceCaseDeplacement == null && this.TestBoardLimit(PieceCoord.x - a, PieceCoord.y + a))
                {
                    Coords.Add(new Coordone(PieceCoord.x - a, PieceCoord.y + a));
                }
                else if (PieceCaseDeplacement != null && PieceCaseDeplacement.color == adversaire)
                {
                    Coords.Add(new Coordone(PieceCoord.x - a, PieceCoord.y + a));
                    break;
                }

                else
                {
                    break;
                }
            }
            //Attack2
            for (int a = 1; a < 8; a++)
            {
                if (PieceCoord.x - a < 0 || PieceCoord.y - a < 0)
                {
                    break;
                }
                Pawn PieceCaseDeplacement2 = Board[PieceCoord.x - a, PieceCoord.y - a];

                if (PieceCaseDeplacement2 == null && this.TestBoardLimit(PieceCoord.x - a, PieceCoord.y - a))
                {
                    Coords.Add(new Coordone(PieceCoord.x - a, PieceCoord.y - a));
                }
                else if (PieceCaseDeplacement2 != null && PieceCaseDeplacement2.color == adversaire)
                {
                    Coords.Add(new Coordone(PieceCoord.x - a, PieceCoord.y - a));
                    break;
                }
                else
                {
                    break;
                }
            }
            //Attack3
            for (int a = 1; a < 8; a++)
            {
                if (PieceCoord.x + a > 7 || PieceCoord.y - a < 0)
                {
                    break;
                }
                Pawn PieceCaseDeplacement3 = Board[PieceCoord.x + a, PieceCoord.y - a];

                if (PieceCaseDeplacement3 == null && this.TestBoardLimit(PieceCoord.x + a, PieceCoord.y - a))
                {
                    Coords.Add(new Coordone(PieceCoord.x + a, PieceCoord.y - a));
                }

                else if (PieceCaseDeplacement3 != null && PieceCaseDeplacement3.color == adversaire)
                {
                    Coords.Add(new Coordone(PieceCoord.x + a, PieceCoord.y - a));
                    break;
                }

                else
                {
                    break;
                }

            }
            //Attack4
            for (int a = 1; a < 8; a++)
            {
                if (PieceCoord.x + a > 7 || PieceCoord.y + a > 7)
                {
                    break;
                }
                Pawn PieceCaseDeplacement4 = Board[PieceCoord.x + a, PieceCoord.y + a];
                if (PieceCaseDeplacement4 == null && this.TestBoardLimit(PieceCoord.x + a, PieceCoord.y + a))
                {
                    Coords.Add(new Coordone(PieceCoord.x + a, PieceCoord.y + a));
                }
                else if (PieceCaseDeplacement4 != null && PieceCaseDeplacement4.color == adversaire)
                {
                    Coords.Add(new Coordone(PieceCoord.x + a, PieceCoord.y + a));
                    break;
                }
                else
                {
                    break;
                }
            }
           
            return Coords;
        }
    }
}
