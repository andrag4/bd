using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Ticket
    {
        [Required, MaxLength(30)]
        public string FirstNameP { get; set; }
        [Required, MaxLength(30)]
        public string LastNameP { get; set; }
        public int TicketId { get; set; }

        public int CruiseId { get; set; }
        public virtual Cruise Cruise { get; set; }
        public double price { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

    }
}
