

string inputString = "295235123p48723487597645723645";
char tempChar = ' ';
int startIndex = 0;
int stopIndex = 0;
string firstSubstring = "";
string ValueSubString = "";
string lastSubstring = "";
long totalSum = 0;


for (int i = 0; i < inputString.Length; i++)
{
    if (!char.IsDigit(inputString[i]))
    {
        break;
    }

    if (i == 0)
    {
        tempChar = inputString[i];
        startIndex = i;
        
    }

    if (i > 0 && tempChar == inputString[i]) 
    {
        stopIndex = i;
        firstSubstring = inputString.Substring(0, startIndex);
        ValueSubString = inputString.Substring(startIndex, (stopIndex - startIndex + 1));
        lastSubstring = inputString.Substring(i + 1);
        totalSum += long.Parse(ValueSubString);
        break;
    }
}

    



Console.WriteLine($"Start index är: {startIndex}");
Console.WriteLine($"tempchar är: {tempChar}");
Console.WriteLine($"stopIndex är; {stopIndex}");
Console.WriteLine($"operation är; {stopIndex - startIndex + 1}");


Console.WriteLine($"correctsubstring är:   {ValueSubString}");


Console.Write(firstSubstring);
Console.ForegroundColor = ConsoleColor.Red;
Console.Write(ValueSubString);
Console.ForegroundColor = ConsoleColor.White;
Console.Write(lastSubstring);






