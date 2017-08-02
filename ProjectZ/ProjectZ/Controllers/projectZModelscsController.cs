using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ProjectZ.Models;

namespace ProjectZ.Controllers
{
    public class projectZModelscsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/projectZModelscs
        public IQueryable<projectZModelscs> GetprojectZModelscs()
        {
            return db.projectZModelscs;
        }

        // GET: api/projectZModelscs/5
        [ResponseType(typeof(projectZModelscs))]
        public IHttpActionResult GetprojectZModelscs(int id)
        {
            projectZModelscs projectZModelscs = db.projectZModelscs.Find(id);
            if (projectZModelscs == null)
            {
                return NotFound();
            }

            return Ok(projectZModelscs);
        }

        // PUT: api/projectZModelscs/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutprojectZModelscs(int id, projectZModelscs projectZModelscs)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != projectZModelscs.Id)
            {
                return BadRequest();
            }

            db.Entry(projectZModelscs).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!projectZModelscsExists(id))
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

        // POST: api/projectZModelscs
        [ResponseType(typeof(projectZModelscs))]
        public IHttpActionResult PostprojectZModelscs(projectZModelscs projectZModelscs)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.projectZModelscs.Add(projectZModelscs);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = projectZModelscs.Id }, projectZModelscs);
        }

        // DELETE: api/projectZModelscs/5
        [ResponseType(typeof(projectZModelscs))]
        public IHttpActionResult DeleteprojectZModelscs(int id)
        {
            projectZModelscs projectZModelscs = db.projectZModelscs.Find(id);
            if (projectZModelscs == null)
            {
                return NotFound();
            }

            db.projectZModelscs.Remove(projectZModelscs);
            db.SaveChanges();

            return Ok(projectZModelscs);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool projectZModelscsExists(int id)
        {
            return db.projectZModelscs.Count(e => e.Id == id) > 0;
        }
    }
}