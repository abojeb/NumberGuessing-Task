using System;

namespace numberGuessing
{
    class Program
    {
        static void Main(string[] args)
        {
               Random random = new Random();
            int RandomNumber;
            int guessCount;
            int guess;
            bool gameOver = false;
            string choice;
            string answer;
            
        while (gameOver == false) {
            Console.WriteLine("do you want to choose level to play?easy,medium and hard");
            choice = (Console.ReadLine());
            if (choice=="easy"){
                RandomNumber = random.Next(1,11); 
                guessCount = 6; 
                Console.Write("Guess a number between 1 and 10");
                try {
                    while (guessCount != 0)
                {
                    guess = Convert.ToInt32(Console.ReadLine());
                    guessCount--;

                    if(guess == RandomNumber){
                        Console.WriteLine("You got it right!");
                        gameOver = true;
                    }
                    else if(RandomNumber != guess){
                            Console.WriteLine("That was wrong!");
                            Console.WriteLine("You have " + guessCount + " trial(s) left");
                        }
                }
                Console.WriteLine("gameOver");
                }
                catch (System.FormatException) {
                    Console.WriteLine("Only numbers are allowed");
                }
                }

                if (choice=="medium"){
                RandomNumber = random.Next(1,21); 
                guessCount = 4; 
                Console.Write("Guess a number between 1 and 20");
                try {
                    while (guessCount != 0)
                {
                    guess = Convert.ToInt32(Console.ReadLine());
                    guessCount--;

                    if(guess == RandomNumber){
                        Console.WriteLine("You got it right!");
                        gameOver = true;
                    }
                    else if(RandomNumber != guess){
                            Console.WriteLine("That was wrong!");
                            Console.WriteLine("You have " + guessCount + " trial(s) left");
                        }
                }
                Console.WriteLine("gameOver");
                }
                catch (System.FormatException) {
                    Console.WriteLine("Only numbers are allowed");
                }
                }

                if (choice=="hard"){
                RandomNumber = random.Next(1,51); 
                guessCount = 3; 
                Console.Write("Guess a number between 1 and 50");
                try {
                    while (guessCount != 0)
                {
                    guess = Convert.ToInt32(Console.ReadLine());
                    guessCount--;

                    if(guess == RandomNumber){
                        Console.WriteLine("You got it right!");
                        gameOver = true;
                    }
                    else if(RandomNumber != guess){
                            Console.WriteLine("That was wrong!");
                            Console.WriteLine("You have " + guessCount + " trial(s) left");
                        }
                }
                Console.WriteLine("gameOver");
                }
                catch (System.FormatException) {
                    Console.WriteLine("Only numbers are allowed");
                }
                }
            Console.WriteLine("would you like to retry? y/n");
            answer = Console.ReadLine();
             if(answer == "y")
             {
                gameOver = false;
             }
             else{
                gameOver = true;
             }   
        }
    }
}
}
        
    

