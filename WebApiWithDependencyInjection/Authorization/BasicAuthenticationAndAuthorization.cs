using System;
using System.Net;
using System.Net.Http;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace WebApiWithDependencyInjection.Controllers
{
    public class BasicAuthenticationAndAuthorization : AuthorizationFilterAttribute
    {
        string uName = "LCT";
        string passwd = "LCTtraining";

        public override void OnAuthorization(HttpActionContext actionContext)
        {
            if (actionContext.Request.Headers.Authorization == null)
            {
                actionContext.Response = actionContext.Request
                                            .CreateResponse(HttpStatusCode.Unauthorized);
            }
            else
            {
                string authenticationToken = actionContext.Request.Headers.Authorization.Parameter;
                string decodedAuthenticationToken = Encoding.UTF8.GetString(
                                                        Convert.FromBase64String(authenticationToken));

                string[] userCredentials = decodedAuthenticationToken.Split(':');
                string userName = userCredentials[0];
                string password = userCredentials[1];

                if (uName.Equals(userName, StringComparison.OrdinalIgnoreCase) && passwd.Equals(password))
                {
                    Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(userName), null);
                }
                else
                {
                    actionContext.Response = actionContext.Request
                                            .CreateResponse(HttpStatusCode.Unauthorized);
                }
            }
        }
    }
}