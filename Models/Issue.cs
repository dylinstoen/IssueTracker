using System.ComponentModel.DataAnnotations;

namespace IssueTracker.Models {
    public class Issue {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; } = string.Empty;
        
        [StringLength(100)]
        public string? Description { get; set; }

        [Required]
        public string Priority { get; set; } = "Medium";

        [Required]
        public string Status { get; set; } = "Open";

        [Display(Name="Created At")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        
    }
}
