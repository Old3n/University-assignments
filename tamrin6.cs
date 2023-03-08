// See https://aka.ms/new-console-template for more information


    static bool AskQuestion(string question)
{
    Console.Write("{0} (y/n): ", question);
    string answer = Console.ReadLine();

    while (answer != "y" && answer != "n")
    {
        Console.Write("Invalid response. Please enter 'y' or 'n': ");
        answer = Console.ReadLine();
    }

    return answer == "y";
}
bool answerA = AskQuestion("Do you like pizza?");
if (answerA)
{
    bool answerB = AskQuestion("Do you prefer pepperoni or sausage on your pizza?");
    if (answerB)
    {
        Console.WriteLine("You must really love pizza with pepperoni!");
    }
    else
    {
        Console.WriteLine("You must really love pizza with sausage!");
    }
}
else
{
    bool answerC = AskQuestion("Do you like sushi?");
    if (answerC)
    {
        Console.WriteLine("You're quite the foodie!");
    }
    else
    {
        Console.WriteLine("Well, maybe you just need to try more foods.");
    }
}

bool answerD = AskQuestion("Do you prefer sweet or salty snacks?");
if (answerD)
{
    bool answerE = AskQuestion("Do you like chocolate or candies more?");
    if (answerE)
    {
        Console.WriteLine("Looks like you have a sweet tooth for chocolates!");
    }
    else
    {
        Console.WriteLine("Looks like you prefer candies over chocolates!");
    }
}
else
{
    bool answerF = AskQuestion("Do you like chips or popcorn more?");
    if (answerF)
    {
        Console.WriteLine("You must be a fan of crispy and salty chips!");
    }
    else
    {
        Console.WriteLine("You must be a fan of buttery and crunchy popcorn!");
    }
}

bool answerG = AskQuestion("Do you enjoy outdoor activities?");
if (answerG)
{
    bool answerH = AskQuestion("Do you prefer hiking or camping?");
    if (answerH)
    {
        Console.WriteLine("You must enjoy being surrounded by nature while hiking!");
    }
    else
    {
        Console.WriteLine("You must love the adventure and thrill of camping!");
    }
}
else
{
    bool answerI = AskQuestion("Do you enjoy watching movies or reading books?");
    if (answerI)
    {
        Console.WriteLine("You must be a movie buff!");
    }
    else
    {
        Console.WriteLine("You must be a bookworm!");
    }
}

bool answerJ = AskQuestion("Do you like sports?");
if (answerJ)
{
    bool answerK = AskQuestion("Do you prefer playing or watching sports?");
    if (answerK)
    {
        Console.WriteLine("You must be an active person who enjoys playing sports!");
    }
    else
    {
        Console.WriteLine("You must be a spectator who loves watching sports!");
    }
}
else
{
    bool answerL = AskQuestion("Do you like shopping or traveling?");
    if (answerL)
    {
        Console.WriteLine("You must enjoy going on shopping sprees!");
    }
    else
    {
        Console.WriteLine("You must enjoy traveling to new places!");
    }
}

bool answerM = AskQuestion("Do you like spicy food?");
if (answerM)
{
    bool answerN = AskQuestion("Do you prefer Indian or Mexican spicy food?");
    if (answerN)
    {
        Console.WriteLine("You must enjoy the flavorful spices in Indian food!");
    }
    else
    {
        Console.WriteLine("You must enjoy the bold flavors in Mexican food!");
    }
}
else
{
    bool answerO = AskQuestion("Do you like listening to music?");
    if (answerO)
    {
        Console.WriteLine("You must have a great taste in music!");
    }
    else
    {
        Console.WriteLine("Maybe you just haven't found the right kind of music yet!");
    }
}

bool answerP = AskQuestion("Do you like dogs or cats as pets?");
if (answerP)
{
    bool answerQ = AskQuestion("Do you prefer small or big dogs?");
    if (answerQ)
    {
        Console.WriteLine("You must love carrying around small dogs!");
    }
    else
    {
        Console.WriteLine("You must love having giant dogs as companions!");
    }
}
else
{
    bool answerR = AskQuestion("Do you like birds or fish as pets?");
    if (answerR)
    {
        Console.WriteLine("Birds are such beautiful and intelligent creatures!");
    }
    else
    {
        Console.WriteLine("Fish come in so many varieties and colors!");
    }
}

bool answerS = AskQuestion("Do you prefer coffee or tea?");
if (answerS)
{
    bool answerT = AskQuestion("Do you like your coffee black or with cream and sugar?");
    if (answerT)
    {
        Console.WriteLine("You must like your coffee strong and bitter!");
    }
    else
    {
        Console.WriteLine("You must like your coffee creamy and sweet!");
    }
}
else
{
    bool answerU = AskQuestion("Do you like green tea or herbal tea?");
}