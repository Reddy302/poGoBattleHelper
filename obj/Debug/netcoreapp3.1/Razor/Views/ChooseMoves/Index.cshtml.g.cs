#pragma checksum "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseMoves\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3dd36d6708ca5dfcfc6bb42e8f9aa14353e025dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ChooseMoves_Index), @"mvc.1.0.view", @"/Views/ChooseMoves/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dd36d6708ca5dfcfc6bb42e8f9aa14353e025dc", @"/Views/ChooseMoves/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4beab6cecca1cfaa9085b734186fc40e16bf81e", @"/Views/_ViewImports.cshtml")]
    public class Views_ChooseMoves_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PoGoBattleHelper.ViewModels.ChooseMovesViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ChooseTeam", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("name"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 130px; max-width: 150px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("valign", new global::Microsoft.AspNetCore.Html.HtmlString("bottom"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("ChooseMoves"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("py-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"mx-auto pt-4 pb-3 text-center\">\r\n    <h3 class=\"h3\"><strong>Your Team</strong></h3>\r\n</div>\r\n<div class=\"mx-auto text-center\">\r\n");
#nullable restore
#line 7 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseMoves\Index.cshtml"
     if (Model.TempTeam == null || Model.TempTeam.Count() == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span><strong>SOMETHING WENT WRONG. PLEASE TRY AGAIN.</strong></span>\r\n        <br />\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3dd36d6708ca5dfcfc6bb42e8f9aa14353e025dc7067", async() => {
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
#line 12 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseMoves\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <table class=\"mx-auto text-center\">\r\n            <tbody>\r\n                <tr>\r\n");
#nullable restore
#line 18 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseMoves\Index.cshtml"
                     foreach (Pokemon poke in Model.TempTeam)
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
                        else
                        {
                            modifier = "00";
                        }

                        string dex = poke.Dex.ToString("D3");


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td class=\"p-3\">\r\n                            <div class=\"py-3 px-3 text-center\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3dd36d6708ca5dfcfc6bb42e8f9aa14353e025dc14071", async() => {
                WriteLiteral("\r\n                                    <input type=\"hidden\"");
                BeginWriteAttribute("id", " id=\"", 5864, "\"", 5889, 1);
#nullable restore
#line 135 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseMoves\Index.cshtml"
WriteAttributeValue("", 5869, poke.Name.ToLower(), 5869, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"name\"");
                BeginWriteAttribute("value", " value=\"", 5902, "\"", 5930, 1);
#nullable restore
#line 135 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseMoves\Index.cshtml"
WriteAttributeValue("", 5910, poke.Name.ToLower(), 5910, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3dd36d6708ca5dfcfc6bb42e8f9aa14353e025dc15193", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 136 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseMoves\Index.cshtml"
AddHtmlAttributeValue("", 5983, poke.Name.ToLower(), 5983, 20, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "value", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 136 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseMoves\Index.cshtml"
AddHtmlAttributeValue("", 6037, poke.Name.ToLower(), 6037, 20, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 136 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseMoves\Index.cshtml"
AddHtmlAttributeValue("", 6064, poke.Name, 6064, 10, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 5, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 6081, "~/images/pokes/pokemon_icon_", 6081, 28, true);
#nullable restore
#line 136 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseMoves\Index.cshtml"
AddHtmlAttributeValue("", 6109, dex, 6109, 6, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue("", 6115, "_", 6115, 1, true);
#nullable restore
#line 136 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseMoves\Index.cshtml"
AddHtmlAttributeValue("", 6116, modifier, 6116, 11, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue("", 6127, ".png", 6127, 4, true);
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 134 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseMoves\Index.cshtml"
AddHtmlAttributeValue("", 5708, poke.Name.ToLower(), 5708, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <div class=\"py-0 text-center\"><strong>");
#nullable restore
#line 138 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseMoves\Index.cshtml"
                                                                 Write(poke.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></div>\r\n                            </div>\r\n                        </td>\r\n");
#nullable restore
#line 141 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseMoves\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tr>
                <tr>
                    <td colspan=""3"">
                        <p class=""mx-auto text-center"">Choose a Pokemon above to select it's moves.</p>
                    </td>
                </tr>
            </tbody>
        </table>
");
#nullable restore
#line 150 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseMoves\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n");
#nullable restore
#line 154 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseMoves\Index.cshtml"
 if (Model.TempTeam != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"mx-auto text-center\"><h4><strong>My Team Test</strong></h4></div>\r\n");
#nullable restore
#line 157 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseMoves\Index.cshtml"
     if (Model.TempTeam.Count == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"mx-auto text-center\">Please choose a team to test me</div>");
#nullable restore
#line 158 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseMoves\Index.cshtml"
                                                                           }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table mx-auto\">\r\n        <tbody>\r\n");
#nullable restore
#line 161 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseMoves\Index.cshtml"
             foreach (Pokemon poke in Model.TempTeam)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        <b>Poke:</b> ");
#nullable restore
#line 165 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseMoves\Index.cshtml"
                                Write(poke.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n");
#nullable restore
#line 167 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseMoves\Index.cshtml"
                     foreach (PoGoBattleHelper.Models.Type type in poke.Types)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            <b>Type:</b> ");
#nullable restore
#line 170 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseMoves\Index.cshtml"
                                    Write(type.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n");
#nullable restore
#line 172 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseMoves\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 173 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseMoves\Index.cshtml"
                     foreach (Move move in poke.CinematicMoves)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            <b>Charged Move:</b> ");
#nullable restore
#line 176 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseMoves\Index.cshtml"
                                            Write(move.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td><b>Move Type:</b> ");
#nullable restore
#line 178 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseMoves\Index.cshtml"
                                         Write(move.PokemonType.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 179 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseMoves\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 180 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseMoves\Index.cshtml"
                     foreach (Move move in poke.QuickMoves)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            <b>Fast Move:</b>  ");
#nullable restore
#line 183 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseMoves\Index.cshtml"
                                          Write(move.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td><b>Move Type:</b> ");
#nullable restore
#line 185 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseMoves\Index.cshtml"
                                         Write(move.PokemonType.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 186 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseMoves\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n");
#nullable restore
#line 188 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseMoves\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 191 "C:\Users\lewis\Desktop\Capstone Project\Views\ChooseMoves\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PoGoBattleHelper.ViewModels.ChooseMovesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
