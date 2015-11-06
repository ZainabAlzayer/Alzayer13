using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class InventoryModel
    {



        public String ID { get; set; }

        public Guid IDGen { get; set; }

        public String Code { get; set; }

        public String Name { get; set; }




        public String ID2 { get; set; }

        public Guid IDGen2 { get; set; }

        public String Code2 { get; set; }

        public String Name2 { get; set; }







        [Required(ErrorMessage = "Please enter  code")]

        public String Code4 { get; set; }
        [Required(ErrorMessage = "Please enter The name")]

        public String Name4 { get; set; }

        public String ID4 { get; set; }








        public Guid IDGen3 { get; set; }




        public String ID3 { get; set; }

        public String Code3 { get; set; }

        public String Name3 { get; set; }














        public String Description { get; set; }
        [Required(ErrorMessage = "Please enter Category")]

        public String Catogery { get; set; }

        public List<InventoryModel> MyList { get; set; }

        public InventoryModel()
        {
          //  Equipments = new List<InventoryModel>();


        }

        public static implicit operator List<object>(InventoryModel v)
        {
            throw new NotImplementedException();
        }
    }


}

