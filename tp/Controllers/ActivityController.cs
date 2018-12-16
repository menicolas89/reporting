using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Reporting.Models;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace tp.Controllers
{
    [Route("api/[controller]")]
    public class ActivityController : Controller
    {
        private readonly ReportingContext _context;

        public ActivityController(ReportingContext context)
        {
            _context = context;

            //if (_context.Activities.Count() == 0)
            //{
                // Create a new TodoItem if collection is empty,
                // which means you can't delete all TodoItems.
            //    _context.Activities.Add(new Activity { Name = "Item1" });
            //    _context.SaveChanges();
            //}
        }
        // GET: api/Activity
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Activity>>> GetActivities()
        {
            return await _context.Activities.ToListAsync();
        }

        // GET: api/Activity/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Activity>> GetActivity(long id)
        {
            var activity = await _context.Activities.FindAsync(id);

            if (activity == null)
            {
                return NotFound();
            }

            return activity;
        }

    }
}
