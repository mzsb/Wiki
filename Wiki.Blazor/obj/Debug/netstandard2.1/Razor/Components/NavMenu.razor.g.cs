#pragma checksum "C:\Users\barna\source\repos\Wiki\Wiki.Blazor\Components\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d990793964817c1a8d4804077ac72f49e325bc6"
// <auto-generated/>
#pragma warning disable 1591
namespace Wiki.Blazor.Components
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenMenu>(0);
            __builder.AddAttribute(1, "Attributes", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>>(
#nullable restore
#line 5 "C:\Users\barna\source\repos\Wiki\Wiki.Blazor\Components\NavMenu.razor"
                          new Dictionary<string, object> { { "class", "nav" } }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n\r\n    ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "col-md-3");
                __builder2.AddMarkupContent(6, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLink>(7);
                __builder2.AddAttribute(8, "Path", "entity/default");
                __builder2.AddAttribute(9, "Text", "WikiAssembly");
                __builder2.AddAttribute(10, "Attributes", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>>(
#nullable restore
#line 10 "C:\Users\barna\source\repos\Wiki\Wiki.Blazor\Components\NavMenu.razor"
                                  new Dictionary<string, object> { { "class", "label" } }

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(12, "\r\n\r\n    ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "col-md-6 search");
                __builder2.AddMarkupContent(15, "\r\n\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenAutoComplete>(16);
                __builder2.AddAttribute(17, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.IEnumerable>(
#nullable restore
#line 15 "C:\Users\barna\source\repos\Wiki\Wiki.Blazor\Components\NavMenu.razor"
                                   viewModel.SearchResultItemViewModels

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "Change", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Object>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Object>(this, 
#nullable restore
#line 16 "C:\Users\barna\source\repos\Wiki\Wiki.Blazor\Components\NavMenu.razor"
                                      v => ItemSelected(v)

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(19, "TextProperty", "Label");
                __builder2.AddAttribute(20, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\barna\source\repos\Wiki\Wiki.Blazor\Components\NavMenu.razor"
                                        async args => await SearchAsync(args)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "Placeholder", "Search");
                __builder2.AddAttribute(22, "LoadData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.LoadDataArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.LoadDataArgs>(this, 
#nullable restore
#line 20 "C:\Users\barna\source\repos\Wiki\Wiki.Blazor\Components\NavMenu.razor"
                                       SetSearchDescription

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(24);
                __builder2.AddAttribute(25, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\barna\source\repos\Wiki\Wiki.Blazor\Components\NavMenu.razor"
                                            ButtonClicked

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(26, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 23 "C:\Users\barna\source\repos\Wiki\Wiki.Blazor\Components\NavMenu.razor"
                                                Radzen.ButtonType.Submit

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 24 "C:\Users\barna\source\repos\Wiki\Wiki.Blazor\Components\NavMenu.razor"
                                                 Radzen.ButtonStyle.Primary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "Icon", "search");
                __builder2.AddAttribute(29, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#nullable restore
#line 26 "C:\Users\barna\source\repos\Wiki\Wiki.Blazor\Components\NavMenu.razor"
                                          Radzen.ButtonSize.Medium

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "Attributes", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>>(
#nullable restore
#line 27 "C:\Users\barna\source\repos\Wiki\Wiki.Blazor\Components\NavMenu.razor"
                                                  new Dictionary<string, object> { { "class", "icon" } }

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(31, "\r\n\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n\r\n    <div class=\"col-md-3\"></div>\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\barna\source\repos\Wiki\Wiki.Blazor\Components\NavMenu.razor"
 
    public string Value { get; set; }

    IEnumerable<string> values = new string[] { "en" };

    void Change(IEnumerable<string> value, string name)
    {
        var str = string.Join(", ", value);
        Console.WriteLine($"{name} value changed to {str}");
    }

    private async Task SearchAsync(ChangeEventArgs args)
    {
        Value = args.Value.ToString();
        await viewModel.SearchEntity(Value);
        StateHasChanged();
    }

    private async Task SetSearchDescription()
    {
        await Task.Delay(1);
        await JSRuntime.InvokeVoidAsync("setSearchDescription", 
                                        "ui-autocomplete-items", 
                                        viewModel.SearchResultItemViewModels.Select(c => c.Description)
                                                                            .ToArray());
    }

    private void ItemSelected(object v) =>
        navigationManager.NavigateTo($"entity/{viewModel.SearchResultItemViewModels.First(c => c.Label == (v as string)).Id}");

    private async Task ButtonClicked()
    {
        await viewModel.SearchEntity(Value);
        navigationManager.NavigateTo($"entity/{viewModel.SearchResultItemViewModels.First(c => c.Label == Value).Id}");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SearchComponentViewModel viewModel { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
