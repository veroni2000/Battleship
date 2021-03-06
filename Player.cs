﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Player
    {
        public List<Ship> Ships { get; set; }
        public Board Board { get; set; }
        public bool PlacedShips = false;
        public bool HasLost
        {
            get
            {
                return Ships.All(s => s.IsSunk);
            }
        }
        public Player(Point point)
        {
            Ships = new List<Ship>()
            {
                new Carrier(),
                new Battleship(),
                new Cruiser(),
                new Submarine(),
                new Destroyer(),
            };
            Board = new Board(point);
        }
        public void PlaceRandomShips()
        {
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            foreach (var ship in Ships)
            {
                bool isOpen = true;
                while (isOpen)
                {
                    var startColumn = rand.Next(1, 11);
                    var startRow = rand.Next(1, 11);
                    int endRow = startRow, endColumn = startColumn;
                    var orientation = rand.Next(1, 101) % 2; //1 е хоризонтално

                    List<int> squareNumbers = new List<int>();

                    for (int i = 1; i < ship.Width; i++)
                    {
                        if (orientation == 0)
                            endRow++;
                        else endColumn++;
                    }

                    if (endRow > 10 || endColumn > 10)
                    {
                        isOpen = true;
                        continue;
                    }

                    var affectedSquares = Board.Squares.Range(startRow, startColumn, endRow, endColumn);

                    if(affectedSquares.Any(s => s.IsOccupied))
                    {
                        isOpen = true;
                        continue;
                    }

                    foreach (var square in affectedSquares)
                        square.Occupation = ship.Occupation;

                    isOpen = false;
                }
            }
            PlacedShips = true;
        }
        public Coordinates Shot()
        {
            var hitNeighbors = Board.GetHitNeighbors();
            Coordinates coordinates;
            if (hitNeighbors.Any()) {
                coordinates = SearchingShot(); }
            else
            {
                coordinates = RandomShot();
            }
            return coordinates;
        }
        private Coordinates RandomShot()
        {
            var available = Board.GetOpenSquares();
            Random rand = new Random();
            int square = rand.Next(0,available.Count-1);
            return available[square];

        }
        private Coordinates SearchingShot()
        {
            Random rand = new Random();
            var hitNeighbors = Board.GetHitNeighbors();
            var neighbor = rand.Next(0,hitNeighbors.Count-1);
            return hitNeighbors[neighbor].Coordinates;
        }
        public void AfterShot(Square shot)
        {
            if (shot.IsOccupied)
            {
                foreach (var ship in Ships)
                {
                    if (ship.Occupation == shot.Occupation) ship.Width--;
                }
                Board.Squares.Where(s => s == shot).FirstOrDefault().Occupation = Occupation.Hit;
            }
            else
            {
                Board.Squares.Where(s => s==shot).FirstOrDefault().Occupation = Occupation.Miss;
            }
        }
    }
}
