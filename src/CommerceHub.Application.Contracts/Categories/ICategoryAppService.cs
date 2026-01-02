using System;
using Volo.Abp.Application.Services;
using Volo.Abp.Application.Dtos;

namespace CommerceHub.Categories;

public interface ICategoryAppService : ICrudAppService<CategoryDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateCategoryDto>
{

}
