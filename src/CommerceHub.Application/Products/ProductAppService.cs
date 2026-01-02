using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using CommerceHub.Entities;

namespace CommerceHub.Products;

public class ProductAppService : CrudAppService<Product, ProductDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateProductDto>, IProductAppService
{
    public ProductAppService(IRepository<Product, Guid> repository)
        : base(repository)
    {

    }
}
