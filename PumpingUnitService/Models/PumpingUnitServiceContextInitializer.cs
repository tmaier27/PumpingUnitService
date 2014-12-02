using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PumpingUnitService.Models
{
   public class PumpingUnitServiceContextInitializer : DropCreateDatabaseAlways<PumpingUnitServiceContext>
   {
      protected override void Seed(PumpingUnitServiceContext context)
      {
         var pumpingUnits = new List<PumpingUnit>
         {
            new PumpingUnit() 
            {
               APISize = "APISize1", BeltSize = "BeltSize1", Manufacturer = "Mfgr1", Name = "Unit1", SAPEquipmentNumber = "EqptNo1", SerialNumber = "SerialNo1", SheaveSize = "SheaveSize1",
               Motor = new PumpingUnitMotor() { Frame = "FrameTest", Horsepower = 1000, Manufacturer = "MotorMfgr", RPM = 1000, SAPEquipmentNumber = "SAPMotorEqptNbr", SerialNumber = "12345" }
            },
            new PumpingUnit() 
            {
               APISize = "APISize2", BeltSize = "BeltSize2", Manufacturer = "Mfgr2", Name = "Unit2", SAPEquipmentNumber = "EqptNo2", SerialNumber = "SerialNo2", SheaveSize = "SheaveSize2",
               Motor = new PumpingUnitMotor() { Frame = "FrameTest", Horsepower = 1000, Manufacturer = "MotorMfgr", RPM = 1000, SAPEquipmentNumber = "SAPMotorEqptNbr", SerialNumber = "12345" }
            },
            new PumpingUnit() 
            {
               APISize = "APISize3", BeltSize = "BeltSize3", Manufacturer = "Mfgr3", Name = "Unit3", SAPEquipmentNumber = "EqptNo3", SerialNumber = "SerialNo3", SheaveSize = "SheaveSize3",
               Motor = new PumpingUnitMotor() { Frame = "FrameTest", Horsepower = 1000, Manufacturer = "MotorMfgr", RPM = 1000, SAPEquipmentNumber = "SAPMotorEqptNbr", SerialNumber = "12345" }
            },
            new PumpingUnit() 
            {
               APISize = "APISize4", BeltSize = "BeltSize4", Manufacturer = "Mfgr4", Name = "Unit4", SAPEquipmentNumber = "EqptNo4", SerialNumber = "SerialNo4", SheaveSize = "SheaveSize4",
               Motor = new PumpingUnitMotor() { Frame = "FrameTest", Horsepower = 1000, Manufacturer = "MotorMfgr", RPM = 1000, SAPEquipmentNumber = "SAPMotorEqptNbr", SerialNumber = "12345" }
            },
            new PumpingUnit() 
            {
               APISize = "APISize5", BeltSize = "BeltSize5", Manufacturer = "Mfgr5", Name = "Unit5", SAPEquipmentNumber = "EqptNo5", SerialNumber = "SerialNo5", SheaveSize = "SheaveSize5",
               Motor = new PumpingUnitMotor() { Frame = "FrameTest", Horsepower = 1000, Manufacturer = "MotorMfgr", RPM = 1000, SAPEquipmentNumber = "SAPMotorEqptNbr", SerialNumber = "12345" }
            },
         };
         pumpingUnits.ForEach(p => context.PumpingUnits.Add(p));
         context.SaveChanges();

         var pumpingUnitInspections = new List<PumpingUnitInspection>()
         {
            new PumpingUnitInspection()
            {
               MotorSAPDataMatches = true, PumpingUnitSAPDataMatches = true, UnitOnUponArrival = false, PumpingUnit = pumpingUnits[1],
               InspectionItems = new List<PumpingUnitInspectionItem>()
               {
                  new PumpingUnitInspectionItem() { Category = InspectionTypeCategory.Defect, Type = InspectionType.GearboxGears, Condition = InspectionCondition.C, Comment = "Not looking good"},
                  new PumpingUnitInspectionItem() { Category = InspectionTypeCategory.Defect, Type = InspectionType.Counterweights, Condition = InspectionCondition.AB},
                  new PumpingUnitInspectionItem() { Category = InspectionTypeCategory.Lubricate, Type = InspectionType.Wristpins, Condition = InspectionCondition.Yes, Comment = "Lubed Wristpins"},
                  new PumpingUnitInspectionItem() { Category = InspectionTypeCategory.Maintenance, Type = InspectionType.CleanArea, Condition = InspectionCondition.Yes, Comment = "Cleaned unit pad area"}
               }
            },
            new PumpingUnitInspection()
            {
               MotorSAPDataMatches = true, PumpingUnitSAPDataMatches = false, UnitOnUponArrival = true, PumpingUnit = pumpingUnits[4],
               InspectionItems = new List<PumpingUnitInspectionItem>()
               {
                  new PumpingUnitInspectionItem() { Category = InspectionTypeCategory.Defect, Type = InspectionType.TailBearings, Condition = InspectionCondition.D, Comment = "Turned off unit immediately. Attention required!"},
                  new PumpingUnitInspectionItem() { Category = InspectionTypeCategory.Defect, Type = InspectionType.Cranks, Condition = InspectionCondition.AB},
                  new PumpingUnitInspectionItem() { Category = InspectionTypeCategory.Lubricate, Type = InspectionType.CenterBearings, Condition = InspectionCondition.Yes, Comment = "Lubed bearings"},
                  new PumpingUnitInspectionItem() { Category = InspectionTypeCategory.Maintenance, Type = InspectionType.NoExcessGreaseOilOnUnit, Condition = InspectionCondition.Yes, Comment = "Cleaned off excess grease"}
               }
            },
            new PumpingUnitInspection()
            {
               MotorSAPDataMatches = true, PumpingUnitSAPDataMatches = false, UnitOnUponArrival = true, PumpingUnit = pumpingUnits[4],
               InspectionItems = new List<PumpingUnitInspectionItem>()
               {
                  new PumpingUnitInspectionItem() { Category = InspectionTypeCategory.Defect, Type = InspectionType.TailBearings, Condition = InspectionCondition.D, Comment = "Turned off unit immediately. Attention required!"},
                  new PumpingUnitInspectionItem() { Category = InspectionTypeCategory.Defect, Type = InspectionType.Cranks, Condition = InspectionCondition.C},
                  new PumpingUnitInspectionItem() { Category = InspectionTypeCategory.Lubricate, Type = InspectionType.CenterBearings, Condition = InspectionCondition.CompletedRepair, Comment = "Lubed bearings"},
                  new PumpingUnitInspectionItem() { Category = InspectionTypeCategory.Maintenance, Type = InspectionType.NoExcessGreaseOilOnUnit, Condition = InspectionCondition.No, Comment = "Cleaned off excess grease"}
               }
            }
         };

         pumpingUnitInspections.ForEach(p => context.PumpingUnitInspections.Add(p));
         context.SaveChanges();

         base.Seed(context);
      }
   }
}
