using System.Net;
using System.Web.Mvc;
using AdsAggregatorDomain.Repositories;
using AdsAggregatorWebPresentationModel.Models;
using System.Linq;
using System.Collections.Generic;

namespace AdsAggregatorWebPresentationModel.Controllers
{
    public class CitiesController : Controller
    {
        private ICityRepository _cityRepository;

        public CitiesController(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        // GET: Cities
        public ActionResult Index()
        {
            return View(_cityRepository.GetAll().Select(c => new CityViewModel(c)));
        }

        // GET: Cities/Details/5
        public ActionResult Details(int? id)
        {
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            //City city = db.Cities.Find(id);
            //if (city == null)
            //{
            //    return HttpNotFound();
            //}
            //return View(city);
            return View("test");
        }

        // GET: Cities/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CityId,Name")] CityViewModel city)
        {
            //if (ModelState.IsValid)
            //{
            //    db.Cities.Add(city);
            //    db.SaveChanges();
            //    return RedirectToAction("Index");
            //}

            //return View(city);
            return View("test");
        }

        // GET: Cities/Edit/5
        public ActionResult Edit(int? id)
        {
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            //City city = db.Cities.Find(id);
            //if (city == null)
            //{
            //    return HttpNotFound();
            //}
            //return View(city);
            return View("test");
        }

        // POST: Cities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CityId,Name")] CityViewModel city)
        {
            //if (ModelState.IsValid)
            //{
            //    db.Entry(city).State = EntityState.Modified;
            //    db.SaveChanges();
            //    return RedirectToAction("Index");
            //}
            //return View(city);
            return View("test");
        }

        // GET: Cities/Delete/5
        public ActionResult Delete(int? id)
        {
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            //City city = db.Cities.Find(id);
            //if (city == null)
            //{
            //    return HttpNotFound();
            //}
            //return View(city);
            return View("test");
        }

        // POST: Cities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //City city = db.Cities.Find(id);
            //db.Cities.Remove(city);
            //db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
