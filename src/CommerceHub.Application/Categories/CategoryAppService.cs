using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using CommerceHub.Entities;

namespace CommerceHub.Categories;

public class CategoryAppService : CrudAppService<Category, CategoryDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateCategoryDto>, ICategoryAppService
{
    public CategoryAppService(IRepository<Category, Guid> repository)
        : base(repository)
    {

    }
}
