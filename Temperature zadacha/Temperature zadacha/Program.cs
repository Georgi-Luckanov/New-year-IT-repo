int minValue = int.MaxValue;
int maxValue = int.MinValue;
short[] temperature = new short[5];
double average = 0;
for (int i = 0; i < temperature.Length; i++)
{
    temperature[i] = short.Parse(Console.ReadLine());
    average += temperature[i];
    if (temperature[i] < minValue)
    {
        minValue = temperature[i];
    }
    if (temperature[i] > maxValue)
    {
        maxValue = temperature[i];
    }
}
average = Math.Round (average / temperature.Length,2);
short count = 0;
for (int i = 0;i < temperature.Length;i++)
{
    if (temperature[i] < average)
    {
        count ++;
    }
}
Console.WriteLine($"The lowest temperature: {minValue}");
Console.WriteLine($"The highest temperature: {maxValue}");
Console.WriteLine($"The average temperature: {average}");
Console.WriteLine($"Temperature below average: {count}");


