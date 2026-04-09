using Duende.IdentityServer;
using Duende.IdentityServer.Services;
using IdentityModel;
using Marvin.IDP.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Marvin.IDP.Pages.User.Registration
{
    [AllowAnonymous]
    [SecurityHeaders]
    public class IndexModel(
        ILocalUserService localUserService,
        IIdentityServerInteractionService interactionService) : PageModel
    {
        private readonly ILocalUserService _localUserService = localUserService ??
                throw new ArgumentNullException(nameof(localUserService));
        private readonly IIdentityServerInteractionService _interaction = interactionService ??
                throw new ArgumentNullException(nameof(interactionService));

        [BindProperty]
        public InputModel Input { get; set; }

        public IActionResult OnGet(string returnUrl)
        {
            BuildModel(returnUrl);

            return Page();
        }

        private void BuildModel(string returnUrl)
        {
            Input = new InputModel
            {
                ReturnUrl = returnUrl
            };
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                BuildModel(Input.ReturnUrl);
                return Page();
            }

            var userToCreate = new Entities.User
            {
                UserName = Input.UserName,
                Subject = Guid.NewGuid().ToString(),
                Email = Input.Email,
                Active = false
            };

            userToCreate.Claims.Add(new Entities.UserClaim
            {
                Type = JwtClaimTypes.GivenName,
                Value = Input.GivenName
            });

            userToCreate.Claims.Add(new Entities.UserClaim
            {
                Type = JwtClaimTypes.FamilyName,
                Value = Input.FamilyName
            });

            _localUserService.AddUser(userToCreate, Input.Password);
            await _localUserService.SaveChangesAsync();

            var activationLink = Url.PageLink("/user/activation/index",
                values: new { securityCode = userToCreate.SecurityCode });

            Console.WriteLine(activationLink);
            return Redirect("~/User/ActivationCodeSent");

            //var isUser = new IdentityServerUser(userToCreate.Subject)
            //{
            //    DisplayName = userToCreate.UserName
            //};

            //await HttpContext.SignInAsync(isUser);

            //if (_interaction.IsValidReturnUrl(Input.ReturnUrl)
            //    || Url.IsLocalUrl(Input.ReturnUrl))
            //{
            //    return Redirect(Input.ReturnUrl);
            //}

            //return Redirect("~/");
        }
    }
}
