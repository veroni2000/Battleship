namespace Battleship
{
    partial class FormPlace
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
            this.selectShip = new System.Windows.Forms.ComboBox();
            this.selectOrientation = new System.Windows.Forms.GroupBox();
            this.radioButtonV = new System.Windows.Forms.RadioButton();
            this.radioButtonH = new System.Windows.Forms.RadioButton();
            this.buttonPlace = new System.Windows.Forms.Button();
            this.buttonReady = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelPlace = new System.Windows.Forms.Label();
            this.labelSelectShip = new System.Windows.Forms.Label();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.selectOrientation.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectShip
            // 
            this.selectShip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectShip.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectShip.FormattingEnabled = true;
            this.selectShip.Items.AddRange(new object[] {
            "Carrier(5)",
            "Battleship(4)",
            "Cruiser(3)",
            "Submarine(3)",
            "Destroyer(2)"});
            this.selectShip.Location = new System.Drawing.Point(87, 100);
            this.selectShip.Name = "selectShip";
            this.selectShip.Size = new System.Drawing.Size(145, 26);
            this.selectShip.TabIndex = 0;
            // 
            // selectOrientation
            // 
            this.selectOrientation.Controls.Add(this.radioButtonV);
            this.selectOrientation.Controls.Add(this.radioButtonH);
            this.selectOrientation.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectOrientation.Location = new System.Drawing.Point(87, 169);
            this.selectOrientation.Name = "selectOrientation";
            this.selectOrientation.Size = new System.Drawing.Size(145, 97);
            this.selectOrientation.TabIndex = 1;
            this.selectOrientation.TabStop = false;
            this.selectOrientation.Text = "Select orientation";
            // 
            // radioButtonV
            // 
            this.radioButtonV.AutoSize = true;
            this.radioButtonV.Location = new System.Drawing.Point(6, 53);
            this.radioButtonV.Name = "radioButtonV";
            this.radioButtonV.Size = new System.Drawing.Size(78, 22);
            this.radioButtonV.TabIndex = 1;
            this.radioButtonV.Text = "Vertical";
            this.radioButtonV.UseVisualStyleBackColor = true;
            // 
            // radioButtonH
            // 
            this.radioButtonH.AutoSize = true;
            this.radioButtonH.Checked = true;
            this.radioButtonH.Location = new System.Drawing.Point(6, 25);
            this.radioButtonH.Name = "radioButtonH";
            this.radioButtonH.Size = new System.Drawing.Size(95, 22);
            this.radioButtonH.TabIndex = 0;
            this.radioButtonH.TabStop = true;
            this.radioButtonH.Text = "Horizontal";
            this.radioButtonH.UseVisualStyleBackColor = true;
            // 
            // buttonPlace
            // 
            this.buttonPlace.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlace.Location = new System.Drawing.Point(87, 306);
            this.buttonPlace.Name = "buttonPlace";
            this.buttonPlace.Size = new System.Drawing.Size(101, 45);
            this.buttonPlace.TabIndex = 2;
            this.buttonPlace.Text = "Place ship";
            this.buttonPlace.UseVisualStyleBackColor = true;
            this.buttonPlace.Click += new System.EventHandler(this.buttonPlace_Click);
            // 
            // buttonReady
            // 
            this.buttonReady.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReady.ForeColor = System.Drawing.Color.Green;
            this.buttonReady.Location = new System.Drawing.Point(257, 12);
            this.buttonReady.Name = "buttonReady";
            this.buttonReady.Size = new System.Drawing.Size(100, 55);
            this.buttonReady.TabIndex = 3;
            this.buttonReady.Text = "Ready to play";
            this.buttonReady.UseVisualStyleBackColor = true;
            this.buttonReady.Click += new System.EventHandler(this.buttonReady_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.ForeColor = System.Drawing.Color.Red;
            this.buttonCancel.Location = new System.Drawing.Point(382, 12);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 55);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlace.Location = new System.Drawing.Point(512, 49);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(0, 18);
            this.labelPlace.TabIndex = 5;
            // 
            // labelSelectShip
            // 
            this.labelSelectShip.AutoSize = true;
            this.labelSelectShip.Font = new System.Drawing.Font("Arial", 12F);
            this.labelSelectShip.Location = new System.Drawing.Point(93, 75);
            this.labelSelectShip.Name = "labelSelectShip";
            this.labelSelectShip.Size = new System.Drawing.Size(85, 18);
            this.labelSelectShip.TabIndex = 6;
            this.labelSelectShip.Text = "Select ship";
            // 
            // buttonRemove
            // 
            this.buttonRemove.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemove.Location = new System.Drawing.Point(630, 22);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(110, 45);
            this.buttonRemove.TabIndex = 7;
            this.buttonRemove.Text = "Remove ship";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Visible = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // FormPlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.labelSelectShip);
            this.Controls.Add(this.labelPlace);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonReady);
            this.Controls.Add(this.buttonPlace);
            this.Controls.Add(this.selectOrientation);
            this.Controls.Add(this.selectShip);
            this.DoubleBuffered = true;
            this.Name = "FormPlace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormPlace";
            this.Load += new System.EventHandler(this.FormPlace_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormPlace_MouseDown);
            this.selectOrientation.ResumeLayout(false);
            this.selectOrientation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox selectShip;
        private System.Windows.Forms.GroupBox selectOrientation;
        private System.Windows.Forms.RadioButton radioButtonV;
        private System.Windows.Forms.RadioButton radioButtonH;
        private System.Windows.Forms.Button buttonPlace;
        private System.Windows.Forms.Button buttonReady;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.Label labelSelectShip;
        private System.Windows.Forms.Button buttonRemove;
    }
}