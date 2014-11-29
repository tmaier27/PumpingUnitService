using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PumpingUnitService.Models
{
   public class PumpingUnit
   {
      public PumpingUnit()
      {
         //PumpingUnitInspections = new List<PumpingUnitInspection>();
      }
      public int Id { get; set; }
      public string Name { get; set; }
      public string SAPEquipmentNumber { get; set; }
      public string Manufacturer { get; set; }
      public string SerialNumber { get; set; }
      public string APISize { get; set; }
      public string SheaveSize { get; set; }
      public string BeltSize { get; set; }
      public PumpingUnitMotor Motor { get; set; }

      // Navigation
      //public virtual ICollection<PumpingUnitInspection> PumpingUnitInspections { get; set; }
   }
}
