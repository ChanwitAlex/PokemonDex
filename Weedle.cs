using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDex
{
    public class Weedle : Pokemon
    {
        public Weedle() 
        {
            this.Type = PokemonType.poison;
            this.Height = 1.0;
            this.Weight = 3.2;
            this.HP = 40;
            this.Attack = 35;
            this.Defense = 30;
            this.SpecialAttack = 20;
            this.SpecialDefense = 20;
            this.Speed = 50;
            this.Total = 195;
            this.Name = "Weedle";
            this.image =
                Resource1.ResourceManager.GetObject("Weedle") as byte[] ?? Array.Empty<byte>();
        }
    }
}
