using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using System.Web.Caching;


namespace WebApplication1.Controllers
{
    public class CategoryController : Controller
    {


        public ActionResult NewInventory()
        {

               var model = new InventoryModel
               {
                   ID = HttpContext.Application["ID"] as string,
                   Name = HttpContext.Application["Name"] as string,
                   Code = HttpContext.Application["Code"] as string,


                   ID2 = HttpContext.Application["ID2"] as string,
                   Name2 = HttpContext.Application["Name2"] as string,
                   Code2 = HttpContext.Application["Code2"] as string,

                    ID3 = HttpContext.Application["ID3"] as string,
                   Name3 = HttpContext.Application["Name3"] as string,
                   Code3 = HttpContext.Application["Code3"] as string

               };
              

           //  List<InventoryModel> MyList = new List<InventoryModel>();

        /*    List<InventoryModel> MyList = HttpContext.Application["list"] as List<InventoryModel>;

            InventoryModel model = new InventoryModel
                {
                    ID = MyList[0].ID,
                    Name = MyList[0].Name,
                    Code = MyList[0].Code

                };*/
            

           













            //  MyList = HttpContext.Application["Mylist"] as List<InventoryModel>;

            /*  var MyList = HttpContext.Application["ID"] as InventoryModel;






                var model = new InventoryModel
                {
                    ID = MyList.ID.ToString(),
                   Name = MyList.Name.ToString(),
                    Code = MyList.Code.ToString()

                };*/



            return View(model);
        }












        // GET: Category
        public ActionResult AddCategory()
        {

         



            return View();
        }

   


        [HttpGet]
        public ViewResult AddItems()
        {
            return View();
        }

        [HttpPost]
        public ViewResult AddItems(InventoryModel inventory)
        {
            if (ModelState.IsValid)
            {
                return View("../Inventory/Index", inventory);
            } else

                return View();


        }
    }


    }




