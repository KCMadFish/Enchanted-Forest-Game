namespace StoryGame;
/// introduction to the game
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Enchanted Forest!\n \n What is your name? ");
        var playerName = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(playerName))
        {
            Console.WriteLine("Please enter your name:");
            playerName = Console.ReadLine();
        }
        bool isPlaying = true;
        Console.WriteLine("Wow, what an interesting name! \n Behold the forest {0}!", playerName);
        Console.WriteLine("You decided to start the day off with an adventure!");
        while (isPlaying)
        {
            Console.WriteLine("You are standing on the edge of the forest. Many choices await you.");
            /// choices begin

            Console.WriteLine("Options: \n1. You smell a delicious scent. In your haste for adventure you forgot to have breakfast \n 2. You notice a small, winding path to the left. A path is good! You can meet new people.\n3. You look straight ahead, there is no path, just tall trees. What's a little extra adventure? \n 4. You look down. What's this? There's candy at your feet! Who says no to free candy?!");
            Console.WriteLine("Which option do you choose?");


            int choice = 0;

            while (choice < 1 || choice > 4)
            {
                Console.WriteLine("Please choose an option, choose between 1 and 4:");

                string? input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Please enter a number not a space!");
                    continue;
                }

                if (!int.TryParse(input, out choice))
                {
                    Console.WriteLine("That's not valid! Please enter a whole number.");
                    continue;
                }

                if (choice < 1 || choice > 4)
                {
                    Console.WriteLine("Please stop trying to break me! Please enter a number between 1 and 4.");
                }
            }
            if (choice == 1)
            {
                Console.WriteLine("You chose option 1. Guess your hunger won! You follow the scent towards a lovely, little cottage. \n You notice its homely vibe with yellow painted walls and a great big oak door.");
            }
            else if (choice == 2)
            {
                Console.WriteLine("You chose option 2. You begin on the winding path. It is quite a peaceful trail, with the sound of birdsong in the air. In the distance you see three little homes and journey towards them.");
            }
            else if (choice == 3)
            {
                Console.WriteLine("You chose option 3. This part of the forest is a little spooky, but you are brave! While walking you hear some whistling ahead.");
            }
            else if (choice == 4)
            {
                Console.WriteLine("You chose option 4. Dang, eating sweets off the floor? I mean go off I guess! You follow the trail of candy, eating some while putting the rest in your pockets. The burst of sugar on your tongue fuels you to continue on.");
            }
        }
    }
}