using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PumpingUnitService.Models
{
   public class PumpingUnitInspectionItem
   {
      public int Id { get; set; }
      public InspectionTypeCategory Category { get; set; }
      public InspectionType Type { get; set; }
      public InspectionCondition Condition { get; set; }
      public string Comment { get; set; }

      // Navigate
      //public virtual PumpingUnitInspection PumpingUnitInspection { get; set; }
   }

   public enum InspectionTypeCategory
   {
      Defect,
      Lubricate,
      Maintenance
   }

   public enum InspectionType
   {
      GearboxGears,
      Cranks,
      Counterweights,
      CenterBearings,
      TailBearings,
      Wristpins,
      CleanArea,
      NoExcessGreaseOilOnUnit,
      SAPEquipmentNumberOnUnit
   }

   public enum InspectionCondition
   {
      AB,
      C,
      D,
      CompletedRepair,
      Yes,
      No,
      NA
   }
}
