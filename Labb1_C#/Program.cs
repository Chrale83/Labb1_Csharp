

string inputString = "29535123p48723487597645723645";
char tempChar = ' ';
int startIndex = 0;
int stopIndex = 0;
string tempSubString = "";
string lastSubstring = "";
int totalSum = 0;

for (int i = 0; i < inputString.Length; i++)
{
	if (!char.IsDigit(inputString[i]))
	{
		break;
	}

	if (i == 0)
	{
	tempChar = inputString[i];
	startIndex = inputString.IndexOf(inputString[i]);
	}

	if (i > 0 && tempChar == inputString[i])
	{
		stopIndex = i;
		tempSubString = inputString.Substring(startIndex, i + 1);
		lastSubstring = inputString.Substring(i+1);

		totalSum += int.Parse(tempSubString);
    }



}
    Console.WriteLine(tempSubString + " " + lastSubstring);
	Console.WriteLine(totalSum);


