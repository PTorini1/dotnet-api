using dotnet_api.Enums;

namespace dotnet_api.Dtos.Character
{
    public class AddCharacterDto
    {
        public string Name { get; set; } = "Frodo";

        public int HitPoints { get; set; } = 100;

        public int Strenght { get; set; } = 10;

        public int Defense { get; set; } = 10;

        public int Intelligence { get; set; } = 10;

        public TypeOfCharacter Class { get; set; } = TypeOfCharacter.Knight;
    }
}
