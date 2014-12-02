using System;
using System.Linq;
namespace PumpingUnitService.Models
{
   public interface IRepository
   {
      IQueryable<PumpingUnit> GetAllPumpingUnits();
      IQueryable<PumpingUnitInspection> GetAllPumpingUnitInspections();
      IQueryable<PumpingUnitInspection> GetPumpingUnitInspectionsByPumpingUnit(int id);
   }
}
