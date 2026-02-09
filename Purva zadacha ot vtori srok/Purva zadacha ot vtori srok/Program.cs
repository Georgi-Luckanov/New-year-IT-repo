/*for (int i = 0; i <= 100; i++)
{
    Console.Write(i + " ");

    if (i % 10 == 9) 
    {
        Console.WriteLine();
    }
}
Console.WriteLine();*/

int num = 0;
while (num <= 100)
{
    Console.Write(num + " ");
    if(num % 10 == 9)
    {
        Console.WriteLine();
    }
    num++;
}
Console.WriteLine();