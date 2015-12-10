using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.WindowsAzure.Mobile.Service;

namespace TravelBBNService.DataObjects
{
    public class Account : EntityData
    {
        public string Username { get; set; }
        public byte[] Salt { get; set; }
        public byte[] SaltedAndHashedPassword { get; set; }
        public IEnumerable<Reis> reizen { get; set; }
    }
}