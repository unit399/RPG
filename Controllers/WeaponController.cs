using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RPG.Dtos.Character;
using RPG.Dtos.Weapon;
using RPG.Models;
using RPG.Services.WeaponService;

namespace RPG.Controllers;

[Authorize]
[ApiController]
[Route("[controller]")]
public class WeaponController : ControllerBase
{
    private readonly IWeaponService _weaponService;

    public WeaponController(IWeaponService _weaponService)
    {
        this._weaponService = _weaponService;
    }
    
    [HttpPost]
    public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> AddWeapon(AddWeaponDto newWeapon)
    {
        return Ok(await _weaponService.AddWeapon(newWeapon));
    }
}