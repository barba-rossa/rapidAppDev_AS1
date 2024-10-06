using System;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private bool isXTurn = true;
        private int moveCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.Text == "")
            {
                button.Text = isXTurn ? "X" : "O";
                isXTurn = !isXTurn;
                moveCount++;
                button.Enabled = false;
                CheckForWinner();
            }
        }

        // Continue


    }
}