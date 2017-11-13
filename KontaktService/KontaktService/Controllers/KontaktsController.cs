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
using KontaktService.DAL;
using KontaktService.Models;

namespace KontaktService.Controllers
{
    public class KontaktsController : ApiController
    {
        private ImenikContext db = new ImenikContext();

        // GET: api/Kontakts
        public IQueryable<Kontakt> GetKontakti()
        {
            return db.Kontakti;
        }

        // GET: api/Kontakts/5
        [ResponseType(typeof(Kontakt))]
        public IHttpActionResult GetKontakt(int id)
        {
            Kontakt kontakt = db.Kontakti.Find(id);
            if (kontakt == null)
            {
                return NotFound();
            }

            return Ok(kontakt);
        }

        // PUT: api/Kontakts/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutKontakt(int id, Kontakt kontakt)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != kontakt.ID)
            {
                return BadRequest();
            }

            db.Entry(kontakt).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KontaktExists(id))
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

        // POST: api/Kontakts
        [ResponseType(typeof(Kontakt))]
        public IHttpActionResult PostKontakt(Kontakt kontakt)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Kontakti.Add(kontakt);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = kontakt.ID }, kontakt);
        }

        // DELETE: api/Kontakts/5
        [ResponseType(typeof(Kontakt))]
        public IHttpActionResult DeleteKontakt(int id)
        {
            Kontakt kontakt = db.Kontakti.Find(id);
            if (kontakt == null)
            {
                return NotFound();
            }

            db.Kontakti.Remove(kontakt);
            db.SaveChanges();

            return Ok(kontakt);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool KontaktExists(int id)
        {
            return db.Kontakti.Count(e => e.ID == id) > 0;
        }
    }
}