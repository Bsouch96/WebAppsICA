using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ThAmCo.Events.Data;

namespace ThAmCo.Events.Controllers
{
    public class StaffingController : Controller
    {
        private readonly EventsDbContext _context;

        public StaffingController(EventsDbContext context)
        {
            _context = context;
        }

        // GET: Staffing
        public async Task<IActionResult> Index()
        {
            var eventsDbContext = _context.Staffings.Include(s => s.Event).Include(s => s.Staff);
            return View(await eventsDbContext.ToListAsync());
        }

        // GET: Staffing/5
        public async Task<IActionResult> StaffingIndex(int? id)
        {
            //Grabs all Staff members relevant to the passed in eventID.
            var AvailableStaff = _context.Staffings.Include(s => s.Staff).Include(s => s.Event).Where(e => e.EventID == id);

            //Grabs all guests relevant to the passed in event id.
            //var eventsDbContext = _context.Guests.Include(g => g.Customer).Include(g => g.Event).Where(e => e.EventId == id);
            ViewBag.count = AvailableStaff.Count();
            return View("Index", await AvailableStaff.ToListAsync());
        }

        // GET: Staffing/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var staffing = await _context.Staffings
                .Include(s => s.Event)
                .Include(s => s.Staff)
                .FirstOrDefaultAsync(m => m.StaffID == id);
            if (staffing == null)
            {
                return NotFound();
            }

            return View(staffing);
        }

        // GET: Staffing/Create
        public IActionResult Create()
        {
            ViewData["EventID"] = new SelectList(_context.Events, "Id", "Title");
            ViewData["StaffID"] = new SelectList(_context.Staffs, "StaffID", "StaffEmail");
            return View();
        }

        // POST: Staffing/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EventID,StaffID")] Staffing staffing)
        {
            if (ModelState.IsValid)
            {
                _context.Add(staffing);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EventID"] = new SelectList(_context.Events, "Id", "Title", staffing.EventID);
            ViewData["StaffID"] = new SelectList(_context.Staffs, "StaffID", "StaffEmail", staffing.StaffID);
            return View(staffing);
        }

        // GET: Staffing/Edit/5
        public async Task<IActionResult> Edit(int? id, int? id1)
        {
            if (id == null)
            {
                return NotFound();
            }

            var staffing = await _context.Staffings.FirstOrDefaultAsync(s => s.StaffID == id && s.EventID == id1);
            if (staffing == null)
            {
                return NotFound();
            }
            ViewData["EventID"] = new SelectList(_context.Events, "Id", "Title", staffing.EventID);
            ViewData["StaffID"] = new SelectList(_context.Staffs, "StaffID", "StaffEmail", staffing.StaffID);
            return View(staffing);
        }

        // POST: Staffing/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EventID,StaffID")] Staffing staffing)
        {
            if (id != staffing.StaffID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(staffing);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StaffingExists(staffing.StaffID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["EventID"] = new SelectList(_context.Events, "Id", "Title", staffing.EventID);
            ViewData["StaffID"] = new SelectList(_context.Staffs, "StaffID", "StaffEmail", staffing.StaffID);
            return View(staffing);
        }

        // GET: Staffing/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var staffing = await _context.Staffings.Include(s => s.Event).Include(s => s.Staff).FirstOrDefaultAsync(m => m.StaffID == id);

            if (staffing == null)
            {
                return NotFound();
            }

            return View(staffing);
        }

        // POST: Staffing/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id, int eventId)
        {
            var staffing = await _context.Staffings.FirstOrDefaultAsync(s => s.StaffID == id && s.EventID == eventId);
            _context.Staffings.Remove(staffing);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StaffingExists(int id)
        {
            return _context.Staffings.Any(e => e.StaffID == id);
        }
    }
}
