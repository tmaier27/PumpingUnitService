using Breeze.ContextProvider;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;
namespace PumpingUnitService.Models
{
   public interface IRepository
   {
      string Metadata { get; }
      SaveResult SaveChanges(JObject saveBundle);
      IQueryable<PumpingUnit> PumpingUnits();
      IQueryable<PumpingUnitInspection> PumpingUnitInspections();

      //IQueryable<PumpingUnit> GetAllPumpingUnits();
      //IQueryable<PumpingUnitInspection> GetAllPumpingUnitInspections();
      //IQueryable<PumpingUnitInspection> GetPumpingUnitInspectionsByPumpingUnit(int id);
   }
}
