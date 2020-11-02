using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Threading.Tasks;

namespace CarePartnersPortal
{
    public class AD
    {
        public static string GetEmail(string username)
        {            
            using (PrincipalContext ctx = new PrincipalContext(ContextType.Domain))
            {                
                UserPrincipal user = UserPrincipal.FindByIdentity(ctx, username);                
                if (user != null)
                {
                    return user.EmailAddress;                    
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        public static string GetCurrentUser(AuthenticationState userState)
        {

            if (userState.User.Identity.IsAuthenticated)
            {

                return userState.User.Identity.Name.Substring(13).ToString();

            }
            else
            {
                return string.Empty;
            }
        }       
    }
}
