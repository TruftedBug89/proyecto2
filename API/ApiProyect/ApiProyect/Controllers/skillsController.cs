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
    public class skillsController : ApiController
    {
        private frase_aluEntities db = new frase_aluEntities();

        // GET: api/skills
        public IQueryable<skills> Getskills()
        {
            db.Configuration.LazyLoadingEnabled = false;
            return db.skills;
        }

        // GET: api/skills/5
        [ResponseType(typeof(skills))]
        public async Task<IHttpActionResult> Getskills(int id)
        {
            IHttpActionResult result;
            db.Configuration.LazyLoadingEnabled = false;
            skills skills = db.skills
                            .Include("Kpis")
                            .Where(c => c.id == id).FirstOrDefault();
            //skills skills = await db.skills.FindAsync(id);
            if (skills == null)
            {
                result = NotFound();
            }
            else {  
                result= Ok(skills);
            }

            return result;
        }

        // PUT: api/skills/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putskills(int id, skills skills)
        {
            IHttpActionResult result;
            String missatge = "";
            if (!ModelState.IsValid)
            {
                result = BadRequest(ModelState);
            }
            else
            {
                if (id != skills.id)
                {
                    result = BadRequest();
                }
                else
                {
                    db.Entry(skills).State = EntityState.Modified;

                    try
                    {
                        await db.SaveChangesAsync();
                        result = StatusCode(HttpStatusCode.NoContent);
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!skillsExists(id))
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

        // POST: api/skills
        [ResponseType(typeof(skills))]
        public async Task<IHttpActionResult> Postskills(skills skills)
        {
            IHttpActionResult result;
            if (!ModelState.IsValid)
            {
                result = BadRequest(ModelState);
            }
            else
            {
                db.skills.Add(skills);
                String missatge = "";
                try
                {
                    await db.SaveChangesAsync();
                    result = CreatedAtRoute("DefaultApi", new { id = skills.id }, skills);
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

        // DELETE: api/skills/5
        [ResponseType(typeof(skills))]
        public async Task<IHttpActionResult> Deleteskills(int id)
        {
            IHttpActionResult result;
            skills skills = await db.skills.FindAsync(id);
            if (skills == null)
            {
                result = NotFound();
            }
            else
            {
                String missatge = "";
                try
                {
                    db.skills.Remove(skills);
                    await db.SaveChangesAsync();
                    result = Ok(skills);
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

        private bool skillsExists(int id)
        {
            return db.skills.Count(e => e.id == id) > 0;
        }
    }
}