using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDex
{
    public class Ekans : Pokemon
    {
        public Ekans() 
        {
            this.Type = PokemonType.poison;
            this.Height = 2.0;
            this.Weight = 6.9;
            this.HP = 35;
            this.Attack = 60;
            this.Defense = 44;
            this.SpecialAttack = 40;
            this.SpecialDefense = 54;
            this.Speed = 55;
            this.Total = 288;
            this.Name = "Ekans";
            this.image =
                Resource1.ResourceManager.GetObject("Ekans") as byte[] ?? Array.Empty<byte>();
        }
    }
}
