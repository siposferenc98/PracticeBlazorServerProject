using System.ComponentModel.DataAnnotations;

namespace PracticeBlazorServerProject.Models
{
    public class Card
    {
        [Required]
        public Guid Id { get; set; }
        public string BackgroundUrl { get; set; }
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "The card has no name")]
        public string Title { get; set; }
        public string Location { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public Guid EventId { get; set; }

    }
}
