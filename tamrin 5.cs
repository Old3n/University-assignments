// See https://aka.ms/new-console-template for more information
// tamrinat hossein mikarami 
ConsoleKeyInfo digit;
int score;
bool check;
string input;
do 
{
    Console.WriteLine("Enter your score : ");
    score = 0;
    do
    {

        

        LockKeyborad();
        studentscore();

    } while (digit.Key.ToString() != "Enter");

    Console.WriteLine();
    scorecalc();
    LockKeyboradYN();

}
while (input.ToLower() == "y");

Console.WriteLine("Thank you ");





void LockKeyboradYN()
{
    Console.WriteLine("Do you want to continue? press y, press n for stop ");
    do
    {
        input = Console.ReadKey(true).KeyChar.ToString();

    } while (input.ToLower() != "y" && input.ToLower() != "n");
}

void studentscore()
{
    if (digit.Key.ToString() != "Enter")
    {
        score =  score  * 10 + Convert.ToInt16(digit.KeyChar.ToString());
        Console.Write(digit.KeyChar);
        

    }
}

void LockKeyborad()
{
    do
    {
        digit = Console.ReadKey(true);

    } while (digit.KeyChar.ToString() != "0" && digit.KeyChar.ToString() != "1" &&
            digit.KeyChar.ToString() != "2" && digit.KeyChar.ToString() != "3" &&
            digit.KeyChar.ToString() != "4" && digit.KeyChar.ToString() != "5" &&
            digit.KeyChar.ToString() != "6" && digit.KeyChar.ToString() != "7" &&
            digit.KeyChar.ToString() != "8" && digit.KeyChar.ToString() != "9" &&
            digit.Key.ToString() != "Enter");
}


void scorecalc() 
{
    if (score >= 0 && score <= 10)

    {
        Console.WriteLine("youre terrible you have failed !!! ");


    }
    else if (score >= 11 && score <= 15)
    {
        Console.WriteLine("youre not bad you are in the C grade ");
    }
    else if (score >= 16 && score <= 17)
    {
        Console.WriteLine("youre in the B grade good job ");
    }
    else if (score >= 18 && score <= 20)
    {
        Console.WriteLine("youre in the a graed Prefect ");

    }
    else {
        Console.WriteLine("plz enter the right score between 0 and 20 ");
    }
}