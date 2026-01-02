using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using CommerceHub.Entities;
using CommerceHub.Products;

namespace CommerceHub.Orders;

public class OrderAppService : CommerceHubAppService, IOrderAppService
{
    private readonly IRepository<Order, Guid> _orderRepository;
    private readonly IRepository<Product, Guid> _productRepository;

    public OrderAppService(
        IRepository<Order, Guid> orderRepository,
        IRepository<Product, Guid> productRepository)
    {
        _orderRepository = orderRepository;
        _productRepository = productRepository;
    }

    // Allow anonymous access for guest checkout
    public async Task<OrderDto> CreateAsync(CreateOrderDto input)
    {
        var order = new Order(
            GuidGenerator.Create(),
            input.CustomerName,
            input.CustomerEmail,
            input.ShippingAddress
        );

        if (input.CustomerPhone != null)
        {
            order.CustomerPhone = input.CustomerPhone;
        }

        foreach (var item in input.Items)
        {
            var product = await _productRepository.GetAsync(item.ProductId);
            order.AddItem(item.ProductId, item.Quantity, product.Price);
        }

        await _orderRepository.InsertAsync(order);

        return ObjectMapper.Map<Order, OrderDto>(order);
    }

    public async Task<OrderDto> GetAsync(Guid id)
    {
        var order = await _orderRepository.GetAsync(id);
        return ObjectMapper.Map<Order, OrderDto>(order);
    }
}
