Console.Write("Where are you going?: ");
string location = Console.ReadLine();
Console.Write("How far is it. in km?: ");
double km = Convert.ToDouble(Console.ReadLine());
Console.Write("how many liters of gas does the car use per 100km?: ");
double per100km = Convert.ToDouble(Console.ReadLine());
Console.Write("What's the price of gas per liter?: ");
double price100km = Convert.ToDouble(Console.ReadLine());
Console.Write("How many people are going?: ");
int peoplegoing = Convert.ToInt32(Console.ReadLine());

double fuelNeededLiters = km / 100 * per100km;
Console.WriteLine($"fuel needed is {fuelNeededLiters} liters");
double totalGasCost = fuelNeededLiters * price100km;
Console.WriteLine($"the total gas cost is {totalGasCost}");
double totalPersonShare = totalGasCost * peoplegoing;
Console.WriteLine($"each person share is {totalPersonShare}");
int personShareDollars = Convert.ToInt32(totalPersonShare);
Console.WriteLine($"total share in whole dollars is {personShareDollars}");





