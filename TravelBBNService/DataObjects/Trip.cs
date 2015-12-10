using Microsoft.WindowsAzure.Mobile.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace TravelBBNService.DataObjects {
    public class Trip : EntityData {
        public string Name { get; set; }
        public string Location { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        //public String Icon { get; set; }
       // public List<TodoItem> Items { get; set; }
    }
}