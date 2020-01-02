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
    public class GuestBookingController : Controller
    {
        private readonly EventsDbContext _context;

        public GuestBookingController(EventsDbContext context)
        {
            _context = context;
        }

        // GET: GuestBooking
        public async Task<IActionResult> Index()
        {
            var eventsDbContext = _context.Guests.Include(g => g.Customer).Include(g => g.Event);
            return View(await eventsDbContext.ToListAsync());
        }

        // GET: GuestBooking
        public async Task<IActionResult> EventIndex(int? id)
        {
            //Grabs all guests relevant to the passed in event id.
            var eventsDbContext = _context.Guests.Include(g => g.Customer).Include(g => g.Event).Where(e => e.EventId == id);
            ViewBag.count = eventsDbContext.Count();
            return View(await eventsDbContext.ToListAsync());
        }

        // GET: GuestBooking/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var guestBooking = await _context.Guests
                .Include(g => g.Customer)
                .Include(g => g.Event)
                .FirstOrDefaultAsync(m => m.CustomerId == id);
            if (guestBooking == null)
            {
                return NotFound();
            }

            return View(guestBooking);
        }

        // GET: GuestBooking/Create
        public IActionResult Create(int? eventID)
        {
            if(eventID == null)
            {
                return BadRequest();
            }

            //Grab all current guests and add to a list.
            var listGuests = _context.Customers.ToList();
            var attendingGuests = _context.Guests.Where(a => a.EventId == eventID).ToList();
            //Remove all gueststhat are already attending selected event.
            listGuests.RemoveAll(r => attendingGuests.Any(a => a.CustomerId == r.Id));
            //Grab all current events
            var listEvents = _context.Events.ToList();
            var currentEvents = _context.Guests.Where(e => e.EventId == eventID).ToList();
            //Remove all but the selected event
            listEvents.RemoveAll(s => currentEvents.Any(e => e.EventId != s.Id));
            //Display only non attending guests and the selected event.
            ViewData["CustomerId"] = new SelectList(listGuests, "Id", "Email");
            ViewData["EventId"] = new SelectList(listEvents, "Id", "Title");

            var selectedEvent = _context.Events.Find(eventID);
            if(selectedEvent == null)
            {
                return BadRequest();
            }

            ViewData["Title"] = selectedEvent.Title;

            return View();
        }

        // POST: GuestBooking/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerId,EventId,Attended")] GuestBooking guestBooking)
        {
            if (ModelState.IsValid)
            {
                _context.Add(guestBooking);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Email", guestBooking.CustomerId);
            ViewData["EventId"] = new SelectList(_context.Events, "Id", "Title", guestBooking.EventId);
            return View(guestBooking);
        }

        // GET: GuestBooking/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var guestBooking = await _context.Guests.FindAsync(id);
            if (guestBooking == null)
            {
                return NotFound();
            }
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Email", guestBooking.CustomerId);
            ViewData["EventId"] = new SelectList(_context.Events, "Id", "Title", guestBooking.EventId);
            return View(guestBooking);
        }

        // POST: GuestBooking/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CustomerId,EventId,Attended")] GuestBooking guestBooking)
        {
            if (id != guestBooking.CustomerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(guestBooking);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GuestBookingExists(guestBooking.CustomerId))
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
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Email", guestBooking.CustomerId);
            ViewData["EventId"] = new SelectList(_context.Events, "Id", "Title", guestBooking.EventId);
            return View(guestBooking);
        }

        // GET: GuestBooking/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var guestBooking = await _context.Guests
                .Include(g => g.Customer)
                .Include(g => g.Event)
                .FirstOrDefaultAsync(m => m.CustomerId == id);
            if (guestBooking == null)
            {
                return NotFound();
            }

            return View(guestBooking);
        }

        public async Task<IActionResult> DeleteCustomerBooking(int eId, int cId)
        {
            var guestBooking = await _context.Guests
                .Include(g => g.Customer)
                .Include(g => g.Event)
                .FirstOrDefaultAsync(m => m.CustomerId == cId && m.EventId == eId);
            if (guestBooking == null)
            {
                return NotFound();
            }

            return View("Delete", guestBooking);
        }

        // POST: GuestBooking/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int BookingId)
        {
            var guestBooking = await _context.Guests.FirstOrDefaultAsync(b => b.BookingId == BookingId);
            _context.Guests.Remove(guestBooking);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GuestBookingExists(int id)
        {
            return _context.Guests.Any(e => e.CustomerId == id);
        }
    }
}
