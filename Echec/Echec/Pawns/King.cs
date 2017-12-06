using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echec.Pawns
{
    class King : Pawn
    {
        public King(Color c) : base(c)
        {
            color = c;
            signe = "K";
        }


        public override List<Coordone> GetUsuableCoordinate(Coordone PieceCoord, Pawn[,] Board)
        {
            List<Coordone> Coords = new List<Coordone>();
            int a = 1;
            int b = 1;
            int c = 1;
            int d = 1;
            Color adversaire = Color.White;
            if (color == Color.White)
            {
                adversaire = Color.Black;
            }

            switch (PieceCoord.x)
            {
                case 7:
                    a = 0;
                    break;
                case 0:
                    b = 0;
                    break;
            }
            switch (PieceCoord.y)
            {
                case 7:
                    c = 0;
                    break;
                case 0:
                    d = 0;
                    break;
            }


            Pawn PieceCaseDeplacement = Board[PieceCoord.x, PieceCoord.y + c];
            Pawn PieceCaseDeplacement2 = Board[PieceCoord.x, PieceCoord.y - d];
            Pawn PieceCaseDeplacement3 = Board[PieceCoord.x + a, PieceCoord.y];
            Pawn PieceCaseDeplacement4 = Board[PieceCoord.x - b, PieceCoord.y];

            //Attack 5
            if (this.TestBoardLimit(PieceCoord.x - 1, PieceCoord.y + 1))
            {
                Pawn PieceCaseDeplacement5 = Board[PieceCoord.x - 1, PieceCoord.y + 1];

                if (PieceCaseDeplacement5 == null && this.TestBoardLimit(PieceCoord.x - 1, PieceCoord.y + 1))
                {
                    Coords.Add(new Coordone(PieceCoord.x - 1, PieceCoord.y + 1));
                }
                if (PieceCaseDeplacement5 != null && PieceCaseDeplacement5.color == adversaire)
                {
                    Coords.Add(new Coordone(PieceCoord.x - 1, PieceCoord.y + 1));
                }
            }

            //Attack 6
            if (this.TestBoardLimit(PieceCoord.x - 1, PieceCoord.y - 1))
            {
                Pawn PieceCaseDeplacement6 = Board[PieceCoord.x - 1, PieceCoord.y - 1];

                if (PieceCaseDeplacement6 == null && this.TestBoardLimit(PieceCoord.x - 1, PieceCoord.y - 1))
                {
                    Coords.Add(new Coordone(PieceCoord.x - 1, PieceCoord.y - 1));
                }
                if (PieceCaseDeplacement6 != null && PieceCaseDeplacement6.color == adversaire)
                {
                    Coords.Add(new Coordone(PieceCoord.x - 1, PieceCoord.y - 1));
                }
            }

            //Attack 7
            if (this.TestBoardLimit(PieceCoord.x + 1, PieceCoord.y - 1))
            {
                Pawn PieceCaseDeplacement7 = Board[PieceCoord.x + 1, PieceCoord.y - 1];
                if (PieceCaseDeplacement7 == null && this.TestBoardLimit(PieceCoord.x + 1, PieceCoord.y - 1))
                {
                    Coords.Add(new Coordone(PieceCoord.x + 1, PieceCoord.y - 1));
                }

                if (PieceCaseDeplacement7 != null && PieceCaseDeplacement7.color == adversaire)
                {
                    Coords.Add(new Coordone(PieceCoord.x + 1, PieceCoord.y - 1));
                }
            }

            //Attack 8
            if (this.TestBoardLimit(PieceCoord.x + 1, PieceCoord.y + 1))
            {
                Pawn PieceCaseDeplacement8 = Board[PieceCoord.x + 1, PieceCoord.y + 1];

                if (PieceCaseDeplacement8 == null && this.TestBoardLimit(PieceCoord.x + 1, PieceCoord.y + 1))
                {
                    Coords.Add(new Coordone(PieceCoord.x + 1, PieceCoord.y + 1));
                }
                if (PieceCaseDeplacement8 != null && PieceCaseDeplacement8.color == adversaire)
                {
                    Coords.Add(new Coordone(PieceCoord.x + 1, PieceCoord.y + 1));
                }
            }
                

            //Attack1
            if (PieceCaseDeplacement == null && this.TestBoardLimit(PieceCoord.x, PieceCoord.y + c))
            {
                Coords.Add(new Coordone(PieceCoord.x, PieceCoord.y + c));
            }
            if (PieceCaseDeplacement != null && PieceCaseDeplacement.color == adversaire)
            {
                Coords.Add(new Coordone(PieceCoord.x, PieceCoord.y + c));
            }

            //Attack2
            if (PieceCaseDeplacement2 == null && this.TestBoardLimit(PieceCoord.x, PieceCoord.y - d))
            {
                Coords.Add(new Coordone(PieceCoord.x, PieceCoord.y - d));
            }
            if (PieceCaseDeplacement2 != null && PieceCaseDeplacement2.color == adversaire)
            {
                Coords.Add(new Coordone(PieceCoord.x, PieceCoord.y - d));
            }

            //Attack 3

            if (PieceCaseDeplacement3 == null && this.TestBoardLimit(PieceCoord.x + a, PieceCoord.y))
            {
                Coords.Add(new Coordone(PieceCoord.x + a, PieceCoord.y));
            }

            if (PieceCaseDeplacement3 != null && PieceCaseDeplacement3.color == adversaire)
            {
                Coords.Add(new Coordone(PieceCoord.x + a, PieceCoord.y));
            }

            //Attack 4   
            if (PieceCaseDeplacement4 == null && this.TestBoardLimit(PieceCoord.x - b, PieceCoord.y))
            {
                Coords.Add(new Coordone(PieceCoord.x - b, PieceCoord.y));
            }
            if (PieceCaseDeplacement4 != null && PieceCaseDeplacement4.color == adversaire)
            {
                Coords.Add(new Coordone(PieceCoord.x - b, PieceCoord.y));
            }

            //Attack 5


            //Attack 6
           

            //Attack 7

            //Attack 8
            

            return Coords;
        }
    }
}
