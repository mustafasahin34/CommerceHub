using Riok.Mapperly.Abstractions;
using Volo.Abp.Mapperly;

namespace CommerceHub;

[Mapper]
public partial class CommerceHubApplicationMappers
{
    public partial CommerceHub.Categories.CategoryDto Map(CommerceHub.Entities.Category category);
    public partial CommerceHub.Entities.Category Map(CommerceHub.Categories.CreateUpdateCategoryDto dto);

    public partial CommerceHub.Products.ProductDto Map(CommerceHub.Entities.Product product);
    public partial CommerceHub.Entities.Product Map(CommerceHub.Products.CreateUpdateProductDto dto);

    public partial CommerceHub.Orders.OrderDto Map(CommerceHub.Entities.Order order);
    public partial CommerceHub.Orders.OrderItemDto Map(CommerceHub.Entities.OrderItem orderItem);
}
