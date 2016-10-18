using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace delivery1.App_Code.Model
{
    public class Item
    {
        public int Id { get; set; }

        public string NameItem { get; set; }

        public Order Order { get; set; }

        public double Length { get; set; }

        public double Width { get; set; }

        public double Height { get; set; }

        public double Weight { get; set; }
    }
}