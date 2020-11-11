using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using Microsoft.AspNetCore.Components.Authorization;

namespace CarePartnersPortal

{
    public class ADService
    {
        private static readonly DirectoryEntry directoryOperationsEntry = new DirectoryEntry("LDAP://ou=operations,ou=cp,DC=carepartners,DC=local");
         
        public static List<ADUser> GetActiveUsers()
        {
            List<ADUser> users = new List<ADUser>();
            PrincipalContext ctx = new PrincipalContext(ContextType.Domain, "Carepartners", "OU=cp,dc=carepartners,dc=local");
            UserPrincipal qbeUser = new UserPrincipal(ctx);
            PrincipalSearcher srch = new PrincipalSearcher(qbeUser);

            foreach (var found in srch.FindAll())
            {               
                 users.Add(new ADUser() { Name = found.Name, FirstName = found.SamAccountName, LastName = found.UserPrincipalName });
            }
            return users; 
        }

        public static List<string> GetOperationsUserOUs()
        {
            Dictionary<string,List<string>> results = new Dictionary<string,List<string>>();
            List<string> res = new List<string>();
            using (DirectorySearcher searcher = new DirectorySearcher(directoryOperationsEntry))
            {
                searcher.Filter = "(objectCategory=organizationalUnit)";
                foreach(SearchResult result in searcher.FindAll())
                {
                    string ou;
                    ou = result.Path.Replace(",OU=Operations,OU=CP,DC=CarePartners,DC=local", "");
                    ou = ou.Replace("LDAP://OU=", "");
                    string[] ouArray = ou.Split(",");

                    if(ouArray.Length < 2)
                    {
                        res.Add(ouArray[0]);
                    }                 
                }
            }
            return res;
        }

        public static string GetEmailAddress(string username)
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

        public static SearchResult FindAccountByEmail(string email)
        {
            string filter = string.Format("(proxyaddresses=smtp:{0})", email);

            using (DirectoryEntry gc = new DirectoryEntry("LDAP://DC=carepartners,DC=local"))
            { 
                using (DirectorySearcher searcher = new DirectorySearcher(gc, filter, new string[] { "proxyAddresses", "userprincipalname", "displayName" }))
                {
                    searcher.ReferralChasing = ReferralChasingOption.All;
                    SearchResult result = searcher.FindOne();
                    string email2 = result.Properties[1].Values.ToString();
                    return result;
                }
            }
        }

        public static string GetCurrentUser(AuthenticationState userState)
        {

            if (userState.User.Identity.IsAuthenticated)
            {
                return userState.User.Identity.Name.ToString();
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
