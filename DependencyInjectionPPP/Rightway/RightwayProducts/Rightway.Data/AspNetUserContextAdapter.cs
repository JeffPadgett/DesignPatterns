using Microsoft.AspNetCore.Http;
using Rightway.ClassLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rightway.Data
{
    class AspNetUserContextAdapter : IUserContext
    {
        private static HttpContextAccessor Accessor = new HttpContextAccessor();

        public bool IsInRole(Role role)
        {
            return Accessor.HttpContext.User.IsInRole(role.ToString());
        }
    }
}
