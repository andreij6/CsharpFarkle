using FarkleClassLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarkleApplication
{
    public partial class Form1 : Form
    {
        bool[] playersSet = {false, false};
        Player player1 = new Player();
        Player player2 = new Player();


        public Form1()
        {
            InitializeComponent();
        }

        private void setPlayerOneButton_Click(object sender, EventArgs e)
        {
            playersSet[0] = true;
            SetPlayerName(playerOneLabel, textBox1, setPlayerOneButton, player1);
           

            PlayerOneWins.Text = String.Format("{0}'s roll", player1.Name);
        }

        private void setPlayerTwoButton_Click(object sender, EventArgs e)
        {
            playersSet[1] = true;
            SetPlayerName(playerTwoLabel, textBox2, setPlayerTwoButton, player2);

            PlayerTwoWins.Text = String.Format("{0}'s roll", player2.Name);
        }

        private void FlipButton_Click(object sender, EventArgs e)
        {
            if( Dice.HeadsOrTails() > 3) 
            {
                PlayerOneWins.Visible = true;
            } else {
                PlayerTwoWins.Visible = true;
            }
            FlipButton.Hide();
            rollButton1.Show();
        }

        private void rollButton1_Click(object sender, EventArgs e)
        {
            var values = Dice.Roll(6);

            string message = " ";

            foreach (var item in values)
            {
                message += item;
            }

            listOfDicelabel.Text = message;
            listOfDicelabel.Visible = true;
        }

    }
}
