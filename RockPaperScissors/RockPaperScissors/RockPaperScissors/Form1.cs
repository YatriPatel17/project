using System.Text;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        // declaring variables and initializing them
        int playerScore = 0;
        int computerScore = 0;
        int round = 0;
        int countdown = 5;

        // setting default image
        Image defaultImage = Properties.Resources.RPS;
        public Form1()
        {
            InitializeComponent();
            // setting interval
            countDownTimer.Interval = 1000;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // resetting the game
            ResetGame();
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            // displaying rock image for userchoice
            PlayerChoice("Rock");
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            // displaying paper image for userchoice
            PlayerChoice("Paper");
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            // displaying scissors image for userchoice
            PlayerChoice("Scissors");
        }

        private void PlayerChoice(string playerChoice)
        {
            // resetting the images for a new round
            imgPlayerChoice.Image = defaultImage;
            imgComputerChoice.Image = defaultImage;

            // displaying player choice image
            imgPlayerChoice.Image = GetChoiceImage(playerChoice);
            imgPlayerChoice.Tag = playerChoice;

            // starting countdown
            StartCountdown();
        }

        private string ComputerChoice()
        {
            // generating a random choice for the computer
            Random rand = new Random();
            int choice = rand.Next(1, 4);

            if (choice == 1)
                return "Rock";
            else if (choice == 2)
                return "Paper";
            else
                return "Scissors";
        }

        private void ShowComputerChoice()
        {
            // displaying computer's choice
            string computerChoice = ComputerChoice();
            imgComputerChoice.Image = GetChoiceImage(computerChoice);

            string playerChoice = imgPlayerChoice.Tag.ToString();

            // determining the winner and updating scores
            string roundResult = DetermineWinner(playerChoice, computerChoice);
            UpdateScore(roundResult);

            // displaying round completion message
            if (round < 3)
            {
                lblMessage.Text = $"Round {round} is completed! Get ready for round {round + 1}. Make your choice!";
                ResetRound();
                round++;
                lblRounds.Text = "Round: " + round;
            }
            else
            {
                EndGame(); // ending the game after 3 rounds
            }
        }

        private void ResetRound()
        {
            // resetting the timer label
            lblTimer.Text = "5";
            countdown = 5;
        }

        private void EndGame()
        {
            // displaying the final result
            string resultMessage = $"Game Over! Final Score\nPlayer: {playerScore}\nComputer: {computerScore}";
            if (playerScore > computerScore)
                resultMessage += "\nCongratulations, you won!";
            else if (playerScore < computerScore)
                resultMessage += "\nBetter luck next time!";
            else
                resultMessage += "\nIt's a tie!";

            // updating lable text
            lblMessage.Text = resultMessage;

            // disabling the choice buttons
            btnRock.Enabled = false;
            btnPaper.Enabled = false;
            btnScissors.Enabled = false;

            lblMessage.Text += "\nClick 'Restart' to play again.";
        }

        private void UpdateScore(string result)
        {
            // updating game score
            if (result == "Player")
                playerScore++;
            else if (result == "Computer")
                computerScore++;
            else if (result == "Tie")
                lblMessage.Text = "It's a Tie";

            // displaying game score
            lblPlayerScore.Text = "Player Score: " + playerScore;
            lblComputerScore.Text = "Computer Score: " + computerScore;
        }

        private string DetermineWinner(string playerChoice, string computerChoice)
        {
            // determining winner
            if (playerChoice == computerChoice)
            {
                return "Tie";
            }

            if ((playerChoice == "Rock" && computerChoice == "Scissors") ||
                (playerChoice == "Paper" && computerChoice == "Rock") ||
                (playerChoice == "Scissors" && computerChoice == "Paper"))
            {
                return "Player";
            }
            else
            {
                return "Computer";
            }
        }

        private void ResetGame()
        {
            // resetting all values 
            playerScore = 0;
            computerScore = 0;
            round = 1;
            lblRounds.Text = "Round: " + round;
            lblPlayerScore.Text = "Player Score: " + playerScore;
            lblComputerScore.Text = "Computer Score: " + computerScore;
            imgPlayerChoice.Image = defaultImage;
            imgComputerChoice.Image = defaultImage;
            ResetRound();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            // resetting the game
            ResetGame();

            // enabling the choice buttons
            btnRock.Enabled = true;
            btnPaper.Enabled = true;
            btnScissors.Enabled = true;

            // updating lable text for restarted game
            lblMessage.Text = "Game restarted! Make your choice.";
        }

        private void countDownTimer_Tick(object sender, EventArgs e)
        {
            // decreasing the timer if it has not reached from 5 to 1
            if (countdown > 0)
            {
                lblTimer.Text = countdown.ToString();
                countdown--;
            }
            else
            {
                countDownTimer.Stop(); // stopping the timer when countdown ends
                ShowComputerChoice(); // displaying the computer's choice
            }
        }

        private Image GetChoiceImage(string choice)
        {
            // getting appropriate images
            switch (choice)
            {
                case "Rock":
                    return Properties.Resources.rock;
                case "Paper":
                    return Properties.Resources.paper;
                case "Scissors":
                    return Properties.Resources.scissors;
                default:
                    return Properties.Resources.RPS;
            }
        }

        private void StartCountdown()
        {
            // setting countdown
            countdown = 5;
            lblTimer.Text = countdown.ToString();
            countDownTimer.Start();
        }
    }
}
