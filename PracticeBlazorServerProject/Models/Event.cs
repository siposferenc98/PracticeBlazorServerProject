namespace PracticeBlazorServerProject.Models
{
    public class Event
    {
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public List<Card> Cards { get; set; }
    }
}
