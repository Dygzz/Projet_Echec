using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echec
{
       abstract class Pawn
    {
        public enum Color { White, Black };
        public Color color;
        public bool boardLimit;
        public string signe;
        
        public Pawn(Color c)
        {
            color = c;
        }

        public bool TestBoardLimit(int x, int y)
        {
            if (x < 0 || x > 7 || y < 0 || y > 7)
                return false;
            else
                return true;
        }
        public virtual List<Coordone> GetUsuableCoordinate(Coordone PieceCoord , Pawn[,] Board)
        {
            return new List<Coordone>();
            //TODO faire la liste des coord attaignable par la piece
        }
    }
}
