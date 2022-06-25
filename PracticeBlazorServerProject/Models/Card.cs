namespace PracticeBlazorServerProject.Models
{
    public class Card
    {
        public Guid Id { get; set; }
        public string BackgroundUrl { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }

    }
}
