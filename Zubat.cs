using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDex
{
    public class Zubat : Pokemon
    {
        public Zubat() 
        {
            this.Type = PokemonType.normal;
            this.Height = 2.07;
            this.Weight = 7.5;
            this.HP = 40;
            this.Attack = 45;
            this.Defense = 35;
            this.SpecialAttack = 30;
            this.SpecialDefense = 40;
            this.Speed = 55;
            this.Total = 245;
            this.Name = "Zubat";
            this.image = Resource1.ResourceManager.GetObject("Zubat") as byte[] ?? Array.Empty<byte>();
        }
    }
}
