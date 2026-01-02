using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;
using CommerceHub.Orders;

namespace CommerceHub.Orders;

public class OrderDto : AuditedEntityDto<Guid>
{
    public string CustomerName { get; set; }
    public string CustomerEmail { get; set; }
    public string CustomerPhone { get; set; }
    public string ShippingAddress { get; set; }
    public decimal TotalAmount { get; set; }
    public OrderStatus Status { get; set; }
    public List<OrderItemDto> Items { get; set; }
}

public class CreateOrderDto
{
    public string CustomerName { get; set; }
    public string CustomerEmail { get; set; }
    public string CustomerPhone { get; set; }
    public string ShippingAddress { get; set; }
    public List<CreateOrderItemDto> Items { get; set; }
}
