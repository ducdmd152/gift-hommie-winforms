﻿using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;

namespace BussinessObjects
{
    public interface IOrderRepository
    {
        List<Order> GetAll();
        Order Get(int id);
        bool Exist(int id);
        public void Add(Order entity);
        void Update(Order entity);
        void Save(Order entity);
        void Delete(int id);
        public List<Order> GetAllOrdersOfCustomer(string username);
        double GetTotalOfOrder(int id);
        public List<Order> GetOrdersWithStatus(List<string> status);
        public int GetAvailableProductQuantity(int id);
    }
}
