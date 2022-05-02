using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Name:Manlin Mao
//Purpose: wheel of fortune game for 2 players

namespace assignment2
{

    class Game
    {
        const int SIZE = 5;
        static string[] targetWords = new string[SIZE] { "sloth", "kiwi", "peacock", "capybara", "ayeaye" };
        static int[] scores = new int[SIZE] {50,100, 200, 300, 500 };
       
        //Properties
        public int CurrentScore { get; set; }
        public int PlayerTurn { get; set; }
        public string TargetWord {get;set; }


        //Constructor of Game Class
        public Game()
        {
            AssignWord();
            Random random = new Random();
            PlayerTurn = random.Next(1,2);
            CurrentScore = 0;
        }

        //Function that assign targetWord a random value
        public void AssignWord()
        {
            Random random = new Random();
            int index = random.Next() % SIZE;
            TargetWord = targetWords[index];

        }

        //Function that get a random score from scoresArray
        public void GetScore()
        {
            Random random = new Random();
            int index = random.Next() % SIZE;
            CurrentScore = scores[index];
        }

    }
}
