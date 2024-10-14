using System.Text.Json.Serialization;

namespace BinhDinhFood.Domain.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Role
{
    Admin,
    User
}
