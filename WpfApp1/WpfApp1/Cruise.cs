using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    /// <summary>
    /// рейс
    /// </summary>
    public class Cruise
    {
        [Key]
        public int CruiseId { get; set; }
        public DateTime? Date { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
        public int RouteId { get; set; }
        public virtual Route Route { get; set; }
        public Cruise()
        {
            Tickets = new List<Ticket>();
            
        }
    }
}
