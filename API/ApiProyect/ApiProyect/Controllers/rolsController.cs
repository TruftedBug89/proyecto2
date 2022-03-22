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
    public class rolsController : ApiController
    {
        private frase_aluEntities db = new frase_aluEntities();

        // GET: api/rols
        public IQueryable<rols> Getrols()
        {
            db.Configuration.LazyLoadingEnabled = false;
            return db.rols;
        }

        // GET: api/rols/5
        [ResponseType(typeof(rols))]
        public async Task<IHttpActionResult> Getrols(int id)
        {
            IHttpActionResult result;
            db.Configuration.LazyLoadingEnabled = false;
           
            rols _rols = await db.rols
                                .Include("nom")
                                .Where(c => c.id == id)
                                .FirstOrDefaultAsync();
            if (_rols == null)
            {
                result = NotFound();
            }
            else
            {
                result = Ok(_rols);
            }
            return result;
        }


        [HttpGet]
        [Route("api/rols/nom/{nom}")]
        public async Task<IHttpActionResult> Findnom(String nom)
        {
            IHttpActionResult result;
            db.Configuration.LazyLoadingEnabled = false;

            List<rols> _rols = db.rols
                              .Where(c => c.nom.Contains(nom))
                              .ToList();

            return Ok(_rols);


        }

        // PUT: api/rols/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putrols(int id, rols _rols)
        {
            IHttpActionResult result;
            String missatge = "";
            if (!ModelState.IsValid)
            {
                result = BadRequest(ModelState);
            }
            else
            {
                if (id != _rols.id)
                {
                    result = BadRequest();
                }
                else
                {
                    db.Entry(_rols).State = EntityState.Modified;


                    try
                    {
                        await db.SaveChangesAsync();
                        result = StatusCode(HttpStatusCode.NoContent);
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!rolsExists(id))
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

                        throw;
                    }
                }

            }


            return result;
        }

        // POST: api/rols
        [ResponseType(typeof(rols))]
        public async Task<IHttpActionResult> Postrols(rols _rols)
        {
            IHttpActionResult result;

            if (!ModelState.IsValid)
            {
                result = BadRequest(ModelState);
            }
            else
            {

                db.rols.Add(_rols);
                String missatge = "";

                try
                {
                    await db.SaveChangesAsync();
                    result = CreatedAtRoute("DefaultApi", new { id = _rols.id }, _rols);
                }
                catch (DbUpdateException ex)
                {
                    SqlException sqlException = (SqlException)ex.InnerException.InnerException;
                    missatge = Clases.Error.MissatgeError(sqlException);
                    result = BadRequest(missatge);

                    throw;
                }
            }
            return result;
        }

        // DELETE: api/rols/5
        [ResponseType(typeof(rols))]
        public async Task<IHttpActionResult> Deleterols(int id)
        {
            IHttpActionResult result;
            rols _rols = await db.rols.FindAsync(id);
            if (_rols == null)
            {
                result = NotFound();
            }
            else
            {
                String missatge = "";
                try
                {
                    db.rols.Remove(_rols);
                    await db.SaveChangesAsync();
                    result = Ok(_rols);
                }
                catch (DbUpdateException ex)
                {
                    SqlException sqlException = (SqlException)ex.InnerException.InnerException;
                    missatge = Clases.Error.MissatgeError(sqlException);
                    result = BadRequest(missatge);

                    throw;
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

        private bool rolsExists(int id)
        {
            return db.rols.Count(e => e.id == id) > 0;
        }
    }
}