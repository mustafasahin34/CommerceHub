using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace CommerceHub.Entities;

public class Product : AuditedAggregateRoot<Guid>
{
    public Guid CategoryId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int StockQuantity { get; set; }
    public string TechnicalSpecs { get; set; } // JSON or simple text

    public Product()
    {
    }

    public Product(
        Guid id,
        Guid categoryId,
        string name,
        decimal price,
        int stockQuantity,
        string description = null,
        string technicalSpecs = null)
        : base(id)
    {
        CategoryId = categoryId;
        Name = name;
        Price = price;
        StockQuantity = stockQuantity;
        Description = description;
        TechnicalSpecs = technicalSpecs;
    }
}
