using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CakesWebApplication.DbContexts;
using CakesWebApplication.Models;
using CakesWebApplication.Repository;

namespace CakesWebApplication.Repository_Implementation
{
    public class OrderRepository : IOrderRepository
    {
        private PiesDbContext _context;
        private ShoppingCart _shoppingCart;

        public OrderRepository(PiesDbContext   piesDbContext, ShoppingCart shoppingCart)
        {
            _context = piesDbContext;
            _shoppingCart = shoppingCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;
            _context.Orders.Add(order);
            var shoppingCartItems = _shoppingCart.ShoppingCartItems;

            foreach(var shoppingCart in shoppingCartItems)
            {
                var OrderDetails = new OrderDetail()
                {
                    Amount = shoppingCart.Amount,
                    OrderId = order.OrderId,
                    PieId = shoppingCart.pie.Id,
                    Price = shoppingCart.pie.Price
                };

                _context.orderDetails.Add(OrderDetails);
            }

            _context.SaveChanges();

            

        }
    }
}
