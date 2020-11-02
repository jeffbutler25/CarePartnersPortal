using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;

namespace CarePartnersPortal

{
    public class ADService
    {
        private static readonly DirectoryEntry directoryOperationsEntry = new DirectoryEntry("LDAP://ou=operations,ou=cp,DC=carepartners,DC=local");
        List<ADUser> users = new List<ADUser>();
        public void SetupUsers()
        {
                      
        }
        public List<ADUser> GetActiveUsers()
        {



            //List<string> allUsers = new List<string>();

            // create your domain context and define the OU container to search in
            PrincipalContext ctx = new PrincipalContext(ContextType.Domain, "Carepartners",
                                                        "OU=cp,dc=carepartners,dc=local");

            // define a "query-by-example" principal - here, we search for a UserPrincipal (user)
            UserPrincipal qbeUser = new UserPrincipal(ctx);

            // create your principal searcher passing in the QBE principal    
            PrincipalSearcher srch = new PrincipalSearcher(qbeUser);

            // find all matches
            foreach (var found in srch.FindAll())
            {
                // do whatever here - "found" is of type "Principal" - it could be user, group, computer.....          
                //allUsers.Add(found.DisplayName);
                
                 users.Add(new ADUser() { Name = found.Name, FirstName = found.SamAccountName, LastName = found.UserPrincipalName });
            }
            return users;
            

            //else
            //{
            //    return users.Where(x => x.Location == location).ToList(); 
            //}

        }

        public List<string> GetOperationsUserOUs()
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

        
    }
}
