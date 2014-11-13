using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Triemli.Models.TriemliSPecificModels.Membership
{
    public class UsersInRolesModel
    {
        public int userId { get; set; }
        public List<int> roleIds { get; set; }
    }
}