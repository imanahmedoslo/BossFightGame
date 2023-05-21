using BossFightGame;
using System.Linq.Expressions;
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
int randomStrength = new Random().Next(0, 31);
var Hero = new GameCharacter(170, 20, 40,"hero", true);
var Boss = new GameCharacter(400, 10, "boss", false);
List<GameCharacter> Players = new List<GameCharacter>();
Players.Add(Hero);
Players.Add(Boss);
play();
void play()
{
    int startStaminaPlayerOne = Players[0].Stamina;
    int startStaminaPlayerTwo= Players[1].Stamina;
    
    Console.WriteLine("welcome to Bossfight! You keep watching until one character loses all its health.");
    while (Players[0].Health > 0 && Players[1].Health > 0)
    {
       // var CurrentPlayer = Players[0].Name;
        if (Players[0].IsMyTurn)
       {
            Players[0].Fight(Players[1], startStaminaPlayerOne);
            Console.WriteLine($"{Players[1].Name} is now playing");
            
        } else if (Players[1].IsMyTurn)
        {
            Players[1].randomizeStrength();
            Players[1].Fight(Players[0], startStaminaPlayerTwo);
         //   CurrentPlayer = Players[0].Name;
            Console.WriteLine($"{Players[0].Name} is now playing");
        }
        
            
               
               

            
               
                


        
           
       // for (int i = 0; i < 10; i++)
       // {
       // randomStrength = new Random().Next(0, 31);
        //Console.WriteLine(Boss.Strength);
       
       // }


    }
     if (Players[0].Health <= 0 || Players[1].Health <= 0)
    {
        Console.WriteLine($"Game over, {Players[0].Name} is at{Players[0].Health} health, and {Players[1].Name} is at {Players[1].Health} health.");
    }
}

