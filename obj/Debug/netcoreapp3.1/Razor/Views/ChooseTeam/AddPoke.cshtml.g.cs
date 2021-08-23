#pragma checksum "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseTeam\AddPoke.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e68ce5c54761226e166ffe68b80a3608a351edd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ChooseTeam_AddPoke), @"mvc.1.0.view", @"/Views/ChooseTeam/AddPoke.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e68ce5c54761226e166ffe68b80a3608a351edd", @"/Views/ChooseTeam/AddPoke.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4beab6cecca1cfaa9085b734186fc40e16bf81e", @"/Views/_ViewImports.cshtml")]
    public class Views_ChooseTeam_AddPoke : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PoGoBattleHelper.ViewModels.ChooseTeamViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ChooseTeam", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetType", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("poke"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("valign", new global::Microsoft.AspNetCore.Html.HtmlString("bottom"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("AddPoke"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            WriteLiteral("<div class=\"text-center\">\r\n    <div style=\"padding: 100px 0px 50px;\" class=\"text-center\">\r\n        <h2>Please choose the Pokemon below.</h2>\r\n    </div>\r\n    <h4>Pokemon with the types you chose:</h4>\r\n    <br />\r\n");
#nullable restore
#line 12 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseTeam\AddPoke.cshtml"
     if (Model.PossiblePokes.Count == 0 && Model.PossiblePokes2Types.Count == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e68ce5c54761226e166ffe68b80a3608a351edd6383", async() => {
                WriteLiteral("Choose Pokemon by Type");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 15 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseTeam\AddPoke.cshtml"
    }
    else if (Model.PossiblePokes2Types.Count != 0)
    {
        int counter = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <table align=\"center\">\r\n            <tbody>\r\n                <tr vertical-align=\"bottom\">\r\n");
#nullable restore
#line 22 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseTeam\AddPoke.cshtml"
                     foreach (Pokemon poke in Model.PossiblePokes2Types)
                    {
                        string modifier = "00";
                        if (poke.Name.ToLower().Contains("castform sunny"))
                        {
                            modifier = "12";
                        }
                        else if (poke.Name.ToLower().Contains("castform rainy"))
                        {
                            modifier = "13";
                        }
                        else if (poke.Name.ToLower().Contains("castform snowy"))
                        {
                            modifier = "14";
                        }
                        else if (poke.Name.ToLower().Contains("deoxys attack"))
                        {
                            modifier = "16";
                        }
                        else if (poke.Name.ToLower().Contains("deoxys defense"))
                        {
                            modifier = "17";
                        }
                        else if (poke.Name.ToLower().Contains("deoxys speed"))
                        {
                            modifier = "18";
                        }
                        else if (poke.Name.ToLower().Contains("burmy plant"))
                        {
                            modifier = "19";
                        }
                        else if (poke.Name.ToLower().Contains("burmy sandy"))
                        {
                            modifier = "20";
                        }
                        else if (poke.Name.ToLower().Contains("burmy trash"))
                        {
                            modifier = "21";
                        }
                        else if (poke.Name.ToLower().Contains("wormdam plant"))
                        {
                            modifier = "22";
                        }
                        else if (poke.Name.ToLower().Contains("wormdam sandy"))
                        {
                            modifier = "23";
                        }
                        else if (poke.Name.ToLower().Contains("wormdam trash"))
                        {
                            modifier = "24";
                        }
                        else if (poke.Name.ToLower().Contains("cherrim overcast"))
                        {
                            modifier = "25";
                        }
                        else if (poke.Name.ToLower().Contains("cherrim sunny"))
                        {
                            modifier = "26";
                        }
                        else if (poke.Name.ToLower().Contains("rotom heat"))
                        {
                            modifier = "27";
                        }
                        else if (poke.Name.ToLower().Contains("rotom wash"))
                        {
                            modifier = "28";
                        }
                        else if (poke.Name.ToLower().Contains("rotom frost"))
                        {
                            modifier = "29";
                        }
                        else if (poke.Name.ToLower().Contains("rotom fan"))
                        {
                            modifier = "30";
                        }
                        else if (poke.Name.ToLower().Contains("rotom mow"))
                        {
                            modifier = "91";
                        }
                        else if (poke.Name.ToLower().Contains("giratina altered"))
                        {
                            modifier = "32";
                        }
                        else if (poke.Name.ToLower().Contains("giratina origin"))
                        {
                            modifier = "33";
                        }
                        else if (poke.Name.ToLower().Contains("shaymin land"))
                        {
                            modifier = "34";
                        }
                        else if (poke.Name.ToLower().Contains("shaymin sky"))
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

                        string dex = poke.Dex.ToString("D3");

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td vertical-align=\"bottom\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e68ce5c54761226e166ffe68b80a3608a351edd13288", async() => {
                WriteLiteral("\r\n                                <input type=\"hidden\"");
                BeginWriteAttribute("id", " id=\"", 5848, "\"", 5873, 1);
#nullable restore
#line 133 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseTeam\AddPoke.cshtml"
WriteAttributeValue("", 5853, poke.Name.ToLower(), 5853, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"poke\"");
                BeginWriteAttribute("value", " value=\"", 5886, "\"", 5914, 1);
#nullable restore
#line 133 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseTeam\AddPoke.cshtml"
WriteAttributeValue("", 5894, poke.Name.ToLower(), 5894, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5e68ce5c54761226e166ffe68b80a3608a351edd14404", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 134 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseTeam\AddPoke.cshtml"
AddHtmlAttributeValue("", 5963, poke.Name.ToLower(), 5963, 20, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "value", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 134 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseTeam\AddPoke.cshtml"
AddHtmlAttributeValue("", 6017, poke.Name.ToLower(), 6017, 20, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 134 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseTeam\AddPoke.cshtml"
AddHtmlAttributeValue("", 6044, poke.Name, 6044, 10, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 5, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 6061, "~/images/pokes/pokemon_icon_", 6061, 28, true);
#nullable restore
#line 134 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseTeam\AddPoke.cshtml"
AddHtmlAttributeValue("", 6089, dex, 6089, 6, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue("", 6095, "_", 6095, 1, true);
#nullable restore
#line 134 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseTeam\AddPoke.cshtml"
AddHtmlAttributeValue("", 6096, modifier, 6096, 11, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue("", 6107, ".png", 6107, 4, true);
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
#line 132 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseTeam\AddPoke.cshtml"
AddHtmlAttributeValue("", 5713, poke.Name.ToLower(), 5713, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
            WriteLiteral("\r\n                            <br />\r\n                            <span>");
#nullable restore
#line 137 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseTeam\AddPoke.cshtml"
                             Write(poke.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </td>\r\n");
#nullable restore
#line 139 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseTeam\AddPoke.cshtml"
                        counter++;
                        if (counter % 5 == 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            WriteLiteral("</tr><tr>\r\n");
#nullable restore
#line 143 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseTeam\AddPoke.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 148 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseTeam\AddPoke.cshtml"
    }
    else if (Model.PossiblePokes.Count != 0)
    {
        int counter2 = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <table align=\"center\">\r\n            <tbody>\r\n                <tr vertical-align=\"bottom\">\r\n");
#nullable restore
#line 155 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseTeam\AddPoke.cshtml"
                     foreach (Pokemon poke in Model.PossiblePokes)
                    {
                        string modifier = "00";
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 158 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseTeam\AddPoke.cshtml"
                         if (poke.Name.ToLower().Contains("castform sunny"))
                        {
                            modifier = "12";
                        }
                        else if (poke.Name.ToLower().Contains("castform rainy"))
                        {
                            modifier = "13";
                        }
                        else if (poke.Name.ToLower().Contains("castform snowy"))
                        {
                            modifier = "14";
                        }
                        else if (poke.Name.ToLower().Contains("deoxys attack"))
                        {
                            modifier = "16";
                        }
                        else if (poke.Name.ToLower().Contains("deoxys defense"))
                        {
                            modifier = "17";
                        }
                        else if (poke.Name.ToLower().Contains("deoxys speed"))
                        {
                            modifier = "18";
                        }
                        else if (poke.Name.ToLower().Contains("burmy plant"))
                        {
                            modifier = "19";
                        }
                        else if (poke.Name.ToLower().Contains("burmy sandy"))
                        {
                            modifier = "20";
                        }
                        else if (poke.Name.ToLower().Contains("burmy trash"))
                        {
                            modifier = "21";
                        }
                        else if (poke.Name.ToLower().Contains("wormdam plant"))
                        {
                            modifier = "22";
                        }
                        else if (poke.Name.ToLower().Contains("wormdam sandy"))
                        {
                            modifier = "23";
                        }
                        else if (poke.Name.ToLower().Contains("wormdam trash"))
                        {
                            modifier = "24";
                        }
                        else if (poke.Name.ToLower().Contains("cherrim overcast"))
                        {
                            modifier = "25";
                        }
                        else if (poke.Name.ToLower().Contains("cherrim sunny"))
                        {
                            modifier = "26";
                        }
                        else if (poke.Name.ToLower().Contains("rotom heat"))
                        {
                            modifier = "27";
                        }
                        else if (poke.Name.ToLower().Contains("rotom wash"))
                        {
                            modifier = "28";
                        }
                        else if (poke.Name.ToLower().Contains("rotom frost"))
                        {
                            modifier = "29";
                        }
                        else if (poke.Name.ToLower().Contains("rotom fan"))
                        {
                            modifier = "30";
                        }
                        else if (poke.Name.ToLower().Contains("rotom mow"))
                        {
                            modifier = "91";
                        }
                        else if (poke.Name.ToLower().Contains("giratina altered"))
                        {
                            modifier = "32";
                        }
                        else if (poke.Name.ToLower().Contains("giratina origin"))
                        {
                            modifier = "33";
                        }
                        else if (poke.Name.ToLower().Contains("shaymin land"))
                        {
                            modifier = "34";
                        }
                        else if (poke.Name.ToLower().Contains("shaymin sky"))
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
#line 261 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseTeam\AddPoke.cshtml"
                         

                        string dex = poke.Dex.ToString("D3");

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td vertical-align=\"bottom\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e68ce5c54761226e166ffe68b80a3608a351edd26689", async() => {
                WriteLiteral("\r\n                                <input type=\"hidden\"");
                BeginWriteAttribute("id", " id=\"", 11813, "\"", 11838, 1);
#nullable restore
#line 266 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseTeam\AddPoke.cshtml"
WriteAttributeValue("", 11818, poke.Name.ToLower(), 11818, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"poke\"");
                BeginWriteAttribute("value", " value=\"", 11851, "\"", 11879, 1);
#nullable restore
#line 266 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseTeam\AddPoke.cshtml"
WriteAttributeValue("", 11859, poke.Name.ToLower(), 11859, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5e68ce5c54761226e166ffe68b80a3608a351edd27813", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 267 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseTeam\AddPoke.cshtml"
AddHtmlAttributeValue("", 11928, poke.Name.ToLower(), 11928, 20, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "value", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 267 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseTeam\AddPoke.cshtml"
AddHtmlAttributeValue("", 11982, poke.Name.ToLower(), 11982, 20, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 267 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseTeam\AddPoke.cshtml"
AddHtmlAttributeValue("", 12008, poke.Name, 12008, 10, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 5, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 12024, "~/images/pokes/pokemon_icon_", 12024, 28, true);
#nullable restore
#line 267 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseTeam\AddPoke.cshtml"
AddHtmlAttributeValue("", 12052, dex, 12052, 6, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue("", 12058, "_", 12058, 1, true);
#nullable restore
#line 267 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseTeam\AddPoke.cshtml"
AddHtmlAttributeValue("", 12059, modifier, 12059, 11, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue("", 12070, ".png", 12070, 4, true);
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
#line 265 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseTeam\AddPoke.cshtml"
AddHtmlAttributeValue("", 11678, poke.Name.ToLower(), 11678, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
            WriteLiteral("\r\n                            <br />\r\n                            <span>");
#nullable restore
#line 270 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseTeam\AddPoke.cshtml"
                             Write(poke.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </td>\r\n");
#nullable restore
#line 272 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseTeam\AddPoke.cshtml"
                        counter2++;
                        if (counter2 % 5 == 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            WriteLiteral("</tr><tr>\r\n");
#nullable restore
#line 276 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseTeam\AddPoke.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 281 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseTeam\AddPoke.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PoGoBattleHelper.ViewModels.ChooseTeamViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
