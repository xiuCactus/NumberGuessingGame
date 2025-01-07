// See https://aka.ms/new-console-template for more information


bool isCorrectGuess = false;//false
bool wronganswer = true;

Random random = new Random();

int randomNum = random.Next(1,11);

Console.WriteLine("welcome to the Guess Game");
Console.WriteLine("Guess the correct Number between 1 and 10 to Win the Game ");

//Answered wrongly= True (isCorrectGuess=False =>!iscorrectguess
while (!isCorrectGuess) //true  //false
    //We need a statement that results True, when the answer is wrong.
{
    //Execute only when the user answered wrongly. (iscorrectGuess =False) 
    Console.WriteLine("enter your Number:");
    int guess = Convert.ToInt32(Console.ReadLine());

    if (guess > randomNum)
    {
        Console.WriteLine("to high! Try again.");
    }
    else if (guess < randomNum)
    {
        Console.WriteLine("to low! Try again.");
    }
    else
    {
        Console.WriteLine("Congratulations, you won! ");
        isCorrectGuess = true;
    }
}
Console.ReadKey();