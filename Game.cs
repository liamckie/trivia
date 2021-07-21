using System;
using System.Collections.Generic;
using System.Text;

namespace trivia
{
    public class Game
    {
        private string GameTitleArt = @"
  _____     _       _          ___                  _   
 |_   _| __(_)_   _(_) __ _   / _ \ _   _  ___  ___| |_ 
   | || '__| \ \ / / |/ _` | | | | | | | |/ _ \/ __| __|
   | || |  | |\ V /| | (_| | | |_| | |_| |  __/\__ \ |_ 
   |_||_|  |_| \_/ |_|\__,_|  \__\_\\__,_|\___||___/\__|

";
        private string GameTitle = "Trivia Quest";
        private string Description = "True or False Q&A.";
        private Player CurrentPlayer;
        private TriviaItem UnicornTrivia;

        public Game()
        {
            UnicornTrivia = new TriviaItem("\nThe National Animal of Scotland is the Unicorn, True or False?", "True");
        }

        public void Play()
        {
            Console.Title = GameTitle;

            Console.WriteLine(GameTitleArt);
            Console.WriteLine($"Welcome to {GameTitle}!");
            Console.WriteLine(Description);

            Console.Write("\nPlease enter your name : ");
            string playerName = Console.ReadLine();
            CurrentPlayer = new Player(playerName);
            Console.WriteLine($"Welcome, {playerName}. Your current Score is : {CurrentPlayer.Score}");

            UnicornTrivia.DisplayQuestion();
            Console.WriteLine($"Your Score is : {CurrentPlayer.Score}");

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
