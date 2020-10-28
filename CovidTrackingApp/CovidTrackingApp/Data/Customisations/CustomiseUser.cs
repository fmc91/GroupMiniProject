using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidTrackingApp.Data
{
    public partial class User
    {
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
