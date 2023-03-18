using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Destination
    {
        [Key]
        public int DestinationId { get; set; }
        public virtual ICollection<Route> Route { get; set; }
        public Destination()
        {
            Route = new List<Route>();
            
        }
    }
}
