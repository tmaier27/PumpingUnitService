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
        private PumpingUnitServiceContext db = new PumpingUnitServiceContext();

        // GET: api/PumpingUnit
        public IQueryable<PumpingUnit> GetPumpingUnits()
        {
            return db.PumpingUnits;
        }

        // GET: api/PumpingUnit/5
        [ResponseType(typeof(PumpingUnit))]
        public IHttpActionResult GetPumpingUnit(int id)
        {
            PumpingUnit pumpingUnit = db.PumpingUnits.Find(id);
            if (pumpingUnit == null)
            {
                return NotFound();
            }

            return Ok(pumpingUnit);
        }

        // PUT: api/PumpingUnit/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPumpingUnit(int id, PumpingUnit pumpingUnit)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pumpingUnit.Id)
            {
                return BadRequest();
            }

            db.Entry(pumpingUnit).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PumpingUnitExists(id))
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

        // POST: api/PumpingUnit
        [ResponseType(typeof(PumpingUnit))]
        public IHttpActionResult PostPumpingUnit(PumpingUnit pumpingUnit)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PumpingUnits.Add(pumpingUnit);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = pumpingUnit.Id }, pumpingUnit);
        }

        // DELETE: api/PumpingUnit/5
        [ResponseType(typeof(PumpingUnit))]
        public IHttpActionResult DeletePumpingUnit(int id)
        {
            PumpingUnit pumpingUnit = db.PumpingUnits.Find(id);
            if (pumpingUnit == null)
            {
                return NotFound();
            }

            db.PumpingUnits.Remove(pumpingUnit);
            db.SaveChanges();

            return Ok(pumpingUnit);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PumpingUnitExists(int id)
        {
            return db.PumpingUnits.Count(e => e.Id == id) > 0;
        }
    }
}