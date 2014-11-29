using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PumpingUnitService.Models
{
   public class PumpingUnitMotor
   {
      public int Id { get; set; }
      public string SAPEquipmentNumber { get; set; }
      public string Manufacturer { get; set; }
      public string SerialNumber { get; set; }
      public int Horsepower { get; set; }
      public string Frame { get; set; }
      public int RPM { get; set; }
   }
}
