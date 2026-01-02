using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace CommerceHub.Entities;

public class Category : AuditedAggregateRoot<Guid>
{
    public string Name { get; set; }
    public string Slug { get; set; }
    public Guid? ParentId { get; set; }

    public Category()
    {
    }

    public Category(Guid id, string name, string slug, Guid? parentId = null)
        : base(id)
    {
        Name = name;
        Slug = slug;
        ParentId = parentId;
    }
}
