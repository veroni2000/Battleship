using System;
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
    public partial class FormMain : Form
    {
        private Player Opponent = new Player(new Point(40, 100));
        private Player Player = new Player(new Point(410, 100));
        private Square _click = null;
        private bool playing = false;
        public FormMain()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (playing)
            {
                UpdateShipsLabel(Player.Ships, labelShipsPl);
                UpdateShipsLabel(Opponent.Ships, labelShipsOp);
                foreach (var square in Opponent.Board.Squares)
                {
                    if (Player.HasLost && square.IsOccupied && square.Occupation != Occupation.Hit)
                    {
                        square.Color = Color.Green;
                    }
                    if (square.Occupation == Occupation.Hit) square.Color = Color.Red;
                    if (square.Occupation == Occupation.Miss) square.Color = Color.White;
                    square.Draw(e.Graphics);
                }
            }
            foreach (var square in Player.Board.Squares)
            {
                if (square.IsOccupied) square.Color = Color.Green;
                if (square.Occupation == Occupation.Hit) square.Color = Color.Red;
                if (square.Occupation == Occupation.Miss) square.Color = Color.White;
                square.Draw(e.Graphics);
            }
            if (Player.HasLost)
            {
                gameStatus.Text = "You lose!";
                gameStatus.ForeColor = Color.Red;
            }
            if (Opponent.HasLost)
            {
                gameStatus.Text = "You win!";
                gameStatus.ForeColor = Color.Green;
            }
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            Opponent.PlaceRandomShips();

        }
        private void UpdateShipsLabel(List<Ship> ships, Label label)
        {
            label.Text = "";
            int i = 0;
            foreach (var ship in ships)
            {
                if (!ship.IsSunk)
                {
                    i++;
                    label.Text += ship.Name + "(" + ship.Width + ") ";
                    if (i == 3) label.Text += '\n';
                }
            }
        }
        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (playing)
                {
                    _click = Opponent.Board.Squares.Where(s => s.Contains(e.Location) &&
                    s.Occupation != Occupation.Hit &&
                    s.Occupation != Occupation.Miss).FirstOrDefault();
                    if (_click != null && !Player.HasLost && !Opponent.HasLost)
                    {
                        _click.isOpen = false;
                        Opponent.AfterShot(_click);

                        if (!Opponent.HasLost)
                        {
                            var shotCoord = Player.Shot();
                            var shot = Player.Board.Squares.Where(s => s.Coordinates == shotCoord).FirstOrDefault();
                            shot.isOpen = false;
                            Player.AfterShot(shot);
                        }

                    }
                }
            }
            Invalidate();
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            playing = true;
            buttonStart.Visible = false;
            buttonPlace.Visible = false;
            labelRandom.Visible = false;
            PlayerB.Visible = true;
            AIb.Visible = true;
            if (!Player.PlacedShips) Player.PlaceRandomShips();
            Invalidate();
        }
        private void buttonPlace_Click(object sender, EventArgs e)
        {
            var form = new FormPlace();
            var ships = Player.Ships;
            form.Ships = ships;
            var board = Player.Board;
            form.Board = board;
            if (form.ShowDialog() == DialogResult.OK)
            {
                Player.Ships = form.Ships;
                Player.Board = form.Board;
                Player.PlacedShips = true;
                buttonPlace.Visible = false;
                buttonStart_Click(sender, e);
            }
            else
            {
                Player = new Player(new Point(410, 100));
            }            
            Invalidate();
        }
    }
}
