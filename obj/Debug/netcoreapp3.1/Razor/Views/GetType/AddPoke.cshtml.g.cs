#pragma checksum "C:\Users\lewis\Desktop\Capstone Project\Views\GetType\AddPoke.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "880baf01c5969645b7a09bfcaccc085c5eb5ea96"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GetType_AddPoke), @"mvc.1.0.view", @"/Views/GetType/AddPoke.cshtml")]
namespace AspNetCore
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
#line 1 "C:\Users\lewis\Desktop\Capstone Project\Views\_ViewImports.cshtml"
using PoGoBattleHelper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lewis\Desktop\Capstone Project\Views\_ViewImports.cshtml"
using PoGoBattleHelper.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"880baf01c5969645b7a09bfcaccc085c5eb5ea96", @"/Views/GetType/AddPoke.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4beab6cecca1cfaa9085b734186fc40e16bf81e", @"/Views/_ViewImports.cshtml")]
    public class Views_GetType_AddPoke : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PoGoBattleHelper.ViewModels.GetTypeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetType", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("variableName"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("valign", new global::Microsoft.AspNetCore.Html.HtmlString("bottom"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4""><strong>PoGo Battle Helper</strong></h1>
</div>
<div class=""text-center"">
    <div style=""padding: 100px 0px 50px;"" class=""text-center"">
        <h3>Please choose the Pokemon below.</h3>
    </div>
    <h4>Pokemon with the types you chose:</h4>
    <br />
