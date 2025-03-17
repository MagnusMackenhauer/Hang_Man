string word = "IfYouAreReadingThisItsToLate".ToLower(); //Word to guess

int lives = 10; //how many lives

int currentLives = lives; //current lives

bool win = false; //bool that controls if game needs to stop


List<char> guessedLetters = new List<char>(); //list that holds guessedLetters

while (currentLives > 0 && !win) //while loop that shows the letters or "_"
{
    foreach (char c in word)
    {
        if (guessedLetters.Contains(c))
        {
            Console.Write(c);
        }
        else Console.Write("_");
    }
    Console.WriteLine("\nGuess a letter"); //prompt to guess letter
    Console.WriteLine(currentLives + "/" + lives + " lives"); //shows lives left
    Console.Write("Used Letters: ");
    foreach (char c in guessedLetters)
    {
        Console.Write(c + " ");
    }
    Console.WriteLine();
    
    char guess = Convert.ToChar(Console.ReadLine().ToLower()); //variable that holds players guess

    if (word.Contains(guess) && !guessedLetters.Contains(guess)) //if statement that shows if wrong or false
    {
        Console.WriteLine("You guessed it!");
    }
    else
    {
        Console.WriteLine("You were wrong!");
        currentLives--; //if you were wrong your lives go down
    }
    guessedLetters.Add(guess); //adds the guess to guessed Letters

    bool wordComplete = true; //Sets word wordComplete to be true, but foreach loop after sets it to false if all letters is not there
    foreach (char c in word)
    {
        if (!guessedLetters.Contains(c)) //If guessedLetters doesn't contains c the word is not complete
            wordComplete = false;
    }
    win = wordComplete; //bool Win is set to wordComplete
}

if (win) //if bool win is true
{
    Console.WriteLine("You won!");
}
else Console.WriteLine("You lost!");
