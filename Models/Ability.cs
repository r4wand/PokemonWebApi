using System.Collections.Generic;


namespace PokemonWebApi.Models
{
    public class Ability
    {
        public int Id { get; set; }

        public string name { get; set; }

        public List<Breed> Breeds { get; set; }

    }
}
