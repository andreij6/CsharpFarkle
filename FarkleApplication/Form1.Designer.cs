namespace FarkleApplication
{
    partial class Form1
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
            this.FlipButton = new System.Windows.Forms.Button();
            this.playerOneLabel = new System.Windows.Forms.Label();
            this.playerTwoLabel = new System.Windows.Forms.Label();
            this.setPlayerTwoButton = new System.Windows.Forms.Button();
            this.setPlayerOneButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.initialLabel = new System.Windows.Forms.Label();
            this.PlayerOneWins = new System.Windows.Forms.Label();
            this.PlayerTwoWins = new System.Windows.Forms.Label();
            this.rollButton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FlipButton
            // 
            this.FlipButton.Enabled = false;
            this.FlipButton.Location = new System.Drawing.Point(87, 208);
            this.FlipButton.Name = "FlipButton";
            this.FlipButton.Size = new System.Drawing.Size(75, 41);
            this.FlipButton.TabIndex = 0;
            this.FlipButton.Text = "Flip";
            this.FlipButton.UseVisualStyleBackColor = true;
            this.FlipButton.Click += new System.EventHandler(this.FlipButton_Click);
            // 
            // playerOneLabel
            // 
            this.playerOneLabel.AutoSize = true;
            this.playerOneLabel.Location = new System.Drawing.Point(25, 48);
            this.playerOneLabel.Name = "playerOneLabel";
            this.playerOneLabel.Size = new System.Drawing.Size(35, 13);
            this.playerOneLabel.TabIndex = 1;
            this.playerOneLabel.Text = "label1";
            // 
            // playerTwoLabel
            // 
            this.playerTwoLabel.AutoSize = true;
            this.playerTwoLabel.Location = new System.Drawing.Point(25, 100);
            this.playerTwoLabel.Name = "playerTwoLabel";
            this.playerTwoLabel.Size = new System.Drawing.Size(35, 13);
            this.playerTwoLabel.TabIndex = 2;
            this.playerTwoLabel.Text = "label2";
            // 
            // setPlayerTwoButton
            // 
            this.setPlayerTwoButton.Location = new System.Drawing.Point(12, 95);
            this.setPlayerTwoButton.Name = "setPlayerTwoButton";
            this.setPlayerTwoButton.Size = new System.Drawing.Size(75, 23);
            this.setPlayerTwoButton.TabIndex = 3;
            this.setPlayerTwoButton.Text = "Player 2";
            this.setPlayerTwoButton.UseVisualStyleBackColor = true;
            this.setPlayerTwoButton.Click += new System.EventHandler(this.setPlayerTwoButton_Click);
            // 
            // setPlayerOneButton
            // 
            this.setPlayerOneButton.Location = new System.Drawing.Point(12, 43);
            this.setPlayerOneButton.Name = "setPlayerOneButton";
            this.setPlayerOneButton.Size = new System.Drawing.Size(75, 23);
            this.setPlayerOneButton.TabIndex = 4;
            this.setPlayerOneButton.Text = "Player 1";
            this.setPlayerOneButton.UseVisualStyleBackColor = true;
            this.setPlayerOneButton.Click += new System.EventHandler(this.setPlayerOneButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Player1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(131, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "Player2";
            // 
            // initialLabel
            // 
            this.initialLabel.AutoSize = true;
            this.initialLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initialLabel.Location = new System.Drawing.Point(4, 146);
            this.initialLabel.Name = "initialLabel";
            this.initialLabel.Size = new System.Drawing.Size(149, 32);
            this.initialLabel.TabIndex = 7;
            this.initialLabel.Text = "Set Players!";
            // 
            // PlayerOneWins
            // 
            this.PlayerOneWins.AutoSize = true;
            this.PlayerOneWins.Location = new System.Drawing.Point(12, 219);
            this.PlayerOneWins.Name = "PlayerOneWins";
            this.PlayerOneWins.Size = new System.Drawing.Size(25, 13);
            this.PlayerOneWins.TabIndex = 8;
            this.PlayerOneWins.Text = "Roll";
            this.PlayerOneWins.Visible = false;
            // 
            // PlayerTwoWins
            // 
            this.PlayerTwoWins.AutoSize = true;
            this.PlayerTwoWins.Location = new System.Drawing.Point(181, 222);
            this.PlayerTwoWins.Name = "PlayerTwoWins";
            this.PlayerTwoWins.Size = new System.Drawing.Size(28, 13);
            this.PlayerTwoWins.TabIndex = 9;
            this.PlayerTwoWins.Text = " Roll";
            this.PlayerTwoWins.Visible = false;
            // 
            // rollButton1
            // 
            this.rollButton1.Location = new System.Drawing.Point(87, 202);
            this.rollButton1.Name = "rollButton1";
            this.rollButton1.Size = new System.Drawing.Size(75, 47);
            this.rollButton1.TabIndex = 10;
            this.rollButton1.TabStop = false;
            this.rollButton1.Text = "Roll!";
            this.rollButton1.UseVisualStyleBackColor = true;
            this.rollButton1.Visible = false;
            this.rollButton1.Click += new System.EventHandler(this.rollButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 261);
            this.Controls.Add(this.rollButton1);
            this.Controls.Add(this.PlayerTwoWins);
            this.Controls.Add(this.PlayerOneWins);
            this.Controls.Add(this.initialLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.setPlayerOneButton);
            this.Controls.Add(this.setPlayerTwoButton);
            this.Controls.Add(this.playerTwoLabel);
            this.Controls.Add(this.playerOneLabel);
            this.Controls.Add(this.FlipButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FlipButton;
        private System.Windows.Forms.Label playerOneLabel;
        private System.Windows.Forms.Label playerTwoLabel;
        private System.Windows.Forms.Button setPlayerTwoButton;
        private System.Windows.Forms.Button setPlayerOneButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label initialLabel;
        private System.Windows.Forms.Label PlayerOneWins;
        private System.Windows.Forms.Label PlayerTwoWins;
        private System.Windows.Forms.Button rollButton1;
    }
}

