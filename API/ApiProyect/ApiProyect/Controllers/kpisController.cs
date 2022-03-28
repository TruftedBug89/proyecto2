using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
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
            db.Configuration.LazyLoadingEnabled = false;
            return db.kpis;
        }

        // GET: api/kpis/5
        [ResponseType(typeof(kpis))]
        public async Task<IHttpActionResult> Getkpis(int id)
        {
            IHttpActionResult result;
            db.Configuration.LazyLoadingEnabled = false;
            kpis kpis = db.kpis.Where(c => c.id == id).FirstOrDefault();
            //kpis kpis = await db.kpis.FindAsync(id);
            if (kpis == null)
            {
                result = NotFound();
            }
            else {  
                result= Ok(kpis);
            }

            return result;
        }

        // PUT: api/kpis/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putkpis(int id, kpis kpis)
        {
            IHttpActionResult result;
            String missatge = "";
            if (!ModelState.IsValid)
            {
                result = BadRequest(ModelState);
            }
            else
            {
                if (id != kpis.id)
                {
                    result = BadRequest();
                }
                else
                {
                    db.Entry(kpis).State = EntityState.Modified;

                    try
                    {
                        await db.SaveChangesAsync();
                        result = StatusCode(HttpStatusCode.NoContent);
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!kpisExists(id))
                        {
                            result = NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                    catch (DbUpdateException ex)
                    {
                        SqlException sqlException = (SqlException)ex.InnerException.InnerException;
                        missatge = Clases.Error.MissatgeError(sqlException);
                        result = BadRequest(missatge);
                    }
                }
            }
            return result;
        }

        // POST: api/kpis
        [ResponseType(typeof(kpis))]
        public async Task<IHttpActionResult> Postkpis(kpis kpis)
        {
            IHttpActionResult result;
            if (!ModelState.IsValid)
            {
                result = BadRequest(ModelState);
            }
            else
            {
                db.kpis.Add(kpis);
                String missatge = "";
                try
                {
                    await db.SaveChangesAsync();
                    result = CreatedAtRoute("DefaultApi", new { id = kpis.id }, kpis);
                }
                catch (DbUpdateException ex)
                {
                    SqlException sqlException = (SqlException)ex.InnerException.InnerException;
                    missatge = Clases.Error.MissatgeError(sqlException);
                    result = BadRequest(missatge);
                }
            }
            return result;
        }

        // DELETE: api/kpis/5
        [ResponseType(typeof(kpis))]
        public async Task<IHttpActionResult> Deletekpis(int id)
        {
            IHttpActionResult result;
            kpis kpis = await db.kpis.FindAsync(id);
            if (kpis == null)
            {
                result = NotFound();
            }
            else
            {
                String missatge = "";
                try
                {
                    db.kpis.Remove(kpis);
                    await db.SaveChangesAsync();
                    result = Ok(kpis);
                }
                catch (DbUpdateException ex)
                {
                    SqlException sqlException = (SqlException)ex.InnerException.InnerException;
                    missatge = Clases.Error.MissatgeError(sqlException);
                    result = BadRequest(missatge);
                }
            }
            return result;
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