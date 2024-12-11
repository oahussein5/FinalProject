using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class DogProfile
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Breed is required")]
        public string Breed { get; set; }

        [Range(0, 30, ErrorMessage = "Age must be between 0 and 30")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Size is required")]
        public string Size { get; set; }

        [Required(ErrorMessage = "Location is required")]
        public string Location { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Image URL is required")]
        public string ImageUrl { get; set; }
    }
}
