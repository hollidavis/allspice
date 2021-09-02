namespace allspice.Models
{
    public class Recipe
    {
        public int Id{get; set;}
        [Required]
        [MinLength(3)]
        [MaxLength(25)]
        public string Title{get; set;}
        public string Body{get; set;}
        public int CookTime{get; set;}
        public int PrepTime{get; set;}
        public string CreatorId{get; set;}
        public Profile Creator { get; set; }
    }
}