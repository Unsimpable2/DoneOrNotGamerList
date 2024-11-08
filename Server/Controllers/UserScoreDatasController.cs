using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Server.Context;
using Server.Models;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserScoreDatasController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public UserScoreDatasController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: api/UserScoreDatas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserScoreData>>> GetUserScoreData()
        {
            return await _context.UserScoreData.ToListAsync();
        }

        // GET: api/UserScoreDatas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserScoreData>> GetUserScoreData(int id)
        {
            var userScoreData = await _context.UserScoreData.FindAsync(id);

            if (userScoreData == null)
            {
                return NotFound();
            }

            return userScoreData;
        }

        // PUT: api/UserScoreDatas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserScoreData(int id, UserScoreData userScoreData)
        {
            if (id != userScoreData.ScoreId)
            {
                return BadRequest();
            }

            _context.Entry(userScoreData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserScoreDataExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/UserScoreDatas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UserScoreData>> PostUserScoreData(UserScoreData userScoreData)
        {
            _context.UserScoreData.Add(userScoreData);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserScoreData", new { id = userScoreData.ScoreId }, userScoreData);
        }

        // DELETE: api/UserScoreDatas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserScoreData(int id)
        {
            var userScoreData = await _context.UserScoreData.FindAsync(id);
            if (userScoreData == null)
            {
                return NotFound();
            }

            _context.UserScoreData.Remove(userScoreData);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserScoreDataExists(int id)
        {
            return _context.UserScoreData.Any(e => e.ScoreId == id);
        }
    }
}
