using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Triemli.Models.TriemliSpecificModels
{
    public class EmployeeInfoModel : Triemli.Models.TriemliSPecificModels.IEmployeeInfoModel
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string userCode { get; set; }
        public string userPass { get; set; }
    }
}