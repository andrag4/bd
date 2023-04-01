using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }


        public virtual ICollection<Ticket> Tickets { get; set; }
        public Category()
        {
            Tickets = new List<Ticket>();
        }
    }
}
