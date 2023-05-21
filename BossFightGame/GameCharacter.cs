using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossFightGame
{
    public class GameCharacter
    {
        public int Health { get; private set; }
        public int Strength { get;private set; }
        public int Stamina { get; private set; }
       public string Name { get; private set; }
        public bool IsMyTurn { get; private set; }

        public GameCharacter(int health, int strength, int stamina, string name, bool isMyTurn) { 
            this.Health = health;   
            this.Strength = strength;
            this.Stamina = stamina;
            this.Name = name;
            this.IsMyTurn = isMyTurn;
        }
        public GameCharacter(int health, int stamina, string name, bool isMyTurn) { 
        
            this.Health = health;
            this.Stamina = stamina;
            this.Name = name;
            randomizeStrength();
            this.IsMyTurn = isMyTurn;
        }
        public void Fight(GameCharacter opponent, int startStamina)
        {
            if (this.Stamina == 0)
            {
                Recharge(startStamina);
                this.IsMyTurn = false;
                opponent.Changetrun();
            }
            else {
                opponent.changeHealth(this);
                this.Stamina -= 10;
                this.IsMyTurn = false;
                opponent.Changetrun();
               // Console.WriteLine($"{this.Name} attacked");
            };
        }
        public void Recharge(int startStamina)
        {
            this.Stamina = startStamina;
            Console.WriteLine($"{this.Name} was too tired, this round is used for recharge. {this.Name} stamina is now at {startStamina}");
        }

        public void changeHealth(GameCharacter opponent)
        {
            this.Health = this.Health- opponent.Strength;
            Console.WriteLine($"{this.Name} lost {opponent.Strength}  and has now {this.Health} in health");

        }

        public int randomizeStrength()
        {
            return  this.Strength=new Random().Next(0, 31);
        }
        public void Changetrun()
        {
            this.IsMyTurn = true;
        }
    }

}
