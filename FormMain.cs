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
        private Player Opponent = new Player("Opponent", new Point(40, 100));
        private Player Player = new Player("Player", new Point(410, 100));
        private Square _click = null;
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public FormMain()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            foreach (var square in Opponent.Board.Squares)
            {
                if (Player.HasLost&&square.IsOccupied&&square.Occupation!=Occupation.Hit)
                {
                    square.Color = Color.Green;
                }
                if (square.Occupation == Occupation.Hit) square.Color = Color.Red;
                if (square.Occupation == Occupation.Miss) square.Color = Color.White;
                square.Draw(e.Graphics);
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
            Player.PlaceRandomShips();
        }

        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _click = Opponent.Board.Squares.Where(s => s.Contains(e.Location) &&
                s.Occupation != Occupation.Hit &&
                s.Occupation != Occupation.Miss).FirstOrDefault();
                if (_click != null && !Player.HasLost && !Opponent.HasLost)
                {
                    _click.isOpen = false;
                    Opponent.AfterShot(_click);

                    var shotCoord = Player.Shot();
                    var shot = Player.Board.Squares.Where(s => s.Coordinates == shotCoord).FirstOrDefault();
                    shot.isOpen = false;

                    Player.AfterShot(shot);
                }       
            }
            Invalidate();
        }

    }
}
