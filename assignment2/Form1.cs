using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Name:Manlin Mao
//Purpose: wheel of fortune game for 2 players

namespace assignment2
{
    public partial class Form1 : Form
    {
        //Objects
        Player playerOne, playerTwo;
        Game gameOne;

        int length;
        public Form1()
        {
            InitializeComponent();
        }

        private void startGame_Click(object sender, EventArgs e)
        {
            GenerateNewGame();
        }

        private void guessNewButton_Click_1(object sender, EventArgs e)
        {
            string partsWord = targetWordRead.Text;
            int compare;

            //generate user inputs to new string and compare
            partsWord = GenerateAnswer(gameOne.TargetWord, 
                        char.Parse(userGuessWord.Text.ToLower()), partsWord);
            compare = partsWord.CompareTo(targetWordRead.Text);

            //wrong guess
            if (compare == 0)
            {
                SwitchTurn(gameOne.PlayerTurn);
                GetPictureScore(gameOne.CurrentScore);
            }
            else//right guess
            {
                targetWordRead.Text = partsWord;
                AddPlayerScores(gameOne.PlayerTurn);

                gameOne.GetScore();
                GetPictureScore(gameOne.CurrentScore);
            }

            //randomly erase one player's scores after game start
            if (gameOne.CurrentScore == 50)
            {
                if (playerOne.PlayerScore > 200 && gameOne.PlayerTurn == 1)
                {
                    BankruptPlayer(gameOne.PlayerTurn);

                }
                else if (playerTwo.PlayerScore > 200 && gameOne.PlayerTurn == 2)
                {
                    BankruptPlayer(gameOne.PlayerTurn);

                }

            }
            //matched guessed word and target word
            if (partsWord == gameOne.TargetWord)
            {
                GenerateFinalResponse(playerOne.PlayerScore, playerTwo.PlayerScore, 
                                      playerOne.PlayerName, playerTwo.PlayerName);
            }
        }


        //function bankrupt player
        private void BankruptPlayer(int turn)
        {
            if(turn==1)
            {
                scores.Image = Properties.Resources.bankrubpt;
                MessageBox.Show("Bankrupted! " + playerName2.Text + "'s turn now!");
                playerOne.PlayerScore = 0;
                gameOne.GetScore();
                GetPictureScore(gameOne.CurrentScore);
                gameOne.PlayerTurn = 2;
                player1Score.Text = playerOne.PlayerScore.ToString();
            }
            else
            {
                scores.Image = Properties.Resources.bankrubpt;
                MessageBox.Show("Bankrupted! " + playerName1.Text + "'s turn now!");
                playerTwo.PlayerScore = 0;
                gameOne.GetScore();
                GetPictureScore(gameOne.CurrentScore);
                gameOne.PlayerTurn = 1;
                player2Score.Text = playerTwo.PlayerScore.ToString();
            }
        }

        //function for add each player's score
        public void AddPlayerScores(int turn)
        {
            switch (turn)
            {
                case 1:
                    playerOne.PlayerScore += gameOne.CurrentScore;
                    player1Score.Text = playerOne.PlayerScore.ToString();

                    break;
                default:
                    playerTwo.PlayerScore += gameOne.CurrentScore;
                    player2Score.Text = playerTwo.PlayerScore.ToString();

                    break;
            }
        }

        //function for switch turn
        public void SwitchTurn(int turn)
        {
            if (turn == 1)
            {
                MessageBox.Show("Wrong guess," + playerName2.Text + "'s turn now!");
                gameOne.PlayerTurn = 2;
                playerOne.NumLose++;
                gameOne.GetScore();
            }
            else
            {
                MessageBox.Show("Wrong guess," + playerName1.Text + "'s turn now!");
                gameOne.PlayerTurn = 1;
                playerTwo.NumLose++;
                gameOne.GetScore();
            }
        }

