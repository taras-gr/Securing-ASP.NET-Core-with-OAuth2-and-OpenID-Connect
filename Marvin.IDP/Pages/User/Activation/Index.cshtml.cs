using Marvin.IDP.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Marvin.IDP.Pages.User.Activation;

[SecurityHeaders]
[AllowAnonymous]
public class IndexModel(ILocalUserService localUserService) : PageModel
{
    private readonly ILocalUserService _localUserService = localUserService ??
            throw new ArgumentNullException(nameof(localUserService));

    [BindProperty]
    public InputModel Input { get; set; }

    public async Task<IActionResult> OnGet(string securityCode)
    {
        Input = new InputModel();

        if (await _localUserService.ActivateUserAsync(securityCode))
        {
            Input.Message = "Your account has been activated. You can now log in.";
        }
        else
        {
            Input.Message = "Invalid activation code. Please contact support.";
        }

        await _localUserService.SaveChangesAsync();

        return Page();
    }
}
