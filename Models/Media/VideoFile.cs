using EPiServer.Framework.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace Mot.Models.Media
{
    [ContentType(
        DisplayName = "Video",
        GUID = "2DEE5859-DBF1-4C8A-9DA0-B48C86F82F93")]
    [MediaDescriptor(ExtensionString = "mp4")]
    public class VideoFile : VideoData
    {
    }
}
