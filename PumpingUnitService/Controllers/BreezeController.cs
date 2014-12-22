using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Breeze.WebApi2;
using PumpingUnitService.Models;
using Breeze.ContextProvider;
using Newtonsoft.Json.Linq;

namespace PumpingUnitService.Controllers
{
   [BreezeController]
   public class BreezeController : ApiController
   {
      private readonly IRepository _repo;

      public BreezeController(IRepository repo)
      {
         _repo = repo;
      }

      [HttpGet]
      public string Metadata()
      {
         return _repo.Metadata;
      }

      [HttpPost]
      public SaveResult SaveChanges(JObject saveBundle)
      {
         return _repo.SaveChanges(saveBundle);
      }

      [HttpGet]
      public IQueryable<PumpingUnit> PumpingUnits()
      {
         return _repo.PumpingUnits();
      }

      [HttpGet]
      public IQueryable<PumpingUnitInspection> PumpingUnitInspections()
      {
         return _repo.PumpingUnitInspections();
      }

   }
}