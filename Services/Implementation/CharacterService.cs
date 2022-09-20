using AutoMapper;
using dotnet_rpg.Dtos.Character;
using dotnet_rpg.Models;
using dotnet_rpg.Models.Response;
using dotnet_rpg.Services.CharacterServices;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Services.Implementation
{
    public class CharacterService : ICharacterService
    {

        private static List<Character> characters = new List<Character>
        {
        new Character(),
        new Character { Id = 1, Name = "Sam"},
        };

        private readonly IMapper _mapper;

        public CharacterService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<CharacterServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter)
        {
            CharacterServiceResponse<List<GetCharacterDto>> characterServiceResponse = new CharacterServiceResponse<List<GetCharacterDto>>();
            Character character = _mapper.Map<Character>(newCharacter);
            character.Id = characters.Max(c => c.Id) + 1;
            characterServiceResponse.Data = (characters.Select(c => _mapper.Map<GetCharacterDto>(c))).ToList();
            return characterServiceResponse;
        }

        public async Task<CharacterServiceResponse<List<GetCharacterDto>>> GetAllCharacters()
        {
            CharacterServiceResponse<List<GetCharacterDto>> characterServiceResponse = new CharacterServiceResponse<List<GetCharacterDto>>();
            characterServiceResponse.Data = (characters.Select(c => _mapper.Map<GetCharacterDto>(c))).ToList();
            return characterServiceResponse;
        }

        public async Task<CharacterServiceResponse<GetCharacterDto>> GetCharacterById(int id)
        {
            CharacterServiceResponse<GetCharacterDto> characterServiceResponse = new CharacterServiceResponse<GetCharacterDto>();
          
            characterServiceResponse.Data = _mapper.Map<GetCharacterDto>(characters.FirstOrDefault(c => c.Id == id));
            return characterServiceResponse;
        }

        public async Task<CharacterServiceResponse<List<GetCharacterDto>>> UpdateCharacter(UpdateCharacterDto updatedCharacter)
        {
            CharacterServiceResponse<GetCharacterDto> characterServiceResponse = new CharacterServiceResponse<GetCharacterDto>();

            Character character = characters.FirstOrDefault(c => c.Id == updatedCharacter.Id);
            character.Name = updatedCharacter.Name;
            character.Class = updatedCharacter.Class;
            character.Defense = updatedCharacter.Defense;
            character.HitPoints = updatedCharacter.HitPoints;
            character.Intelligence = updatedCharacter.Intelligence;
            character.Strength = updatedCharacter.Strength;

            characterServiceResponse.Data = _mapper.Map<GetCharacterDto>(character);
            return characterServiceResponse;

        }
    }
}
