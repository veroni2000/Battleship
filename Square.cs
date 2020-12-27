using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    public class Square
    {
        public bool isOpen = true;
        public Square(int row, int column)
        {
            Coordinates = new Coordinates(row, column);
            Width = 30;
            Color = Color.Aqua;
        }
        protected int width;
        public int Width
        {
            get { return width; }
            set
            {
                if (value <= 0) throw new ArgumentException("Width must be greater than 0.");
                else width = value;
            }
        }
        public Point Location { get; set; }
        public Coordinates Coordinates { get; set; }
        public Occupation Occupation { get; set; }
        public Color Color { get; set; }
        public bool Contains(Point point)
        {
            return
                Location.X < point.X && point.X < Location.X + Width &&
                Location.Y < point.Y && point.Y < Location.Y + Width;
        }
        public void Draw(Graphics graphics)
        {
            using (var pen = new Pen(Color, 3))
            {
                graphics.DrawRectangle(pen, Location.X, Location.Y, Width, Width);
            }
            using (var brush = new SolidBrush(Color.FromArgb(Math.Min(byte.MaxValue, Color.R + 150),
                    Math.Min(byte.MaxValue, Color.G + 150),
                    Math.Min(byte.MaxValue, Color.B + 150))))
            {
                graphics.FillRectangle(brush, Location.X, Location.Y,
                    Width, Width);
            }
        }
        public bool IsOccupied
        {
            get
            {
                return
                    Occupation == Occupation.Carrier ||
                    Occupation == Occupation.Battleship ||
                    Occupation == Occupation.Cruiser ||
                    Occupation == Occupation.Submarine ||
                    Occupation == Occupation.Destroyer;
            }
        }
        public bool IsRandomAvailable
        {
            get
            {
                return (Coordinates.Row % 2 == 0 && Coordinates.Column % 2 == 0)
                    || (Coordinates.Row % 2 == 1 && Coordinates.Column % 2 == 1);
            }
        }
    }
    public enum Occupation
    {
        Empty,
        Hit,
        Miss,
        Carrier,
        Battleship,
        Cruiser,
        Submarine,
        Destroyer
    }
    public class Coordinates
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public Coordinates(int row, int column)
        {
            Row = row;
            Column = column;
        }
    }
    public static class SquareExtensions
    {
        public static List<Square> Range(this List<Square> squares,
            int startRow,
            int startColumn,
            int endRow,
            int endColumn)
        {
            return squares.Where(s => s.Coordinates.Row >= startRow
            && s.Coordinates.Column >= startColumn
            && s.Coordinates.Row <= endRow
            && s.Coordinates.Column <= endColumn).ToList();
        }
        public static Square At(this List<Square> squares, int row, int column)
        {
            return squares.Where(s => s.Coordinates.Row == row && s.Coordinates.Column == column).First();
        }
    }   
}
