using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CakesWebApplication.Models;
using CakesWebApplication.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CakesWebApplication.Controllers
{
    public class OrderController : Controller
    {
        private IOrderRepository _orderRepository;
        private ShoppingCart _shoppingCart;

        public OrderController(IOrderRepository orderRepository, ShoppingCart shoppingCart)
        {
            _orderRepository = orderRepository;
            _shoppingCart = shoppingCart;
        }

        [Authorize]
        public IActionResult Checkout()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            if (_shoppingCart.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Your cart is emtpy, add some items first");
            }

            if (ModelState.IsValid)
            {
                _orderRepository.CreateOrder(order);
                _shoppingCart.ClearCart();
                return RedirectToAction("CheckoutCompleted");
            }
            return View(order);

        }

        public IActionResult CheckoutCompleted()
        {
            ViewBag.CheckoutCompleteMessage = HttpContext.User.Identity.Name +
                                      ", thanks for your order. You'll soon enjoy our delicious pies!";
            return View();
        }
    }
}