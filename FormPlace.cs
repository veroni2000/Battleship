﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleship
{
    public partial class FormPlace : Form
    {
        private Ship _shipToBePlaced = null;
        private bool _orientationH;
        private List<Square> _openSquares = new List<Square>();
        private int _shipIndex;
        private bool ready = false;
        private int clearSelect = 5;

        private List<Ship> _ships;
        public List<Ship> Ships
        {
            get
            {
                return _ships;
            }
            set
            {
                _ships = value;
            }
        }
        private Board _board;
        public Board Board
        {
            get
            {
                return _board;
            }
            set
            {
                _board = value;
            }
        }
        public FormPlace()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            foreach (var square in Board.Squares)
            {
                if (square.IsOccupied) square.Color = Color.Green;
                square.Draw(e.Graphics);
            }
            foreach(var ship in Ships)
            {
                if(ship.IsPlaced)
                selectShip.Items.Remove(ship.Name);
            }
        }
        private void FormPlace_Load(object sender, EventArgs e)
        {

        }

        private void FormPlace_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var _click = _openSquares.Where(s => s.Contains(e.Location))
                .FirstOrDefault();
                if (_click != null)
                {
                    List<Square> affectedSquares;
                    if (_orientationH)
                    {
                        affectedSquares = Board.Squares
                            .Range(_click.Coordinates.Row, _click.Coordinates.Column,
                            _click.Coordinates.Row, _click.Coordinates.Column + _shipToBePlaced.Width - 1);
                    }
                    else
                    {
                        affectedSquares = Board.Squares
                            .Range(_click.Coordinates.Row, _click.Coordinates.Column,
                            _click.Coordinates.Row + _shipToBePlaced.Width - 1, _click.Coordinates.Column);
                    }
                    foreach (var square in affectedSquares)
                        square.Occupation = _shipToBePlaced.Occupation;

                    clearSelect--;
                    _shipToBePlaced = null;

                    labelPlace.Text = "";
                    affectedSquares = null;
                    _openSquares = new List<Square>();
                    selectShip.Items.RemoveAt(_shipIndex);
                    if (selectShip.Items.Count == 0) ready = true;
                    if (clearSelect == 0)
                    {
                        selectShip.Visible = false;
                        selectOrientation.Visible = false;
                        buttonPlace.Visible = false;
                    }
                }
            }
            Invalidate();
        }
        private void buttonPlace_Click(object sender, EventArgs e)
        {
            if (selectShip.SelectedIndex==selectShip.Items.IndexOf("Carrier(5)"))
            {
                _shipIndex = selectShip.Items.IndexOf("Carrier(5)");
                _shipToBePlaced = new Carrier(); 
            }
            else if (selectShip.SelectedIndex == selectShip.Items.IndexOf("Battleship(4)"))
            {
                _shipIndex = selectShip.Items.IndexOf("Battleship(4)");
                _shipToBePlaced = new Battleship();
            }
            else if (selectShip.SelectedIndex == selectShip.Items.IndexOf("Cruiser(3)"))
            {
                _shipIndex = selectShip.Items.IndexOf("Cruiser(3)");
                _shipToBePlaced = new Cruiser();
            }
            else if (selectShip.SelectedIndex == selectShip.Items.IndexOf("Submarine(3)"))
            {
                _shipIndex = selectShip.Items.IndexOf("Submarine(3)");
                _shipToBePlaced = new Submarine();
            }
            else if(selectShip.SelectedIndex == selectShip.Items.IndexOf("Destroyer(2)"))
            {
                _shipIndex = selectShip.Items.IndexOf("Destroyer(2)");
                _shipToBePlaced = new Destroyer();
            }
            if (radioButtonV.Checked) _orientationH = false;
            else _orientationH = true;
            if (_shipToBePlaced == null)
            {
                MessageBox.Show("Select ship first!");
            }
            else
            {
                _openSquares = new List<Square>();
                labelPlace.Text = "Place your "+_shipToBePlaced.Name;
                MessageBox.Show(_shipToBePlaced.Width.ToString());
                foreach (var square in Board.Squares)
                {
                    var startColumn = square.Coordinates.Column;
                    var startRow = square.Coordinates.Row;
                    int endRow = startRow, endColumn = startColumn;

                    List<int> squareNumbers = new List<int>();

                    for (int i = 1; i < _shipToBePlaced.Width; i++)
                    {
                        if (!_orientationH)
                            endRow++;
                        else endColumn++;
                    }

                    if (endRow > 10 || endColumn > 10)
                    {
                        continue;
                    }

                    var affectedSquares = Board.Squares.Range(startRow, startColumn, endRow, endColumn);

                    if (affectedSquares.Any(s => s.IsOccupied))
                    {
                        continue;
                    }

                    _openSquares.Add(square);
                }
                
                Invalidate();
            }
            
        }
        private void buttonReady_Click(object sender, EventArgs e)
        {
            if (ready)
                DialogResult = DialogResult.OK;
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            clearSelect = 5;
            DialogResult = DialogResult.Cancel;
            
        }
    }
}