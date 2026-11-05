using System.ComponentModel.Design;

const int ADULT_WEEKDAY = 50;
const int ADULT_WEEKEND = 65;
const int YOUTH_WEEKDAY = 25;
const int YOUTH_WEEKEND = 35;
const int NIGHT_SKIING = 20;
const int CHILDREN = 0;
const int STUDENT_WEEKDAY = 25;
const int STUDENT_WEEKEND = 35;
const int SENIOR = 30;



Console.WriteLine("Ski Hill Day Pass\n");
Console.Write("Age: ");
int age = Convert.ToInt32(Console.ReadLine());

Console.Write("Day (1 = Monday ... 7 = Sunday: ");
int day = Convert.ToInt32(Console.ReadLine());
bool isWeekend = day == 6 || day == 7;

Console.Write("Night skiing? (y/n): ");
string night = Console.ReadLine();
bool isNight = (night.ToLower() == "y");

Console.Write("Student card? (y/n): ");
string student = Console.ReadLine();
bool isStudent = (student.ToLower() == "y");

string ticketType = "";
int ticketPrice = 0;
// First check is Age to narrow down which type of age group
// Second check Weekday and or Weekend
//third if its night or day
// fourth if its student or not

if (age > 0 && age < 6)
{
    ticketType = "child";
    ticketPrice = CHILDREN;
}
else if (age > 5 && age < 18)
{
    if (isWeekend)
    {
        ticketPrice = YOUTH_WEEKEND;
        ticketType = "youth weekend";
    }
    else
    {
        ticketPrice = YOUTH_WEEKDAY;
        ticketType = "youth weekday";
    }
    
} 
else if (age > 18 && day < 65)
{
    if (isWeekend)
    {
        ticketType = "adult weekend";
        ticketPrice = ADULT_WEEKEND;
    }
    else
    {
        ticketType = "adult weekday";
        ticketPrice = ADULT_WEEKDAY;
    }

}
else if (age > 65 && age < 120)
{
    ticketType = "senior ticket";
    ticketPrice = SENIOR;
}
else if (isNight)
{
    ticketType = "night ticket";
    ticketPrice = NIGHT_SKIING;
}
else if (isStudent)
{
    if (isWeekend)
    {
        ticketPrice = STUDENT_WEEKEND;
        ticketType = "student weekend";
    }
    else
    {
        ticketType = "student weekday";
        ticketPrice = STUDENT_WEEKDAY;
    }
}
else
{
    Console.WriteLine("invalid");

}

Console.WriteLine(ticketType);
Console.WriteLine($"{ticketPrice:c}");

