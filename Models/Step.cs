using System.ComponentModel.DataAnnotations;

namespace allspice.Models
{
    public class Step
    {
        public int Id{get; set;}
        public string Body{get; set;}
        [Required]
        public string CreatorId{get; set;}
        [Required]
        public int RecipeId{get; set;}
    }
}