using System;
using System.Collections.Generic;

namespace dotnet_rpg.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Frodo";

        public int HitPoints { get; set; } = 100;

        public int Strength { get; set; } = 10;

        public int Defense { get; set; } = 10;

        public int Intelligence { get; set; } = 10; 

        public RpgClass Class { get; set; } = RpgClass.Knigt;

        public static implicit operator List<object>(Character v)
        {
            throw new NotImplementedException();
        }
    }
}
