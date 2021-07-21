using System;
using System.Collections.Generic;
using System.Text;

namespace trivia
{
    public class TriviaItem
    {
        private string Question;
        private string Answer;

        public TriviaItem(string triviaQuestion, string triviaAnswer)
        {
            Question = triviaQuestion;
            Answer = triviaAnswer;
        }

        public void DisplayQuestion()
        {
            Console.WriteLine(Question);
            string playerAnswer = Console.ReadLine();

            if (playerAnswer == "True" || playerAnswer == "true" || playerAnswer == "t")
            {
                Console.WriteLine($"The answer was {Answer} and you guessed '{playerAnswer}'. Well Done!");
            }
            else
            {
                Console.WriteLine($"The answer was {Answer} and you guessed '{playerAnswer}'. Incorrect Answer :(");
            }
        }
    }
}
