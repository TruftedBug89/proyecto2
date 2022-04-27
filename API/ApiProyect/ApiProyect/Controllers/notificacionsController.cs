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
    public class notificacionsController : ApiController
    {
        private frase_aluEntities db = new frase_aluEntities();

        // GET: api/notificacions
        public IQueryable<notificacions> Getnotificacions()
        {
            db.Configuration.LazyLoadingEnabled = false;

            return db.notificacions
                .Include("usuaris");
        }

        // GET: api/notificacions/5
        [ResponseType(typeof(notificacions))]
        public async Task<IHttpActionResult> Getnotificacions(int id)
        {
            db.Configuration.LazyLoadingEnabled = false;
            notificacions notificacions = await db.notificacions.FindAsync(id);
            if (notificacions == null)
            {
                return NotFound();
            }

            return Ok(notificacions);
        }

        // PUT: api/notificacions/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putnotificacions(int id, notificacions notificacions)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != notificacions.id)
            {
                return BadRequest();
            }

            db.Entry(notificacions).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!notificacionsExists(id))
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

        // POST: api/notificacions
        [ResponseType(typeof(notificacions))]
        public async Task<IHttpActionResult> Postnotificacions(notificacions notificacions)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.notificacions.Add(notificacions);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = notificacions.id }, notificacions);
        }

        // DELETE: api/notificacions/5
        [ResponseType(typeof(notificacions))]
        public async Task<IHttpActionResult> Deletenotificacions(int id)
        {
            //notificacions notificacions = await db.notificacions.FindAsync(id);
            //if (notificacions == null)
            //{
            //    return NotFound();
            //}

            //db.notificacions.Remove(notificacions);
            //await db.SaveChangesAsync();

            //return Ok(notificacions);

            IHttpActionResult result;

            notificacions _notificacio = await db.notificacions.FindAsync(id);

            if (_notificacio == null)
            {
                result = NotFound();
            }
            else
            {
                String missatge = "";
                try
                {
                    db.notificacions.Remove(_notificacio);
                    await db.SaveChangesAsync();
                    result = Ok(_notificacio);
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

        private bool notificacionsExists(int id)
        {
            return db.notificacions.Count(e => e.id == id) > 0;
        }
    }
}