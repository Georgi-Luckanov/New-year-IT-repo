using System.Globalization;

int number = 0;
int negative = 0;

do
{
    number = int.Parse(Console.ReadLine());
    if (number < 0)
    {
        int digit = 0;
        int numberCopy = number;
        while (number !=0)
        {
            numberCopy = numberCopy / 10;
            digit++;
        }
        
        if ((digit % 2) ==0)
        {
            negative = number;
            break;
        }
     
    }
} while  (number != 0);
Console.WriteLine(negative);
Console.WriteLine("No suitable number found");
