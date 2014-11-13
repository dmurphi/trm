using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Triemli.Models.TriemliSPecificModels
{
    public class ParkingModel
    {
        public string carNumberPlate { get; set; }
        public Guid employeeId { get; set; }
        public double parkingPeriod { get; set; }
        public DateTime parkingDateTime { get; set; }
    }
}