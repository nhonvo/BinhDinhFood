namespace BinhDinhFood.Application.Common.Models.Auth.Media;

public class MediaCreateRequest
{
    public MediaType Type { get; set; }

    public string MediaLink { get; set; }

    public string Caption { get; set; }

    public int Duration { get; set; }

    public DateTime DateCreated { get; set; }

    public IFormFile MediaFile { get; set; }

}
