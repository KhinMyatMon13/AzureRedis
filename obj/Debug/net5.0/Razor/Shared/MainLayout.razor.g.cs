#pragma checksum "D:\@Projects\RedisTest\AzureRedis\RedisDemoNET5\RedisDemoNET5\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52a02bb46358323d602228beecd78f63de46fea0"
// <auto-generated/>
#pragma warning disable 1591
namespace RedisDemoNET5.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\@Projects\RedisTest\AzureRedis\RedisDemoNET5\RedisDemoNET5\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\@Projects\RedisTest\AzureRedis\RedisDemoNET5\RedisDemoNET5\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\@Projects\RedisTest\AzureRedis\RedisDemoNET5\RedisDemoNET5\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\@Projects\RedisTest\AzureRedis\RedisDemoNET5\RedisDemoNET5\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\@Projects\RedisTest\AzureRedis\RedisDemoNET5\RedisDemoNET5\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\@Projects\RedisTest\AzureRedis\RedisDemoNET5\RedisDemoNET5\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\@Projects\RedisTest\AzureRedis\RedisDemoNET5\RedisDemoNET5\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\@Projects\RedisTest\AzureRedis\RedisDemoNET5\RedisDemoNET5\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\@Projects\RedisTest\AzureRedis\RedisDemoNET5\RedisDemoNET5\_Imports.razor"
using RedisDemoNET5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\@Projects\RedisTest\AzureRedis\RedisDemoNET5\RedisDemoNET5\_Imports.razor"
using RedisDemoNET5.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\@Projects\RedisTest\AzureRedis\RedisDemoNET5\RedisDemoNET5\_Imports.razor"
using Microsoft.Extensions.Caching.Distributed;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-nwm2xopb80");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-nwm2xopb80");
            __builder.OpenComponent<RedisDemoNET5.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-nwm2xopb80");
            __builder.AddMarkupContent(11, "<div class=\"top-row px-4\" b-nwm2xopb80><a href=\"https://docs.microsoft.com/aspnet/\" target=\"_blank\" b-nwm2xopb80>About</a></div>\r\n\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "content px-4");
            __builder.AddAttribute(14, "b-nwm2xopb80");
            __builder.AddContent(15, 
#nullable restore
#line 14 "D:\@Projects\RedisTest\AzureRedis\RedisDemoNET5\RedisDemoNET5\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
