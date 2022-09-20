using dotnet_rpg.Dtos.Character;
using dotnet_rpg.Models;
using dotnet_rpg.Models.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace dotnet_rpg.Services.CharacterServices
{
    public interface ICharacterService
    {
        Task<CharacterServiceResponse<List<GetCharacterDto>>> GetAllCharacters();

        Task<CharacterServiceResponse<GetCharacterDto>> GetCharacterById(int id);

        Task<CharacterServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);
        Task<CharacterServiceResponse<List<GetCharacterDto>>> UpdateCharacter(UpdateCharacterDto updatedCharacter);
    }
}
