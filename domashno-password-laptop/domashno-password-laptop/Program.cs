Console.WriteLine("Enter a password:");
string password = Console.ReadLine();
int letter = 0;
int number = 0;
int symbol = 0;
char[] charArray = password.ToCharArray();
for (int i = 0; i < charArray.Length; i++)
{
    //if ((charArray[i] >= 65 && charArray[i] <= 90) || (charArray[i] >= 97 && charArray[i] <= 122))
    if (char.IsLetter(charArray[i]))
    {
        letter++;
    }
    else if (char.IsDigit(charArray[i]))
    {
        number++;
    }
    else
    {
        symbol++;
    }
}
if (password.Length >= 8 && letter > 0 && number > 0 && symbol > 0)
{
    Console.WriteLine("Strong password");
}
else if (password.Length >= 6 && letter > 0 && number > 0)
{
    Console.WriteLine("Medium password");
}
else
{
    Console.WriteLine("Weak password");
}