#pragma checksum "D:\Dojo_Assignments\C#\ORM\TheWall\Views\Home\_ShowMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0a403e2f9de56dd6471ca7ead02647d17d751d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__ShowMessage), @"mvc.1.0.view", @"/Views/Home/_ShowMessage.cshtml")]
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
#line 1 "D:\Dojo_Assignments\C#\ORM\TheWall\Views\_ViewImports.cshtml"
using TheWall;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Dojo_Assignments\C#\ORM\TheWall\Views\_ViewImports.cshtml"
using TheWall.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Dojo_Assignments\C#\ORM\TheWall\Views\_ViewImports.cshtml"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0a403e2f9de56dd6471ca7ead02647d17d751d9", @"/Views/Home/_ShowMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5a812e09bc0cad14ed0dda375d9b2abc9dddfb6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__ShowMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Message>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_DeleteMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_DeleteComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Dojo_Assignments\C#\ORM\TheWall\Views\Home\_ShowMessage.cshtml"
  
        foreach(Message m in Model)
        {   

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"pl-3 font-weight-bold text-primary\">");
#nullable restore
#line 5 "D:\Dojo_Assignments\C#\ORM\TheWall\Views\Home\_ShowMessage.cshtml"
                                                       Write(m.Creator.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 5 "D:\Dojo_Assignments\C#\ORM\TheWall\Views\Home\_ShowMessage.cshtml"
                                                                         Write(m.UpdatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"pl-3 py-2\">");
#nullable restore
#line 7 "D:\Dojo_Assignments\C#\ORM\TheWall\Views\Home\_ShowMessage.cshtml"
                              Write(m.MessageContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"my-4 row col-sm-3\">\r\n                <a id=\"new-comment\" class=\"col text-success\" style=\"cursor: pointer;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 379, "\"", 448, 5);
            WriteAttributeValue("", 389, "showModal(\'/newcommentpartial/", 389, 30, true);
#nullable restore
#line 9 "D:\Dojo_Assignments\C#\ORM\TheWall\Views\Home\_ShowMessage.cshtml"
WriteAttributeValue("", 419, m.MessageId, 419, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 431, "\',", 431, 2, true);
            WriteAttributeValue(" ", 433, "\'New", 434, 5, true);
            WriteAttributeValue(" ", 438, "Comment\')", 439, 10, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-comment\"></i></a>\r\n");
#nullable restore
#line 10 "D:\Dojo_Assignments\C#\ORM\TheWall\Views\Home\_ShowMessage.cshtml"
                  
                    if(m.Creator == ViewBag.curuser)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a id=\"edit-message\" class=\"col text-info\" style=\"cursor: pointer;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 673, "\"", 744, 5);
            WriteAttributeValue("", 683, "showModal(\'/editmessagepartial/", 683, 31, true);
#nullable restore
#line 13 "D:\Dojo_Assignments\C#\ORM\TheWall\Views\Home\_ShowMessage.cshtml"
WriteAttributeValue("", 714, m.MessageId, 714, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 726, "\',", 726, 2, true);
            WriteAttributeValue(" ", 728, "\'Edit", 729, 6, true);
            WriteAttributeValue(" ", 734, "Message\')", 735, 10, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-pencil-alt\"></i></a>\r\n");
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d0a403e2f9de56dd6471ca7ead02647d17d751d96869", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 15 "D:\Dojo_Assignments\C#\ORM\TheWall\Views\Home\_ShowMessage.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = m;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 16 "D:\Dojo_Assignments\C#\ORM\TheWall\Views\Home\_ShowMessage.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <hr>\r\n");
#nullable restore
#line 20 "D:\Dojo_Assignments\C#\ORM\TheWall\Views\Home\_ShowMessage.cshtml"
            
            if(m.CommentsForMessage.Count>0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p class=\"pl-3 font-weight-bold\">Comment:</p>\r\n");
#nullable restore
#line 24 "D:\Dojo_Assignments\C#\ORM\TheWall\Views\Home\_ShowMessage.cshtml"
                foreach(Comment c in m.CommentsForMessage)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"pl-5 font-weight-bold text-primary\">\r\n                        <span>");
#nullable restore
#line 27 "D:\Dojo_Assignments\C#\ORM\TheWall\Views\Home\_ShowMessage.cshtml"
                         Write(c.Creator.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 27 "D:\Dojo_Assignments\C#\ORM\TheWall\Views\Home\_ShowMessage.cshtml"
                                           Write(c.CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    \r\n");
#nullable restore
#line 29 "D:\Dojo_Assignments\C#\ORM\TheWall\Views\Home\_ShowMessage.cshtml"
                      

                        if(c.Creator == ViewBag.curuser)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d0a403e2f9de56dd6471ca7ead02647d17d751d910184", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 33 "D:\Dojo_Assignments\C#\ORM\TheWall\Views\Home\_ShowMessage.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = c;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 34 "D:\Dojo_Assignments\C#\ORM\TheWall\Views\Home\_ShowMessage.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                    <div class=\"pl-5 py-2 mb-4\">\r\n                        ");
#nullable restore
#line 38 "D:\Dojo_Assignments\C#\ORM\TheWall\Views\Home\_ShowMessage.cshtml"
                   Write(c.CommentContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <hr>\r\n");
#nullable restore
#line 41 "D:\Dojo_Assignments\C#\ORM\TheWall\Views\Home\_ShowMessage.cshtml"
                }
            }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Message>> Html { get; private set; }
    }
}
#pragma warning restore 1591
