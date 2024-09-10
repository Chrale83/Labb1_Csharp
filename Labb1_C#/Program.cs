
static long CalcStringValue(string inputString)
{
char tempChar = '\0';
int startIndex = 0;
int stopIndex = 0;
string firstSubstring = string.Empty;
string ValueSubString = string.Empty;
string lastSubstring = string.Empty;
long totalSum = 0;
bool stringFound = true;

for (int i = 0; i < inputString.Length; i++)
{
    
    stringFound = false;


for (int j = i; j < inputString.Length; j++)
{
    if (!char.IsDigit(inputString[j]))
    {
        break;
    }
           
    if (j == i)
    {
        tempChar = inputString[j];
        startIndex = j;
    }
        
    if (j > i && tempChar == inputString[j]) 
    {
        stopIndex = j;
        firstSubstring = inputString.Substring(0, startIndex);
        ValueSubString = inputString.Substring(startIndex, (stopIndex - startIndex + 1));
        lastSubstring = inputString.Substring(j + 1);
        totalSum += long.Parse(ValueSubString);
        stringFound = true;

        break;
    }

    if (stringFound)
    {
    Console.Write(firstSubstring);
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(ValueSubString);
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write(lastSubstring);
    Console.WriteLine();
    }
}
}
    Console.WriteLine();
    return totalSum;
}
long totalSumOfString = 0;

Console.Write("Skriv in din sträng: ");
string inPutedString = Console.ReadLine();
Console.WriteLine();



totalSumOfString = CalcStringValue(inPutedString);


if (totalSumOfString == 0)
{
    Console.WriteLine($"Det fanns ingen sammanhängande sträng");
}
else
{
    Console.WriteLine($"Total summan är: {totalSumOfString}");
}

