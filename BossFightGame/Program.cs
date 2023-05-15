using BossFightGame;
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
var randomStrength = new Random().Next(0 - 31);
var Hero = new GameCharacter(100, 20, 40);
var Boss = new GameCharacter(400, randomStrength, 10);
play();
void play()
{
    var CurrentPlayer = "hero";
    Console.WriteLine("welcome to Bossfight! You can keep playing until one character loses all its health.");
    while (Hero.Health != 0 || Boss.Health != 0)
    {


    }
}

