
using System.Linq;

namespace MvcApp.Controllers
{
    public class DatabaseDAL
    {
        private static USAStatesEntities ecEntity = new USAStatesEntities();

        public static IQueryable<State> GetAllStates()
        {
            return ecEntity.States;
        }

    }
}