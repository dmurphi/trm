using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;

namespace Triemli.Services
{
    public class Authentication : Triemli.Services.IAuthentication
    {
        public bool CreateAccount(string uname, string pass)
        {
            bool succeeded = false;

            var hashedPassword = Crypto.HashPassword(pass);

            CreateAccountInDatabase(uname, hashedPassword);

            return succeeded;
        }

        public bool ValidateCredentials(string uname, string pass)
        {
            var hashedPassword = GetPasswordFromDatabase(uname);
            var doesPasswordMatch = Crypto.VerifyHashedPassword(hashedPassword, pass);

            return doesPasswordMatch;
        }

        public void CreateAccountInDatabase(string uname, string hashedPass)
        {
            throw new NotImplementedException();
        }

        public string GetPasswordFromDatabase(string uname)
        {

            Triemli.Repository.AuthenticationRepository _auth = new Triemli.Repository.AuthenticationRepository();
            return _auth.getUserPassword(uname);
            throw new NotImplementedException();
        }
    }
}