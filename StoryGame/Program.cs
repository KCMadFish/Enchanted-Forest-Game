using System.Runtime.ConstrainedExecution;
using System.Text;

namespace StoryGame;
internal class Program
{
    static bool[] completedEndings  = new bool[16];
    static void Main(string[] args)
    {
        /// INTRODUCTION TO GAME

        Console.WriteLine("Welcome to the Enchanted Forest!\n \n What is your name? ");
        var playerName = Console.ReadLine();

        /// code makes sure they can't leaave blank or enter a space for their name

        while (string.IsNullOrWhiteSpace(playerName))
        {
            Console.WriteLine("Please enter your name:");
            playerName = Console.ReadLine();
        }

        bool isPlaying = true;
        Console.WriteLine("Wow, what an interesting name! \n Behold the forest {0}!", playerName + "!");
        Console.WriteLine("You decided to start the day off with an adventure!");
        while (isPlaying)
        {
            if (AllEndingsComplete())
            {
                Console.WriteLine("Congratulations! You have completed all the endings! \n Please find another game to play!");
                Console.WriteLine("\n Press any key to exit the game."); /// added this because when I got to the end of the game it just completely exited before I could read the end of the story
                Console.ReadKey();
                break;
            }

            Console.WriteLine("You are standing on the edge of the forest. Many choices await you.");
            /// choices begin

            Console.WriteLine("Choose a path");
            Console.WriteLine("1. You smell a delicious scent. In your haste for adventure you forgot to have breakfast (Goldilocks)" + PathStatus(1));
            Console.WriteLine("2. You notice a small, winding path to the left. A path is good! You can meet new people. (3Pigs)" + PathStatus(2));
            Console.WriteLine("3. You look straight ahead, there is no path, just tall trees. What's a little extra adventure? (RedHood)" + PathStatus(3));
            Console.WriteLine("4. You look down. What's this? There's candy at your feet! Who says no to free candy?! (HnG)" + PathStatus(4));

            Console.WriteLine("Which option do you choose?");


            int choice = 0;

            while (choice < 1 || choice > 4 || IsPathComplete(choice))
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
                else if (IsPathComplete(choice))
                {
                    Console.WriteLine("You have already completed this path! Please choose another path.");
                    choice = 0; // Reset choice to force the loop to continue
                }
            }

            /// OPTIONS

            if (choice == 1)
            {
                PlayGoldilocks(playerName);
            }
            else if (choice == 2)
            {
                Play3Pigs(playerName);
            }
            else if (choice == 3)
            {
                PlayRedHood(playerName);
            }
            else if (choice == 4)
            {
                PlayHnG(playerName);
            }
            if (AllEndingsComplete())
            {
                Console.WriteLine("\nCongratulations! You have completed all the endings! \n Please find another game to play!");
                Console.WriteLine("\n Press any key to exit the game."); /// added this because when I got to the end of the game it just completely exited before I could read the end of the story
                Console.ReadKey();
                break;  

            }
            Console.WriteLine("\n What do you want to do? \n 1. Play another story \n 2. Exit");
            int replayChoice = 0;
            while (replayChoice < 1 || replayChoice > 2)
            {
                Console.WriteLine("Please choose an option, choose between 1 and 2:");
                string? input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Please enter a number not a space!");
                    continue;
                }
                if (!int.TryParse(input, out replayChoice))
                {
                    Console.WriteLine("That's not valid! Please enter a whole number.");
                    continue;
                }
                if (replayChoice < 1 || replayChoice > 2)
                {
                    Console.WriteLine("Please stop trying to break me! Please enter a number between 1 and 2.");
                }
            }
            if (replayChoice == 2)
            {
                isPlaying = false;

                Console.WriteLine("Thank you for having an adventure! Good luck on your next one, goodbye!");
            }
        }
    }
       static void CompleteEnding(int story, int ending)
            {
                int index = (story - 1) * 4 + (ending - 1);

                completedEndings[index] = true;
            }

            static bool EndingIsComplete(int story, int ending)
            {
                int index = (story - 1) * 4 + (ending - 1);

                return completedEndings[index];
            }

            static bool IsPathComplete(int story)
            {
                for (int ending = 1; ending <= 4; ending++)
                {
                    if (!EndingIsComplete(story, ending))
                    {
                        return false;
                    }
                }

                return true;
            }

            static bool AllEndingsComplete()
            {
                for (int i = 0; i < 16; i++)
                {
                    if (!completedEndings[i])
                    {
                        return false;
                    }
                }

                return true;
            }

            static string PathStatus(int story)
            {
                if (IsPathComplete(story))
                {
                    return "(Completed)";
                }

                return "";
                /// this return "" is for the path status to show up in the main menu if the path is completed, if it is not completed, it will return nothing and the path will show up as normal
            }

    

    private static string EndingStatus(int story, int ending)
    {
        if (EndingIsComplete(story, ending))
        {
            return "(Completed - Unavailable)";
        }

        return "";
    }

    ///STORY 1 GOLDILOCKS

    static void PlayGoldilocks(string playerName)
            {
                Console.WriteLine("\n You chose option 1 " + playerName + ". \n Guess your hunger won! You follow the scent towards a lovely, little cottage. \n You notice its homely vibe with yellow painted walls and a great big oak door.");
                Console.WriteLine("You knock on the door and receive no answer, but your knocking opens the door! \n Since you're super nosy, you decide to enter the home. \n Inside you find a kitchen with a wooden table in the middle. On the table are delightful bowls of porridge that make your stomach rumble.");
                Console.WriteLine("\n What do you decide to do?");

                Console.WriteLine(" \n 1.1. Have a seat at the table and start eating the biggest bowl of porridge. What? You're super hungry!" + EndingStatus(1, 1));

                Console.WriteLine("1.2. Decide you are very hungry but you sit down and eat the smallest bowl of porridge,surely no one will miss it?" + EndingStatus(1, 2));

                Console.WriteLine("1.3. Your curiosity wins over your hunger. You decide to explore the house further." + EndingStatus(1, 3));

                Console.WriteLine("1.4. You think you've intruded enough and want to meet the owners of the cottage. You have a seat at the table but do not touch anything further.\n " + EndingStatus(1, 4));
                
                int Story1choice = 0;

                while (Story1choice < 1 || Story1choice > 4 || EndingIsComplete(1, Story1choice))
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
                        continue;
                    }
                    if (EndingIsComplete(1, Story1choice))
                    {
                        Console.WriteLine("You have already completed this ending! Please choose another option.");
                        Story1choice = 0; 
                    }

                }

                if (Story1choice == 1)
                {
                    Console.WriteLine("\n Ending 1.1 You ate all of the porridge! Wow you really were hungry! \n Right after you finished eating, the home owners came back! \n A daddy bear, mommy bear, and baby bear");
                    Console.WriteLine("Turns out you have eaten all of daddy bear's porridge! He is not impressed with you and gives you a thorough scolding! \n You are very embarrassed and should be! Who enters a stranger's home and eats their porridge? \n You return home feeling guilty.");
                    CompleteEnding(1, 1);
                }
                else if (Story1choice == 2)
                {
                    Console.WriteLine("\n Ending 1.2 You eat the smallest bowl of porridge. It is delicious! \n Three bears enter the house while you are sitting there. Unfortunately for you, you ate baby bear's porridge! He is very specific about his porridge. \n The bears are very upset, their claws come out and you narrowly avoid becoming their next meal! You run all the way home and decide never to adventure again.");
                    CompleteEnding(1, 2);
                }
                else if (Story1choice == 3)
                {
                    Console.WriteLine("\n Ending 1.3 You decide to further explore the house and come across a bedroom with three beds! \n You decide to have a nap and are awoken to the sound of bears coming home. They discover you and ask what you are doing. \n You counter asking why there are 3 beds. \n Turns out mommy and daddy bear are having marital issues. Yikes!They introduce themselves and explain their situation");
                    Console.WriteLine("\n What is Mommy Bear's name?");
                    string? mBearName = Console.ReadLine();

                    while (string.IsNullOrWhiteSpace(mBearName))
                    {
                        Console.WriteLine("\n Please enter Mommy Bear's name:");
                        mBearName = Console.ReadLine();
                    }

                    Console.WriteLine("\n And what is Daddy Bear's name?");
                    string? dBearName = Console.ReadLine();

                    while (string.IsNullOrWhiteSpace(dBearName))
                    {
                        Console.WriteLine("\n Please enter Daddy Bear's name:");
                        dBearName = Console.ReadLine();
                    }
                    Console.WriteLine("\n You are now " + mBearName + " and " + dBearName + "'s marriage counsellor. \n Good luck with your new job!");
                    CompleteEnding(1, 3);
                }
                else if (Story1choice == 4)
                {
                    Console.WriteLine("\n Ending 1.4 You have a seat at the table but do not touch anything further. You hear the door open. Three bears enter the house and are surprised to find you at their table but offer you some porridge. \n While everyone is eating you get to chatting with the bears. Mommy and Daddy bear are impressed with your respectfulness. They decide to adopt you! \n You're now a bear, I guess!");
                    CompleteEnding(1, 4);
                }
            }


            /// Story 2 -  3 LITTLE PIGS


            static void Play3Pigs(string playerName)
            {
                Console.WriteLine("\n You chose option 2 " + playerName + "! You begin on the winding path. It is quite a peaceful trail, with the sound of birdsong in the air. In the distance you see three little homes and journey towards them. \n You notice that the homes are made of different material. The one directly in front of you is made of straw, the next of sticks, and the furthest one is made of bricks. \n What do you decide to do?");
                Console.WriteLine("\n 2.1.You decide to approach the home closest to you knock on the door.It's not much of a knock considering it's straw but the door opens anyways " + EndingStatus(2, 1));
                Console.WriteLine("2.2. You walk ahead, ignoring the straw home, and approach the door of the next home" + EndingStatus(2, 2));
                Console.WriteLine("2.3.You walk a bit further wanting to stretch your legs.While walking you see a wolf outside of the straw house.Maybe he lives there?" + EndingStatus(2, 3));
                Console.WriteLine("2.4.You don't want to visit anyone's house, let's just walk around a little and see what we find! \n " + EndingStatus(2, 4));

        
               int Story2choice = 0;

                while (Story2choice < 1 || Story2choice > 4 || EndingIsComplete(2, Story2choice))
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
                    Console.WriteLine("\n Ending 2.1 A squeaky voice bids you enter. Inside is a little, speckled pig playing boardgames. \n He is so excited to see you and asks you to join his games. Before you can start your game, you hear a huff and puff and his house gets blown down!");

                    Console.WriteLine("You and the pig get eaten by the big bad wolf. Womp womp :( "); 
                    CompleteEnding(2, 1);
        }
                else if (Story2choice == 2)
                {
                    Console.WriteLine("\nEnding 2.2 You enter the stick house and are greeted by a short, pink pig. \n He is excited to have a guest and says he must bring his brother to join you for a chat! He lives just over in the straw house");
                    Console.WriteLine("You begin exiting the house and notice the straw house is being blow down by a wolf! Oh no! The pink pig squeals and runs to the rescue of his brother, while you decide to run in the opposite direction home! \n Coward!");
                    CompleteEnding(2, 2);
        }
                else if (Story2choice == 3)
                {
                    Console.WriteLine("\n Ending 2.3 When you reach the brick house, you knock on the door and get invited in for tea by a black pig with a curly tail.");
                    Console.WriteLine("As you are enjoying your tea, there is a bang! bang! bang! on the door. The black pig opens it and in flee two other pigs. \n They say a wolf blew their houses down and is outside the door! Guess you are staying a little while longer...");
                    CompleteEnding(2, 3);
                }
                else if (Story2choice == 4)
                {
                    Console.WriteLine("\n Ending 2.4 While you are walking you come across a wolf! You hesitantly greet him and ask what he is up to. \n He lets you know that he is oh so hungry and he is going to get some ham! Who can fault a guy! You are also quite hungry since you skipped breakfast so you ask to come with him");
                    Console.WriteLine("The wolf obliges you and you walk towards the straw house. You watch in confusion as the wolf blows the house down!\n He walks in and begins eating the live pig that is inside! \n You run away in horror. You are now an accessory to murder, you better change your name! \n What will your new name be?");
                    string? newName = Console.ReadLine();
                    while (string.IsNullOrWhiteSpace(newName))
                    {
                        Console.WriteLine("Do you want to go to prison?? Enter a new name!");
                        newName = Console.ReadLine();
                    }
                    Console.WriteLine("\n You are now known as " + newName + ". Hopefully, the cops never find you.");
                    CompleteEnding(2, 4);
        }
            }

            /// STORY 3 RED RIDING HOOD

            static void PlayRedHood(string playerName)
            {
                Console.WriteLine("\n You chose option 3. This part of the forest is a little spooky, but you are brave! While walking you hear some whistling ahead. You decide to follow it and come across a girl in a red hood. She says she is off to her grandmother's house. You notice she keeps looking over her shoulder.");
                Console.WriteLine("\n What do you choose to do?");
                Console.WriteLine("\n 3.1.You offer to walk with her to her grandmother's house"  + EndingStatus(3, 1));
                Console.WriteLine("3.2. You ask her why she keeps looking over her shoulder" + EndingStatus(3, 2));
                Console.WriteLine("3.3. You decide to part ways with her." + EndingStatus(3, 3));
                Console.WriteLine("3.4. You decide to look around and try to spot what she is looking for." + EndingStatus(3, 4));

                int Story3choice = 0;

                while (Story3choice < 1 || Story3choice > 4 || EndingIsComplete(3, Story3choice))
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
                    Console.WriteLine("\n Ending 3.1 You walk with her to her grandmother's house. Once you're there, you sit down and have a nice cup of tea. Her grandmother has strangely long ears and a snout, but who are you to judge?");

                    Console.WriteLine("You go home and see her and her grandmother on the news that night. They were eaten by a wolf!");
                    CompleteEnding(3, 1);
                }
                else if (Story3choice == 2)
                {
                    Console.WriteLine("\n Ending 3.2 She explains that she is waiting on a friend. You decide to sit down and wait with her, and she shares some muffins from her basket.");

                    Console.WriteLine("Just when you decide it's time to get up and go, her friend joins her! He apologises for his lateness. He was dealing with his cousin, who was trying to blow a house down? And eat its inhabitants!?!? \n You decide you better be on your way before you encounter his cousin!");
                    Console.WriteLine("\n Where will you go to hide?");
                    string? newLocation = Console.ReadLine();

                    while (string.IsNullOrWhiteSpace(newLocation))
                    {
                        Console.WriteLine("You need somewhere to hide! Where will you go?");
                        newLocation = Console.ReadLine();
                    }
                    Console.WriteLine("You are now hiding in " + newLocation + ". Hopefully, you can avoid the cousin!");
                    CompleteEnding(3, 2);
                }
                else if (Story3choice == 3)
                {
                    Console.WriteLine("\n Ending 3.3 You part ways with her. As you explore by yourself, you come across a lovely, little home. Inside is an old lady. This must be her grandmother! She invites you in for tea but says she has no grandchildren. However, there have been reports of a little girl in a red hood who is there one second and gone the next. Spooky!");
                    CompleteEnding(3, 3);
                }
                else if (Story3choice == 4)
                {
                    Console.WriteLine("\n Ending 3.4 You turn your head and scan the forest around you, determined to find out what she is looking for. As your eyes skim the forest, you see another set peeking out at you. \n AH! \n It's a wolf!");

                    Console.WriteLine("You scream, she screams, the wolf screams. \n The wolf gives you an incredulous look and continues on his way. \n Wow, dramatic much?");
                    CompleteEnding(3, 4);
                }
            }


            /// STORY 4 HANSEL AND GRETEL

            static void PlayHnG(string playerName)
            {
                Console.WriteLine("\n You chose option 4. Dang, eating sweets off the floor? I mean go off I guess! You follow the trail of candy, eating some while putting the rest in your pockets. \n The burst of sugar on your tongue urges you forward. You must see how long this path really is.");
                Console.WriteLine("You continue following the trail, stuffing your pockets until they are bursting at the seams. Towards the end of the trail you come across an entire house of candy! \n What do you choose to do?");
                Console.WriteLine("\n 4.1. A house of candy! You must have a taste! You begin gnawing on a gingerbread windowsill" + EndingStatus(4, 1));
                Console.WriteLine("4.2. Wow! You marvel at the unique house but decide you've had enough sugar for today. " + EndingStatus(4, 2));
                Console.WriteLine("4.3. You hear screams coming from inside the house. What is that? " + EndingStatus(4, 3));
                Console.WriteLine("4.4. You decide to knock on the door" + EndingStatus(4, 4));
                int Story4choice = 0;

                while (Story4choice < 1 || Story4choice > 4 || EndingIsComplete(4, Story4choice))
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
                    Console.WriteLine("\n Ending 4.1 As you are gnawing on the windowsill (I am trying really hard not to judge you rn), a witch pops her head outside the door! From inside comes a pleasing aroma. The witch smiles and offers you some stew. ");

                    Console.WriteLine("Mmm, something savoury does sound great after all the candy. You go inside to enjoy a nice, hearty stew. \n While you are slurping up the last bit you notice something at the bottom of the bowl... \n A human toe?!?!? \n Enjoy the knowledge that you are now a cannibal");
                    CompleteEnding(4, 1);
        }
                else if (Story4choice == 2)
                {
                    Console.WriteLine("\n Ending 4.2 You chose option 2. You head home with pockets full of candy. Today was a good day for you!");
                    CompleteEnding(4, 2);
                }
                else if (Story4choice == 3)
                {
                    Console.WriteLine("\n Ending 4.3 You chose option 3. OMG! You burst into the house and see a witch holding two children hostage! You start fighting her off and knock her into a huge stew pot!");
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
                    Console.WriteLine("\n Oh dear! " + Child1Name + " and " + Child2Name + " have no other way home. Guess you now have to look after them!");
                    Console.WriteLine("\n Congratulations on becoming a parent!");
                    CompleteEnding(4, 3);
        }
                else if (Story4choice == 4)
                {
                    Console.WriteLine("\n Ending 4.4. Once you have finished knocking, a witch opens the door! She greets you and bids you enter. Once inside you notice a big pot in the middle of the kitchen! You ask her what she's making and she says stew but she is missing an ingredient");
                    Console.WriteLine("Before you can think further, you are being pushed into the pot! \n You are now a stew ingredient. \n At least all the candy in your pockets is going to give the stew a nice taste");
                    CompleteEnding(4, 4);
        }
            }

        }

