using Breeze.ContextProvider.EF6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PumpingUnitService.Models
{
   public class Repository : IRepository
   {
      //private PumpingUnitServiceContext db;
      private readonly EFContextProvider<PumpingUnitServiceContext> _contextProvider = new EFContextProvider<PumpingUnitServiceContext>();

      public string Metadata
      {
         get { return _contextProvider.Metadata(); }
      }

      public Breeze.ContextProvider.SaveResult SaveChanges(Newtonsoft.Json.Linq.JObject saveBundle)
      {
         return _contextProvider.SaveChanges(saveBundle);
      }

      public IQueryable<PumpingUnit> PumpingUnits()
      {
         return _contextProvider.Context.PumpingUnits;
      }

      public IQueryable<PumpingUnitInspection> PumpingUnitInspections()
      {
         return _contextProvider.Context.PumpingUnitInspections;
      }
   }
}
