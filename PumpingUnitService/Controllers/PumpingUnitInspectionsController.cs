using PumpingUnitService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PumpingUnitService.Controllers
{
    public class PumpingUnitInspectionsController : ApiController
    {
       private IRepository _repo;

       public PumpingUnitInspectionsController(IRepository repo)
       {
          _repo = repo;
       }

       public IQueryable<PumpingUnitInspection> Get()
       {
          return _repo.GetAllPumpingUnitInspections();
       }

       public IQueryable<PumpingUnitInspection> Get(int id)
       {
          return _repo.GetPumpingUnitInspectionsByPumpingUnit(id);
       }
    }
}
