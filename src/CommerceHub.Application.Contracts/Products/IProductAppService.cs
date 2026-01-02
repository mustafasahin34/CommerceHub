using System;
using Volo.Abp.Application.Services;
using Volo.Abp.Application.Dtos;

namespace CommerceHub.Products;

public interface IProductAppService : ICrudAppService<ProductDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateProductDto>
{

}
