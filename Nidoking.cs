using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDex
{
    public class Nidoking : Pokemon
    {
        public Nidoking()
        {
            this.Type = PokemonType.normal;
            this.Height = 4.07;
            this.Weight = 62;
            this.HP = 81;
            this.Attack = 102;
            this.Defense = 77;
            this.SpecialAttack = 85;
            this.SpecialDefense = 75;
            this.Speed = 85;
            this.Total = 505;
            this.Name = "Nidoking";
            this.image =
                Resource1.ResourceManager.GetObject("Nidoking") as byte[] ?? Array.Empty<byte>();
        }
    }
}
