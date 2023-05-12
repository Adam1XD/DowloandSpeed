using DowloandSpeed;

Console.WriteLine("---Dowland speed Calculator---");
DFile file = new();
file.Choice();
Console.WriteLine("Inser your dowloand speed in megabytes:");
Console.WriteLine(file.DowloandSpeed(double.Parse(Console.ReadLine()))); 