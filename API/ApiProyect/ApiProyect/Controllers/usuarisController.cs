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
        public List<usuaris> Getusuaris()
        {
            db.Configuration.LazyLoadingEnabled = false;

            List<usuaris> _usuaris = db.usuaris.ToList();
           

            return _usuaris;


        }

        [HttpGet]
        [Route("api/usuaris/id/{id}")]
        public async Task<IHttpActionResult> findByIdGroup(int id)
        {
            IHttpActionResult result;
            db.Configuration.LazyLoadingEnabled = false;


      
            List<usuaris> person = (from usuaris in db.usuaris
                          join e in db.grups_has_alumnes
                          on usuaris.id equals e.usuaris_id
                          where e.grups_id == id
                          select usuaris).ToList();




            //List<usuaris> _usuaris = db.usuaris
            //                            .Where(c => c.nom.Contains(nom))
            //                            .ToList();

            return Ok(person);


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
                                .Include("grups_has_alumnes.grups")
                                .Include("grups_has_docents.grups")
                                //.Include("grups_has_alumnes.grups.grups_has_llistes_skills.llistes_skills.skills.kpis")
                                //.Include("grups_has_docents.grups.grups_has_llistes_skills.llistes_skills.skills.kpis")
                                .Include("valoracions")
                                .Include("valoracions1")
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

        //Filtrar Usuario Por Nombre de Usuario
        [HttpGet]
        [Route("api/usuaris/nom/{nom}")]
        public async Task<IHttpActionResult> findBynom(String nom)
        {
            IHttpActionResult result;
            db.Configuration.LazyLoadingEnabled = false;

            usuaris _usuari = await db.usuaris
                                .Include("rols")
                                .Include("grups_has_alumnes.grups")
                                .Include("grups_has_docents.grups")
                                //.Where(c => c.nom.Equals(nom))
                                .Where(c => c.nomUsuari.Equals(nom))
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