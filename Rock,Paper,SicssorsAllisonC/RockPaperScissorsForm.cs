/*
 * Created by: Allison Cook
 * Created on: 9 March, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #17 - Rock, Paper, Scissors
 * This program It allows the user to pick rock, paper or scissors 
 * and the program generates a random number for it's choice of rock, paper or scissors.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_SicssorsAllisonC
{
    public partial class frmRockPaperScissors : Form
    {
        //constants 
        const int MAX = 3, MIN = 1;

        //variables
        string userChoice, computerChoice, outcome;

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //get random 
        Random randomNumberGenerator = new Random();

        public frmRockPaperScissors()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //genorate random number
            int computer = randomNumberGenerator.Next(MIN, MAX + 1);

            //chang to rock, paper or scissors
            if (computer == 1)
            {
                picComputer.Image = Properties.Resources.rock;
                computerChoice = "rock";
            }
            else if(computer == 2)
            {
                picComputer.Image = Properties.Resources.paper;
                computerChoice = "paper";
            }
            else if (computer == 3)
            {
                picComputer.Image = Properties.Resources.scissors;
                computerChoice = "scissors";
            }

            //set user choice
            if (chkRock.Checked == true)
            {
                userChoice = "rock";
                picUser.Image = Properties.Resources.rock;
                chkRock.Checked = false;
            }
            else if(chkPaper.Checked == true)
            {
                userChoice = "paper";
                picUser.Image = Properties.Resources.paper;
                chkPaper.Checked = false;
            }
            else if (chkScissors.Checked == true)
            {
                userChoice = "scissors";
                picUser.Image = Properties.Resources.scissors;
                chkScissors.Checked = false;
            }

            //see who wins
            if (userChoice == computerChoice)
            {
                outcome = "tie.";
            }
            else if (userChoice == "rock" && computerChoice == "scissors")
            {
                outcome = "win!";
            }
            else if (userChoice == "paper" && computerChoice == "rock")
            {
                outcome = "win!";
            }
            else if (userChoice == "scissors" && computerChoice == "paper")
            {
                outcome = "win!";
            }
            else if (userChoice == "rock" && computerChoice == "paper")
            {
                outcome = "lose.";
            }
            else if (userChoice == "paper" && computerChoice == "scissors")
            {
                outcome = "lose.";
            }
            else if (userChoice == "scissors" && computerChoice == "rock")
            {
                outcome = "lose.";
            }

            //show outcome and computer choice
            lblComputer.Text = computerChoice;
            lblOutcome.Text = "You " + outcome;

        }
    }
}
