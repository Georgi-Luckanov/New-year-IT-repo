int minValue = int.MaxValue;
int maxValue = int.MinValue;
short[] temperature  = new short[30];
for (int i  = 0; i  < temperature.Length; i ++)
{
   temperature[i] = short.Parse(Console.ReadLine());
    if (temperature[i] < minValue)
    {
        minValue = temperature[i];
    }
    if (temperature[i] > maxValue)
    {
        maxValue = temperature[i];
    }
}
Console.WriteLine($"The lowest temperature: {minValue}");
Console.WriteLine($"The highest temperature: {maxValue}");