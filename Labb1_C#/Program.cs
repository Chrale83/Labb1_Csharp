



static long CalcSubStringValue(string inputedString)
{
    Console.WriteLine();
    string inputString = inputedString;

    if (inputString == string.Empty)
    {
        Console.WriteLine("Du skrev inte in nån sträng (standard sträng kommer användas");
        inputString = "29535123p48723487597645723645";
        Console.WriteLine();
    }

char tempChar = '\0';
int startIndex = 0;
int stopIndex = 0;
string firstSubString = string.Empty;
string ValueSubString = string.Empty;
string lastSubString = string.Empty;
long totalSum = 0;
bool IsStringFound = true;

for (int i = 0; i < inputString.Length; i++)
{
    IsStringFound = false;
    
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
            firstSubString = inputString.Substring(0, startIndex);
            ValueSubString = inputString.Substring(startIndex, (stopIndex - startIndex + 1));
            lastSubString = inputString.Substring(j + 1);
            totalSum += long.Parse(ValueSubString);
            IsStringFound = true;
            
            break;
        }
    }
    
    if (IsStringFound)
    {
        Console.Write(firstSubString);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(ValueSubString);
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(lastSubString);
        Console.WriteLine();
    }
}
    Console.WriteLine();
    return totalSum;
} 
long totalSubStringValue = 0;

Console.Write($"Skriv in valfri sträng: ");
totalSubStringValue = CalcSubStringValue(Console.ReadLine());

Console.WriteLine($"Den totala summan av delsträngarna är: {totalSubStringValue}");

