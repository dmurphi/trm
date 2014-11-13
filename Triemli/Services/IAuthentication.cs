using System;
namespace Triemli.Services
{
    public interface IAuthentication
    {
        bool CreateAccount(string uname, string pass);
        void CreateAccountInDatabase(string uname, string hashedPass);
        string GetPasswordFromDatabase(string uname);
        bool ValidateCredentials(string uname, string pass);
    }
}
