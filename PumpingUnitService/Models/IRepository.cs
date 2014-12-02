using System;
using System.Collections.Generic;
using System.Linq;
namespace PumpingUnitService.Models
{
   public interface IRepository
   {
      IQueryable<PumpingUnit> GetAllPumpingUnits();
      IQueryable<PumpingUnit> GetAllPumpingUnitsWithInspections();
      PumpingUnit GetPumpingUnit(int id);
      IQueryable<PumpingUnitInspection> GetAllPumpingUnitInspections();
      IQueryable<PumpingUnitInspection> GetPumpingUnitInspectionsByPumpingUnit(int id);
   }
}
