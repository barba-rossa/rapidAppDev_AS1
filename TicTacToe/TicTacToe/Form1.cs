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

        private void CheckForWinner()
        {
            if ((btn1.Text == btn2.Text && btn2.Text == btn3.Text && btn1.Text != "") ||
                (btn4.Text == btn5.Text && btn5.Text == btn6.Text && btn4.Text != "") ||
                (btn7.Text == btn8.Text && btn8.Text == btn9.Text && btn7.Text != "") ||
                (btn1.Text == btn4.Text && btn4.Text == btn7.Text && btn1.Text != "") ||
                (btn2.Text == btn5.Text && btn5.Text == btn8.Text && btn2.Text != "") ||
                (btn3.Text == btn6.Text && btn6.Text == btn9.Text && btn3.Text != "") ||
                (btn1.Text == btn5.Text && btn5.Text == btn9.Text && btn1.Text != "") ||
                (btn3.Text == btn5.Text && btn5.Text == btn7.Text && btn3.Text != ""))
            {
                string winner = isXTurn ? "O" : "X";
                MessageBox.Show(winner + " Wins!", "Game Over");
                ResetGame();
            }
            else if (moveCount == 9)
            {
                MessageBox.Show("It's a draw!", "Game Over");
                ResetGame();
            }
        }

        private void ResetGame()
        {
            foreach (Control c in Controls)
            {
                if (c is Button && c.Tag == "play")
                {
                    ((Button)c).Enabled = true;
                    ((Button)c).Text = "";
                }
            }

            isXTurn = true;
            moveCount = 0;
        }
    }
}