");
#nullable restore
#line 12 "C:\Users\lewis\Desktop\Capstone Project\Views\GetType\AddPoke.cshtml"
     if (ViewBag.possiblePokes2Types.Count == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "880baf01c5969645b7a09bfcaccc085c5eb5ea965744", async() => {
                WriteLiteral("Choose Pokemon by Type");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 15 "C:\Users\lewis\Desktop\Capstone Project\Views\GetType\AddPoke.cshtml"
    }
    else
    {
        int counter = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <table align=\"center\">\r\n            <tbody>\r\n                <tr vertical-align=\"bottom\">\r\n");
#nullable restore
#line 22 "C:\Users\lewis\Desktop\Capstone Project\Views\GetType\AddPoke.cshtml"
                     foreach (Pokemon poke in ViewBag.possiblePokes2Types)
                    {
                        string modifier = "00";
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\lewis\Desktop\Capstone Project\Views\GetType\AddPoke.cshtml"
                         if (@poke.Name.ToLower().Contains("castform sunny"))
                        {
                            modifier = "12";
                        }
                        else if (@poke.Name.ToLower().Contains("castform rainy"))
                        {
                            modifier = "13";
                        }
                        else if (@poke.Name.ToLower().Contains("castform snowy"))
                        {
                            modifier = "14";
                        }
                        else if (@poke.Name.ToLower().Contains("deoxys attack"))
                        {
                            modifier = "16";
                        }
                        else if (@poke.Name.ToLower().Contains("deoxys defense"))
                        {
                            modifier = "17";
                        }
                        else if (@poke.Name.ToLower().Contains("deoxys speed"))
                        {
                            modifier = "18";
                        }
                        else if (@poke.Name.ToLower().Contains("burmy plant"))
                        {
                            modifier = "19";
                        }
                        else if (@poke.Name.ToLower().Contains("burmy sandy"))
                        {
                            modifier = "20";
                        }
                        else if (@poke.Name.ToLower().Contains("burmy trash"))
                        {
                            modifier = "21";
                        }
                        else if (@poke.Name.ToLower().Contains("wormdam plant"))
                        {
                            modifier = "22";
                        }
                        else if (@poke.Name.ToLower().Contains("wormdam sandy"))
                        {
                            modifier = "23";
                        }
                        else if (@poke.Name.ToLower().Contains("wormdam trash"))
                        {
                            modifier = "24";
                        }
                        else if (@poke.Name.ToLower().Contains("cherrim overcast"))
                        {
                            modifier = "25";
                        }
                        else if (@poke.Name.ToLower().Contains("cherrim sunny"))
                        {
                            modifier = "26";
                        }
                        else if (@poke.Name.ToLower().Contains("rotom heat"))
                        {
                            modifier = "27";
                        }
                        else if (@poke.Name.ToLower().Contains("rotom wash"))
                        {
                            modifier = "28";
                        }
                        else if (@poke.Name.ToLower().Contains("rotom frost"))
                        {
                            modifier = "29";
                        }
                        else if (@poke.Name.ToLower().Contains("rotom fan"))
                        {
                            modifier = "30";
                        }
                        else if (@poke.Name.ToLower().Contains("rotom mow"))
                        {
                            modifier = "91";
                        }
                        else if (@poke.Name.ToLower().Contains("giratina altered"))
                        {
                            modifier = "32";
                        }
                        else if (@poke.Name.ToLower().Contains("giratina origin"))
                        {
                            modifier = "33";
                        }
                        else if (@poke.Name.ToLower().Contains("shaymin land"))
                        {
                            modifier = "34";
                        }
                        else if (@poke.Name.ToLower().Contains("shaymin sky"))
                        {
                            modifier = "35";
                        }
                        else if (poke.Name.ToLower().Contains("alola"))
                        {
                            modifier = "61";
                        }
                        else if (poke.Name.ToLower().Contains("galar"))
                        {
                            modifier = "31";
                        }
                        else if (poke.Name.ToLower().Contains("mega"))
                        {
                            modifier = "51";
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 128 "C:\Users\lewis\Desktop\Capstone Project\Views\GetType\AddPoke.cshtml"
                         

                        string dex = poke.Dex.ToString("D3");

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td vertical-align=\"bottom\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "880baf01c5969645b7a09bfcaccc085c5eb5ea9612775", async() => {
                WriteLiteral("\r\n                                <input type=\"hidden\"");
                BeginWriteAttribute("id", " id=", 5744, "", 5758, 1);
#nullable restore
#line 133 "C:\Users\lewis\Desktop\Capstone Project\Views\GetType\AddPoke.cshtml"
WriteAttributeValue("", 5748, poke.Name, 5748, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"variableName\"");
                BeginWriteAttribute("value", " value=", 5778, "", 5795, 1);
#nullable restore
#line 133 "C:\Users\lewis\Desktop\Capstone Project\Views\GetType\AddPoke.cshtml"
WriteAttributeValue("", 5785, poke.Name, 5785, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "880baf01c5969645b7a09bfcaccc085c5eb5ea9613865", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 134 "C:\Users\lewis\Desktop\Capstone Project\Views\GetType\AddPoke.cshtml"
AddHtmlAttributeValue("", 5842, poke.Name, 5842, 10, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 134 "C:\Users\lewis\Desktop\Capstone Project\Views\GetType\AddPoke.cshtml"
AddHtmlAttributeValue("", 5890, poke.Name, 5890, 10, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 5, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 5906, "~/images/pokes/pokemon_icon_", 5906, 28, true);
#nullable restore
#line 134 "C:\Users\lewis\Desktop\Capstone Project\Views\GetType\AddPoke.cshtml"
AddHtmlAttributeValue("", 5934, dex, 5934, 6, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue("", 5940, "_", 5940, 1, true);
#nullable restore
#line 134 "C:\Users\lewis\Desktop\Capstone Project\Views\GetType\AddPoke.cshtml"
AddHtmlAttributeValue("", 5941, modifier, 5941, 11, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue("", 5952, ".png", 5952, 4, true);
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 132 "C:\Users\lewis\Desktop\Capstone Project\Views\GetType\AddPoke.cshtml"
AddHtmlAttributeValue("", 5629, poke.Name, 5629, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <br />\r\n                            <span>");
#nullable restore
#line 137 "C:\Users\lewis\Desktop\Capstone Project\Views\GetType\AddPoke.cshtml"
                             Write(poke.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </td>\r\n");
#nullable restore
#line 139 "C:\Users\lewis\Desktop\Capstone Project\Views\GetType\AddPoke.cshtml"
                        counter++;
                        if (counter % 5 == 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            WriteLiteral("</tr><tr>\r\n");
#nullable restore
#line 143 "C:\Users\lewis\Desktop\Capstone Project\Views\GetType\AddPoke.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 148 "C:\Users\lewis\Desktop\Capstone Project\Views\GetType\AddPoke.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PoGoBattleHelper.ViewModels.GetTypeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591