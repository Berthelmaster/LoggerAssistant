using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LoggerAssistant.API.Data;
using LoggerAssistant.API.Model;

namespace LoggerAssistant.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public LogsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Logs/Accountkey
        [HttpGet("{key}")]
        public async Task<ActionResult<IEnumerable<Log>>> GetLogs(string key)
        {
            var findaccount = await _context.Accounts.Where(g => g.Token == key).FirstOrDefaultAsync();

            if(findaccount != null)
            {
                return await _context.Logs.Where(a => a.Account.Id == findaccount.Id).ToListAsync();
            }

            return NotFound();
        }

        // DELETE: api/Logs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Log>> DeleteLog(int id, string key)
        {
            var log = await _context.Logs.FindAsync(id);

            if(log.Account.Token != key)
            {
                return BadRequest();
            }

            if (log == null)
            {
                return NotFound();
            }

            _context.Logs.Remove(log);
            await _context.SaveChangesAsync();

            return Ok(log);
        }
    }
}
