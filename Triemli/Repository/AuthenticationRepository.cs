using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Triemli.Models.TriemliSpecificModels;

namespace Triemli.Repository
{
    public class AuthenticationRepository:BaseRepository
    {
        public string getUserPassword(string uname)
        {
            string userHashedPass = String.Empty;

            using (var db = BaseRepository.getDB())
            {
                try
                {
                    var result = db.Query<EmployeeInfoModel>("select * from EmployeeInfo").FirstOrDefault().userPass;

                    userHashedPass =  result;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return userHashedPass;
        }

    }
}