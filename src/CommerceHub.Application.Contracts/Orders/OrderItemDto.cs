using System;
using Volo.Abp.Application.Dtos;

namespace CommerceHub.Orders;

public class OrderItemDto : EntityDto<Guid>
{
    public Guid ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal TotalPrice { get; set; }
}

public class CreateOrderItemDto
{
    public Guid ProductId { get; set; }
    public int Quantity { get; set; }
}
