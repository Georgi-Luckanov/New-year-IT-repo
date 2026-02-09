//zadacha s "for"
for (int i = 0; i <= 100; i++)
{
    Console.Write(i + " ");

    if (i % 10 == 9) 
    {
        Console.WriteLine();
    }
}
Console.WriteLine();
int num = 0;

//zadacha s "do while"
while (num <= 100)
{
    Console.Write(num + " ");
    if (num % 10 == 9)
    {
        Console.WriteLine();
    }
    num++;
}
Console.WriteLine();
do
{
    Console.WriteLine(num + " ");
    if (num % 10 == 9)
    { 
        Console.WriteLine(); 
    }
    num++;
} while (num <= 100);
Console.WriteLine();

//Task:
//Input N numbers and output the one with the highest value 
int numbrer = int.Parse(Console.ReadLine());
int max = int.MinValue;
for (int i = 0; i < numbrer; i++)
{
    int number = int.Parse(Console.ReadLine());
        if (number >  max)
        {
        max = number;
        }
}
Console.WriteLine(max);