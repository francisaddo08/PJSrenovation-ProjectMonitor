#pragma checksum "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Projects\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6d6fe58716e7c7e731357d31bac8f848a66232a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PJSrenovationWeb.Pages.Projects.Pages_Projects_Details), @"mvc.1.0.razor-page", @"/Pages/Projects/Details.cshtml")]
namespace PJSrenovationWeb.Pages.Projects
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
#line 1 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\_ViewImports.cshtml"
using PJSrenovationWeb;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6d6fe58716e7c7e731357d31bac8f848a66232a", @"/Pages/Projects/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"361560c68f240a126124f6e8f876cbf9d14f1ff5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Projects_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Projects\Details.cshtml"
  
    ViewData["Title"] = Model.Project.Property.Address;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"row \">\r\n    <div class=\"col-sm-2 font-weight-bold\">\r\n        ");
#nullable restore
#line 11 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Projects\Details.cshtml"
   Write(Html.DisplayNameFor(model => model.Project.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n        ");
#nullable restore
#line 12 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Projects\Details.cshtml"
   Write(Html.DisplayNameFor(model => model.Project.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n\r\n    </div>\r\n    <div class=\"col-sm-2\">\r\n        ");
#nullable restore
#line 16 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Projects\Details.cshtml"
   Write(Html.DisplayFor(model => model.Project.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        ");
#nullable restore
#line 17 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Projects\Details.cshtml"
   Write(Html.DisplayFor(model => model.Project.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n    </div>\r\n    <div class=\" col-sm-4\">\r\n        <span class=\"font-weight-bold text-muted \"> PROJECT DETAILS</span>\r\n        \r\n     \r\n    </div>\r\n\r\n    <div class=\"col-sm-4\">\r\n");
#nullable restore
#line 26 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Projects\Details.cshtml"
          

            if (Model.Project.ActualEndDate != null)
            {
                DateTime d = Model.Project.ActualEndDate.GetValueOrDefault();


#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"font-weight-bold\">Actual End Date: </span><span> ");
#nullable restore
#line 32 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Projects\Details.cshtml"
                                                                         Write(d.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 33 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Projects\Details.cshtml"
            } 
         
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-sm-4\">\r\n        <h4>Client</h4>\r\n        <span> ");
#nullable restore
#line 42 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Projects\Details.cshtml"
          Write(Html.DisplayFor(model => model.Project.Property.Client.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span><br />\r\n        <span> ");
#nullable restore
#line 43 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Projects\Details.cshtml"
          Write(Html.DisplayFor(model => model.Project.Property.Client.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br /></span>\r\n        <span>  ");
#nullable restore
#line 44 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Projects\Details.cshtml"
           Write(Html.DisplayFor(model => model.Project.Property.Client.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n    </div>\r\n    <div class=\"col-sm-4\">\r\n        <h4>Property</h4>\r\n        <span> ");
#nullable restore
#line 49 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Projects\Details.cshtml"
          Write(Html.DisplayFor(model => model.Project.Property.FullAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br />\r\n        <span> ");
#nullable restore
#line 50 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Projects\Details.cshtml"
          Write(Html.DisplayFor(model => model.Project.Property.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n    </div>\r\n    <div class=\"col-sm-4\">\r\n        <h4> Scope</h4>\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6d6fe58716e7c7e731357d31bac8f848a66232a9406", async() => {
                WriteLiteral("Contract Doc");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1723, "~/documents/", 1723, 12, true);
#nullable restore
#line 56 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Projects\Details.cshtml"
AddHtmlAttributeValue("", 1735, Model.Project.ProjectScope, 1735, 27, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <!-- Button to Open the Modal -->\r\n        <button type=\"button\" class=\"btn btn-primary lightbox-popup\" id=\"lightbox-popup\" onclick=\"openModal()\">\r\n            Open Images\r\n        </button>\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 84 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Projects\Details.cshtml"
  
    Dictionary<string, string> Images = new Dictionary<string, string>();
    if (Model.Project.ProjectImage != null)
    {
        Images.Add(Model.Project.ProjectImage, Model.Project.Property.FullAddress);
    }
    if (Model.Project.PaintingDecoratingWorks.Count != 0)
    {
        foreach (var item in Model.Project.PaintingDecoratingWorks)
        {
            if (item.WorkImage != null)
            {
                Images.Add(item.WorkImage, item.PropertyArea);
            }
            if (item.Job != null && !string.IsNullOrWhiteSpace(item.Job.JobImage))
            {
                Images.Add(item.Job.JobImage, item.PropertyArea);
            }
        }


    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n<div id=\"myModal\" class=\"modal\">\r\n    <span class=\"close cursor\" onclick=\"closeModal()\">&times;</span>\r\n    <div class=\"modal-content\">\r\n");
#nullable restore
#line 114 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Projects\Details.cshtml"
         if (Images.Count != 0)
            {
                int imageIndex = 1;
                foreach (var item in Images)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"mySlides\">\r\n                        <div class=\"numbertext\">");
#nullable restore
#line 121 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Projects\Details.cshtml"
                                           Write(imageIndex);

#line default
#line hidden
#nullable disable
            WriteLiteral("  / ");
#nullable restore
#line 121 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Projects\Details.cshtml"
                                                          Write(Images.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a6d6fe58716e7c7e731357d31bac8f848a66232a13652", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4142, "~/ProjectImages/", 4142, 16, true);
#nullable restore
#line 122 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Projects\Details.cshtml"
AddHtmlAttributeValue("", 4158, item.Key, 4158, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 123 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Projects\Details.cshtml"
AddHtmlAttributeValue("", 4223, item.Value, 4223, 11, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 4234, "]", 4234, 1, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 125 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Projects\Details.cshtml"
                    imageIndex = imageIndex + 1;
                }

            }








        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <a class=\"prev\" onclick=\"plusSlides(-1)\">&#10094;</a>\r\n        <a class=\"next\" onclick=\"plusSlides(1)\">&#10095;</a>\r\n\r\n        <div class=\"caption-container\">\r\n            <p id=\"caption\"></p>\r\n        </div>\r\n\r\n\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n<p>No OF iMAGES ");
#nullable restore
#line 185 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Projects\Details.cshtml"
           Write(Model.ProjectImages.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n\r\n\r\n");
            WriteLiteral(@"<div class=""table-responsive"">
    <h4>Jobs</h4>
    <table class=""table table-bordered "">
        <thead class=""thead-dark"">
            <tr>
                <th>Property Area</th>
                <th>Work</th>
                <th>Colour</th>
                <th>Hours</th>
                <th>Painter</th>
                <th>Status</th>
                <th>Completed</th>

            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 207 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Projects\Details.cshtml"
             foreach (var item in Model.Project.PaintingDecoratingWorks)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 210 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Projects\Details.cshtml"
               Write(item.PropertyArea);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 211 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Projects\Details.cshtml"
               Write(item.WorkArea);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 212 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Projects\Details.cshtml"
                 if (item.Job != null)
                {
                    string colour = item.Job.WallColourValue.Trim();
                    string[] colourValue = colour.Split(" ");


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td class=\"wall-colour\"");
            BeginWriteAttribute("style", " style=\"", 7137, "\"", 7169, 2);
            WriteAttributeValue("", 7145, "background-color:", 7145, 17, true);
#nullable restore
#line 217 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Projects\Details.cshtml"
WriteAttributeValue("", 7162, colour, 7162, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        ");
#nullable restore
#line 218 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Projects\Details.cshtml"
                   Write(item.Job.WallColourName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>");
#nullable restore
#line 220 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Projects\Details.cshtml"
                   Write(item.Job.ManHours);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 221 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Projects\Details.cshtml"
                   Write(item.Job.Painter.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 222 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Projects\Details.cshtml"
                   Write(item.Job.Stages);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 223 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Projects\Details.cshtml"

                    
                    if (item.Job.EndDate != null)
                    {
                        DateTime d = item.Job.EndDate.GetValueOrDefault();

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 228 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Projects\Details.cshtml"
                       Write(d.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                \r\n                </td>\r\n");
#nullable restore
#line 231 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Projects\Details.cshtml"
                    }
                    else
                    {
                        DateTime today = DateTime.UtcNow;

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 235 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Projects\Details.cshtml"
                       Write(today);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 236 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Projects\Details.cshtml"
                    }



                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tr>\r\n");
#nullable restore
#line 243 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Projects\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n<hr />\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-sm-2\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6d6fe58716e7c7e731357d31bac8f848a66232a22656", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 257 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Projects\Details.cshtml"
                               WriteLiteral(Model.Project.ProjectID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6d6fe58716e7c7e731357d31bac8f848a66232a24858", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PJSrenovationWeb.Pages.Projects.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PJSrenovationWeb.Pages.Projects.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PJSrenovationWeb.Pages.Projects.DetailsModel>)PageContext?.ViewData;
        public PJSrenovationWeb.Pages.Projects.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
