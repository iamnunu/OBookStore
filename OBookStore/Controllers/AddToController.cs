using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using OBookStore.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OBookStore.Controllers
{


    public class AddToController : Controller
    {
        nuggetContext db = new nuggetContext();
        
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult AddPage()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult AddBook()
        {

            return View();
        }

        public JsonResult AddPage2()
        {

            return Json("Page not added Successfully");
        }

        public JsonResult AddContent()
        {

            return Json("Page not added Successfully");
        }

        public JsonResult AddSignoff()
        {

            return Json("Page not added Successfully");
        }

        public IActionResult AddVideo()
        {

            return View();
        }

        public JsonResult AddVideoRow(Video video)
        {
            if (video.Equals(null))
            {
                return Json("No Data Inserted");
            }

            /*Insert Video into Azure Storage*/
            video.Thumbnail = "Azure Location";


            try
            {
                video.CreationDate = DateTime.Now;
                video.CreationSource = "Admin";

                db.Video.Add(video);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }

            return Json("Video Added "+video.Name);
        }

       
    }
}
