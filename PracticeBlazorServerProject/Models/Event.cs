using System.ComponentModel.DataAnnotations;

namespace PracticeBlazorServerProject.Models
{
    public class Event
    {
        [Required]
        public Guid Id { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public List<Card> Cards { get; set; }
    }
}
