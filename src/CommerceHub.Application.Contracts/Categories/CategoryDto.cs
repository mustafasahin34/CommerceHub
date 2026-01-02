using System;
using Volo.Abp.Application.Dtos;

namespace CommerceHub.Categories;

public class CategoryDto : AuditedEntityDto<Guid>
{
    public string Name { get; set; }
    public string Slug { get; set; }
    public Guid? ParentId { get; set; }
}

public class CreateUpdateCategoryDto
{
    public string Name { get; set; }
    public string Slug { get; set; }
    public Guid? ParentId { get; set; }
}
