//Console.WriteLine("Enter your name:");
//string userName = Console.ReadLine();

//GreetUser(userName);


//static void GreetUser(string someName)
//{
//    Console.WriteLine($"Hello, {someName}");
//}


Console.WriteLine("Enter your comment:");
string userInput = Console.ReadLine();

CountSpaces(userInput);

static void CountSpaces(string someString)
{
    someString = someString.Trim();
    int wordCounter = 1;

    foreach (char symbol in someString)
    {
        if (char.IsWhiteSpace(symbol))
        {
            wordCounter++;  
        }
 
    }
    string word = "word";
    if(wordCounter > 1)
    {
        word = "words";
    }
    Console.WriteLine($"Your comment contains {wordCounter}{word}.");
}


