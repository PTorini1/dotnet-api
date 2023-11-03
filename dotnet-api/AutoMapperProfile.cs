using AutoMapper;
using dotnet_api.Dtos.Character;
using dotnet_api.Models;

namespace dotnet_api
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
        }
    }
}
