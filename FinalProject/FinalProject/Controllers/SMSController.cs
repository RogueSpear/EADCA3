using System;
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
using FinalProject.Models;

namespace FinalProject.Controllers
{
    public class SMSController : ApiController
    {
        private UserDbContext db = new UserDbContext();

        // GET: api/SMS
        public IQueryable<SMS> GetSMS()
        {
            return db.SMS;
        }

        // GET: api/SMS/5
        [ResponseType(typeof(SMS))]
        public async Task<IHttpActionResult> GetSMS(int id)
        {
            SMS sMS = await db.SMS.FindAsync(id);
            if (sMS == null)
            {
                return NotFound();
            }

            return Ok(sMS);
        }

        // PUT: api/SMS/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutSMS(int id, SMS sMS)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sMS.ID)
            {
                return BadRequest();
            }

            db.Entry(sMS).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SMSExists(id))
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

        // POST: api/SMS
        [ResponseType(typeof(SMS))]
        public async Task<IHttpActionResult> PostSMS(SMS sMS)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.SMS.Add(sMS);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = sMS.ID }, sMS);
        }

        // DELETE: api/SMS/5
        [ResponseType(typeof(SMS))]
        public async Task<IHttpActionResult> DeleteSMS(int id)
        {
            SMS sMS = await db.SMS.FindAsync(id);
            if (sMS == null)
            {
                return NotFound();
            }

            db.SMS.Remove(sMS);
            await db.SaveChangesAsync();

            return Ok(sMS);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SMSExists(int id)
        {
            return db.SMS.Count(e => e.ID == id) > 0;
        }
    }
}