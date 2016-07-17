using System.Net;
using System.Web.Mvc;
using AdsAggregatorDomain.Repositories;
using AdsAggregatorWebPresentationModel.Models;
using System.Linq;
using AdsAggregatorDomain;

namespace AdsAggregatorWebPresentationModel.Controllers
{
    public class DistrictsController : Controller
    {
        private IDistrictRepository _districtRepository;
        private ICityRepository _cityRepository;

        public DistrictsController(IDistrictRepository districtRepository, ICityRepository cityRepository)
        {
            _districtRepository = districtRepository;
            _cityRepository = cityRepository;
        }

        // GET: Districts
        public ActionResult Index()
        {
            return View(_districtRepository.GetAll().Select(c => new DistrictViewModel(c)));
        }

        // GET: Districts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var district = _districtRepository.Find((int)id);
            if (district == null)
            {
                return HttpNotFound();
            }
            return View(new DistrictDetailsViewModel(district));
        }

        // GET: Districts/Create
        public ActionResult Create()
        {
            return View(new DistrictEditViewModel(_cityRepository.GetAll()));
        }

        // POST: Districts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DistrictId, CityId,Name")] DistrictEditViewModel district)
        {
            if (ModelState.IsValid)
            {
                District domainDistrict = new District(district.DistrictId, district.Name, _cityRepository.Find(district.CityId));
                _districtRepository.Insert(domainDistrict);
                return RedirectToAction("Index");
            }
            return View(district);
        }

        // GET: Districts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var district = _districtRepository.Find((int)id);
            if (district == null)
            {
                return HttpNotFound();
            }
            return View(new DistrictEditViewModel(_cityRepository.GetAll(), district));
        }

        // POST: Districts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DistrictId,CityId,Name")] DistrictEditViewModel district)
        {
            if (ModelState.IsValid)
            {
                var domainDistrict = _districtRepository.Find(district.DistrictId);
                domainDistrict.Name = district.Name;
                domainDistrict.City = _cityRepository.Find(district.CityId);
                _districtRepository.Update(domainDistrict);
                return RedirectToAction("Index");
            }
            return View(district);
        }

        // GET: Districts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var district = _districtRepository.Find((int)id);
            if (district == null)
            {
                return HttpNotFound();
            }
            return View(new DistrictDetailsViewModel(district));
        }

        // POST: Districts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var district = _districtRepository.Find(id);
            _districtRepository.Delete(district);
            return RedirectToAction("Index");
        }
    }
}
