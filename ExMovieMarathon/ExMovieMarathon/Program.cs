// part 1

int movie1 = 142;
int movie2 = 169;
int movie3 = 152;
int movie4 = 120;

int lenght = movie1 + movie2 + movie3 + movie4;
Console.WriteLine($"total minutes is {lenght} Minues! ");

int totalHours = lenght / 60;
int totalMinutes = lenght % 60;

Console.WriteLine($"total is {totalHours} hours and {totalMinutes} Minutes!");

// Part 2

double Average = lenght / 4;
Console.WriteLine($"average lenght is {Average} Minutes");

// Part 3


int groupSize = 6;
int groupCost = 60;
int snackCost = 24;
int totalPerPerson = snackCost + groupCost / groupSize;
Console.WriteLine($"Total per person is {totalPerPerson}$");

// Part 4

int totalFullRow = 30 / 8;
int totalLastRow = 30 % 8;
Console.WriteLine($"total full rows is {totalFullRow} and total people in last row is {totalLastRow} people!");

// Part 5

Random random = new Random();
int ticketNumber = random.Next(1, 101);
int remainderNumber = ticketNumber % 2;
Console.WriteLine($"the ticket number is {ticketNumber} and the remainder is {remainderNumber}");

