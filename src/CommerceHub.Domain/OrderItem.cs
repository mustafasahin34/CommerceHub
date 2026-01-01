using System;
using Volo.Abp.Domain.Entities;

namespace CommerceHub.Entities;

public class OrderItem : Entity<Guid>
{
    public Guid OrderId { get; set; }
    public Guid ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal TotalPrice { get; set; }

    protected OrderItem()
    {
    }

    internal OrderItem(Guid orderId, Guid productId, int quantity, decimal unitPrice)
    {
        OrderId = orderId;
        ProductId = productId;
        Quantity = quantity;
        UnitPrice = unitPrice;
        TotalPrice = quantity * unitPrice;
    }
}
