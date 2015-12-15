using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackingList.Models
{
    class User
    {
        public User()
        {
            Trips = new List<Reis>();
        }
        public string Id { get; set; }
        public string Username { get; set; }
        public ICollection<Reis> Trips { get; set; }
    }
}