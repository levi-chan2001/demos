const double STARTING_BALANCE = 200;
const int CORRECT_PIN = 1234;

Console.WriteLine("ATM Withdrawal");
Console.Write("Enter your PIN: ");
int pin = Convert.ToInt32(Console.ReadLine());
Console.Write("Amount to withdraw: $");
double amount = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
bool pinCorrect = (pin == CORRECT_PIN);
if (pinCorrect)
{
    if (amount <= 0)
    {
        Console.WriteLine("Invalid amount");
    }
    else if (!(amount % 20 != 0))
    {
        Console.WriteLine("Amount must be a multiple of $20");
    }
    else if (amount > STARTING_BALANCE)
    {
        Console.WriteLine("Insufficient funds.");
    }
    else
    {
        double newBalance = STARTING_BALANCE - amount;
        Console.WriteLine($"Dispensed ${amount}");
        Console.WriteLine($"New balance: ${newBalance}");
    }
        
        
}
else
{
    Console.WriteLine("Incorrect PIN.");
}


