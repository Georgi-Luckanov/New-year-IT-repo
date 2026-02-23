int minValue = int.MaxValue;
short[] temperature  = new short[30];
for (int i  = 0; i  < temperature.Length; i ++)
{
   temperature[i] = short.Parse(Console.ReadLine());
    if (temperature[i] < minValue)
    {
        minValue = temperature[i];
    }
}
Console.WriteLine(minValue);