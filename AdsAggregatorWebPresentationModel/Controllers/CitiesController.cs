using System.Net;
using System.Web.Mvc;
using AdsAggregatorDomain.Repositories;
using AdsAggregatorWebPresentationModel.Models;
using System.Linq;
using AdsAggregatorDomain;

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
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var city = _cityRepository.Find((int)id);
            if (city == null)
            {
                return HttpNotFound();
            }
            return View(new CityViewModel(city));
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
            if (ModelState.IsValid)
            {
                City domainCity = new City(city.CityId, city.Name);
                _cityRepository.Insert(domainCity);
                return RedirectToAction("Index");
            }

            return View(city);
        }

        // GET: Cities/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var city = _cityRepository.Find((int)id);
            if (city == null)
            {
                return HttpNotFound();
            }
            return View(new CityViewModel(city));
        }

        // POST: Cities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CityId,Name")] CityViewModel city)
        {
            if (ModelState.IsValid)
            {
                var domainCity = _cityRepository.Find(city.CityId);
                domainCity.Name = city.Name;
                _cityRepository.Update(domainCity);
                return RedirectToAction("Index");
            }
            return View(city);
        }

        // GET: Cities/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var city = _cityRepository.Find((int)id);
            if (city == null)
            {
                return HttpNotFound();
            }
            return View(new CityViewModel(city));
        }

        // POST: Cities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var city = _cityRepository.Find(id);
            _cityRepository.Delete(city);
            return RedirectToAction("Index");
        }
    }
}
