using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBasic_clone.Controllers
{
    public class PassDataController : Controller
    {
        // GET: PassData
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PassViewBag() 
        {
            ViewBag.Nickname = "Mary";
            //ViewData["Nickname"] = "David";
            ViewBag.Height = 168;
            ViewBag.Weight = 50;
            ViewBag.Married = false;
            return View();
        }
        public ActionResult PassViewData()
        {
            ViewData["Name"] = "Kevin";     //儲存字串
            ViewData["Age"] = 33;         //儲存數字
            ViewData["Single"] = true;    //布林值
            return View();
        }

        public ActionResult PassTempData()
        {
            TempData["ErrorMessage"] = "無足夠權限存取系統資料,請聯絡系統管理人員";
            TempData["UserName"] = "David";
            TempData["Time"] = DateTime.Now.ToLongTimeString();
            return RedirectToAction("ErrorMessage", "ErrorHandler"); //轉向至另一個action
        }

        public ActionResult PetShop()
        {
            //1.使用ViewData傳遞資料到View
            ViewData["Company"] = "汪星人寵物店";

            //2.使用ViewBag傳遞資料到View
            ViewBag.Address = "台北市信義區松山路";

            //宣告一個List泛型集合,代表Model資料模型
            List<string> petList = new List<string>();
            petList.Add("狗");
            petList.Add("貓");
            petList.Add("鳥");
            petList.Add("烏龜");
            petList.Add("變色龍");

            //3.將petsList資料模型指派給ViewData.Modal屬性,傳遞到View
            ViewData.Model = petList;

            return View();

            //實際上傳送Modal物件給View,會更常使用View(petsList)語法取代
            //return View(petList);
        }
    }
}