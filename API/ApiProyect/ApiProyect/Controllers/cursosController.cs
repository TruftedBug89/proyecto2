using System;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using ApiProyect.Models;

namespace ApiProyect.Controllers
{
    public class cursosController : ApiController
    {
        private frase_aluEntities db = new frase_aluEntities();

        // GET: api/cursos
        public IQueryable<cursos> Getcursos()
        {
            db.Configuration.LazyLoadingEnabled = false;
            return db.cursos;
        }

        // GET: api/cursos/5
        [ResponseType(typeof(cursos))]
        public async Task<IHttpActionResult> Getcursos(int id)
        {
            IHttpActionResult result;
            db.Configuration.LazyLoadingEnabled = false;
            cursos cursos = db.cursos.Where(c => c.id == id).FirstOrDefault();
            //cursos cursos = await db.cursos.FindAsync(id);
            if (cursos == null)
            {
                result = NotFound();
            }
            else
            {
                result = Ok(cursos);
            }

            return result;
        }

        // PUT: api/cursos/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putcursos(int id, cursos cursos)
        {
            IHttpActionResult result;
            String missatge = "";
            if (!ModelState.IsValid)
            {
                result = BadRequest(ModelState);
            }
            else
            {
                if (id != cursos.id)
                {
                    result = BadRequest();
                }
                else
                {
                    db.Entry(cursos).State = EntityState.Modified;

                    try
                    {
                        await db.SaveChangesAsync();
                        result = StatusCode(HttpStatusCode.NoContent);
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!cursosExists(id))
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

        // POST: api/cursos
        [ResponseType(typeof(cursos))]
        public async Task<IHttpActionResult> Postcursos(cursos cursos)
        {
            IHttpActionResult result;
            if (!ModelState.IsValid)
            {
                result = BadRequest(ModelState);
            }
            else
            {
                db.cursos.Add(cursos);
                String missatge = "";
                try
                {
                    await db.SaveChangesAsync();
                    result = CreatedAtRoute("DefaultApi", new { id = cursos.id }, cursos);
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

        // DELETE: api/cursos/5
        [ResponseType(typeof(cursos))]
        public async Task<IHttpActionResult> Deletecursos(int id)
        {
            IHttpActionResult result;
            cursos cursos = await db.cursos.FindAsync(id);
            if (cursos == null)
            {
                result =  NotFound();
            }
            else
            {
                String missatge = "";
                try
                {
                    db.cursos.Remove(cursos);
                    await db.SaveChangesAsync();
                    result = Ok(cursos);
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

        private bool cursosExists(int id)
        {
            return db.cursos.Count(e => e.id == id) > 0;
        }
    }
}