using System;
public static class NumberGuessing
{
    public static void Run(){
        int numberOfCases, startIndex, endIndex, numberOfGuess, guessedNumber = 0;
            //Get Inputs
            string input, result = null;

            //Read Number of Cases
            input = Console.ReadLine();
            numberOfCases = int.Parse(input);

            for (int i = 0; i < numberOfCases; i++)
            {
                result = null;
                //Read (a,b]
                input = Console.ReadLine();
                string[] indexInputArray = input.Split(' ');
                startIndex = int.Parse(indexInputArray[0]) + 1;
                endIndex = int.Parse(indexInputArray[1]);

                //Read Number of Guesses
                input = Console.ReadLine();
                numberOfGuess = int.Parse(input);

                //Guess A Number
                while (result != "CORRECT")
                {
                    if (result == "TOO_BIG")
                    {
                        endIndex = guessedNumber - 1;
                    }
                    else if (result == "TOO_SMALL")
                    {
                        startIndex = guessedNumber + 1;
                    }
                    else if (result == "WRONG_ANSWER")
                    {
                        Environment.Exit(0);
                    }
                    guessedNumber = (startIndex + endIndex) / 2;
                    Console.WriteLine(guessedNumber);
                    Console.Out.Flush();
                    result = Console.ReadLine();
                }
            }
    }
}