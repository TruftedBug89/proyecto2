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
    public class usuarisController : ApiController
    {
        private frase_aluEntities db = new frase_aluEntities();

        // GET: api/usuaris
        public IQueryable<usuaris> Getusuaris()
        {
            db.Configuration.LazyLoadingEnabled = false;
            return db.usuaris;
        }

        // GET: api/usuaris/5
        [ResponseType(typeof(usuaris))]
        public async Task<IHttpActionResult> Getusuaris(int id)
        {
            IHttpActionResult result;
            db.Configuration.LazyLoadingEnabled = false;
            //usuaris _usuari = await db.usuaris.FindAsync(id);

            usuaris _usuari = await db.usuaris
                                //.Include("rols")
                                .Where(c => c.id == id)
                                .FirstOrDefaultAsync();

            if (_usuari == null)
            {
                result = NotFound();
            }
            else
            {
                result = Ok(_usuari);
            }

            return result;

        }

        [HttpGet]
        [Route("api/usuaris/nom/{nom}")]
        public async Task<IHttpActionResult> findBynom(String nom)
        {
            IHttpActionResult result;
            db.Configuration.LazyLoadingEnabled = false;

            List<usuaris> _usuaris = db.usuaris
                                        .Where(c => c.nom.Contains(nom))
                                        .ToList();

            return Ok(_usuaris);


        }
        // PUT: api/usuaris/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putusuaris(int id, usuaris _usuaris)
        {
            IHttpActionResult result;
            String missatge = "";
            if (!ModelState.IsValid)
            {
                result = BadRequest(ModelState);
            }
            else
            {
                if (id != _usuaris.id)
                {
                    result = BadRequest();
                }
                else
                {
                    db.Entry(_usuaris).State = EntityState.Modified;


                    try
                    {
                        await db.SaveChangesAsync();
                        result = StatusCode(HttpStatusCode.NoContent);
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!usuarisExists(id))
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

        // POST: api/usuaris
        [ResponseType(typeof(usuaris))]
        public async Task<IHttpActionResult> Postusuaris(usuaris _usuaris)
        {
            IHttpActionResult result;

            if (!ModelState.IsValid)
            {
                result = BadRequest(ModelState);
            }
            else
            {

                db.usuaris.Add(_usuaris);
                String missatge = "";

                try
                {
                    await db.SaveChangesAsync();
                    result = CreatedAtRoute("DefaultApi", new { id = _usuaris.id }, _usuaris);
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

        // DELETE: api/usuaris/5
        [ResponseType(typeof(usuaris))]
        public async Task<IHttpActionResult> Deleteusuaris(int id)
        {
            IHttpActionResult result;
            usuaris _usuaris = await db.usuaris.FindAsync(id);
            if (_usuaris == null)
            {
                result = NotFound();
            }
            else
            {
                String missatge = "";
                try
                {
                    db.usuaris.Remove(_usuaris);
                    await db.SaveChangesAsync();
                    result = Ok(_usuaris);
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

        private bool usuarisExists(int id)
        {
            return db.usuaris.Count(e => e.id == id) > 0;
        }
    }

}