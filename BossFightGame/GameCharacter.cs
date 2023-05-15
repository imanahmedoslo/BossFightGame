using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossFightGame
{
    public class GameCharacter
    {
        public int Health { get; set; }
        public int Strength { get; set; }
        public int Stamina { get; set; }

        public GameCharacter(int health, int strength, int stamina) { 
            this.Health = health;   
            this.Strength = strength;
            this.Stamina = stamina;
        }
    }
}
