using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackingList.Models
{
    public class Reis
    {
        public string User { get; set; }
        public string Title { get; set; }
        public DateTime DepartureDate { get; set; }
        public String Location { get; set; }
        List<ReisItem> ReisItems { get; set; }
        List<Taak> Taken { get; set; }

    }
}
