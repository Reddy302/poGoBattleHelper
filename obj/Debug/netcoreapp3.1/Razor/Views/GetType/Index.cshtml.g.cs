#pragma checksum "C:\Users\lewis\Desktop\Capstone Project\Views\GetType\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ff4c4e9547cbf7b388213d2085630ef289d367d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GetType_Index), @"mvc.1.0.view", @"/Views/GetType/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ff4c4e9547cbf7b388213d2085630ef289d367d", @"/Views/GetType/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4beab6cecca1cfaa9085b734186fc40e16bf81e", @"/Views/_ViewImports.cshtml")]
    public class Views_GetType_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PoGoBattleHelper.ViewModels.GetTypeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("type"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("valign", new global::Microsoft.AspNetCore.Html.HtmlString("center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("valign", new global::Microsoft.AspNetCore.Html.HtmlString("bottom"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        <h3>Choose first type</h3>
    </div>
    <br />
    <h4>Pokemon Types:</h4>
    <table align=""center"">
        <tbody>
            <tr>
");
#nullable restore
#line 15 "C:\Users\lewis\Desktop\Capstone Project\Views\GetType\Index.cshtml"
                  int counter = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\lewis\Desktop\Capstone Project\Views\GetType\Index.cshtml"
                 foreach (PoGoBattleHelper.Models.Type type in Model.Types)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ff4c4e9547cbf7b388213d2085630ef289d367d5935", async() => {
                WriteLiteral("\r\n                            <input type=\"hidden\"");
                BeginWriteAttribute("id", " id=", 707, "", 731, 1);
#nullable restore
#line 20 "C:\Users\lewis\Desktop\Capstone Project\Views\GetType\Index.cshtml"
WriteAttributeValue("", 711, type.Name.ToLower(), 711, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"type\"");
                BeginWriteAttribute("value", " value=", 743, "", 770, 1);
#nullable restore
#line 20 "C:\Users\lewis\Desktop\Capstone Project\Views\GetType\Index.cshtml"
WriteAttributeValue("", 750, type.Name.ToLower(), 750, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1ff4c4e9547cbf7b388213d2085630ef289d367d7014", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 21 "C:\Users\lewis\Desktop\Capstone Project\Views\GetType\Index.cshtml"
AddHtmlAttributeValue("", 813, type.Name.ToLower(), 813, 20, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 21 "C:\Users\lewis\Desktop\Capstone Project\Views\GetType\Index.cshtml"
AddHtmlAttributeValue("", 863, type.Name, 863, 10, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 879, "~/images/types/", 879, 15, true);
#nullable restore
#line 21 "C:\Users\lewis\Desktop\Capstone Project\Views\GetType\Index.cshtml"
AddHtmlAttributeValue("", 894, type.Id, 894, 10, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue("", 904, ".png", 904, 4, true);
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 19 "C:\Users\lewis\Desktop\Capstone Project\Views\GetType\Index.cshtml"
AddHtmlAttributeValue("", 594, type.Name.ToLower(), 594, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n");
#nullable restore
#line 24 "C:\Users\lewis\Desktop\Capstone Project\Views\GetType\Index.cshtml"
                    counter++;
                    if (counter % 9 == 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            WriteLiteral("</tr><tr>\r\n");
#nullable restore
#line 28 "C:\Users\lewis\Desktop\Capstone Project\Views\GetType\Index.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n        </tbody>\r\n    </table>\r\n</div>\r\n<br />\r\n<br/>\r\n<div class=\"text-center\">\r\n");
#nullable restore
#line 37 "C:\Users\lewis\Desktop\Capstone Project\Views\GetType\Index.cshtml"
     if (ViewBag.possiblePokes.Count == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Choose a type to see possible Pokemon with that type here.</p>\r\n");
#nullable restore
#line 40 "C:\Users\lewis\Desktop\Capstone Project\Views\GetType\Index.cshtml"
    }
    else
    {
        int counter2 = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <table align=\"center\">\r\n            <tbody>\r\n                <tr vertical-align=\"bottom\">\r\n");
#nullable restore
#line 47 "C:\Users\lewis\Desktop\Capstone Project\Views\GetType\Index.cshtml"
                     foreach (Pokemon poke in ViewBag.possiblePokes)
                    {
                        string modifier = "00";
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\lewis\Desktop\Capstone Project\Views\GetType\Index.cshtml"
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
#line 153 "C:\Users\lewis\Desktop\Capstone Project\Views\GetType\Index.cshtml"
                         

                        string dex = poke.Dex.ToString("D3");

                        // Below you will likely have to change the action to "AddPoke" or some shit to get the poke on your team

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td vertical-align=\"bottom\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ff4c4e9547cbf7b388213d2085630ef289d367d18510", async() => {
                WriteLiteral("\r\n                                <input type=\"hidden\"");
                BeginWriteAttribute("id", " id=", 6750, "", 6764, 1);
#nullable restore
#line 160 "C:\Users\lewis\Desktop\Capstone Project\Views\GetType\Index.cshtml"
WriteAttributeValue("", 6754, poke.Name, 6754, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=", 6764, "", 6780, 1);
#nullable restore
#line 160 "C:\Users\lewis\Desktop\Capstone Project\Views\GetType\Index.cshtml"
WriteAttributeValue("", 6770, poke.Name, 6770, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=", 6780, "", 6797, 1);
#nullable restore
#line 160 "C:\Users\lewis\Desktop\Capstone Project\Views\GetType\Index.cshtml"
WriteAttributeValue("", 6787, poke.Name, 6787, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1ff4c4e9547cbf7b388213d2085630ef289d367d19861", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 161 "C:\Users\lewis\Desktop\Capstone Project\Views\GetType\Index.cshtml"
AddHtmlAttributeValue("", 6844, poke.Name, 6844, 10, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "name", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 161 "C:\Users\lewis\Desktop\Capstone Project\Views\GetType\Index.cshtml"
AddHtmlAttributeValue("", 6860, poke.Name, 6860, 10, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 161 "C:\Users\lewis\Desktop\Capstone Project\Views\GetType\Index.cshtml"
AddHtmlAttributeValue("", 6888, poke.Name, 6888, 10, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 5, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 6904, "~/images/pokes/pokemon_icon_", 6904, 28, true);
#nullable restore
#line 161 "C:\Users\lewis\Desktop\Capstone Project\Views\GetType\Index.cshtml"
AddHtmlAttributeValue("", 6932, dex, 6932, 6, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue("", 6938, "_", 6938, 1, true);
#nullable restore
#line 161 "C:\Users\lewis\Desktop\Capstone Project\Views\GetType\Index.cshtml"
AddHtmlAttributeValue("", 6939, modifier, 6939, 11, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue("", 6950, ".png", 6950, 4, true);
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
#line 159 "C:\Users\lewis\Desktop\Capstone Project\Views\GetType\Index.cshtml"
AddHtmlAttributeValue("", 6639, poke.Name, 6639, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "name", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 159 "C:\Users\lewis\Desktop\Capstone Project\Views\GetType\Index.cshtml"
AddHtmlAttributeValue("", 6655, poke.Name, 6655, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <br />\r\n                            <span>");
#nullable restore
#line 164 "C:\Users\lewis\Desktop\Capstone Project\Views\GetType\Index.cshtml"
                             Write(poke.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </td>\r\n");
#nullable restore
#line 166 "C:\Users\lewis\Desktop\Capstone Project\Views\GetType\Index.cshtml"
                        counter2++;
                        if (counter2 % 5 == 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            WriteLiteral("</tr><tr>\r\n");
#nullable restore
#line 170 "C:\Users\lewis\Desktop\Capstone Project\Views\GetType\Index.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 175 "C:\Users\lewis\Desktop\Capstone Project\Views\GetType\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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