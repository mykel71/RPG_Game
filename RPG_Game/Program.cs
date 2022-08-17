using RPG_Game;


//Create and store a random class.
Random random = new Random();


//Output stating that we want the player's name
Console.WriteLine("What is your name?");

//Create a player and store the properties.
Player player = new Player()
{
    Name = Console.ReadLine()
};

//Let the player know his name
Console.WriteLine("Thank you for Entering your name, " + player.Name + ".\n");

//Create a variable to track the first enemy.
Enemy firstEnemy = new Enemy("Giant Enemy Crab");


//Perfome the batle loop
GameLoop(firstEnemy, random, player, 5, 15);


// Check if the player is dead. 
if (!player.IsDead)
{
    //Create a new Boss Character
    Boss boss = new Boss();

    GameLoop(boss, random, player, 50, 20);

    if (!player.IsDead)
    {
        Console.WriteLine("Congratulations!!! " + player.Name + ", You have defeated all the enemies and saved the kingdom. But sadly, the Princess is in another Castle....!");
    }
    else
    {
        GameOver();
    }
}
else
{
    GameOver();
}

static void GameOver()
{
    //The game over
    Console.WriteLine("GAME OVER!");
}



static void GameLoop(Enemy enemy, Random random, Player player, int max_attack_power, int max_player_attack_power)
{
    //print out about the enemy
    Console.WriteLine(player.Name + ", You have encountered a " + enemy.Name + "!");

    //While the firstEnemy and player are not dead, repeat the playable cycle. 
    while (!enemy.IsDead && player.IsDead)
    {
        //Show Options
        Console.WriteLine(" What would you like to do? \n\n1.Single Attack \n2.Three Strike Attack \n3.Defend \n4.Heal\n\n");
        //Store the player action.
        string playerAction = Console.ReadLine();


        //Check which action the player took.
        switch (playerAction)
        {
            case "1":
                //write out what the player choose.
                Console.WriteLine("You choose to single attack the " + enemy.Name + "!");
                //Apply attack damage to the enemy
                enemy.GetsHit(random.Next(1, max_player_attack_power));
                break;
            case "2":
                Console.WriteLine("You choose to three Strike Attack the " + enemy.Name + "!");

                //loop 3 times to perform multi attack
                for (int i = 0; i < 3; i++)
                {
                    enemy.GetsHit(random.Next(1, max_player_attack_power));

                    if (enemy.IsDead)
                    {
                        break;
                    }
                }
                //The Code here now run after the loop
                break;
            case "3":
                Console.WriteLine("You choose to Defend!");
                //Set the player is guarding
                player.IsGuarding = true;
                break;
            case "4":
                Console.WriteLine("You choose to Heal!");

                //Heal the player
                player.Heal(random.Next(1, 15));
                break;
            default:
                Console.WriteLine("Invalid Action " + player.Name + "!");
                break;
        }

        //make sure the enemy is not dead
        if (!enemy.IsDead)
        {
            //Have the enemy attack the player
            player.GetsHit(random.Next(1, max_attack_power));
        }


    }
}



