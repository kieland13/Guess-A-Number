using System;

namespace GuessTheNumber
{
   class GuessTheNumber
   {
      private static Random randomNumber = new Random();


      static void Main()
      {

         //initialize variables
         int counter = 1;
         int timesPlayed = 0;
         int sum = 0;
         int average = 0;

         //ask the user to guess the number
         Console.WriteLine("Guess a number between 1 and 1000");
         int numberGuessed = Convert.ToInt32(Console.ReadLine());

         //validate the user chooses a valid number between 1 and 1000
         while (numberGuessed < 1 || numberGuessed > 1000)
         {
            //if answer is not valid, display this message
               Console.WriteLine("Please choose a number between 1 and 1000.");
               numberGuessed = Convert.ToInt32(Console.ReadLine());
         }

         //connect variable to other method
         int rightNumber = NumberGuesser();

         //checking to see if 0 was entered
         while (numberGuessed != 0)
         {
            //checking to see if the answers match
            while (numberGuessed != rightNumber)
            {
               //if answer is higher than random number
               if (numberGuessed > rightNumber)
               {
                  Console.WriteLine("Too high. Try again.");
                  numberGuessed = Convert.ToInt32(Console.ReadLine());
                  counter++;
                  //increase the counter for number of guesses
               }
               //if answer is lower than random number
               else if (numberGuessed < rightNumber)
               {
                  Console.WriteLine("Too low. Try again.");
                  numberGuessed = Convert.ToInt32(Console.ReadLine());
                  counter++;
                  //increase the counter for number of guesses
               }
               else
               //if answer matches random number
               {
                  Console.WriteLine("Congratulations. You guessed the number.");
               }
            }

            //print the results
            Console.WriteLine("Congratulations. You guessed the number.");
            Console.WriteLine("It only took you " + counter + " times to guess it.");
            Console.WriteLine("Would you like to play again? If so, Guess a number. (0 to stop playing)");
            numberGuessed = Convert.ToInt32(Console.ReadLine());
            sum = sum + counter;
            counter = 1;
            timesPlayed++;
            average = sum / timesPlayed;
            rightNumber = NumberGuesser();
         }
         Console.WriteLine($"Your average attempts per game was {average:F}");
        
         static int NumberGuesser()
         {
            int compNumber = randomNumber.Next(1, 1001);

            return compNumber;


         }
      }
   }
}
