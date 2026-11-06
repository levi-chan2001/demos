Console.WriteLine("Step Challenge");
Console.WriteLine();
Console.Write("Count down from: ");
int countDown = Convert.ToInt32(Console.ReadLine());
if (countDown <= 0)
{
    Console.WriteLine("Invalid number");
}
else
{
    while (countDown > 0)
    {
        Console.WriteLine($"{countDown}...");
        countDown--;
    }
    Console.WriteLine("Go!");
}
Console.WriteLine();

int totalSteps = 0;
int days = 0;
int bestDay = 0;

Console.WriteLine("Enter today's steps (0 to stop): ");
int steps = Convert.ToInt32(Console.ReadLine());
while (steps != 0)
{
    totalSteps += steps;
    days++;
    if (steps > bestDay)
    {
        bestDay = steps;
    }
    Console.WriteLine("Enter Today's steps (0 to stop): ");
    steps = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();
if (days == 0)
{
    Console.WriteLine("No steps logged.");
}
else
{
    double average = (double)totalSteps / days;
    Console.WriteLine("Days logged: " + days);
    Console.WriteLine("Total steps: " + totalSteps);
    Console.WriteLine("Best day: " + bestDay);
    Console.WriteLine("Average: " + average);
}
Console.WriteLine();

const int GOAL = 100000;

Console.Write("Steps per day for the challenge: ");
int stepsPerDay = Convert.ToInt32(Console.ReadLine());

if (stepsPerDay <= 0)
{
    Console.WriteLine("Steps per day must be more than 0");
}
else
{
    int runningTotal = 0;
    int daysNeeded = 0;

    while (runningTotal < GOAL)
    {
        runningTotal += stepsPerDay;
        daysNeeded++;
    }
}