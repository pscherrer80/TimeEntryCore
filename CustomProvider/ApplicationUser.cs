using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeEntryCore.CustomProvider
{
    public class ApplicationUser
    {
        public virtual Guid Id { get; set; } = Guid.NewGuid(); 
        public virtual string UserName { get; set; } 
        public virtual string Email { get; set; } 
        public virtual bool EmailConfirmed { get; set; } 
        public virtual String PasswordHash { get; set; } 
        public string NormalizedUserName { get; internal set; } 
        public string AuthenticationType { get; set; } 
        public int IsAuthenticated { get; set; } 
        public string Name { get; set; }

    }
}
