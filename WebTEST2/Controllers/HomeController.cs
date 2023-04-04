using Azure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebTEST2.Models;
using X.PagedList;

namespace WebTEST2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
		private QlbongDaContext db = new QlbongDaContext();
		public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var listcauthu = db.Cauthus.OrderBy(x=>x.HoVaTen).ToList();
            return View(listcauthu);
        }
        public IActionResult ShowSanPham(string maDt, int? page)
        {
            return View();
        }
        public IActionResult ChiTietSP(string MaSP)
        {
            return View();
        }
        [Route("ThemCauThu")]
        [HttpGet]
        public IActionResult ThemCauThu()
        {
            ViewBag.CauLacBoId = new SelectList(db.Caulacbos.OrderBy(x => x.TenClb), "CauLacBoId", "TenClb");
            return View();
        }
        [Route("ThemCauThu")]
        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult ThemCauThu(Cauthu cauthu)
        {
            ViewBag.CauLacBoId = new SelectList(db.Caulacbos.OrderBy(x => x.TenClb), "CauLacBoId", "TenClb");
            if (ModelState.IsValid)
            {
                db.Cauthus.Add(cauthu);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cauthu);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}