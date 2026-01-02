using System;
using Volo.Abp.Application.Dtos;

namespace CommerceHub.Products;

public class ProductDto : AuditedEntityDto<Guid>
{
    public Guid CategoryId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int StockQuantity { get; set; }
    public string TechnicalSpecs { get; set; }
}

public class CreateUpdateProductDto
{
    public Guid CategoryId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int StockQuantity { get; set; }
    public string TechnicalSpecs { get; set; }
}
