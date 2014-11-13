using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Triemli.Models.TriemliSPecificModels;

namespace Triemli.Services.Membership
{
    public class RolesServices
    {

        public bool addRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public bool addRoleToUser(int userId, int roleId)
        {
            throw new NotImplementedException();
        }

        public List<RolesModel> getUserRoles(int userId)
        {
            throw new NotImplementedException();
        }

        public bool removeRoleFromUser(int roleId, int userId)
        {
            throw new NotImplementedException();
        }

        public bool removeRolesFromUser(List<int> roleIds, int userId)
        {
            throw new NotImplementedException();
        }

        public bool removeRolesFromUsers(List<int> roleIds, List<int> userIds)
        {
            throw new NotImplementedException();
        }
    }
}