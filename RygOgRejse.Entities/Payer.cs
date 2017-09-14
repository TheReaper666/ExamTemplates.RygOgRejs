using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RygOgRejse.Entities
{
    class Payer
    {
        protected string FirstName;
        protected string LastName;
        protected string SocialSecurityNumber;

        public Payer(string FirstName, string LastName, string SocialSecurityNumber)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.SocialSecurityNumber = SocialSecurityNumber; 
        }
    }
}
