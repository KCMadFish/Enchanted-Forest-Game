using System.Text;

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

            /// Story 1 Options

            if (choice == 1)
            {
                Console.WriteLine("You chose option 1. Guess your hunger won! You follow the scent towards a lovely, little cottage. \n You notice its homely vibe with yellow painted walls and a great big oak door.");
                Console.WriteLine("You knock on the door and receive no answer, but your knocking opens the door! \n Since you're super nosy, you decide to enter the home. \n Inside you find a kitchen with a wooden table in the middle. On the table are bowls of porridge.");
                Console.WriteLine("What do you decide to do? You're actually really hungry! \n 1. Have a seat at the table and start eating the biggest bowl of porridge. What? You're super hungry \n 2.Decide you are very hungry but you sit down and eat the smallest bowl of porridge,surely no one will miss it? \n 3. Your curiosity wins over your hunger. You decide to explore the house further \n 4. You think you've intruded enough and want to meet the owners of the cottage. You have a seat at the table but do not touch anything further.");
                int Story1choice = 0;

                while (Story1choice < 1 || Story1choice > 4)
                {
                    Console.WriteLine("Please choose an option, choose between 1 and 4:");

                    string? input = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(input))
                    {
                        Console.WriteLine("Please enter a number not a space!");
                        continue;
                    }

                    if (!int.TryParse(input, out Story1choice))
                    {
                        Console.WriteLine("That's not valid! Please enter a whole number.");
                        continue;
                    }

                    if (Story1choice < 1 || Story1choice > 4)
                    {
                        Console.WriteLine("Please stop trying to break me! Please enter a number between 1 and 4.");
                    }
                }

                if (Story1choice == 1)
                {
                    Console.WriteLine("Ending 1.1 You ate all of the porridge! Wow you really were hungry! \n Right after you finished eating, the home owners came back! \n A daddy bear, mommy bear, and baby bear");
                    Console.WriteLine("Turns out you have eaten all of daddy bear's porridge! He is not impressed with you and gives you a thorough scolding! \n You are very embarrassed and should be! Who enters a stranger's home and eats their porridge? \n You return home feeling guilty.");
                }
                else if (Story1choice == 2)
                {
                    Console.WriteLine("You chose option 2. You eat the smallest bowl of porridge. It is delicious! \n Three bears enter the house while you are sitting there. Unfortunately for you, you ate baby bear's porridge! He is very specific about his porridge. \n The bears are very upset, their claws come out and you narrowly avoid becoming their next meal! You run all the way home and decide never to adventure again.");
                }
                else if (Story1choice == 3)
                {
                    Console.WriteLine("You chose option 3. You decide to further explore the house and come across a bedroom with three beds! \n You decide to have a nap and are awoken to the sound of bears coming home. They discover you and ask what you are doing. \n You counter asking why there are 3 beds. \n Turns out mommy and daddy bear are having marital issues. Yikes! You are now the bears marriage counsellor. \n Good luck with your new job!");
                }
                else if (Story1choice == 4)
                {
                    Console.WriteLine("You chose option 4. You have a seat at the table but do not touch anything further. You hear the door open. Three bears enter the house and are surprised to find you at their table but offer you some porridge. \n While everyone is eating you get to chatting with the bears. Mommy and Daddy bear are impressed with your respectfulness. They dedicde to adopt you! \n You're now a bear, I guess!");
                }
            }

            /// Story 2 Options

            else if (choice == 2)
            {
                Console.WriteLine("You chose option 2. You begin on the winding path. It is quite a peaceful trail, with the sound of birdsong in the air. In the distance you see three little homes and journey towards them. \n You notice that the homes are made of different material. The one directly in front of you is made of straw, the next of sticks, and the furthest one is made of bricks. \n What do you decide to do?");
                Console.WriteLine("1.You decide to approach the home closest to you knock on the door.It's not much of a knock considering it's straw but the door opens anyways \n 2. You walk ahead, ignoring the straw home, and approach the door of the next home \n 3.You walk a bit further wanting to stretch your legs.While walking you see a wolf outside of the straw house.Maybe he lives there ? \n 4.You don't want to visit anyone's house, let's just walk around a little and see what we find!");


                int Story2choice = 0;

                while (Story2choice < 1 || Story2choice > 4)
                {
                    Console.WriteLine("Please choose an option, choose between 1 and 4:");

                    string? input = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(input))
                    {
                        Console.WriteLine("Please enter a number not a space!");
                        continue;
                    }

                    if (!int.TryParse(input, out Story2choice))
                    {
                        Console.WriteLine("That's not valid! Please enter a whole number.");
                        continue;
                    }

                    if (Story2choice < 1 || Story2choice > 4)
                    {
                        Console.WriteLine("Please stop trying to break me! Please enter a number between 1 and 4.");
                    }
                }
                if (Story2choice == 1)
                {
                    Console.WriteLine("You chose option 1. A squeaky voice bids you enter. Inside is a little, speckled pig playing boardgames. \n He is so excited to see you and asks you to join his games. Before you can start your game, you hear a huff and puff and his house gets blown down!");

                    Console.WriteLine("You and the pig get eaten by the big bad wolf. Womp womp :( ");
                }
                else if (Story2choice == 2)
                {
                    Console.WriteLine("You chose option 2. You enter the stick house and are greeted by a short, pink pig. \n He is excited to have a guest and says he must bring his brother to join you for a chat! He lives just over in the straw house");
                    Console.WriteLine("You begin exiting the house and notice the straw house is being blow down by a wolf! Oh no! The pink pig squeals and runs to the rescue of his brother, while you decide to run in the opposite direction home! \n Coward!");
                }
                else if (Story2choice == 3)
                {
                    Console.WriteLine("You chose option 3. When you reach the brick house, you knock on the door and get invited in for tea by a black pig with a curly tail.");
                    Console.WriteLine("As you are enjoying your tea, there is a bang! bang! bang! on the door. The black pig opens it and in flee two other pigs. \n They say a wolf blew their houses down and is outside the door! Guess you are staying a little while longer...");
                }
                else if (Story2choice == 4)
                {
                    Console.WriteLine("You chose option 4. While you are walking you come across a wolf! You hesitantly greet him and ask what he is up to. \n He lets you know that he is oh so hungry and he is going to get some ham! Who can fault a guy! You are also quite hungry since you skipped breakfast so you ask to come with him");
                    Console.WriteLine("The wolf obliges you and you walk towards the straw house. You watch in confusion as the wolf blows the house down!\n He walks in and begins eating the live pig that is inside! \n You run away in horror. You are now an accessory to murder, you better change your name!");
                }
            }
            /// Story 3 Options
            else if (choice == 3)
            {
                Console.WriteLine("You chose option 3. This part of the forest is a little spooky, but you are brave! While walking you hear some whistling ahead.");
            }
            /// Story 4 Options
            else if (choice == 4)
            {
                Console.WriteLine("You chose option 4. Dang, eating sweets off the floor? I mean go off I guess! You follow the trail of candy, eating some while putting the rest in your pockets. The burst of sugar on your tongue fuels you to continue on.");
            }
            }
        }
    }