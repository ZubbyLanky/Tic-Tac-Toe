using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        Boolean checker;
        int plusOneX;
        int plusOneO;


        void Enable_Flase()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;

        }
        //which of my button has X
        void Score(){

            //Scores for player X

            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                button1.BackColor = Color.Cyan;
                button2.BackColor = Color.Cyan;
                button3.BackColor = Color.Cyan;
                MessageBox.Show("Player X won the game", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);                
                plusOneX = int.Parse(lblX.Text);
                plusOneX++;
                lblX.Text = Convert.ToString(plusOneX);
                Enable_Flase();
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                button4.BackColor = Color.Cyan;
                button5.BackColor = Color.Cyan;
                button6.BackColor = Color.Cyan;
                MessageBox.Show("Player X won the game", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOneX = int.Parse(lblX.Text);
                plusOneX++;
                lblX.Text = Convert.ToString(plusOneX);
                Enable_Flase();
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                button7.BackColor = Color.Cyan;
                button8.BackColor = Color.Cyan;
                button9.BackColor = Color.Cyan;
                MessageBox.Show("Player X won the game", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOneX = int.Parse(lblX.Text);
                plusOneX++;
                lblX.Text = Convert.ToString(plusOneX);
                Enable_Flase();
            }
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                button1.BackColor = Color.Cyan;
                button4.BackColor = Color.Cyan;
                button7.BackColor = Color.Cyan;
                MessageBox.Show("Player X won the game", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOneX = int.Parse(lblX.Text);
                plusOneX++;
                lblX.Text = Convert.ToString(plusOneX);
                Enable_Flase();
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                button2.BackColor = Color.Cyan;
                button5.BackColor = Color.Cyan;
                button8.BackColor = Color.Cyan;
                MessageBox.Show("Player X won the game", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOneX = int.Parse(lblX.Text);
                plusOneX++;
                lblX.Text = Convert.ToString(plusOneX);
                Enable_Flase();
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                button3.BackColor = Color.Cyan;
                button6.BackColor = Color.Cyan;
                button9.BackColor = Color.Cyan;
                MessageBox.Show("Player X won the game", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOneX = int.Parse(lblX.Text);
                plusOneX++;
                lblX.Text = Convert.ToString(plusOneX);
                Enable_Flase();
            }
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                button1.BackColor = Color.Cyan;
                button5.BackColor = Color.Cyan;
                button9.BackColor = Color.Cyan;
                MessageBox.Show("Player X won the game", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOneX = int.Parse(lblX.Text);
                plusOneX++;
                lblX.Text = Convert.ToString(plusOneX);
                Enable_Flase();
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                button3.BackColor = Color.Cyan;
                button5.BackColor = Color.Cyan;
                button7.BackColor = Color.Cyan;
                MessageBox.Show("Player X won the game", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOneX = int.Parse(lblX.Text);
                plusOneX++;
                lblX.Text = Convert.ToString(plusOneX);
                Enable_Flase();
            }




            //Score for player O
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                button1.BackColor = Color.Cyan;
                button2.BackColor = Color.Cyan;
                button3.BackColor = Color.Cyan;
                MessageBox.Show("Player O won the game", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOneO = int.Parse(lblO.Text);
                plusOneO++;
                lblO.Text = Convert.ToString(plusOneO);
                Enable_Flase();
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                button4.BackColor = Color.Cyan;
                button5.BackColor = Color.Cyan;
                button6.BackColor = Color.Cyan;
                MessageBox.Show("Player O won the game", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOneO = int.Parse(lblO.Text);
                plusOneO++;
                lblO.Text = Convert.ToString(plusOneO);
                Enable_Flase();
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                button7.BackColor = Color.Cyan;
                button8.BackColor = Color.Cyan;
                button9.BackColor = Color.Cyan;
                MessageBox.Show("Player O won the game", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOneO = int.Parse(lblO.Text);
                plusOneO++;
                lblO.Text = Convert.ToString(plusOneO);
                Enable_Flase();
            }
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                button1.BackColor = Color.Cyan;
                button4.BackColor = Color.Cyan;
                button7.BackColor = Color.Cyan;
                MessageBox.Show("Player O won the game", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOneO = int.Parse(lblO.Text);
                plusOneO++;
                lblO.Text = Convert.ToString(plusOneO);
                Enable_Flase();
            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                button2.BackColor = Color.Cyan;
                button5.BackColor = Color.Cyan;
                button8.BackColor = Color.Cyan;
                MessageBox.Show("Player O won the game", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOneO = int.Parse(lblO.Text);
                plusOneO++;
                lblO.Text = Convert.ToString(plusOneO);
                Enable_Flase();
            }
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                button3.BackColor = Color.Cyan;
                button6.BackColor = Color.Cyan;
                button9.BackColor = Color.Cyan;
                MessageBox.Show("Player O won the game", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOneO = int.Parse(lblO.Text);
                plusOneO++;
                lblO.Text = Convert.ToString(plusOneO);
                Enable_Flase();
            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                button1.BackColor = Color.Cyan;
                button5.BackColor = Color.Cyan;
                button9.BackColor = Color.Cyan;
                MessageBox.Show("Player O won the game", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOneO = int.Parse(lblO.Text);
                plusOneO++;
                lblO.Text = Convert.ToString(plusOneO);
                Enable_Flase();
            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                button3.BackColor = Color.Cyan;
                button5.BackColor = Color.Cyan;
                button7.BackColor = Color.Cyan;
                MessageBox.Show("Player O won the game", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOneO = int.Parse(lblO.Text);
                plusOneO++;
                lblO.Text = Convert.ToString(plusOneO);
                Enable_Flase();
            }

            //if ((button1.Text == "X" && button2.Text == "X" && button3.Text == "X") || (button4.Text == "X" && button5.Text == "X" && button6.Text == "X") || (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            //    || (button1.Text == "X" && button4.Text == "X" && button7.Text == "X") || (button2.Text == "X" && button5.Text == "X" && button8.Text == "X") || (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            //    || (button1.Text == "X" && button5.Text == "X" && button9.Text == "X") || (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            //    || (button1.Text == "O" && button2.Text == "O" && button3.Text == "O") || (button4.Text == "O" && button5.Text == "O" && button6.Text == "O") || (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            //    || (button1.Text == "O" && button4.Text == "O" && button7.Text == "O") || (button2.Text == "O" && button5.Text == "O" && button8.Text == "O") || (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            //    || (button1.Text == "O" && button5.Text == "O" && button9.Text == "O") || (button3.Text == "O" && button5.Text == "O" && button7.Text == "O"))
            //{
            //    MessageBox.Show("No winner Restart the game", "Tic Tac Toe",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Information);
            //}
            


        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button1.Text = "X";
                checker = true;
            }
            else
            {
                button1.Text = "O";
                checker = false;
            }
            Score();
            button1.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button2.Text = "X";
                checker = true;
            }
            else
            {
                button2.Text = "O";
                checker = false;
            }
            Score();
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button3.Text = "X";
                checker = true;
            }
            else
            {
                button3.Text = "O";
                checker = false;
            }
            Score();
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button4.Text = "X";
                checker = true;
            }
            else
            {
                button4.Text = "O";
                checker = false;
            }
            Score();
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button5.Text = "X";
                checker = true;
            }
            else
            {
                button5.Text = "O";
                checker = false;
            }
            Score();
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button6.Text = "X";
                checker = true;
            }
            else
            {
                button6.Text = "O";
                checker = false;
            }
            Score();
            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button7.Text = "X";
                checker = true;
            }
            else
            {
                button7.Text = "O";
                checker = false;
            }
            Score();
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button8.Text = "X";
                checker = true;
            }
            else
            {
                button8.Text = "O";
                checker = false;
            }
            Score();
            button8.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button9.Text = "X";
                checker = true;
            }
            else
            {
                button9.Text = "O";
                checker = false;
            }
            Score();
            button9.Enabled = false;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            try
            {

            //Enabling all the button as we click on the New Game button
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;


            //Clearing all the data inside each button
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";


            //Intializing all the stored score to zero for both X and O player.
            lblX.Text = "0";
            lblO.Text = "0";

            button1.BackColor = default;
            button2.BackColor = default;
            button3.BackColor = default;
            button4.BackColor = default;
            button5.BackColor = default;
            button6.BackColor = default;
            button7.BackColor = default;
            button8.BackColor = default;
            button9.BackColor = default;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tic Tao Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {

            try
            {
            
            //Enabling all the button as we click on the New Game button
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;


            //Clearing all the data inside each button
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            button1.BackColor = default;
            button2.BackColor = default;
            button3.BackColor = default;
            button4.BackColor = default;
            button5.BackColor = default;
            button6.BackColor = default;
            button7.BackColor = default;
            button8.BackColor = default;
            button9.BackColor = default;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tic Tao Toe", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
        }


        //To exit the program.
        private void btnExist_Click(object sender, EventArgs e)
        {
            
            try
            {
                DialogResult iExit;
                iExit = MessageBox.Show("Confirm", "Tic Tao Toe", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
                if (iExit == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Tic Tao Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
