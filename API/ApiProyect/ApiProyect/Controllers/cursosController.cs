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
            db.Configuration.LazyLoadingEnabled = false;
            cursos cursos = await db.cursos.FindAsync(id);
            if (cursos == null)
            {
                return NotFound();
            }

            return Ok(cursos);
        }

        // PUT: api/cursos/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putcursos(int id, cursos cursos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cursos.id)
            {
                return BadRequest();
            }

            db.Entry(cursos).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!cursosExists(id))
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

        // POST: api/cursos
        [ResponseType(typeof(cursos))]
        public async Task<IHttpActionResult> Postcursos(cursos cursos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.cursos.Add(cursos);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = cursos.id }, cursos);
        }

        // DELETE: api/cursos/5
        [ResponseType(typeof(cursos))]
        public async Task<IHttpActionResult> Deletecursos(int id)
        {
            cursos cursos = await db.cursos.FindAsync(id);
            if (cursos == null)
            {
                return NotFound();
            }

            db.cursos.Remove(cursos);
            await db.SaveChangesAsync();

            return Ok(cursos);
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