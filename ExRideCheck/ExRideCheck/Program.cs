Console.Write("What's your name? ");
string name = Console.ReadLine();

Console.Write("How old are you? ");
int age = Convert.ToInt32(Console.ReadLine());

Console.Write("How tall are you, in cm? ");
int height = Convert.ToInt32(Console.ReadLine());

Console.Write("How many ride tickets do you have? ");
int tickets = Convert.ToInt32(Console.ReadLine());


bool isTall = height >= 122;
Console.WriteLine($"Tall enough for roller coaster: {isTall}");

bool kidCanRide = !(height >= 110);
Console.WriteLine($"Can ride the kiddie train: {kidCanRide}");

bool needAdult = age < 12;
Console.WriteLine($"Needs an adult: {needAdult}");

bool rideAlone = height >= 122 && age >= 12;
Console.WriteLine($"Can ride roller coaster alone: {rideAlone}");

bool getDiscount = age < 6 || age >= 65;
Console.WriteLine($"Gets the discount: {getDiscount}");

bool isTeen = age >= 13 && age <= 19;
Console.WriteLine($"Is a teen: {isTeen}");

bool ticketLeft = tickets == 1;
Console.WriteLine($"Exactly one ticket left: {ticketLeft}");

bool enoughTicketsCoaster = tickets >= 4;
Console.WriteLine($"Enough tickets for the coaster: {enoughTicketsCoaster}");

bool canRideToday = rideAlone && enoughTicketsCoaster;
Console.WriteLine($"Can ride the coaster today: {canRideToday}");
