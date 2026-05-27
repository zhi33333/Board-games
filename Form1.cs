using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using System.Media;

namespace 棋排類遊戲
{
    public partial class Form1 : Form
    {
        string currentPlayer = "X";
        bool gameOver = false;
        Button[,] buttons;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn12_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttons = new Button[3, 3]
            {
                { btn00, btn01, btn02 },
                { btn10, btn11, btn12 },
                { btn20, btn21, btn22 }
            };

            foreach (Button btn in buttons)
            {
                btn.Click += Cell_Click;
                btn.BackColor = Color.White;
                btn.ForeColor = Color.Black;

                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderColor = Color.Black;
                btn.FlatAppearance.BorderSize = 1;
            }

            btnRestart.Click += BtnRestart_Click;

            lblStatus.Text = "目前玩家：X";
        }
        private void Cell_Click(object sender, EventArgs e)
        {
            if (gameOver)
                return;

            Button clickedButton = sender as Button;

            if (clickedButton.Text != "")
                return;

            clickedButton.Text = currentPlayer;

            if (currentPlayer == "X")
            {
                clickedButton.ForeColor = Color.RoyalBlue;
            }
            else
            {
                clickedButton.ForeColor = Color.Crimson;
            }

            // 點格子音效
            SystemSounds.Beep.Play();

            if (CheckWinner())
            {
                lblStatus.Text = "玩家 " + currentPlayer + " 獲勝！";

                // 獲勝音效
                SystemSounds.Asterisk.Play();

                gameOver = true;
                return;
            }

            if (CheckDraw())
            {
                lblStatus.Text = "平手！";

                // 平手音效
                SystemSounds.Exclamation.Play();

                gameOver = true;
                return;
            }

            if (currentPlayer == "X")
            {
                currentPlayer = "O";
            }
            else
            {
                currentPlayer = "X";
            }

            lblStatus.Text = "目前玩家：" + currentPlayer;
        }

        private bool CheckWinner()
        {
            for (int i = 0; i < 3; i++)
            {
                if (buttons[i, 0].Text != "" &&
                    buttons[i, 0].Text == buttons[i, 1].Text &&
                    buttons[i, 1].Text == buttons[i, 2].Text)
                {
                    HighlightWinner(buttons[i, 0], buttons[i, 1], buttons[i, 2]);
                    return true;
                }

                if (buttons[0, i].Text != "" &&
                    buttons[0, i].Text == buttons[1, i].Text &&
                    buttons[1, i].Text == buttons[2, i].Text)
                {
                    HighlightWinner(buttons[0, i], buttons[1, i], buttons[2, i]);
                    return true;
                }
            }

            if (buttons[0, 0].Text != "" &&
                buttons[0, 0].Text == buttons[1, 1].Text &&
                buttons[1, 1].Text == buttons[2, 2].Text)
            {
                HighlightWinner(buttons[0, 0], buttons[1, 1], buttons[2, 2]);
                return true;
            }

            if (buttons[0, 2].Text != "" &&
                buttons[0, 2].Text == buttons[1, 1].Text &&
                buttons[1, 1].Text == buttons[2, 0].Text)
            {
                HighlightWinner(buttons[0, 2], buttons[1, 1], buttons[2, 0]);
                return true;
            }

            return false;
        }

        private bool CheckDraw()
        {
            foreach (Button btn in buttons)
            {
                if (btn.Text == "")
                {
                    return false;
                }
            }

            return true;
        }

        private void HighlightWinner(Button b1, Button b2, Button b3)
        {
            b1.BackColor = Color.LightGreen;
            b2.BackColor = Color.LightGreen;
            b3.BackColor = Color.LightGreen;
        }

        private void BtnRestart_Click(object sender, EventArgs e)
        {
            foreach (Button btn in buttons)
            {
                btn.Text = "";
                btn.BackColor = Color.White;
                btn.ForeColor = Color.Black;

                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderColor = Color.Black;
                btn.FlatAppearance.BorderSize = 1;
            }

            currentPlayer = "X";
            gameOver = false;
            lblStatus.Text = "目前玩家：X";
        }
    }
}
