using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echec.Pawns
{
    class Queen : Pawn
    {
        public Queen(Color c) : base(c)
        {
            color = c;
            signe = "Q";
        }

        public override List<Coordone> GetUsuableCoordinate(Coordone PieceCoord, Pawn[,] Board)
        {
            List<Coordone> Coords = new List<Coordone>();

            Color adversaire = Color.White;
            if (color == Color.White)
            {
                adversaire = Color.Black;
            }
            //Attack1Tower
            for (int a = 1; a < 8; a++)
            {
                if (PieceCoord.y + a > 7)
                {
                    break;
                }
                Pawn PieceCaseDeplacement = Board[PieceCoord.x, PieceCoord.y + a];

                if (PieceCaseDeplacement == null && this.TestBoardLimit(PieceCoord.x, PieceCoord.y + a))
                {
                    Coords.Add(new Coordone(PieceCoord.x, PieceCoord.y + a));
                }
                else if (PieceCaseDeplacement != null && PieceCaseDeplacement.color == adversaire)
                {
                    Coords.Add(new Coordone(PieceCoord.x, PieceCoord.y + a));
                    break;
                }

                else
                {
                    break;
                }
            }
            //Attack2Tower
            for (int a = 1; a < 8; a++)
            {
                if (PieceCoord.y - a < 0)
                {
                    break;
                }
                Pawn PieceCaseDeplacement2 = Board[PieceCoord.x, PieceCoord.y - a];

                if (PieceCaseDeplacement2 == null && this.TestBoardLimit(PieceCoord.x, PieceCoord.y - a))
                {
                    Coords.Add(new Coordone(PieceCoord.x, PieceCoord.y - a));
                }
                else if (PieceCaseDeplacement2 != null && PieceCaseDeplacement2.color == adversaire)
                {
                    Coords.Add(new Coordone(PieceCoord.x, PieceCoord.y - a));
                    break;
                }
                else
                {
                    break;
                }
            }
            //Attack3Tower
            for (int a = 1; a < 8; a++)
            {
                if (PieceCoord.x + a > 7)
                {
                    break;
                }
                Pawn PieceCaseDeplacement3 = Board[PieceCoord.x + a, PieceCoord.y];

                if (PieceCaseDeplacement3 == null && this.TestBoardLimit(PieceCoord.x + a, PieceCoord.y))
                {
                    Coords.Add(new Coordone(PieceCoord.x + a, PieceCoord.y));
                }

                else if (PieceCaseDeplacement3 != null && PieceCaseDeplacement3.color == adversaire)
                {
                    Coords.Add(new Coordone(PieceCoord.x + a, PieceCoord.y));
                    break;
                }

                else
                {
                    break;
                }

            }
            //Attack4Tower
            for (int a = 1; a < 8; a++)
            {
                if (PieceCoord.x - a < 0)
                {
                    break;
                }
                Pawn PieceCaseDeplacement4 = Board[PieceCoord.x - a, PieceCoord.y];
                if (PieceCaseDeplacement4 == null && this.TestBoardLimit(PieceCoord.x - a, PieceCoord.y))
                {
                    Coords.Add(new Coordone(PieceCoord.x - a, PieceCoord.y));
                }
                else if (PieceCaseDeplacement4 != null && PieceCaseDeplacement4.color == adversaire)
                {
                    Coords.Add(new Coordone(PieceCoord.x - a, PieceCoord.y));
                    break;
                }
                else
                {
                    break;
                }
            }

            //Attack1Bischop
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
            //Attack2Bischop
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
            //Attack3Bischop
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
            //Attack4Bischop
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
