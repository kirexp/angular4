using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;
using AngularWithJwt.Models;
using ESA.DAL.Almaty.Entities.Account;
using ESA.DAL.Almaty.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace AngularWithJwt.Controllers
{
    public class AccountController : Controller
    {
        private SignInManager<User> SignInManager { get; }
        private IConfiguration Configuration { get; }
        public AccountController(SignInManager<User>signInManager, IConfiguration configuration) {
            SignInManager = signInManager;
            Configuration = configuration;
        }

        public async Task<IActionResult> Auth(string userName, string password) {
            using (var repository = new Repository<User>()) {
                var user = repository.Get(x => x.UserName == userName).SingleOrDefault();
                var result = await this.SignInManager.PasswordSignInAsync(user,password,false,false);
                if (result.Succeeded) {
                    var requestAt = DateTime.Now;
                    var expiresIn = requestAt + TokenAuthOption.ExpiresSpan;
                    var token = GenerateToken(user, expiresIn);
                    return Json(new RequestResult {
                        State = RequestState.Success,
                        Data = new {
                            requertAt = requestAt,
                            expiresIn = TokenAuthOption.ExpiresSpan.TotalSeconds,
                            tokeyType = TokenAuthOption.TokenType,
                            accessToken = token
                        }
                    });
                }
                else {
                    return null;
                }
            }
        }
        [NonAction]
        private string GenerateToken(User user, DateTime expires)
        {
            var handler = new JwtSecurityTokenHandler();
            ClaimsIdentity identity = new ClaimsIdentity(
                new GenericIdentity(user.UserName, "TokenAuth"),
                new[] {
                    new Claim("Id", user.Id.ToString()),
                    new Claim(ClaimsIdentity.DefaultRoleClaimType,"Admin"),
                    new Claim("Email", user.Profile.Email),
                    new Claim("Type", user.UserType.ToString())
                }
            );

            var securityToken = handler.CreateToken(new SecurityTokenDescriptor
            {
                Issuer = TokenAuthOption.Issuer,
                Audience = TokenAuthOption.Audience,
                SigningCredentials = TokenAuthOption.SigningCredentials,
                Subject = identity,
                Expires = expires
            });
            return handler.WriteToken(securityToken);
        }
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme,Roles = "Admin")]
        public IActionResult ForAdmin() {
            return Json("Yes is Admin");
        }
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public IActionResult ForAuth() {
            return Json("Yes is auth");
        }
        public IActionResult ForAll()
        {
            return Json("Yes is All");
        }
    }
}
