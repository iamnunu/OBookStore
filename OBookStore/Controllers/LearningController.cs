using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OBookStore.Models;
using X.PagedList;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OBookStore.Controllers
{

   
    public class LearningController : Controller
    {
        nuggetContext db = new nuggetContext();

        [HttpGet]
        public ActionResult Index(string sortOrder, string currentFilter, string searchString, int? page)
        {

            ViewBag.CurrentSort = sortOrder;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            
            var video = db.Video.Where(X=>X.Categories== currentFilter || currentFilter == null || currentFilter=="").ToList();

            var pageNumber = page ?? 1; // if no page was specified in the querystring, default to the first page (1)
            var onePageOfProducts = video.ToPagedList(pageNumber, 25); // will only contain 25 products max because of the pageSize

            ViewBag.OnePageOfProducts = onePageOfProducts;
            ViewBag.Categories = video.Select(x => x.Categories).Distinct().ToList();
            ViewBag.Tags = video.Select(x => x.Tags).Distinct().ToList();
            return View();

           
        }

        public ActionResult Books(int ID)
        {
            ViewBag.BookId = ID;

            
            return View();
        }


        public JsonResult GetPage(int Book)
        {
            string _bookPath = db.Video.Where(X => X.Id == Book).Select(X => X.Path).FirstOrDefault();
            var _data = System.IO.File.ReadAllLines(_bookPath);
            
            return Json(_data);
        }

        public JsonResult getIndexes(int? _pageID)
        {
            if (_pageID == null)
            {
                return Json("Error: Page ID is Null");
            }

            var result = db.BookPages.Where(x => x.Id == _pageID).FirstOrDefault();
            return Json(result);
        }


    }



}
