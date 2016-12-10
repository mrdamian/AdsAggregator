using AdsAggregatorDomain.DomainObjects;
using AdsAggregatorDomain.Repositories;
using AdsAggregatorWebPresentationModel.Models.StreetType;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace AdsAggregatorWebPresentationModel.Controllers
{
    public class StreetTypeController : Controller
    {
        private IStreetTypeRepository _streetTypeRepository;
        private ILanguageRepository _languageRepository;

        public StreetTypeController(IStreetTypeRepository streetTypeRepository, ILanguageRepository languageRepository)
        {
            _streetTypeRepository = streetTypeRepository;
            _languageRepository = languageRepository;
        }

        // GET: StreetType
        public ActionResult Index()
        {
            // TODO: get it from session or cookies
            int selectedLanguageId = 1;
            return GetStreetTypesByLanguage(selectedLanguageId);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(int languageId)
        {
            return GetStreetTypesByLanguage(languageId);
        }

        private ActionResult GetStreetTypesByLanguage(int languageId)
        {
            int selectedLanguageId = languageId;
            return View(new StreetTypeListViewModel(
                _streetTypeRepository.GetAll(selectedLanguageId).Select(c => new StreetTypeViewModel(c)),
                _languageRepository.GetAll(),
                selectedLanguageId));
        }

        // GET: StreetType/Details/5
        public ActionResult Details(int? id, int languageId)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var streetType = _streetTypeRepository.Find((int)id, languageId);
            if (streetType == null)
            {
                return HttpNotFound();
            }
            return View(new StreetTypeViewModel(streetType));
        }

        // GET: StreetType/Create
        public ActionResult Create()
        {
            return View(new StreetTypeEditViewModel(_languageRepository.GetAll()));
        }

        // POST: StreetType/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StreetTypeId, ShortName, FullName, LanguageId, OriginalLanguageId")] StreetTypeEditViewModel streetType)
        {
            if (ModelState.IsValid)
            {
                StreetType domainStreetType = new StreetType(
                    streetType.StreetTypeId, 
                    streetType.ShortName,
                    streetType.FullName, 
                    _languageRepository.Find(streetType.LanguageId));
                _streetTypeRepository.Insert(domainStreetType);
                return RedirectToAction("Index");
            }
            return View(streetType);
        }
    }
}
