using dotnet_rpg.Models;
using System.Collections.Generic;

namespace dotnet_rpg.Services.CharacterServices
{
    public interface ICharacterService
    {
        List<Character> GetAllCharacters();

        Character GetCharacterById(int id);

        List<Character> AddCharacter(Character newCharacter);
    }
}
