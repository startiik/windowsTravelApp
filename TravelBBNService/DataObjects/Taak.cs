using Microsoft.WindowsAzure.Mobile.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelBBNService.DataObjects
{
    public class Taak: EntityData
    {
        public string TaskName { get; set; }
        public DateTime DueDate { get; set; }
        public bool Done { get; set; }
    }
}