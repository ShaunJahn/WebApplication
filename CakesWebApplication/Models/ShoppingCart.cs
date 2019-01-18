using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//for getting GetCart
using CakesWebApplication.DbContexts;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using CakesWebApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace CakesWebApplication.Models
{
    public class ShoppingCart
    {
        private PiesDbContext _Context;

        public ShoppingCart(PiesDbContext piesDbContext)
        {
            _Context = piesDbContext;
        }

        public string ShoppingCartId { get; set; }
        public List<ShoppingCartItemDto> ShoppingCartItems { get; set; }

        //get session data to get cart
        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            var context = services.GetService<PiesDbContext>();
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartId);

            return new ShoppingCart(context) { ShoppingCartId = cartId };
        }


        public void AddCart(PieDto pie, int amount)
        {
            var shoppingCartItem = _Context.ShoppingCartItems.SingleOrDefault(c => c.pie.Id == pie.Id && c.ShoppingCartId == ShoppingCartId);

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItemDto
                {
                    ShoppingCartId = ShoppingCartId,
                    pie = pie,
                    Amount = 1
                };
                _Context.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }

            _Context.SaveChanges();

        }

        public int RemoveFromCart(PieDto pie)
        {
            var shoppingCartItem = _Context.ShoppingCartItems.SingleOrDefault(c => c.pie.Id == pie.Id && c.ShoppingCartId == ShoppingCartId);
            var localAmount = 0;

            if (shoppingCartItem.Amount > 1)
            {
                shoppingCartItem.Amount--;
                localAmount = shoppingCartItem.Amount;
            }
            else
            {
                _Context.ShoppingCartItems.Remove(shoppingCartItem);
            }
            _Context.SaveChanges();

            return localAmount;
        }

        public List<ShoppingCartItemDto> GetShoppingCartItems()
        {
            return ShoppingCartItems ??
                   (ShoppingCartItems =
                       _Context.ShoppingCartItems.Include(c=>c.pie).Where(c => c.ShoppingCartId == ShoppingCartId).ToList());
        }

        public void ClearCart()
        {
            var cartItems = _Context
                .ShoppingCartItems
                .Where(cart => cart.ShoppingCartId == ShoppingCartId);

            _Context.ShoppingCartItems.RemoveRange(cartItems);

            _Context.SaveChanges();
        }

        public decimal GetShoppingCartTotal()
        {
            var total = _Context.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                .Select(c => c.pie.Price * c.Amount).Sum();
            return total;
        }

    }
}
