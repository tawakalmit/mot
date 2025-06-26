using System.ComponentModel.DataAnnotations;

namespace Mot.Models.Pages
{
    [ContentType(
        DisplayName = "Metadata",
        GUID = "29CF07B0-6B50-4E6E-928C-4EC487D9BA56")]
    public class Metadata : PageData
    {
        [Display(
            Name = "Title",
            GroupName = "SEO",
            Order = 10)]
        public virtual string? MetaTitle { get; set; }
        [Display(
            Name = "Description",
            GroupName = "SEO",
            Order = 20)]
        public virtual string? Description { get; set; }
        [Display(
            Name = "Keywords",
            GroupName = "SEO",
            Order = 30)]
        public virtual string? Keywords { get; set; }
    }
}
