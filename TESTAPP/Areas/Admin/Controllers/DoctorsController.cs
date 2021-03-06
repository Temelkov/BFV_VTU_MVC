﻿using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TESTAPP.Data;
using TESTAPP.Models;

namespace TESTAPP.Areas.Admin.Doctors.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class DoctorsController : Controller
    {
        private readonly MvcDoctorContext _context;

        public DoctorsController(MvcDoctorContext context)
        {
            _context = context;
        }

        // GET: Doctors
        public async Task<IActionResult> Index(string searchString)
        {
            //TODO It's recommended to use "using" statement, also it would be more high-quality programming code if you use services for all business logic. Also you can use Repository pattern to decouple Db connection.
            var doctors = from d in _context.Doctor
                          select d;

            if (!String.IsNullOrEmpty(searchString))
            {
                doctors = doctors.Where(s => s.doctorFirstName.Contains(searchString));
            }

            return View(await doctors.ToListAsync());
        }

        // GET: Doctors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            //TODO Use SingleOrDefault. There is some differences between single and first. When searched data type of Id's (primary key/unique key column) it is more accurate to use SingleOrDefault- will generate query like "select * from users where userid = 1"             Select matching record, Throws exception if more than one records found. FirstOrDefault will generate query like "select top 1 * from users where userid = 1" Select first matching rows
            //When retrieve data from Db, you must use some DTO object (view model), https://docs.microsoft.com/en-us/aspnet/web-api/overview/data/using-web-api-with-entity-framework/part-5
            var doctor = await _context.Doctor
                .FirstOrDefaultAsync(m => m.doctor_id == id);
            if (doctor == null)
            {
                return NotFound();
            }

            return View(doctor);
        }

        // GET: Doctors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Doctors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.

        //TODO Here you can use View model "DoctorViewModel" for instance. 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("doctor_id,doctorFirstName,doctorMidName,doctorLastName,internship,speciality")] Doctor doctor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(doctor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(doctor);
        }

        // GET: Doctors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doctor = await _context.Doctor.FindAsync(id);
            if (doctor == null)
            {
                return NotFound();
            }
            return View(doctor);
        }

        // POST: Doctors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("doctor_id,doctorFirstName,doctorMidName,doctorLastName,internship,speciality")] Doctor doctor)
        {
            if (id != doctor.doctor_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(doctor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DoctorExists(doctor.doctor_id))
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
            return View(doctor);
        }

        // GET: Doctors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doctor = await _context.Doctor
                .FirstOrDefaultAsync(m => m.doctor_id == id);
            if (doctor == null)
            {
                return NotFound();
            }

            return View(doctor);
        }

        // POST: Doctors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var doctor = await _context.Doctor.FindAsync(id);
            _context.Doctor.Remove(doctor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DoctorExists(int id)
        {
            return _context.Doctor.Any(e => e.doctor_id == id);
        }
    }
}
