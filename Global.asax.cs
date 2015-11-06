using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using WebApplication1.Models;
using System.Web.Caching;


namespace WebApplication1
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

              List<InventoryModel> Equipments = new List<InventoryModel>();
               InventoryModel Eq1 = new InventoryModel
               {
                   ID = "1",
                   Code = "C0001",
                   Name = "Laptop Computer",
               };

               InventoryModel Eq2 = new InventoryModel
               {
                   ID = "2",
                   Code = "C0002",
                   Name = "DEsktop Computer",
               };

               InventoryModel Eq3 = new InventoryModel
               {
                   ID = "3",
                   Code = "P0003",
                   Name = "Printer ",
               };


               Equipments.Add(Eq1);
               Equipments.Add(Eq2);
               Equipments.Add(Eq3);

           Application["Mylist"] = Equipments;
           // HttpContext.Current.Cache["List"] = Equipments;



               Application["ID"] =" 1"; 
               Application["Name"] = "Computer";
               Application["Code"] = "P003";

               Application["ID2"] = "2";
               Application["Name2"] = "Laptoop";
               Application["Code2"] = "l006";

               Application["ID3"] = "3";
               Application["Name3"] = "Printer";
               Application["Code3"] = "C003";













            /*  Application["MyList"] = new List<InventoryModel>();

              ((List<InventoryModel>)Application["Mylist"]).Add(Eq1);

              InventoryModel Obj = ((List<InventoryModel>)Application["MyList"])[0];

            ((List<InventoryModel>)Application["Mylist"]).Add(Eq2);

            InventoryModel obj2 = ((List<InventoryModel>)Application["MyList"])[1];


            ((List<InventoryModel>)Application["Mylist"]).Add(Eq3);

            InventoryModel obj3 = ((List<InventoryModel>)Application["MyList"])[2];*/




            /*  if (Application["Equipments"] != null)
              {
                  InventoryModel Items = Application["Equipments"] as InventoryModel;
                  //String Name = Items.Name;
                  String Code = Items.Code;
                  int ID = Items.ID;
              }*/



















        }
    }
}
