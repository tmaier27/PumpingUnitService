using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
         return db.PumpingUnits;
      }

      public IQueryable<PumpingUnit> GetAllPumpingUnitsWithInspections()
      {
         return db.PumpingUnits.Include("PumpingUnitInspections");
      }

      public PumpingUnit GetPumpingUnit(int id)
      {
         return db.PumpingUnits.FirstOrDefault(p => p.Id == id);
      }

      public IQueryable<PumpingUnitInspection> GetAllPumpingUnitInspections()
      {
         return db.PumpingUnitInspections;
      }

      public IQueryable<PumpingUnitInspection> GetPumpingUnitInspectionsByPumpingUnit(int id)
      {
         return db.PumpingUnitInspections.Where(p => p.PumpingUnitId == id);
      }
   }
}