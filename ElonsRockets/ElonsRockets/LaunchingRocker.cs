Rocket newRocket = new Rocket();
Console.WriteLine("Press a Key");
Console.ReadKey();
newRocket.Launch();
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Rocket has launched");

Console.WriteLine("Press any key to see the status of the rocket, q to quit and l to land");

while (true)
{
    Console.WriteLine($"Status: {newRocket.Status}");
    var keyEntered = Console.ReadKey();
    if (missionDuration.TotalSeconds > 10)
            Console.ForegroundColor = ConsoleColor.Magenta;
    if (keyEntered.KeyChar == 'l') 
    {
        newRocket.Land();
    }
    if (keyEntered.KeyChar == 'q')
    {
        break;
    }
}
