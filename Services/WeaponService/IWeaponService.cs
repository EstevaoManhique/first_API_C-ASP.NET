using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet7rpg_prep.Dtos.Weapon;

namespace dotnet7rpg_prep.Services.WeaponService
{
    public interface IWeaponService
    {
        Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon);
    }
}