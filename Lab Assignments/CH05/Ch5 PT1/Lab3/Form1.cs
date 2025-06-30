using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        int round = 0;
        int playerScore = 0;
        int computerScore = 0;
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void PlayRound(int playerChoice)
        {
            if (round >= 3)
            {
                lblFinalResult.Text = "Game over! Restart the program to play again.";
                return;
            }

            int computerChoice = rand.Next(1, 4); // 1 = Rock, 2 = Paper, 3 = Scissors
            string[] choiceNames = { "", "Rock", "Paper", "Scissors" };

            // Display choices
            lblPlayerChoiceResults.Text = "You chose: " + choiceNames[playerChoice];
            lblComputerChoice.Text = "Computer chose: " + choiceNames[computerChoice];

            // Determine winner
            if (playerChoice == computerChoice)
            {
                // Tie — no score change
            }
            else if ((playerChoice == 1 && computerChoice == 3) ||
                     (playerChoice == 2 && computerChoice == 1) ||
                     (playerChoice == 3 && computerChoice == 2))
            {
                playerScore++;
            }
            else
            {
                computerScore++;
            }

            round++;

            // Update score display
            lblPlayerScoreText.Text = "Player Score: " + playerScore;
            lblComputerScoreText.Text = "Computer Score:";
            lblComputerScoreResult.Text = computerScore.ToString();

            // Final result after 3 rounds
            if (round == 3)
            {
                if (playerScore > computerScore)
                {
                    lblFinalResult.Text = "🎉 You win the match!";
                }
                else if (computerScore > playerScore)
                {
                    lblFinalResult.Text = "💻 Computer wins the match!";
                }
                else
                {
                    lblFinalResult.Text = "🤝 It's a tie!";
                }
            }
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            PlayRound(1); // Rock
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            PlayRound(2); // Paper
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            PlayRound(3); // Scissors
        }
    }
}