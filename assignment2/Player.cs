using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Name:Manlin Mao
//Purpose: wheel of fortune game for 2 players

namespace assignment2
{
    class Player
    {
        //Properties
        public string PlayerName { get; set; }
        public int PlayerScore { get; set; }
        public int NumWins { get; set; }
        public int NumLose { get; set; }


        //Constructor of Player Class
        public Player(string initialName)
        {
            PlayerName = initialName;
            PlayerScore = 0;
            NumWins = 0;
            NumLose = 0;
        }

        public void AddScore(int score)
        {
            PlayerScore += score;
        }
    }
}
