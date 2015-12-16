using Microsoft.WindowsAzure.Mobile.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace TravelBBNService.DataObjects {
    public class Reis : EntityData {
        public string UserID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public DateTime DepartureDate { get; set; }
        public IEnumerable<Item> Items { get; set; }
        public IEnumerable<Taak> Taken { get; set; }
    }
}