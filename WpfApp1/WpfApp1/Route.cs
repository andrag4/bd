using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Route
    {
        [Key]
        public int RouteId { get; set; }
        [Required, MaxLength(100)]
        public string RouteName { get; set; }
        public virtual ICollection<Cruise> Cruises { get; set; }

        public virtual ICollection<Destination> Destinations { get; set; }
        public Route()
        {
            Cruises = new List<Cruise>();
            Destinations = new List<Destination>();
        }
    }
}
