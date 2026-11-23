using System;
using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order()
    {
        _products = new List<Product>();
    }

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }

    public double GetSubtotal()
    {
        double subtotal = 0;
        foreach (Product product in _products)
        {
            subtotal += product.GetTotalCost();
        }
        return subtotal;
    }

    public double GetShippingCost()
    {
        if (_customer == null)
        {
            return 0;
        }
        return _customer.LivesInUSA() ? 5.00 : 35.00;
    }

    public double CalculateTotalPrice()
    {
        return GetSubtotal() + GetShippingCost();
    }

    public string GetPackingLabel()
    {
        StringBuilder label = new StringBuilder();
        label.AppendLine("=== PACKING LABEL ===");
        foreach (Product product in _products)
        {
            label.AppendLine($"Product: {product.GetName()} | ID: {product.GetProductId()} (Qty: {product.GetQuantity()})");
        }
        return label.ToString();
    }

    public string GetShippingLabel()
    {
        StringBuilder label = new StringBuilder();
        label.AppendLine("=== SHIPPING LABEL ===");
        if (_customer != null)
        {
            label.AppendLine(_customer.GetName());
            label.AppendLine(_customer.GetAddress().GetFormattedAddress());
        }
        return label.ToString();
    }
}