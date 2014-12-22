using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PumpingUnitService.Models
{
   public class PumpingUnitInspection
   {
      public PumpingUnitInspection()
      {
         //InspectionItems = new List<PumpingUnitInspectionItem>();
      }
      public int Id { get; set; }
      public bool PumpingUnitSAPDataMatches { get; set; }
      public bool MotorSAPDataMatches { get; set; }
      public bool UnitOnUponArrival { get; set; }
      public int PumpingUnitId { get; set; }
      // Navigate
      public virtual PumpingUnit PumpingUnit { get; set; }
      public virtual ICollection<PumpingUnitInspectionItem> InspectionItems { get; set; }
   }
}
