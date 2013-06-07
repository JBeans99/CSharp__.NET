using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MvcApp.GridModels;

namespace MvcApp.Controllers
{
    public class HomeController : Controller
    {
        private USAStatesEntities usaEntity = new USAStatesEntities();

        [HttpGet]
        public ActionResult Index()
        {
            State model = new State();

            return View(model);
        }

        [HttpPost]
        public ActionResult GetStates(JqGridSettings gridSettings)
        {
            var states = DatabaseDAL.GetAllStates();
            var stateList = new List<State>();
            foreach (var state in states)
            {
                stateList.Add(state);
            }

            int totalPages;
            int totalRecords;
            var allStates = stateList.AsQueryable();

            var results = jqGridDataManager.GetGridData<State>(gridSettings, allStates, out totalPages, out totalRecords);
            JqGridResult result = new JqGridResult()
            {
                Page = gridSettings.PageIndex,
                Records = totalRecords,
                Total = totalPages,
                Rows = results.ToList()
            };

            return Json(result, JsonRequestBehavior.AllowGet);

        }

        public ActionResult SaveState(State state)
        {
            if (state.StateID == 0)
                usaEntity.States.Add(state);
            else
            {
                var existing = usaEntity.States.Find(state.StateID);
                if (!existing.Name.Equals(state.Name))
                    existing.Name = state.Name;
                if (existing.Abbreviation != null && !existing.Abbreviation.Equals(state.Abbreviation))
                    existing.Abbreviation = state.Abbreviation;
            }

            usaEntity.SaveChanges();
            return Content("true");
        }

        public ActionResult DeleteState(State state)
        {
            if (state.StateID != 0)
            {
                var existingState = usaEntity.States.Find(state.StateID);
                usaEntity.States.Remove(existingState);
            }

            usaEntity.SaveChanges();
            return Content("true");
        }

    }
}
