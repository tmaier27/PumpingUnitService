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
    public class PumpingUnitInspectionsController : ApiController
    {
        private PumpingUnitServiceContext db = new PumpingUnitServiceContext();

        // GET: api/PumpingUnitInspections
        public IQueryable<PumpingUnitInspection> GetPumpingUnitInspections()
        {
            return db.PumpingUnitInspections;
        }

        // GET: api/PumpingUnitInspections/5
        [ResponseType(typeof(PumpingUnitInspection))]
        public IHttpActionResult GetPumpingUnitInspection(int id)
        {
            PumpingUnitInspection pumpingUnitInspection = db.PumpingUnitInspections.Find(id);
            if (pumpingUnitInspection == null)
            {
                return NotFound();
            }

            return Ok(pumpingUnitInspection);
        }

        // PUT: api/PumpingUnitInspections/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPumpingUnitInspection(int id, PumpingUnitInspection pumpingUnitInspection)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pumpingUnitInspection.Id)
            {
                return BadRequest();
            }

            db.Entry(pumpingUnitInspection).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PumpingUnitInspectionExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/PumpingUnitInspections
        [ResponseType(typeof(PumpingUnitInspection))]
        public IHttpActionResult PostPumpingUnitInspection(PumpingUnitInspection pumpingUnitInspection)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PumpingUnitInspections.Add(pumpingUnitInspection);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = pumpingUnitInspection.Id }, pumpingUnitInspection);
        }

        // DELETE: api/PumpingUnitInspections/5
        [ResponseType(typeof(PumpingUnitInspection))]
        public IHttpActionResult DeletePumpingUnitInspection(int id)
        {
            PumpingUnitInspection pumpingUnitInspection = db.PumpingUnitInspections.Find(id);
            if (pumpingUnitInspection == null)
            {
                return NotFound();
            }

            db.PumpingUnitInspections.Remove(pumpingUnitInspection);
            db.SaveChanges();

            return Ok(pumpingUnitInspection);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PumpingUnitInspectionExists(int id)
        {
            return db.PumpingUnitInspections.Count(e => e.Id == id) > 0;
        }
    }
}