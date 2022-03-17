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
    public class valoracionsController : ApiController
    {
        private frase_aluEntities db = new frase_aluEntities();

        // GET: api/valoracions
        public IQueryable<valoracions> Getvaloracions()
        {
            db.Configuration.LazyLoadingEnabled = false;
            return db.valoracions;
        }

        // GET: api/valoracions/5
        [ResponseType(typeof(valoracions))]
        public async Task<IHttpActionResult> Getvaloracions(int id)
        {
            IHttpActionResult result;
            db.Configuration.LazyLoadingEnabled = false;
            valoracions valoracions = db.valoracions.Include("kpis").Where(c => c.kpis_id == id).FirstOrDefault();
            //valoracions valoracions = await db.valoracions.FindAsync(id);
            if (valoracions == null)
            {
                result = NotFound();
            }
            else {
                result = Ok(valoracions);
            }

            return result;
        }
        [HttpGet]

        // PUT: api/valoracions/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putvaloracions(int id, valoracions valoracions)
        {
            IHttpActionResult result;
            String missatge = "";
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else {
                if (id != valoracions.kpis_id)
                {
                    result = BadRequest();
                }
                else {
                    db.Entry(valoracions).State = EntityState.Modified;
                   
                    try
                    {
                        await db.SaveChangesAsync();
                        result = StatusCode(HttpStatusCode.NoContent);
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!valoracionsExists(id))
                        {
                            result =  NotFound();
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

        // POST: api/valoracions
        [ResponseType(typeof(valoracions))]
        public async Task<IHttpActionResult> Postvaloracions(valoracions _valoracions)
        {
            IHttpActionResult result;
            if (!ModelState.IsValid)
            {
                result = BadRequest(ModelState);
            }
            else {
                db.valoracions.Add(_valoracions);
                String missatge = "";
                try
                {
                    await db.SaveChangesAsync();
                    result = CreatedAtRoute("DefaultApi", new { id = _valoracions.kpis_id }, _valoracions);
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

        // DELETE: api/valoracions/5
        [ResponseType(typeof(valoracions))]
        public async Task<IHttpActionResult> Deletevaloracions(int id)
        {
            IHttpActionResult result;
            valoracions valoracions = await db.valoracions.FindAsync(id);
            if (valoracions == null)
            {
                result= NotFound();
            }
            else {
                String missatge = "";
                try
                {
                    db.valoracions.Remove(valoracions);
                    await db.SaveChangesAsync();
                    result = Ok(valoracions);
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

        private bool valoracionsExists(int id)
        {
            return db.valoracions.Count(e => e.kpis_id == id) > 0;
        }
    }
}