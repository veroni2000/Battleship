namespace Battleship
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AIb = new System.Windows.Forms.Label();
            this.PlayerB = new System.Windows.Forms.Label();
            this.gameStatus = new System.Windows.Forms.Label();
            this.labelShipsOp = new System.Windows.Forms.Label();
            this.labelShipsPl = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonPlace = new System.Windows.Forms.Button();
            this.labelRandom = new System.Windows.Forms.Label();
            this.buttonPlayAgain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AIb
            // 
            this.AIb.AutoSize = true;
            this.AIb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AIb.ForeColor = System.Drawing.Color.MidnightBlue;
            this.AIb.Location = new System.Drawing.Point(40, 75);
            this.AIb.Name = "AIb";
            this.AIb.Size = new System.Drawing.Size(148, 19);
            this.AIb.TabIndex = 2;
            this.AIb.Text = "Opponent`s board";
            this.AIb.Visible = false;
            // 
            // PlayerB
            // 
            this.PlayerB.AutoSize = true;
            this.PlayerB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayerB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.PlayerB.Location = new System.Drawing.Point(410, 75);
            this.PlayerB.Name = "PlayerB";
            this.PlayerB.Size = new System.Drawing.Size(120, 19);
            this.PlayerB.TabIndex = 3;
            this.PlayerB.Text = "Player`s board";
            this.PlayerB.Visible = false;
            // 
            // gameStatus
            // 
            this.gameStatus.AutoSize = true;
            this.gameStatus.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameStatus.ForeColor = System.Drawing.Color.Green;
            this.gameStatus.Location = new System.Drawing.Point(325, 25);
            this.gameStatus.Name = "gameStatus";
            this.gameStatus.Size = new System.Drawing.Size(0, 32);
            this.gameStatus.TabIndex = 4;
            // 
            // labelShipsOp
            // 
            this.labelShipsOp.AutoSize = true;
            this.labelShipsOp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelShipsOp.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelShipsOp.Location = new System.Drawing.Point(40, 433);
            this.labelShipsOp.Name = "labelShipsOp";
            this.labelShipsOp.Size = new System.Drawing.Size(0, 18);
            this.labelShipsOp.TabIndex = 5;
            // 
            // labelShipsPl
            // 
            this.labelShipsPl.AutoSize = true;
            this.labelShipsPl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelShipsPl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelShipsPl.Location = new System.Drawing.Point(410, 433);
            this.labelShipsPl.Name = "labelShipsPl";
            this.labelShipsPl.Size = new System.Drawing.Size(0, 18);
            this.labelShipsPl.TabIndex = 6;
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.ForeColor = System.Drawing.Color.Green;
            this.buttonStart.Location = new System.Drawing.Point(100, 266);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(165, 73);
            this.buttonStart.TabIndex = 7;
            this.buttonStart.Text = "Start playing";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonPlace
            // 
            this.buttonPlace.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlace.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonPlace.Location = new System.Drawing.Point(100, 100);
            this.buttonPlace.Name = "buttonPlace";
            this.buttonPlace.Size = new System.Drawing.Size(165, 64);
            this.buttonPlace.TabIndex = 9;
            this.buttonPlace.Text = "Place ships";
            this.buttonPlace.UseVisualStyleBackColor = true;
            this.buttonPlace.Click += new System.EventHandler(this.buttonPlace_Click);
            // 
            // labelRandom
            // 
            this.labelRandom.AutoSize = true;
            this.labelRandom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRandom.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelRandom.Location = new System.Drawing.Point(124, 342);
            this.labelRandom.Name = "labelRandom";
            this.labelRandom.Size = new System.Drawing.Size(112, 18);
            this.labelRandom.TabIndex = 10;
            this.labelRandom.Text = "(random ships)";
            // 
            // buttonPlayAgain
            // 
            this.buttonPlayAgain.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlayAgain.ForeColor = System.Drawing.Color.Green;
            this.buttonPlayAgain.Location = new System.Drawing.Point(570, 19);
            this.buttonPlayAgain.Name = "buttonPlayAgain";
            this.buttonPlayAgain.Size = new System.Drawing.Size(113, 51);
            this.buttonPlayAgain.TabIndex = 11;
            this.buttonPlayAgain.Text = "Play again";
            this.buttonPlayAgain.UseVisualStyleBackColor = true;
            this.buttonPlayAgain.Visible = false;
            this.buttonPlayAgain.Click += new System.EventHandler(this.buttonPlayAgain_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.buttonPlayAgain);
            this.Controls.Add(this.labelRandom);
            this.Controls.Add(this.buttonPlace);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelShipsPl);
            this.Controls.Add(this.labelShipsOp);
            this.Controls.Add(this.gameStatus);
            this.Controls.Add(this.PlayerB);
            this.Controls.Add(this.AIb);
            this.DoubleBuffered = true;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Battleship";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label AIb;
        private System.Windows.Forms.Label PlayerB;
        private System.Windows.Forms.Label gameStatus;
        private System.Windows.Forms.Label labelShipsOp;
        private System.Windows.Forms.Label labelShipsPl;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonPlace;
        private System.Windows.Forms.Label labelRandom;
        private System.Windows.Forms.Button buttonPlayAgain;
    }
}

