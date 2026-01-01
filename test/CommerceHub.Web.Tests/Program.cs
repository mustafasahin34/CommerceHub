using Microsoft.AspNetCore.Builder;
using CommerceHub;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();

builder.Environment.ContentRootPath = GetWebProjectContentRootPathHelper.Get("CommerceHub.Web.csproj");
await builder.RunAbpModuleAsync<CommerceHubWebTestModule>(applicationName: "CommerceHub.Web" );

public partial class Program
{
}
