using System.ComponentModel.DataAnnotations;

namespace allspice.Models
{
    public class Step
    {
        public int Id{get; set;}
        public string Body{get; set;}
        public string CreatorId{get; set;}
        public int RecipeId{get; set;}
    }
}