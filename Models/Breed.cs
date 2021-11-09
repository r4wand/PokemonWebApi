
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PokemonWebApi.Models
{
    public class Breed
    {
        public int Id { get; set; }

        [Required]
        public string Description { get; set; }

        public List<Type> Types { get; set; }

        public List<Ability> Abilities { get; set; }

        public double Height { get; set; }

        // evolved from refrences the id of the previous breed
        public int? EvolvedFromId { get; set; }


        [ForeignKey("EvolvedFromId")]
        public Breed EvolvedFrom { get; set; }

        // evolved to refrences the id of the next breed
        public int? EvolvedToId { get; set; }

        [ForeignKey("EvolvedToId")]
        public Breed EvolvedTo { get; set; }

        // this is the image link of the breed  
        public string Image { get; set; }

    }
}
