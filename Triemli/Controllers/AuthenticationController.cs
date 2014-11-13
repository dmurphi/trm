using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//////using System.Web.Http;
using System.Web.Mvc;
using Triemli.Services;

namespace Triemli.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly IAuthentication _auth;

        public AuthenticationController(IAuthentication auth)
        {
            _auth = auth;
        }

        [HttpGet]
        public bool CreateAccount(string uname, string pass)
        {
            return _auth.CreateAccount(uname, pass);
        }



        public bool ValidateCredentials(string uname, string pass)
        {
            return _auth.ValidateCredentials(uname, pass);
        }
    }
}