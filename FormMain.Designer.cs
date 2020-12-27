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
            this.SuspendLayout();
            // 
            // AIb
            // 
            this.AIb.AutoSize = true;
            this.AIb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AIb.ForeColor = System.Drawing.Color.MidnightBlue;
            this.AIb.Location = new System.Drawing.Point(40, 75);
            this.AIb.Name = "AIb";
            this.AIb.Size = new System.Drawing.Size(87, 19);
            this.AIb.TabIndex = 2;
            this.AIb.Text = "AI`s board";
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
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.gameStatus);
            this.Controls.Add(this.PlayerB);
            this.Controls.Add(this.AIb);
            this.DoubleBuffered = true;
            this.Name = "FormMain";
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
    }
}

