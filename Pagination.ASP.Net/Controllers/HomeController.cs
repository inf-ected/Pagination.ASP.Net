using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Pagination.ASP.Net.Models;

namespace Pagination.ASP.Net.Controllers
{
    public class HomeController : Controller
    {
        MobileContext db = new MobileContext();

        public ActionResult Index(int page = 1)
        {
            int pageSize = 3;
            // получаем нужные объекты из дб
            IEnumerable<Phone> phonesPerPage = db.Phones
                .OrderBy(x => x.Id) //нужэжен для Skip
                .Skip((page - 1) * pageSize)    // пропускает вначале ненужные
                .Take(pageSize) // берет количество которое помещается на 1 странице
                .ToList();
            PageInfo pageInfo = new PageInfo { PageNumber = page, PageSize = pageSize, TotalItems = db.Phones.Count() };
            IndexViewModel indexView = new IndexViewModel { PageInfo = pageInfo, Phones = phonesPerPage };
            return View(indexView);
        }


        public string Dump(int page = 1)
        {
            int pageSize = 3;
            // получаем нужные объекты из дб
            IEnumerable<Phone> phonesPerPage = db.Phones
                .OrderBy(x => x.Id) //нужэжен для Skip
                .Skip((page - 1) * pageSize)    // пропускает вначале ненужные
                .Take(pageSize) // берет количество которое помещается на 1 странице
                .ToList();
            PageInfo pageInfo = new PageInfo { PageNumber = page, PageSize = pageSize, TotalItems = db.Phones.Count() };
            IndexViewModel indexView = new IndexViewModel { PageInfo = pageInfo, Phones = phonesPerPage };
            return JsonConvert.SerializeObject(indexView);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}