using System.Runtime.ConstrainedExecution;
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
                Console.WriteLine("What do you decide to do? You're actually really hungry! \n 1.1. Have a seat at the table and start eating the biggest bowl of porridge. What? You're super hungry \n 1.2. Decide you are very hungry but you sit down and eat the smallest bowl of porridge,surely no one will miss it? \n 1.3. Your curiosity wins over your hunger. You decide to explore the house further \n 1.4. You think you've intruded enough and want to meet the owners of the cottage. You have a seat at the table but do not touch anything further.");
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
                    Console.WriteLine("Ending 1.2 You eat the smallest bowl of porridge. It is delicious! \n Three bears enter the house while you are sitting there. Unfortunately for you, you ate baby bear's porridge! He is very specific about his porridge. \n The bears are very upset, their claws come out and you narrowly avoid becoming their next meal! You run all the way home and decide never to adventure again.");
                }
                else if (Story1choice == 3)
                {
                    Console.WriteLine("Ending 1.3 You decide to further explore the house and come across a bedroom with three beds! \n You decide to have a nap and are awoken to the sound of bears coming home. They discover you and ask what you are doing. \n You counter asking why there are 3 beds. \n Turns out mommy and daddy bear are having marital issues. Yikes!They introduce themselves and explain their situation");
                       Console.WriteLine("What is Mommy Bear's name?");
                    string? mBearName = Console.ReadLine();

                    while (string.IsNullOrWhiteSpace(mBearName))
                    {
                        Console.WriteLine("Please enter Mommy Bear's name:");
                        mBearName = Console.ReadLine();
                    }

                    Console.WriteLine("And what is Daddy Bear's name?");
                    string? dBearName = Console.ReadLine();

                    while (string.IsNullOrWhiteSpace(dBearName))
                    {
                        Console.WriteLine("Please enter Daddy Bear's name:");
                        dBearName = Console.ReadLine();
                    }
                    Console.WriteLine("You are now " + mBearName + " and " + dBearName + "'s marriage counsellor. \n Good luck with your new job!");
                }
                else if (Story1choice == 4)
                {
                    Console.WriteLine("Ending 1.4 You have a seat at the table but do not touch anything further. You hear the door open. Three bears enter the house and are surprised to find you at their table but offer you some porridge. \n While everyone is eating you get to chatting with the bears. Mommy and Daddy bear are impressed with your respectfulness. They decide to adopt you! \n You're now a bear, I guess!");
                }
            }

            /// Story 2 Options

            else if (choice == 2)
            {
                Console.WriteLine("You chose option 2. You begin on the winding path. It is quite a peaceful trail, with the sound of birdsong in the air. In the distance you see three little homes and journey towards them. \n You notice that the homes are made of different material. The one directly in front of you is made of straw, the next of sticks, and the furthest one is made of bricks. \n What do you decide to do?");
                Console.WriteLine("2.1.You decide to approach the home closest to you knock on the door.It's not much of a knock considering it's straw but the door opens anyways \n 2.2. You walk ahead, ignoring the straw home, and approach the door of the next home \n 2.3.You walk a bit further wanting to stretch your legs.While walking you see a wolf outside of the straw house.Maybe he lives there ? \n 2.4.You don't want to visit anyone's house, let's just walk around a little and see what we find!");


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
                    Console.WriteLine("Ending 2.1 A squeaky voice bids you enter. Inside is a little, speckled pig playing boardgames. \n He is so excited to see you and asks you to join his games. Before you can start your game, you hear a huff and puff and his house gets blown down!");

                    Console.WriteLine("You and the pig get eaten by the big bad wolf. Womp womp :( ");
                }
                else if (Story2choice == 2)
                {
                    Console.WriteLine("Ending 2.2 You enter the stick house and are greeted by a short, pink pig. \n He is excited to have a guest and says he must bring his brother to join you for a chat! He lives just over in the straw house");
                    Console.WriteLine("You begin exiting the house and notice the straw house is being blow down by a wolf! Oh no! The pink pig squeals and runs to the rescue of his brother, while you decide to run in the opposite direction home! \n Coward!");
                }
                else if (Story2choice == 3)
                {
                    Console.WriteLine("Ending 2.3 When you reach the brick house, you knock on the door and get invited in for tea by a black pig with a curly tail.");
                    Console.WriteLine("As you are enjoying your tea, there is a bang! bang! bang! on the door. The black pig opens it and in flee two other pigs. \n They say a wolf blew their houses down and is outside the door! Guess you are staying a little while longer...");
                }
                else if (Story2choice == 4)
                {
                    Console.WriteLine("Ending 2.4 While you are walking you come across a wolf! You hesitantly greet him and ask what he is up to. \n He lets you know that he is oh so hungry and he is going to get some ham! Who can fault a guy! You are also quite hungry since you skipped breakfast so you ask to come with him");
                    Console.WriteLine("The wolf obliges you and you walk towards the straw house. You watch in confusion as the wolf blows the house down!\n He walks in and begins eating the live pig that is inside! \n You run away in horror. You are now an accessory to murder, you better change your name! \n What will your new name be?");
                    string? newName = Console.ReadLine();
                    while (string.IsNullOrWhiteSpace(newName))
                    {
                        Console.WriteLine("Do you want to go to prison?? Enter a new name!");
                        newName = Console.ReadLine();
                    }
                    Console.WriteLine("You are now known as " + newName + ". Hopefully, the cops never find you.");
                }
            }
            /// Story 3 Options
            else if (choice == 3)
            {
                Console.WriteLine("You chose option 3. This part of the forest is a little spooky, but you are brave! While walking you hear some whistling ahead. You decide to follow it and come across a girl in a red hood. She says she is off to her grandmother's house. You notice she keeps looking over her shoulder.");
                Console.WriteLine("What do you choose to do? \n 3.1.You offer to walk with her to her grandmother's house \n 3.2. You ask her why she keeps looking over her shoulder \n 3.3. You decide to part ways with her. \n 3.4. You decide to look around and try to spot what she is looking for.");

                int Story3choice = 0;

                while (Story3choice < 1 || Story3choice > 4)
                {
                    Console.WriteLine("Please choose an option, choose between 1 and 4:");

                    string? input = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(input))
                    {
                        Console.WriteLine("Please enter a number not a space!");
                        continue;
                    }

                    if (!int.TryParse(input, out Story3choice))
                    {
                        Console.WriteLine("That's not valid! Please enter a whole number.");
                        continue;
                    }

                    if (Story3choice < 1 || Story3choice > 4)
                    {
                        Console.WriteLine("Please stop trying to break me! Please enter a number between 1 and 4.");
                    }
                }

                if (Story3choice == 1)
                {
                    Console.WriteLine("Ending 3.1 You walk with her to her grandmother's house. Once you're there, you sit down and have a nice cup of tea. Her grandmother has strangely long ears and a snout, but who are you to judge?");

                    Console.WriteLine("You go home and see her and her grandmother on the news that night. They were eaten by a wolf!");
                }
                else if (Story3choice == 2)
                {
                    Console.WriteLine("Ending 3.2 She explains that she is waiting on a friend. You decide to sit down and wait with her, and she shares some muffins from her basket.");

                    Console.WriteLine("Just when you decide it's time to get up and go, her friend joins her! He apologises for his lateness. He was dealing with his cousin, who was trying to blow a house down? And eat its inhabitants!?!? \n You decide you better be on your way before you encounter his cousin!");
                    Console.WriteLine("Where will you go to hide?");
                    string? newLocation = Console.ReadLine();

                    while (string.IsNullOrWhiteSpace(newLocation))
                    {
                        Console.WriteLine("You need somewhere to hide! Where will you go?");
                        newLocation = Console.ReadLine();
                    }
                    Console.WriteLine("You are now hiding in " + newLocation + ". Hopefully, you can avoid the cousin!");
                }
                else if (Story3choice == 3)
                {
                    Console.WriteLine("Ending 3.3 You part ways with her. As you explore by yourself, you come across a lovely, little home. Inside is an old lady. This must be her grandmother! She invites you in for tea but says she has no grandchildren. However, there have been reports of a little girl in a red hood who is there one second and gone the next. Spooky!");
                }
                else if (Story3choice == 4)
                {
                    Console.WriteLine("Ending 3.4 You turn your head and scan the forest around you, determined to find out what she is looking for. As your eyes skim the forest, you see another set peeking out at you. \n AH! \n It's a wolf!");

                    Console.WriteLine("You scream, she screams, the wolf screams. \n The wolf gives you an incredulous look and continues on his way. \n Wow, dramatic much?");
                }
            }

            /// Story 4 Options
            else if (choice == 4)
            {
                Console.WriteLine("You chose option 4. Dang, eating sweets off the floor? I mean go off I guess! You follow the trail of candy, eating some while putting the rest in your pockets. \n The burst of sugar on your tongue urges you forward. You must see how long this path really is.");
                Console.WriteLine("You continue following the trail, stuffing your pockets until they are bursting at the seams. Towards the end of the trail you come across an entire house of candy! \n What do you choose to do?");
                Console.WriteLine("4.1. A house of candy! You must have a taste! You begin gnawing on a gingerbread windowsill. \n 4.2. Wow! You marvel at the unique house but decide you've had enough sugar for today. \n 4.3. You hear screams coming from inside the house. What is that? \n 4.4. You decide to knock on the door");
                int Story4choice = 0;

                while (Story4choice < 1 || Story4choice > 4)
                {
                    Console.WriteLine("Please choose an option, choose between 1 and 4:");

                    string? input = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(input))
                    {
                        Console.WriteLine("Please enter a number not a space!");
                        continue;
                    }

                    if (!int.TryParse(input, out Story4choice))
                    {
                        Console.WriteLine("That's not valid! Please enter a whole number.");
                        continue;
                    }

                    if (Story4choice < 1 || Story4choice > 4)
                    {
                        Console.WriteLine("Please stop trying to break me! Please enter a number between 1 and 4.");
                    }
                }
                if (Story4choice == 1)
                {
                    Console.WriteLine("Ending 4.1 As you are gnawing on the windowsill (I am trying really hard not to judge you rn), a witch pops her head outside the door! From inside comes a pleasing aroma. The witch smiles and offers you some stew. ");

                    Console.WriteLine("Mmm, something savoury does sound great after all the candy. You go inside to enjoy a nice, hearty stew. \n While you are slurping up the last bit you notice something at the bottom of the bowl... \n A human toe?!?!? \n Enjoy the knowledge that you are now a cannibal");
                }
                else if (Story4choice == 2)
                {
                    Console.WriteLine("Ending 4.2 You chose option 2. You head home with pockets full of candy. Today was a good day for you!");
                }
                else if (Story4choice == 3)
                {
                    Console.WriteLine("Ending 4.3 You chose option 3. OMG! You burst into the house and see a witch holding two children hostage! You start fighting her off and knock her into a huge stew pot!");
                    Console.WriteLine("The children thank you profusely and introduce themselves. What is the first child's name?");
                    string? Child1Name = Console.ReadLine();

                    while (string.IsNullOrWhiteSpace(Child1Name))
                    {
                        Console.WriteLine("Please enter the first child's name:");
                        Child1Name = Console.ReadLine();
                    }

                    Console.WriteLine("And what is the second child's name?");
                    string? Child2Name = Console.ReadLine();

                    while (string.IsNullOrWhiteSpace(Child2Name))
                    {
                        Console.WriteLine("Please enter the second child's name:");
                        Child2Name = Console.ReadLine();
                    }
                    Console.WriteLine("They mention they will follow their candy trail home. \n Wait didn't you eat that?");
                    Console.WriteLine("Oh dear! " + Child1Name + " and " + Child2Name + " have no other way home. Guess you now have to look after them!");
                    Console.WriteLine("Congratulations on becoming a parent!");
                }
                else if (Story4choice == 4)
                {
                    Console.WriteLine("Ending 4.4. Once you have finished knocking, a witch opens the door! She greets you and bids you enter. Once inside you notice a big pot in the middle of the kitchen! You ask her what she's making and she says stew but she is missing an ingredient");
                    Console.WriteLine("Before you can think further, you are being pushed into the pot! \n You are now a stew ingredient. \n At least all the candy in your pockets is going to give the stew a nice taste");
                }
            }
        }
    }
}

