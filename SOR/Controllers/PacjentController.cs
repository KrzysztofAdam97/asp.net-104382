using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SOR.Models;
using SOR.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOR.Controllers
{
    public class PacjentController : Controller
    {
        private readonly IPacjentRepository _pacjentRepository;

        public PacjentController(IPacjentRepository pacjentRepository)
        {
            _pacjentRepository = pacjentRepository;
        }
     

        // GET: Pacjent
        public ActionResult Index()
        {
            return View(_pacjentRepository.GetAllActive());
        }

        // GET: Pacjent/Details/5
        public ActionResult Details(int id)
        {
            return View(_pacjentRepository.Get(id));
        }

        // GET: Pacjent/Create
        public ActionResult Create()
        {
            return View(new PacjentModel());
        }

        // POST: Pacjent/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PacjentModel pacjentModel)
        {
            _pacjentRepository.Add(pacjentModel);

            return RedirectToAction(nameof(Index));
        }

        // GET: Pacjent/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_pacjentRepository.Get(id));
        }

        // POST: Pacjent/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, PacjentModel pacjentModel)
        {
            _pacjentRepository.Update(id, pacjentModel);

            return RedirectToAction(nameof(Index));
        }

        // GET: Pacjent/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_pacjentRepository.Get(id));
        }

        // POST: Pacjent/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, PacjentModel pacjentModel)
        {
            _pacjentRepository.Delete(id);

            return RedirectToAction(nameof(Index));
        }

        // GET: Pacjent/Szpital/5
        public ActionResult Szpital(int id)
        {
            PacjentModel pacjent = _pacjentRepository.Get(id);
            pacjent.Szpital = true;
            _pacjentRepository.Update(id, pacjent);

            return RedirectToAction(nameof(Index));
        }
    }
}
