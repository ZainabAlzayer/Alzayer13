using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class InventoryController : Controller
    {
        // GET: Inventory
       
        public ActionResult Index()
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






            return View(model);



        }

        public ActionResult LaptopIndex()
        {
            List<InventoryModel> Laptops = new List<InventoryModel>();
            InventoryModel Eq1 = new InventoryModel
            {
                ID = "1",
                Code = "C0001",
                Name = "Laptop Computer",
                Description = "Dell XPS 13 Laptop",
            };

            Laptops.Add(Eq1);

            return View(Laptops);
        }


        public ActionResult ComputerIndex()
        {
            List<InventoryModel> Desktop = new List<InventoryModel>();
            InventoryModel Eq1 = new InventoryModel
            {
                ID = "2",
                Code = "C0002",
                Name = "Desktop Computer",
                Description = "Dell Inspiron 3000 i3646-2600BLK Desktop Computer ",
            };

            Desktop.Add(Eq1);

            return View(Desktop);
        }

        public ActionResult PrinterIndex()
        {
            List<InventoryModel> Printers = new List<InventoryModel>();
            InventoryModel Eq1 = new InventoryModel
            {
                ID = "3",
                Code = "P0003",
                Name = "Printers",
                Description = "Xerox WorkCentre 3215/NI Wireless Mono Laser Multifunction ",
            };

            Printers.Add(Eq1);

            return View(Printers);
        }











    }
}