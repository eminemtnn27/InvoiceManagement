#pragma checksum "C:\Users\WII\Desktop\Tödeb Bitirme Projesi\InvoiceManagement\InvoiceManagement.Mvc\Views\Messages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d692d8189305bf99a863a45d76ba96e57209643"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(InvoiceManagement.Mvc.Pages.Messages.Views_Messages_Index), @"mvc.1.0.view", @"/Views/Messages/Index.cshtml")]
namespace InvoiceManagement.Mvc.Pages.Messages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\WII\Desktop\Tödeb Bitirme Projesi\InvoiceManagement\InvoiceManagement.Mvc\Views\_ViewImports.cshtml"
using InvoiceManagement.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d692d8189305bf99a863a45d76ba96e57209643", @"/Views/Messages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01c224f485f7940c3e692914e7917db77ead7894", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Messages_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EntityLayer.Concrete.Message>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("float: right;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Messages", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Message/Delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:inline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row container d-flex justify-content-center\">\r\n    <div class=\"col-lg-12 grid-margin stretch-card\">\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n             ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d692d8189305bf99a863a45d76ba96e572096435896", async() => {
                WriteLiteral("Mesaj Gönder");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        <h4 class=""card-title"">Mesajlar</h4>
        <div class=""table-responsive"">
            <table class=""table"">
            <thead>
                <tr> 
                <th> Mesaj No </th>
                <th> Alıcı   </th>
                <th> Gönderen </th>
                <th> Konu </th>
                <th> Mesaj </th>
                <th> Mesaj Tarihi </th>
                <th> Mesaj Durumu </th>
                <th> </th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 23 "C:\Users\WII\Desktop\Tödeb Bitirme Projesi\InvoiceManagement\InvoiceManagement.Mvc\Views\Messages\Index.cshtml"
                 foreach (var msg in Model )
                { 

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                        <td>");
#nullable restore
#line 26 "C:\Users\WII\Desktop\Tödeb Bitirme Projesi\InvoiceManagement\InvoiceManagement.Mvc\Views\Messages\Index.cshtml"
                       Write(msg.MessageId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                        <td>Admin</td>\r\n                        <td>");
#nullable restore
#line 28 "C:\Users\WII\Desktop\Tödeb Bitirme Projesi\InvoiceManagement\InvoiceManagement.Mvc\Views\Messages\Index.cshtml"
                       Write(msg.User.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 29 "C:\Users\WII\Desktop\Tödeb Bitirme Projesi\InvoiceManagement\InvoiceManagement.Mvc\Views\Messages\Index.cshtml"
                       Write(msg.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 30 "C:\Users\WII\Desktop\Tödeb Bitirme Projesi\InvoiceManagement\InvoiceManagement.Mvc\Views\Messages\Index.cshtml"
                       Write(msg.Messages);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 31 "C:\Users\WII\Desktop\Tödeb Bitirme Projesi\InvoiceManagement\InvoiceManagement.Mvc\Views\Messages\Index.cshtml"
                       Write(msg.MessageDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n");
#nullable restore
#line 33 "C:\Users\WII\Desktop\Tödeb Bitirme Projesi\InvoiceManagement\InvoiceManagement.Mvc\Views\Messages\Index.cshtml"
                             if(@msg.MessageStatus==false)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span>Okunmadı</span>\r\n");
#nullable restore
#line 36 "C:\Users\WII\Desktop\Tödeb Bitirme Projesi\InvoiceManagement\InvoiceManagement.Mvc\Views\Messages\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span>Okundu</span>\r\n");
#nullable restore
#line 40 "C:\Users\WII\Desktop\Tödeb Bitirme Projesi\InvoiceManagement\InvoiceManagement.Mvc\Views\Messages\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>                    \r\n                        <td> \r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d692d8189305bf99a863a45d76ba96e5720964311014", async() => {
                WriteLiteral("\r\n                            <input type=\"hidden\" name=\"MessageId\"");
                BeginWriteAttribute("value", " value=\"", 1874, "\"", 1896, 1);
#nullable restore
#line 44 "C:\Users\WII\Desktop\Tödeb Bitirme Projesi\InvoiceManagement\InvoiceManagement.Mvc\Views\Messages\Index.cshtml"
WriteAttributeValue("", 1882, msg.MessageId, 1882, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <button type=\"submit\"  class=\"btn btn-outline-danger\" >Sil</button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td> \r\n                    </tr>    \r\n");
#nullable restore
#line 49 "C:\Users\WII\Desktop\Tödeb Bitirme Projesi\InvoiceManagement\InvoiceManagement.Mvc\Views\Messages\Index.cshtml"
                  }               

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n            </table> \r\n        </div>\r\n        </div>\r\n    </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EntityLayer.Concrete.Message>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
