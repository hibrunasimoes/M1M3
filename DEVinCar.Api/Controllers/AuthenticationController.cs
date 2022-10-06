using System;
using DEVinCar.Api.Service;
using DEVinCar.Domain.DTOs;
using DEVinCar.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace DEVinCar.Api.Controllers
{
    public class AuthenticationController : ControllerBase
    {
        private readonly IUserService _userServico;
        public AuthenticationController(IUserService userServico)
        {
            _userServico = userServico;
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Login(
        [FromBody] UserLoginDTO DTO) // UserLoginDTO DTO
        {
            var user = _userServico.ObterPorUsuario(DTO.Email, DTO.Password);

            if (user == null) return Unauthorized();

            var token = TokenService.GenerateTokenFromUser(user);
            var refreshToken = TokenService.GenerateRefreshToken();
            TokenService.SaveRefreshToken(user.Email, refreshToken);
            return Ok(new
            {
                token,
                refreshToken
            });
        }

        [HttpPost]
        [Route("refresh")]
        [AllowAnonymous]
        public IActionResult RefreshToken([FromQuery] string token, [FromQuery] string refreshToken)
        {
            var principal = TokenService.GetPrincipalFromExpiredToken(token);
            var username = principal.Identity.Name;
            var savedRefreshToken = TokenService.GetRefreshToken(username);

            if (savedRefreshToken != refreshToken)
                throw new SecurityTokenException("Invalid refresh token");

            var newToken = TokenService.GenerateTokenFromClaims(principal.Claims);
            var newRefreshToken = TokenService.GenerateRefreshToken();
            TokenService.DeleteRefreshToken(username, refreshToken);
            TokenService.SaveRefreshToken(username, newRefreshToken);

            return new ObjectResult(new
            {
                token = newToken,
                refreshToken = newRefreshToken

            });

        }

        [HttpGet]
        [Route("list-refresh-tokens")]
        public IActionResult ListRefreshTokens()
        {
            return Ok(TokenService.GetAllRefreshTokens());
        }

    }

}



