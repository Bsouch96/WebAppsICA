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
    public class EventController : Controller
    {
        private readonly EventsDbContext _context;

        public EventController(EventsDbContext context)
        {
            _context = context;
        }

        // GET: Event
        public async Task<IActionResult> Index()
        {
            return View(await _context.Events.ToListAsync());
        }

        // GET: Event/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @event = await _context.Events.Select(e => new Models.EventViewModel
            {
                EventID = e.Id,
                EventTitle = e.Title,
                Date = e.Date,
                Duration = e.Duration,
                TypeId = e.TypeId,
                NumberOfGuests = _context.Guests.Where(g => g.EventId == e.Id).Count(),
                NumberOfStaff = _context.Staffings.Where(g => g.StaffID == e.Id).Count(),

                Guests = _context.Guests.Where(g => g.EventId == e.Id).Select(g => new Models.GuestViewModel
                {
                    GuestID = g.Customer.Id,
                    FullName = g.Customer.FirstName + " " + g.Customer.Surname,
                    GuestEmail = g.Customer.Email,
                    Attended = g.Attended
                }),

                Staff = _context.Staffings.Where(g => g.EventID == e.Id).Select(g => new Models.StaffViewModel
                { 
                    StaffID = g.Staff.StaffID,
                    FullName = g.Staff.StaffFirstName + " " + g.Staff.StaffSurname,
                    StaffEmail = g.Staff.StaffEmail,
                    FirstAider = g.Staff.FirstAider
                })
               
            }).FirstOrDefaultAsync(m => m.EventID == id);

            var GuestList = _context.Guests.Where(g => g.EventId == @event.EventID);
            var StaffList = _context.Staffings.Where(g => g.EventID == @event.EventID);
            int guestCount = GuestList.Count();
            int staffCount = StaffList.Count();
            if (staffCount > 0 && staffCount >= (guestCount / 10))
            {
                @event.SufficientStaffMessage = "Sufficient Staff Present";
                @event.SufficientStaff = false;
            }
            else
            {
                @event.SufficientStaffMessage = "Insufficient Staff Present";
                @event.SufficientStaff = true;
            }

            if (StaffList.Where(f => f.Staff.FirstAider).Count() > 0)
            {
                @event.FirstAiderMessage = "First Aider Present";
                @event.FirstAiderPresent = false;
            }
            else
            {
                @event.FirstAiderMessage = "No First Aider Present";
                @event.FirstAiderPresent = true;
            }

            if (@event == null)
            {
                return NotFound();
            }

            if (@event == null)
            {
                return NotFound();
            }

            return View(@event);
        }

        // GET: Event/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Event/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Date,Duration,TypeId")] Event @event)
        {
            if (ModelState.IsValid)
            {
                _context.Add(@event);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(@event);
        }

        // GET: Event/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @event = await _context.Events.FindAsync(id);
            if (@event == null)
            {
                return NotFound();
            }
            return View(@event);
        }

        // POST: Event/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Date,Duration,TypeId")] Event @event)
        {   
            

            /*if (@event.Date != DBevent.Date)
            {
                return View(@event);
            }*/

            if (id != @event.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    //Variable DBevent created to access database based upon id given.
                    var @DBevent = await _context.Events.FindAsync(id);

                    //Assigning event date and event type to the same as the current DB values
                    //This is to further prevent changes being saved to a venue's date and type. See event/Edit for initial security.
                    DBevent.Title = @event.Title;
                    DBevent.Duration = @event.Duration;
                    _context.Update(DBevent);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EventExists(@event.Id))
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
            return View(@event);
        }

        // GET: Event/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @event = await _context.Events
                .FirstOrDefaultAsync(m => m.Id == id);
            if (@event == null)
            {
                return NotFound();
            }

            return View(@event);
        }

        // POST: Event/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var @event = await _context.Events.FindAsync(id);
            _context.Events.Remove(@event);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EventExists(int id)
        {
            return _context.Events.Any(e => e.Id == id);
        }
    }
}
