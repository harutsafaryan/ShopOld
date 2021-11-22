﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    interface ICustomerRepository : IBaseRepository<Customer>
    {
        List<Order> GetOrdersByCustomerId(Guid id);
    }
}
