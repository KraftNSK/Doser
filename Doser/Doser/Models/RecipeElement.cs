namespace IDoser.Models
{
    public class RecipeElement
    {
        public int Id { get; set; } 
        public Material Material { get; set; }
        public double Weigth { get; set; }
        public string Description { get; set; }
    }
}