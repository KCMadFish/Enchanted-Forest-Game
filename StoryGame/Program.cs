using System.Xml.Linq;
/// introduction to the game
Console.WriteLine("Welcome to the Enchanted Forest!\n");
Console.Write("What is your name? ");
var playerName = Console.ReadLine();
while (playerName == "")
{
    Console.WriteLine("Please enter your name:");
    playerName = Console.ReadLine();
}
Console.WriteLine("Wow,{0} what an interesting name! Behold the forest", playerName);
Console.WriteLine("You decided to start the day off with an adventure! You are standing on the edge of the forest. Many choices await you.");
/// choices begin
Console.WriteLine("Options: \n1. You smell a delicious scent. In your haste for adventure you forgot to have breakfast\n2. You notice a small, winding path to the left. A path is good! You can meet new people.\n3. You look straight ahead, there is no path, just tall trees. What's a little extra adventure? \n4. You look down. What's this? There's candy at your feet! Who says no to free candy?!");