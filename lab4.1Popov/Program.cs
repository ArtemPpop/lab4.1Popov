double[] Y = new double[12];
for (int i = 0; i < 12; i++)
{
    Y[i] = Math.Pow(i, 2) - 2 * i + 19.3 * Math.Cos(i);
}
double sum = 0;
for (int i = 0; i < 12; i++)
{
    sum += Y[i];
}
double average = sum / 12;


double[] newY = new double[12];
int index = 0;
for (int i = 0; i < 12; i++)
{
    if (Y[i] < average)
    {
        newY[index] = Y[i];
        index++;
    }
}
for (int i = 0; i < 12; i++)
{
    if (Y[i] >= average)
    {
        newY[index] = Y[i];
        index++;
    }
}

Console.WriteLine($"начальный массив Y:");
foreach (double element in Y)
{
    Console.Write(element + " ");
}


Console.WriteLine("новый массив newY:");
foreach (double element in newY)
{
    Console.Write(element + " ");
}