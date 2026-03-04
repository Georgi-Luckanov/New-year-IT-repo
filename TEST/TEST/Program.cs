using System.ComponentModel.DataAnnotations;

int n = int.Parse(Console.ReadLine());
int maxLength = 0;

int[] number = new int[n];
for (int i = 0; i < n; i++)
{
    number[i] = int.Parse(Console.ReadLine());
}
for  (int i = 0; n > 0; i++)
{
    int count = 0;
    if (number[i] > maxLength && number[i] == maxLength )
    {
        count++;
    }
    else
    {
        count = maxLength;
    }
}
Console.WriteLine(maxLength);