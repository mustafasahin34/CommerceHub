using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.OpenIddict.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.EntityFrameworkCore;
using CommerceHub;


namespace CommerceHub.EntityFrameworkCore;

[ReplaceDbContext(typeof(IIdentityDbContext))]
[ReplaceDbContext(typeof(ITenantManagementDbContext))]
[ConnectionStringName("Default")]
public class CommerceHubDbContext :
    AbpDbContext<CommerceHubDbContext>,
    IIdentityDbContext,
    ITenantManagementDbContext
{
    /* Add DbSet properties for your Aggregate Roots / Entities here. */

    #region Entities from the modules

    /* Notice: We only implemented IIdentityDbContext and ITenantManagementDbContext
     * and replaced them for this DbContext. This allows you to perform JOIN
     * queries for the entities of these modules over the repositories easily. You
     * typically don't need that for other modules. But, if you need, you can
     * implement the DbContext interface of the needed module and use ReplaceDbContext
     * attribute just like IIdentityDbContext and ITenantManagementDbContext.
     *
     * More info: Replacing a DbContext of a module ensures that the related module
     * uses this DbContext on runtime. Otherwise, it will use its own DbContext class.
     */

    //Identity
    public DbSet<IdentityUser> Users { get; set; }
    public DbSet<IdentityRole> Roles { get; set; }
    public DbSet<IdentityClaimType> ClaimTypes { get; set; }
    public DbSet<OrganizationUnit> OrganizationUnits { get; set; }
    public DbSet<IdentitySecurityLog> SecurityLogs { get; set; }
    public DbSet<IdentityLinkUser> LinkUsers { get; set; }
    public DbSet<IdentityUserDelegation> UserDelegations { get; set; }
    public DbSet<IdentitySession> Sessions { get; set; }
    // Tenant Management
    public DbSet<Tenant> Tenants { get; set; }
    public DbSet<TenantConnectionString> TenantConnectionStrings { get; set; }

    #endregion

    // CommerceHub Entities
    
    // CommerceHub Entities
    
    // CommerceHub Entities
    
    // CommerceHub Entities
    
    public DbSet<CommerceHub.Entities.Category> Categories { get; set; }
    public DbSet<CommerceHub.Entities.Product> Products { get; set; }
    public DbSet<CommerceHub.Entities.Order> Orders { get; set; }
    public DbSet<CommerceHub.Entities.OrderItem> OrderItems { get; set; }
     

    public CommerceHubDbContext(DbContextOptions<CommerceHubDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        /* Include modules to your migration db context */

        builder.ConfigurePermissionManagement();
        builder.ConfigureSettingManagement();
        builder.ConfigureBackgroundJobs();
        builder.ConfigureAuditLogging();
        builder.ConfigureIdentity();
        builder.ConfigureOpenIddict();
        builder.ConfigureFeatureManagement();
        builder.ConfigureTenantManagement();

        /* Configure your own tables/entities inside here */

        builder.Entity<CommerceHub.Entities.Category>(b =>
        {
            b.ToTable(CommerceHubConsts.DbTablePrefix + "Categories", CommerceHubConsts.DbSchema);
            b.ConfigureByConvention();
            b.Property(x => x.Name).IsRequired().HasMaxLength(128);
            b.Property(x => x.Slug).IsRequired().HasMaxLength(128);
            b.HasIndex(x => x.Slug);
        });

        builder.Entity<CommerceHub.Entities.Product>(b =>
        {
            b.ToTable(CommerceHubConsts.DbTablePrefix + "Products", CommerceHubConsts.DbSchema);
            b.ConfigureByConvention();
            b.Property(x => x.Name).IsRequired().HasMaxLength(128);
            b.Property(x => x.Price).HasColumnType("decimal(18,2)");
            // Relations
            b.HasOne<CommerceHub.Entities.Category>().WithMany().HasForeignKey(x => x.CategoryId).IsRequired();
        });

        builder.Entity<CommerceHub.Entities.Order>(b =>
        {
            b.ToTable(CommerceHubConsts.DbTablePrefix + "Orders", CommerceHubConsts.DbSchema);
            b.ConfigureByConvention();
            b.Property(x => x.TotalAmount).HasColumnType("decimal(18,2)");
            b.HasMany(x => x.Items).WithOne().HasForeignKey(x => x.OrderId).IsRequired();
        });

        builder.Entity<CommerceHub.Entities.OrderItem>(b =>
        {
            b.ToTable(CommerceHubConsts.DbTablePrefix + "OrderItems", CommerceHubConsts.DbSchema);
            b.ConfigureByConvention();
            b.Property(x => x.UnitPrice).HasColumnType("decimal(18,2)");
            b.Property(x => x.TotalPrice).HasColumnType("decimal(18,2)");
        });
    }
}
