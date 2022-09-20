using dotnet_rpg.Models;
using System.Collections.Generic;
using System;

namespace dotnet_rpg.Dtos.Character
{
    public class AddCharacterDto
    {
        public string Name { get; set; } = "Frodo";

        public int HitPoints { get; set; } = 100;

        public int Strength { get; set; } = 10;

        public int Defense { get; set; } = 10;

        public int Intelligence { get; set; } = 10;

        public RpgClass Class { get; set; } = RpgClass.Knigt;

        public static implicit operator List<object>(AddCharacterDto v)
        { 
            throw new NotImplementedException(); 
        }
    }
}
