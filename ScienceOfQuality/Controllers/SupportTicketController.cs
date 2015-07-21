using System.Drawing.Drawing2D;
using System.Linq;
using System.Web.Mvc;
using ScienceOfQuality.Models;

namespace ScienceOfQuality.Controllers
{
    public class SupportTicketController : Controller
    {
        // GET: SupportTicket
        public ActionResult Index()
        {
            return View();
        }

        // GET: SupportTicket/Details/5
        public ActionResult Details(int id)
        {
            SupportTicketModel sm = SoqData.Tickets.Find(f => f.Id == id);
            return View(sm);
        }

        // GET: SupportTicket/Create
        public ActionResult Create()
        {
            return View(new SupportTicketModel());
        }

        // POST: SupportTicket/Create
        [HttpPost]
        public ActionResult Create(SupportTicketModel model)
        {
            try
            {
                model.Id = SoqData.Tickets.Count + 1;
                SoqData.Tickets.Add(model);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SupportTicket/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                SupportTicketModel model = SoqData.Tickets.Find(f => f.Id == id);
                return View(model);
            }
            catch
            {
                return View();
            }
            
        }

        // POST: SupportTicket/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, SupportTicketModel model)
        {
            try{
                SoqData.Tickets[SoqData.Tickets.FindIndex(f => f.Id == model.Id)] = model;
                
                return View("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SupportTicket/Delete/5
        public ActionResult Delete(int id)
        {
            SoqData.Tickets.Remove(SoqData.Tickets.Find(f => f.Id == id));
            return RedirectToAction("Home");
        }

        
    }
}
