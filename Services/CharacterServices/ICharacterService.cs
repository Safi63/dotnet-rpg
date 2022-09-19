using dotnet_rpg.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace dotnet_rpg.Services.CharacterServices
{
    public interface ICharacterService
    {
        Task<List<Character>> GetAllCharacters();

        Task<Character> GetCharacterById(int id);

        Task<List<Character>> AddCharacter(Character newCharacter);
    }
}
