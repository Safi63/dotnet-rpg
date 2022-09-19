﻿using dotnet_rpg.Models;
using System.Collections.Generic;
using System.Linq;

namespace dotnet_rpg.Services.CharacterServices
{
    public class CharacterService : ICharacterService
    {

        private static List<Character> characters = new List<Character>
        {
        new Character(),
        new Character { Id = 4, Name = "Sam"},
        new Character { Id = 5, Name = "Jhon"},
        new Character { Id = 6, Name = "David"},
        new Character { Id = 7, Name = "Barbors"}
        };
        public List<Character> AddCharacter(Character newCharacter)
        {
            characters.Add(newCharacter);
            return characters;
        }

        public List<Character> GetAllCharacters()
        {
            return characters;
        }

        public Character GetCharacterById(int id)
        {
            return characters.FirstOrDefault(c => c.Id == id);
        }
    }
}
 