using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using OBookStore.Models;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.File;
using System.IO;
using Microsoft.AspNetCore.Http;

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


        public static async Task AzureStorageFileOperation()
        {
            const string DemoShare = "";
            const string DemoDirectory = "";
            const string ImageToUpload = "";


            
        }

        public JsonResult AddPageContent(string Content)
        {

            string filename = "";
            string path = "";

            try
            {
                 filename = System.DateTime.Now.ToString().Replace("/", "").Replace(":", "").ToString() + ".html";
                 path = @"FileShare/";
               
                System.IO.File.WriteAllText(path + filename, Content);
                

            }catch(Exception ex)
            {
                return Json(ex.Message);
            }

            return Json(path + filename);
        }

        public JsonResult AddPagetoTable(IFormCollection formCollection, int id)
        {

            try
            {
                Video video = new Video();
                video.Name = formCollection["NAME"];
                video.Object = Int32.Parse(formCollection["OBJECT"]);
                video.Caption = formCollection["CAPTION"];
                video.Path = formCollection["THUMBNAIL"];
                video.Tags = formCollection["TAGS"];
                video.Thumbnail = formCollection["CATEGORIES"];
                video.CreationDate = System.DateTime.Now;
                video.CreationSource = "Admin";
                db.Video.Add(video);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }

            return Json("success");
        }




    }
}
