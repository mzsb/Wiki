#pragma checksum "C:\Users\barna\source\repos\Wiki\Wiki.Blazor\Components\Claim\Reference.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f51367aa6471d2be5b7b46bb5426c831bf6b9c3d"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#nullable restore
#line 1 "C:\Users\barna\source\repos\Wiki\Wiki.Blazor\Components\Claim\Reference.razor"
using System.Collections.ObjectModel;

#line default
#line hidden
#nullable disable
    public partial class Reference : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\barna\source\repos\Wiki\Wiki.Blazor\Components\Claim\Reference.razor"
       
    [Parameter]
    public ObservableCollection<ReferenceItemViewModel> References { get; set; }

    [Parameter]
    public Func<ClaimDataItemViewModel, RenderFragment> GetSpecificComponent { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591