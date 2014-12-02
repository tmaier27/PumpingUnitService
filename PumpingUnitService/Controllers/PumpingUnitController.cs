using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using PumpingUnitService.Models;

namespace PumpingUnitService.Controllers
{
   public class PumpingUnitController : ApiController 
   {
      private IRepository _repo;

      public PumpingUnitController(IRepository repo)
      {
         _repo = repo;
      }

      public IQueryable<PumpingUnit> Get()
      {
         return _repo.GetAllPumpingUnits();
      }
   }
}