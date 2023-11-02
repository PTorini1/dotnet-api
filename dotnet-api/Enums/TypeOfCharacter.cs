using System.Text.Json.Serialization;

namespace dotnet_api.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TypeOfCharacter
    {
        Knight = 1,
        Mage = 2,
        Cleric = 3,
    }
}
