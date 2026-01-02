using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace CommerceHub.Orders;

public interface IOrderAppService : IApplicationService
{
    Task<OrderDto> CreateAsync(CreateOrderDto input);
    Task<OrderDto> GetAsync(Guid id);
}
