using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CakesWebApplication.Models;

namespace CakesWebApplication.Repository
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
