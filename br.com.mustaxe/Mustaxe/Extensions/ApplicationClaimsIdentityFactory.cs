using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Mustaxe.Models;

namespace Mustaxe.Extensions
{
	public class ApplicationClaimsIdentityFactory : UserClaimsPrincipalFactory<ApplicationUser>
	{
		public ApplicationClaimsIdentityFactory(
			UserManager<ApplicationUser> userManager,
			IOptions<IdentityOptions> optionsAccessor)
			: base(userManager, optionsAccessor)
		{
		}

		public async override Task<ClaimsPrincipal> CreateAsync(ApplicationUser user)
		{
			var principal = await base.CreateAsync(user);
			var identity = (ClaimsIdentity)principal.Identity;

			var claims = new List<Claim>
			{
				new Claim("Avatar", user.Avatar),
				new Claim("Email", user.Email)
			};

			identity.AddClaims(claims);

			return principal;
		}
	}
}
