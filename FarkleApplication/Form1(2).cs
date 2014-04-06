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
    public partial class Form1
    {
        //These are my Helper methods
        private void SetPlayerName(Label x, TextBox y, Button z, Player a)
        {
            x.Text = y.Text;
            a.Name = x.Text;

            z.Hide();
            y.Hide();
            if(PlayersSetUp())
            {
               initialLabel.Text = "Heads n' Tails";
            }

        }

        private bool PlayersSetUp()
        {
            bool setup = false;

            if(ran[0] && ran[1])
            {
                setup = true;
                FlipButton.Enabled = true;
            }

            
            return setup;
        }
    }
}
