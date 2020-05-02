using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BFV_VTU.Controllers
{
    public class WorkTimeController : Controller
    {
        public IActionResult Index()
        {

            var viewModel = new Models.WorkTime.WorkTimeViewModel
            {
                WorkDayOfWeek = new string[6] { "Moday: 08:00-19:00", "Tuesday: 08:00-19:00", "Wednesday: 08:00-19:00", "Thursday: 08:00-19:00",
                    "Friday: 08:00-19:00", "Saturday-Sunday: 09:00-13:00" }
            };

            ViewBag.WorkDayOfWeek = viewModel.WorkDayOfWeek;

            return View(viewModel);
        }
    }
}