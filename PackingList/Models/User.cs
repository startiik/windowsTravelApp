using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackingList.Models
{
    public class User
    {
        public User()
        {
            Reizen = new List<Reis>();
        }
        public string Id { get; set; }
        public string Username { get; set; }
        public ICollection<Reis> Reizen { get; set; }
    }
}