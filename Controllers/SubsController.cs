using Microsoft.AspNetCore.Mvc;
using WebProject.Data.Interfaces;
using WebProject.Data.Models;
using WebProject.ViewModels;

namespace WebProject.Controllers
{
    public class SubsController : Controller
    {
        private readonly IAllSubs _allSubs;

        public SubsController(IAllSubs iAllSubs)
        {
            _allSubs = iAllSubs;
        }

        public ViewResult Subs()
        {
            ViewBag.Title = "Sub-Manager";
            SubsViewModel obj = new SubsViewModel();
            obj.AllSubs = _allSubs.AllSubs;

            return View(obj);
        }
    }
}
