using Microsoft.AspNetCore.Antiforgery;
using StroudwaterIdentity.Controllers;

namespace StroudwaterIdentity.Web.Host.Controllers
{
    public class AntiForgeryController : StroudwaterIdentityControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
