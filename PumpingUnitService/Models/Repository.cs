using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PumpingUnitService.Models
{
   public class Repository : IRepository
   {
      private PumpingUnitServiceContext db;

      public Repository(PumpingUnitServiceContext db)
      {
         this.db = db;
      }

      public IQueryable<PumpingUnit> GetAllPumpingUnits()
      {
         return db.PumpingUnits.Include("Motor");
      }

      public IQueryable<PumpingUnitInspection> GetAllPumpingUnitInspections()
      {
         //return db.PumpingUnitInspections.Include("PumpingUnit");
         return db.PumpingUnitInspections;
      }

      public IQueryable<PumpingUnitInspection> GetPumpingUnitInspectionsByPumpingUnit(int id)
      {
         return db.PumpingUnitInspections.Include("PumpingUnit").Where(p => p.PumpingUnitId == id);
      }
   }
}
