using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    public class Board
    {
        public List<Square> Squares { get; set; }
        public Board(Point point)
        {
            Squares = new List<Square>();
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    var square = new Square(i, j)
                    {
                        Location = point
                    };
                    Squares.Add(square);
                    point.X += 33;
                }
                point.X -= 330;
                point.Y += 33;
            }
        }
        public List<Square> GetAllHits()
        {
            return Squares.Where(s => s.Occupation == Occupation.Hit).ToList();
        }
        public List<Square> GetNeighbors(Coordinates coordinates)
        {
            int row = coordinates.Row;
            int column = coordinates.Column;
            List<Square> squares = new List<Square>();
            if (column > 1) squares.Add(Squares.At(row, column - 1));
            if (row > 1) squares.Add(Squares.At(row - 1, column));
            if (column < 10) squares.Add(Squares.At(row, column + 1));
            if (row < 10) squares.Add(Squares.At(row + 1, column));
            return squares;
        }
        public List<Square> GetHitNeighbors()
        {
            List<Square> squares = new List<Square>();
            var hits = GetAllHits();
            foreach(var hit in hits)
            {
                foreach(var n in GetNeighbors(hit.Coordinates))
                {
                    if (n.isOpen) squares.Add(n);
                }
            }
            return squares;
        }
        public List<Coordinates> GetOpenSquares()
        {
            return Squares.Where(s => s.isOpen
            && s.IsRandomAvailable).Select(s => s.Coordinates).ToList();
        }
    }
}
