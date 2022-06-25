

string word = "lion";
string guess = "";

//to keep track of the number of guesses.
int count = 0;
int limit = 3; //limit to the number of times user can guess.
bool guessesExhausted = false; //guesses exhausted should be false as long as limit hasnt reached.

while (guess != word && !guessesExhausted)
{
    if (count < limit)
    {
        Console.Write("Guess the name of a wild animal: ");
        guess = Console.ReadLine();
        count++;
    }
    else
    {
        guessesExhausted = true;
    }
}
if (guessesExhausted)
{
    Console.WriteLine("You Lose!");
}
else
{
    Console.WriteLine("You win!");
}




Console.ReadLine();





