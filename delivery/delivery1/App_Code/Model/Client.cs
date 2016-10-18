using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace delivery1.App_Code.Model
{
    public class Client
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public virtual List<Order> Orders { get; set; }
    }
}