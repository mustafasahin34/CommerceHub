using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace CommerceHub.Entities;

public enum OrderStatus
{
    Pending,
    Processing,
    Shipped,
    Completed,
    Cancelled
}

public class Order : AuditedAggregateRoot<Guid>
{
    public string CustomerName { get; set; }
    public string CustomerEmail { get; set; }
    public string CustomerPhone { get; set; } // Added for convenience
    public string ShippingAddress { get; set; }
    public decimal TotalAmount { get; set; }
    public OrderStatus Status { get; set; }

    public List<OrderItem> Items { get; set; }

    protected Order()
    {
    }

    public Order(Guid id, string customerName, string customerEmail, string shippingAddress)
        : base(id)
    {
        CustomerName = customerName;
        CustomerEmail = customerEmail;
        ShippingAddress = shippingAddress;
        Status = OrderStatus.Pending;
        Items = new List<OrderItem>();
    }

    public void AddItem(Guid productId, int quantity, decimal unitPrice)
    {
        Items.Add(new OrderItem(Id, productId, quantity, unitPrice));
        TotalAmount += quantity * unitPrice;
    }
}
