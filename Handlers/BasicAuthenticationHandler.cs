using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using InventoryManagement.Clients;
using InventoryManagement.Schemes;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Options;

namespace InventoryManagement.Handlers
{
    public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        public BasicAuthenticationHandler(IOptionsMonitor<AuthenticationSchemeOptions> options, ILoggerFactory logger, UrlEncoder encoder) : base(options, logger, encoder)
        {
        }

        protected override Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            if(!Request.Headers.ContainsKey("Authorization"))
            {
                return Task.FromResult(AuthenticateResult.Fail("Missing Authorization header"));
            }

            var authorizationHeader = Request.Headers["Authorization"].ToString();
            if(!authorizationHeader.StartsWith("Basic", StringComparison.OrdinalIgnoreCase))
            {
                return Task.FromResult(AuthenticateResult.Fail("The authorization header should starts with Basic"));
            }

            var authBase64Decoded = Encoding.UTF8.GetString(Convert.FromBase64String(authorizationHeader.Replace("Basic ", "", StringComparison.OrdinalIgnoreCase)));
            var credentials = authBase64Decoded.Split(new[] { ':' }, 2);
            if(credentials.Length != 2)
            {
                return Task.FromResult(AuthenticateResult.Fail("Invalide Credentials"));
            }
            var username = credentials[0];
            var password = credentials[1];

            var client = new BasicAuthenticationClient 
            {
                AuthenticationType = BasicAuthenticationScheme.Basic,
                IsAuthenticated = true,
                Name = username
            };

            var claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(client, new[]{
                new Claim(ClaimTypes.Name, username),
                //Add role claim and email claim
            }));

            return Task.FromResult(AuthenticateResult.Success(new AuthenticationTicket(claimsPrincipal, Scheme.Name)));
        }
    }
}