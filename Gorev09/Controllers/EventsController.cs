using EventTracker.Models;
using Microsoft.AspNetCore.Mvc;

namespace EventTracker.Controllers
{
    public class EventsController : Controller
    {
        private static List<EventModel> eventList = new()
        {
            new EventModel {Id = 1,
                            Title = "Musical: The Phantom of The Opera",
                            Description = "A dramatic tale of romance, passion, and mystery, follows the haunting story of a masked figure and his obsession with a talented young soprano, culminating in a poignant blend of emotion, music, and spectacle.",
                            Date = new DateTime(2024, 1, 25, 19, 0, 0)
                           },

            new EventModel {Id = 2,
                            Title = "Theatre: King Lear",
                            Description = "Depicting a once-great ruler's descent into madness, King Lear is one of the most powerful tragedies ever staged. ",
                            Date = new DateTime(2024, 2, 2, 20, 30, 0)
                           }
        };

        [HttpGet]
        public IActionResult List()
        {
            ViewBag.Events = eventList;
            return View();
        }

        [HttpGet("{id}")]
        public IActionResult Details(int id)
        {
            var eventModel = eventList.Find(x => x.Id == id);
            if (eventModel is null)
            {
                return NotFound();
            }
            ViewBag.Event = eventModel;
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var eventToEdit = eventList.FirstOrDefault(e => e.Id == id);
            ViewBag.Event = eventToEdit;
            return View();
        }

        [HttpPost]
        public IActionResult Create(EventModel eventModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            eventModel.Id = eventList.Max(e => e.Id) + 1;
            eventList.Add(eventModel);
            return RedirectToAction("List");
        }


        [HttpPost]
        public IActionResult Delete(int id)
        {
            var eventToDelete = eventList.FirstOrDefault(e => e.Id == id);
            if (eventToDelete is null)
            {
                return NotFound();
            }
            eventList.Remove(eventToDelete);
            return RedirectToAction("List");
        }

        [HttpPost]
        public IActionResult Edit(EventModel updatedEvent)
        {
            if (!ModelState.IsValid)
            {
                return View(updatedEvent);
            }
            var eventToEdit = eventList.FirstOrDefault(e => e.Id == updatedEvent.Id);
            if (eventToEdit is null)
            {
                return NotFound();
            }
            eventToEdit.Title = updatedEvent.Title;
            eventToEdit.Description = updatedEvent.Description;
            eventToEdit.Date = updatedEvent.Date;

            return RedirectToAction("List");
        }





    }
}
