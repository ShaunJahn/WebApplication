using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakesWebApplication.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int PieId { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public virtual PieDto Pie { get; set; }
        public virtual Order Order { get; set; }
    }
}

