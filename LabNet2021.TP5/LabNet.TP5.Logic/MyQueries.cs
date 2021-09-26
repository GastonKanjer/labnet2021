using LabNet.TP5.Entities;
using LabNet.TP5.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet.TP5.Logic
{
    public class MyQueries : BaseLogic
    {
        public Customers Query1(string id)
        {
            return context.Customers.First(c => c.CustomerID == id);
        }
        public List<Products> Query2()
        {
            return context.Products.Where(p => p.UnitsInStock == 0).ToList();
        }
        public List<Products> Query3()
        {
            List<Products> query = (from prod in context.Products
                                    where prod.UnitsInStock > 0 && prod.UnitPrice > 3
                                    select prod).ToList();
            return query;
        }
        public List<Customers> Query4()
        {
            List<Customers> query = (from cust in context.Customers
                                     where cust.Region == "WA"
                                     select cust).ToList();
            return query;
        }
        public Products Query5()
        {
            return context.Products.FirstOrDefault(p => p.ProductID == 789);
        }
        public List<string> Query6()
        {

            List<string> query = (from cust in context.Customers
                                     select  cust.ContactName).ToList();
            return query;
    
        }
        public void Query7()
        {
            var query = from cust in context.Customers
                        join ord in context.Orders
                        on new { cust.CustomerID }
                        equals new { ord.CustomerID }
                        where cust.Region == "WA" && ord.OrderDate > new DateTime(1997, 01, 01)
                        select new { };

        }
        public void Query8()
        {
            var query = context.Customers.Where(c=>c.Region == "WA").Take(3);
        }
        public void Query9()
        {
            var query = from prod in context.Products
                        orderby prod.ProductName
                        select new { }.ToString().ToList();
        }
        public void Query10()
        {
            var query = from prod in context.Products
                        orderby prod.UnitsInStock descending
                        select new { }.ToString().ToList();
        }
        public void Query11()
        {
            var query = context.Products.Select(p => p.Categories);
        }
        public void Query12()
        {
            var query = context.Products.First().ToString().ToList();
        }
        public void Query13()
        {
            var query = context.Customers.Select(c => c.Orders.Count());
        }
    }
}
