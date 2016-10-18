using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using delivery1.App_Code.Model;

namespace delivery1.App_Code.Model
{
    public class Order
    {
        public int Id { get; set; }

        public Client Client { get; set; }
        
        public virtual List<Item> Items { get; set; }
        
        public string Date { get; set; }

        public string Address { get; set; }
        
        public bool Loader { get; set; }    
    }
}