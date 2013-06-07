using System;
using System.Linq;
using System.Web.Mvc;
using MvcApp.AjaxResponses;
using MvcApp.GridModels;
using MvcApp.Models;

namespace MvcApp.Controllers
{
    public class HomeController : Controller
    {
        private SportsStoreEntities db = new SportsStoreEntities();

        [HttpGet]
        public ActionResult Index()
        {
            //CountryModel model=new CountryModel();
            ProductModel model = new ProductModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult GetCustomers(JqGridSettings gridSettings)
        {
            int totalPages;
            int totalRecords;
            var allProducts = DatabaseDAL.GetAllProductModels();

            var results =
                jqGridDataManager.GetGridData<ProductModel>(gridSettings,
                                                            allProducts,
                                                            out totalPages,
                                                            out totalRecords);
            JqGridResult result = new JqGridResult()
            {
                Page = gridSettings.PageIndex,
                Records = totalRecords,
                Total = totalPages,
                Rows = results.ToList()
            };

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public JsonResult PostInput_Ajax(int productId)
        {
            var response = new DefaultAjaxResponse();

            try
            {
                response.AddFeedback(DefaultAjaxResponse.AjaxResponseStatusType.Success,
                    GetSuccessInputResponse(productId));
                return Json(response);
            }
            catch (Exception)
            {
                response.AddFeedback(DefaultAjaxResponse.AjaxResponseStatusType.Error, "Input was failed! ");
                return Json(response);
            }
        }

        private string GetSuccessInputResponse(int productId)
        {
            Product selectedProduct = DatabaseDAL.GetProductByProductID(productId);
            return string.Format("This product is added to cart: {0}; {1}; {2:C}",
                selectedProduct.Name, selectedProduct.Description, selectedProduct.Price);
        }

    }
}
