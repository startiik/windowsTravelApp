using Microsoft.WindowsAzure.Mobile.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelBBNService.DataObjects
{
    public class Item: EntityData
    {
        public string ItemName { get; set; }
        public int Amount { get; set; }
        public bool Done { get; set; }
        public string Category { get; set; }
    }
}