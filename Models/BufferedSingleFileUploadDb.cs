using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace RecipeApp.Models
{
    public class BufferedSingleFileUploadDb
    {
        [Required]
        [Display(Name = "Photo")]
        public IFormFile? FormFile { get; set; }
    }
}
