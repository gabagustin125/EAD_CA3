#pragma checksum "C:\Users\patri\source\repos\CA3\Pages\NewsComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e6832c8c08b0bc7de1a31a9fb0c5956d179562a"
// <auto-generated/>
#pragma warning disable 1591
namespace CA3.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\patri\source\repos\CA3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\patri\source\repos\CA3\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\patri\source\repos\CA3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\patri\source\repos\CA3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\patri\source\repos\CA3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\patri\source\repos\CA3\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\patri\source\repos\CA3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\patri\source\repos\CA3\_Imports.razor"
using CA3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\patri\source\repos\CA3\_Imports.razor"
using CA3.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\patri\source\repos\CA3\Pages\NewsComponent.razor"
using System.Runtime.Serialization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/newscomponent")]
    public partial class NewsComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "*\r\n\r\n");
#nullable restore
#line 6 "C:\Users\patri\source\repos\CA3\Pages\NewsComponent.razor"
 if (newsquery.rootData == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading Page</em></p>");
#nullable restore
#line 9 "C:\Users\patri\source\repos\CA3\Pages\NewsComponent.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddMarkupContent(3, "<label for=\"name\"><strong>News API</strong>:</label>\r\n    ");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "type", "text");
            __builder.AddAttribute(6, "class", "form-control");
            __builder.AddAttribute(7, "placeholder", "Search Author");
            __builder.AddAttribute(8, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\patri\source\repos\CA3\Pages\NewsComponent.razor"
                                                                                                                   (f) => { newsquery.SearchValue = (string)f.Value; }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\patri\source\repos\CA3\Pages\NewsComponent.razor"
                                                                                newsquery.SearchValue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newsquery.SearchValue = __value, newsquery.SearchValue));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(11, "button");
            __builder.AddAttribute(12, "class", "btn-primary");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\patri\source\repos\CA3\Pages\NewsComponent.razor"
                                          () => newsquery.AscendingDate()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(14, "Ascending");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.OpenElement(16, "button");
            __builder.AddAttribute(17, "class", "btn-danger");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\patri\source\repos\CA3\Pages\NewsComponent.razor"
                                        () => newsquery.DescendingDate()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(19, "Descending");
            __builder.CloseElement();
            __builder.OpenElement(20, "table");
            __builder.AddAttribute(21, "class", "table");
            __builder.AddMarkupContent(22, "<thead><tr><th>Source</th>\r\n                <th>Author</th>\r\n                <th>Publish Date</th>\r\n                <th>Title</th>\r\n                <th>Description</th>\r\n                <th>URLs</th></tr></thead>\r\n        ");
            __builder.OpenElement(23, "tbody");
#nullable restore
#line 33 "C:\Users\patri\source\repos\CA3\Pages\NewsComponent.razor"
             foreach (var item in newsquery.rootData.articles.Where(x => newsquery.SearchData(x)))
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(24, "tr");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, "Source: ");
            __builder.AddContent(27, 
#nullable restore
#line 36 "C:\Users\patri\source\repos\CA3\Pages\NewsComponent.razor"
                             item.source.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, "Author : ");
            __builder.AddContent(31, 
#nullable restore
#line 37 "C:\Users\patri\source\repos\CA3\Pages\NewsComponent.razor"
                              item.author

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.OpenElement(33, "td");
            __builder.AddContent(34, "Publish Date : ");
            __builder.AddContent(35, 
#nullable restore
#line 38 "C:\Users\patri\source\repos\CA3\Pages\NewsComponent.razor"
                                    item.publishedAt.ToLongDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.OpenElement(37, "td");
            __builder.AddContent(38, "Title : ");
            __builder.AddContent(39, 
#nullable restore
#line 39 "C:\Users\patri\source\repos\CA3\Pages\NewsComponent.razor"
                             item.title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.OpenElement(41, "td");
            __builder.AddContent(42, "Description : ");
            __builder.AddContent(43, 
#nullable restore
#line 40 "C:\Users\patri\source\repos\CA3\Pages\NewsComponent.razor"
                                   item.description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                ");
            __builder.OpenElement(45, "td");
            __builder.AddContent(46, "URLs : ");
            __builder.OpenElement(47, "a");
            __builder.AddAttribute(48, "href", 
#nullable restore
#line 41 "C:\Users\patri\source\repos\CA3\Pages\NewsComponent.razor"
                                     item.url

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(49, "Link to Article");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 43 "C:\Users\patri\source\repos\CA3\Pages\NewsComponent.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 46 "C:\Users\patri\source\repos\CA3\Pages\NewsComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\Users\patri\source\repos\CA3\Pages\NewsComponent.razor"
       
    public string urltag { get; set; } = "apple";
    Query newsquery = new Query();

    public async Task GetNews()
    {
        try
        {
            string uri = "https://newsapi.org/v2/everything?q=" + urltag + "&apiKey=78ab622934c64f16bfc059b559457036";
            newsquery.rootData = await Http.GetFromJsonAsync<Root>(uri);
        }
        catch (Exception e)
        {
            string errormessage = e.Message;
        }
    }

    protected override async Task OnInitializedAsync()
    {
        await GetNews();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
