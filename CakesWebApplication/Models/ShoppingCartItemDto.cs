using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakesWebApplication.Models
{
    public class ShoppingCartItemDto
    {
        public int Id { get; set; }
        public PieDto pie { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
