

Console.WriteLine("Winter Driving Advisor");

Console.Write("Temperature (C): ");
int temperature = Convert.ToInt32(Console.ReadLine());
Console.Write("Snowfall (cm): ");
int cm = Convert.ToInt32(Console.ReadLine());
Console.Write("wind (km/h): ");
int kmh = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if (temperature <= -20)
{
    Console.WriteLine("Plug in your block heater");
}

if (temperature <= 0)
{
    Console.WriteLine("Watch for black ice");
}
else
{
    Console.WriteLine("No ice expected");
}

if (cm >= 15 || kmh > 40)
{
    Console.WriteLine("Storm conditions. Stay home if you can.");
}
else if (cm == 0)
{
    Console.WriteLine("Roads are clear.");
}
else if (cm < 5 && cm > 0)
{
    Console.WriteLine("Light snow. Drive carefully.");
}
else
{
    Console.WriteLine("Heavy snow. Winter tires needed.");
}
