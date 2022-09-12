int counter = 0;
double nummer;
double[] arr = new double[20];

Console.WriteLine("Tast '#' for at afslutte");
while (true)
{
    if (counter == arr.Length) { Console.WriteLine("Arrayet er fyldt"); Console.WriteLine("Afslutter..."); break; }
    Console.Write($"Indtast tal {counter + 1}: ");
    string input = Console.ReadLine();
    if (input == "#") { break; }
    if (input != null)
    {
        try
        {
            nummer = double.Parse(input);
            arr[counter++] = nummer;
        }
        catch (FormatException)
        {
            Console.WriteLine("Det var jo ikke et tal");
        }
    }
}

Console.WriteLine($"Summen af {PrintArray(arr)} er: {arr.Sum()}");
Console.WriteLine($"Produktet af {PrintArray(arr)} er: {Produkt(arr)}");
Console.WriteLine($"Det største {PrintArray(arr)} er: {arr.Max()}");
Console.WriteLine($"Det mindste {PrintArray(arr)} er: {Min(arr)}");
Console.WriteLine($"Gennemsnittet af {PrintArray(arr)} er: {Avg(arr)}");

static string PrintArray(double[] array)
{
    string str = string.Empty;
    foreach (var item in array)
    {
        if (item != 0)
        {
            str += item + ", ";
        }
    }
    string output = str.Remove(str.Length - 2, 2);
    return output;
}

static double Avg(double[] array)
{
    double sum = 0;
    int counter = 0;
    foreach (var item in array)
    {
        if (item != 0)
        {
            sum += item;
            counter++;
        }
    }
    return sum / counter;
}
static double Min(double[] array)
{
    double min = double.PositiveInfinity;
    foreach (var item in array)
    {
        if (item != 0 && item < min)
        {
            min = item;
        }
    }
    return min;
}
static double Produkt(double[] array)
{
    double produkt = 1;
    foreach (var item in array)
    {
        if (item != 0)
        {
            produkt *= item;
        }
    }
    return produkt;
}