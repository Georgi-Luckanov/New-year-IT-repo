int number = 0;
int LastNumber = number;
int lenght = 0;
int diff = 0;
int maxLenght = int.MinValue;

do
{
    number = int.Parse(Console.ReadLine());
    diff = number - LastNumber;
    if ((diff == 1) || (diff == number))
    {
        lenght++;
    }
    else
    {
        if (lenght>maxLenght)
        {
            maxLenght = lenght;
        }
        diff = 0;
        lenght = 0;
    }
    LastNumber = number;
} while (number != 0);
Console.WriteLine(maxLenght + 1);