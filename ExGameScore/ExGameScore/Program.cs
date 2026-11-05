Console.Write("Player name? ");
string playerName = Console.ReadLine();
Console.Write("Starting lives? ");
int startingLives = Convert.ToInt32(Console.ReadLine());
Console.Write("Points per coin? ");
int pointPerCoin  = Convert.ToInt32(Console.ReadLine());
int score = 0;
string log = $"{playerName}'s game log";
int world = 2; 
score += 3 * pointPerCoin;
log += Environment.NewLine + $"Collected 3 coins. Score: {score}";

startingLives--;
log += Environment.NewLine + $"Hit by an enemy. Lives: {startingLives}";

score *= 2;
log += Environment.NewLine + $"Defeated the boss. Score doubled: {score}";

score -= 25;
log += Environment.NewLine + $"Took a 25-point penalty. Score: {score}";

startingLives++;
log += Environment.NewLine + $"Found an extra life. Lives: {startingLives}";

world = (world + 1) % 3;
log += Environment.NewLine + $"Moved to the next world: world {world}";

Console.WriteLine();
Console.WriteLine($"{log}");
Console.WriteLine();
int totalscore = score;
int totalLives = startingLives;
Console.WriteLine($"total score is {totalscore} and total lives is {totalLives}");

int share = score /= 4;
Console.WriteLine($"shared score is {share}");