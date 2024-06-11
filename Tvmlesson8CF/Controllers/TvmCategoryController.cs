using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tvmlesson8CF.Models;

namespace Tvmlesson8CF.Controllers
{
    public class TvmCategoryController : Controller
    {
        private static Tvmbookstore _Tvmbookstore;
        public TvmCategoryController()
        {
            _Tvmbookstore = new Tvmbookstore();
        }
        // GET: TvmCategory
        public ActionResult TvmIndex()
        {
            var tvmCategory = _Tvmbookstore.TvmCategory.ToList();
            return View(tvmCategory);
        }
        public ActionResult TvmCreate()
        {
            var tvmCategory = new TvmCategory();
            return View(tvmCategory);
        }
        [HttpPost]
        public ActionResult TvmCreate(TvmCategory tvmCategory)
        {
            _Tvmbookstore.TvmCategory.Add(tvmCategory);
            _Tvmbookstore.SaveChanges();
            return RedirectToAction("TvmIndex");
        }
    }
}