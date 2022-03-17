﻿using System;
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
            db.Configuration.LazyLoadingEnabled = false;
            skills skills = await db.skills.FindAsync(id);
            if (skills == null)
            {
                return NotFound();
            }

            return Ok(skills);
        }

        // PUT: api/skills/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putskills(int id, skills skills)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != skills.id)
            {
                return BadRequest();
            }

            db.Entry(skills).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!skillsExists(id))
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

        // POST: api/skills
        [ResponseType(typeof(skills))]
        public async Task<IHttpActionResult> Postskills(skills skills)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.skills.Add(skills);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = skills.id }, skills);
        }

        // DELETE: api/skills/5
        [ResponseType(typeof(skills))]
        public async Task<IHttpActionResult> Deleteskills(int id)
        {
            skills skills = await db.skills.FindAsync(id);
            if (skills == null)
            {
                return NotFound();
            }

            db.skills.Remove(skills);
            await db.SaveChangesAsync();

            return Ok(skills);
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