        //Function that will generate response when game ends
        public void GenerateFinalResponse(int playerOneScore, int playerTwoScore, 
            string playerOneName, string playerTwoName)
        {
            DialogResult buttonResponses;

            if (playerOneScore > playerTwoScore)
            {
                buttonResponses = MessageBox.Show(playerOneName + " wins!", "Would you like to play again? ", MessageBoxButtons.YesNo);
                playerOne.NumWins++;
            }
            else if (playerOneScore == playerTwoScore)
                buttonResponses = MessageBox.Show("Game over, its a tie!", "Would you like to play again? ", MessageBoxButtons.YesNo);
            else
            {
                buttonResponses = MessageBox.Show(playerTwoName + " wins!", "Would you like to play again? ", MessageBoxButtons.YesNo);
                playerTwo.NumWins++;
            }

            if (buttonResponses == DialogResult.Yes)
            {
                GenerateNewGame();
            }
            else
            {
                MessageBox.Show("Thank you for playing!");
            }
        }

        //Function generate a string with dashes
        public string GenerateHidden(int passedLength)
        {
            string hidden;
            char[] intakeCharacters = new char[passedLength];
            for (int index = 0; index < passedLength; index++)
            {
                intakeCharacters[index] = '-';
            }
            hidden = new string(intakeCharacters);

            return hidden;
        }

        //Function that will swap a letter
        public string GenerateAnswer(string targetWord, char letterGuessed, string guessedLetters)
        {
            string hidden;
            int pos;
            char[] targetWordArray = targetWord.ToCharArray();
            char[] guessedLettersArray = guessedLetters.ToCharArray();

            for (pos = 0; pos < targetWord.Length; pos++)
            {
                if (targetWordArray[pos] == letterGuessed)
                {
                    guessedLettersArray[pos] = letterGuessed;

                }

            }

            hidden = new string(guessedLettersArray);
            return hidden;
        }

        //Function that will generate picture for scores
        public void GetPictureScore(int score)
        {
            switch (score)
            {

                case 100:
                    scores.Image = Properties.Resources._100_score;
                    break;
                case 200:
                    scores.Image = Properties.Resources.WHEEL200;
                    break;
                case 300:
                    scores.Image = Properties.Resources._300wheel;
                    break;
                case 500:
                    scores.Image = Properties.Resources._500wheel;
                    break;
                default:
                    scores.Image = Properties.Resources._50_score;
                    break;

            }
        }

        //Function that get a hint for specific word produced
        private string GetHint(string animal)
        {
            string hint;
            switch (animal)
            {
                case "sloth":
                    hint = "The slow-motion animal that works at Department of" +
                        " Mammal Vehicles from the movie Zootopia";
                    break;
                case "kiwi":
                    hint = "An animal with hairlike feathers";
                    break;
                case "peacock":
                    hint = "An animal that displays himself ostentatiously.";
                    break;
                case "capybara":
                    hint = "an animal that resembles a giant long-legged guinea pig.";
                    break;
                default:
                    hint = "An animal that has bulging eyes, " +
                        "ever-growing teeth and long fingers.";
                    break;
            }

            return hint;
        }


        //function that generate new game
        public void GenerateNewGame()
        {
            gameOne = new Game();
            playerOne = new Player(playerName1.Text);
            playerTwo = new Player(playerName2.Text);


            length = gameOne.TargetWord.Length;
            targetWordRead.Text = GenerateHidden(length);

            hints.Text = GetHint(gameOne.TargetWord);

            player1Score.Text = gameOne.CurrentScore.ToString();
            player2Score.Text = gameOne.CurrentScore.ToString();

            if (gameOne.PlayerTurn == 1)
                MessageBox.Show("Game start, player: " + playerName1.Text + "'s turn");
            else
                MessageBox.Show("Game start, player: " + playerName2.Text + "'s turn");
            gameOne.GetScore();
            GetPictureScore(gameOne.CurrentScore);
        }
    }
}





