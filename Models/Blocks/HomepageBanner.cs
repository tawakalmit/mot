using EPiServer.Framework.DataAnnotations;
using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace Mot.Models.Blocks
{
    [ContentType(
        DisplayName = "Homepage Banner",
        GUID = "31D6DDE6-6676-43E0-8571-9D2D6C591109")]
    public class HomepageBanner : BlockData
    {
        [Display(
            Name = "Video",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        [UIHint(UIHint.Video)]
        public virtual ContentReference? Video { get; set; }
    }
}
