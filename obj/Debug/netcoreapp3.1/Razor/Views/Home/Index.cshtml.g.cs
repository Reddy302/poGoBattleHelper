#pragma checksum "C:\Users\MLewis\Desktop\LaunchCode\CoderGirl 2020\Capstone Project\App-PoGoBattleHelper\PoGoBattleHelper\App\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1326ada5bf69c156948ea972d43acb5eeb64ad99"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\MLewis\Desktop\LaunchCode\CoderGirl 2020\Capstone Project\App-PoGoBattleHelper\PoGoBattleHelper\App\Views\_ViewImports.cshtml"
using PoGoBattleHelper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MLewis\Desktop\LaunchCode\CoderGirl 2020\Capstone Project\App-PoGoBattleHelper\PoGoBattleHelper\App\Views\_ViewImports.cshtml"
using PoGoBattleHelper.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1326ada5bf69c156948ea972d43acb5eeb64ad99", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4beab6cecca1cfaa9085b734186fc40e16bf81e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PoGoBattleHelper.Models.Pokemon>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\MLewis\Desktop\LaunchCode\CoderGirl 2020\Capstone Project\App-PoGoBattleHelper\PoGoBattleHelper\App\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">PoGo Battle Helper</h1>\r\n</div>\r\n\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("<table class=\"table\">\r\n    <tr>\r\n        <th>Name</th>\r\n        <th>Type1</th>\r\n        <th>Type2</th>\r\n    </tr>\r\n");
#nullable restore
#line 20 "C:\Users\MLewis\Desktop\LaunchCode\CoderGirl 2020\Capstone Project\App-PoGoBattleHelper\PoGoBattleHelper\App\Views\Home\Index.cshtml"
     foreach (Pokemon poke in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>");
#nullable restore
#line 23 "C:\Users\MLewis\Desktop\LaunchCode\CoderGirl 2020\Capstone Project\App-PoGoBattleHelper\PoGoBattleHelper\App\Views\Home\Index.cshtml"
       Write(poke.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 24 "C:\Users\MLewis\Desktop\LaunchCode\CoderGirl 2020\Capstone Project\App-PoGoBattleHelper\PoGoBattleHelper\App\Views\Home\Index.cshtml"
         foreach (PoGoBattleHelper.Models.Type type in poke.Types)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <td>");
#nullable restore
#line 26 "C:\Users\MLewis\Desktop\LaunchCode\CoderGirl 2020\Capstone Project\App-PoGoBattleHelper\PoGoBattleHelper\App\Views\Home\Index.cshtml"
       Write(type.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 27 "C:\Users\MLewis\Desktop\LaunchCode\CoderGirl 2020\Capstone Project\App-PoGoBattleHelper\PoGoBattleHelper\App\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tr>\r\n");
#nullable restore
#line 30 "C:\Users\MLewis\Desktop\LaunchCode\CoderGirl 2020\Capstone Project\App-PoGoBattleHelper\PoGoBattleHelper\App\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PoGoBattleHelper.Models.Pokemon>> Html { get; private set; }
    }
}
#pragma warning restore 1591