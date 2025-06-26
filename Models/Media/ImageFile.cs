using EPiServer.Framework.DataAnnotations;

namespace Mot.Models.Media
{
    [ContentType(
        DisplayName = "Image",
        GUID = "D441E5A5-E017-45C3-B839-B596CEFB594A")]
    [MediaDescriptor(ExtensionString = "jpg,jpeg,png")]
    public class ImageFile : ImageData
    {
    }
}
