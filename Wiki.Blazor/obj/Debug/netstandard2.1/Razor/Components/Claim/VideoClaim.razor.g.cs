#pragma checksum "C:\Users\barna\source\repos\Wiki\Wiki.Blazor\Components\Claim\VideoClaim.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89ad419f90a570d4710cc617222096ec0ab6cfaa"
// <auto-generated/>
#pragma warning disable 1591
namespace Wiki.Blazor.Components.Claim
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\barna\source\repos\Wiki\Wiki.Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\barna\source\repos\Wiki\Wiki.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\barna\source\repos\Wiki\Wiki.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\barna\source\repos\Wiki\Wiki.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\barna\source\repos\Wiki\Wiki.Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\barna\source\repos\Wiki\Wiki.Blazor\_Imports.razor"
using Wiki.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\barna\source\repos\Wiki\Wiki.Blazor\_Imports.razor"
using Wiki.BLL.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\barna\source\repos\Wiki\Wiki.Blazor\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\barna\source\repos\Wiki\Wiki.Blazor\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\barna\source\repos\Wiki\Wiki.Blazor\_Imports.razor"
using Wiki.Blazor.Shared;

#line default
#line hidden
#nullable disable
    public partial class VideoClaim : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddContent(0, 
#nullable restore
#line 2 "C:\Users\barna\source\repos\Wiki\Wiki.Blazor\Components\Claim\VideoClaim.razor"
 viewModel.Label

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(1, "\r\n");
            __builder.OpenElement(2, "video");
            __builder.AddAttribute(3, "class", "video");
            __builder.AddAttribute(4, "controls", true);
            __builder.AddMarkupContent(5, "\r\n\r\n    ");
            __builder.OpenElement(6, "source");
            __builder.AddAttribute(7, "src", 
#nullable restore
#line 5 "C:\Users\barna\source\repos\Wiki\Wiki.Blazor\Components\Claim\VideoClaim.razor"
                  viewModel.Source

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(8, "type", "video/mp4");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n    ");
            __builder.OpenElement(10, "source");
            __builder.AddAttribute(11, "src", 
#nullable restore
#line 8 "C:\Users\barna\source\repos\Wiki\Wiki.Blazor\Components\Claim\VideoClaim.razor"
                  viewModel.Source

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "type", "video/ogg");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n    Your browser does not support the video tag.\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\Users\barna\source\repos\Wiki\Wiki.Blazor\Components\Claim\VideoClaim.razor"
       
    [Parameter]
    public VideoClaimDataItemViewModel viewModel { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
