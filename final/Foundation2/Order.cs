using System;
using System.Collections.Generic;

namespace ordering
{
    public class Order
    {
        private List<Product> products;
        private Customer customer;

        public Order(Customer customer)
        {
            products = new List<Product>();
            this.customer = customer;
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public double CalculateTotalPrice()
        {
            double totalCost = 0;
            foreach (var product in products)
            {
                totalCost += product.CalculateTotalCost();
            }

            // Add shipping cost based on customer location
            if (customer.IsInUSA())
            {
                totalCost += 5; // USA shipping cost
            }
            else
            {
                totalCost += 35; // International shipping cost
            }

            return totalCost;
        }

        public string GetPackingLabel()
        {
            string label = "Packing Label:\n";
            foreach (var product in products)
            {
                label += $"{product.GetName()} (ID: {product.GetProductId()})\n";
            }
            return label;
        }

        public string GetShippingLabel()
        {
            return $"Shipping Label:\n{customer.GetName()}\n{customer.GetAddress().GetFullAddress()}";
        }
    }
}