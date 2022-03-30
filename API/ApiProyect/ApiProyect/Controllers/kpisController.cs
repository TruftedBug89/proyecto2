using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using ApiProyect.Models;

namespace ApiProyect.Controllers
{
    public class kpisController : ApiController
    {
        private frase_aluEntities db = new frase_aluEntities();

        // GET: api/kpis
        public IQueryable<kpis> Getkpis()
        {
            return db.kpis;
        }

        // GET: api/kpis/5
        [ResponseType(typeof(kpis))]
        public async Task<IHttpActionResult> Getkpis(int id)
        {
            kpis kpis = await db.kpis.FindAsync(id);
            if (kpis == null)
            {
                return NotFound();
            }

            return Ok(kpis);
        }

        // PUT: api/kpis/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putkpis(int id, kpis kpis)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != kpis.id)
            {
                return BadRequest();
            }

            db.Entry(kpis).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!kpisExists(id))
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

        // POST: api/kpis
        [ResponseType(typeof(kpis))]
        public async Task<IHttpActionResult> Postkpis(kpis kpis)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.kpis.Add(kpis);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = kpis.id }, kpis);
        }

        // DELETE: api/kpis/5
        [ResponseType(typeof(kpis))]
        public async Task<IHttpActionResult> Deletekpis(int id)
        {
            kpis kpis = await db.kpis.FindAsync(id);
            if (kpis == null)
            {
                return NotFound();
            }

            db.kpis.Remove(kpis);
            await db.SaveChangesAsync();

            return Ok(kpis);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool kpisExists(int id)
        {
            return db.kpis.Count(e => e.id == id) > 0;
        }
    }
}