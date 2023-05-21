﻿using AutoMapper;
using RPG.Dtos.Character;
using RPG.Dtos.Weapon;
using RPG.Models;

namespace RPG.MappingProfiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
            CreateMap<UpdateCharacterDto, Character>();
            CreateMap<Weapon, GetWeaponDto>();
        }
    }
}
