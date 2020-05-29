using System;
using System.Collections.Generic;
using System.Linq;

namespace Vending
{
    public class VendingMachine
    {
        private List<Product> _products = new List<Product>();

        public VendingMachine()
        {
            _products.Add(new Product() { Id = 1, Name = "Snickers", Price = .75 });
            _products.Add(new Product() { Id = 2, Name = "Pepsi", Price = 1.25 });
            _products.Add(new Product() { Id = 3, Name = "Diamond Ring", Price = 2_400 });
            _products.Add(new Product() { Id = 4, Name = "Tesla", Price = 85_000 });
            _products.Add(new Product() { Id = 5, Name = "Hot Pocket", Price = 1.50 });
        }

        // Add a new product to the Vending Machine (For stocking machine)
        public void AddProduct(Product newProduct)
        {
            _products.Add(newProduct);
        }

        // Remove a product from the Vending Machine (for purchasing a product)
        public void RemoveProduct(Product productToRemove)
        {
            _products.Remove(productToRemove);
        }

        // Get all products ordered by price (lowest on top)
        public List<Product> GetAll()
        {
            IEnumerable<Product> sortedProducts = _products.OrderBy(p => p.Price);
            return sortedProducts.ToList();
        }

        // Find a product by name. Results should be ordered by name)
        public List<Product> SearchByName(string nameCriteria)
        {
            IEnumerable<Product> matchedNames = _products.Where(product => product.Name.ToLower().Contains(nameCriteria)).OrderBy(product => product.Name);
            return matchedNames.ToList();
        }

        // Find a product between a range or prices. Results should be ordered by price
        public List<Product> SearchByPrice(double minPrice, double maxPrice)
        {
            IEnumerable<Product> matchedPrices = _products.Where(product => product.Price >= minPrice && product.Price <= maxPrice).OrderBy(product => product.Price);
            return matchedPrices.ToList();
        }

        // Return a product with a given ID. Return null if not found.
        public Product GetById(int id)
        {
            Product matchedId = _products.FirstOrDefault(product => product.Id == id);
            return matchedId;
        }

        // Return the cheapest product or null if there are no products
        public Product GetCheapest()
        {
            Product cheapestProduct = _products.OrderBy(product => product.Price).FirstOrDefault();
            return cheapestProduct;
        }

        // Return the most expensive product or null if there are no products
        public Product GetMostExpensive()
        {
            Product expensiveProduct = _products.OrderByDescending(product => product.Price).FirstOrDefault();
            return expensiveProduct;
        }

        // Return all the product names in alphabetical ordere
        public List<string> GetProductNames()
        {
            IEnumerable<Product> sortedProducts = _products.OrderBy(p => p.Name);
            IEnumerable<string> productNames = sortedProducts.Select(product => product.Name);
            return productNames.ToList();
        }

        // Property to represent the total of all the products' prices.
        public double TotalValue
        {
            get
            {
                //ReportTotalSales = neighborhoodGroup.Sum(kidObj => kidObj.Sales)
                double totalValue = _products.Sum(product => product.Price);
                return totalValue;
            }
        }
    }
}