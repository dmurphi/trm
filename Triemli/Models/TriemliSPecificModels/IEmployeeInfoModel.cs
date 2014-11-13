using System;
namespace Triemli.Models.TriemliSPecificModels
{
    public interface IEmployeeInfoModel
    {
        string firstName { get; set; }
        string lastName { get; set; }
        string userCode { get; set; }
        string userPass { get; set; }
    }
}
