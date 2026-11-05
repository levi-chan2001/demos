Console.Write("Enter a pets name: ");
string petName = Console.ReadLine();

Console.Write("What's the species? ");
string petSpecies = Console.ReadLine();

Console.Write("Enter personality trait: ");
string petPersonality = Console.ReadLine();

Console.Write("What is the pets favorite toy or activity? ");
string petFavorite = Console.ReadLine();


Console.Write("Enter pet's favorite treat: ");
string petTreat = Console.ReadLine();

string out1 = "meet " + petName + "! This " + petPersonality + " " + petSpecies + " loves " + petFavorite + " and is ready for a new home! ";
//Console.WriteLine(out1);
//Console.WriteLine($"meet {petName}! This {petPersonality} {petSpecies} loves {petFavorite} and is ready for a new home!");
string out2 = "give them some " + petTreat + " and they'll be your best friend.";
//Meet Biscuit! This playful dog loves chasing tennis balls and is ready for a new home.
//give them some peanut butter and they'll be your best friend.

Console.WriteLine($"{out1}\n{out2}");
Console.WriteLine(out1 + "\n" + out2);