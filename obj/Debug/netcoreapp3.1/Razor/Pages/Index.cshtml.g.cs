#pragma checksum "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5657bf2c8c622e665a7feac3061e03367a690be1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PJSrenovationWeb.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace PJSrenovationWeb.Pages
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
#nullable restore
#line 3 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Index.cshtml"
using PJSrenovationWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5657bf2c8c622e665a7feac3061e03367a690be1", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"361560c68f240a126124f6e8f876cbf9d14f1ff5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Admin\Google Drive\pjs renovation ltd\PJSrenovationsSolution\PJSrenovationWeb\Pages\Index.cshtml"
  
    ViewData["Title"] = "Dashboard";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section >
    <div class=""row p-2 m-1"">
        <div class=""col-sm-12 text-center"">
            <p><u class=""display-3"">Project Monitor</u></p>
        </div>
    </div>
    <div class=""row mb-4 p-3 card"">
        <div class=""col-sm-12 text-center"" id=""weekly-performance"">
");
            WriteLiteral("        </div>\r\n\r\n    </div>\r\n    <div class=\"row\">\r\n        <div id=\"painter-performace\" class=\"col-sm-6 card  \">\r\n");
            WriteLiteral("        </div>\r\n        <div class=\"col-sm-6 card\" id=\"work-category\">\r\n");
            WriteLiteral("        </div>\r\n    </div>");
            WriteLiteral("<div class=\"row mt-2\">\r\n    <div class=\"col-sm-6   card\" id=\"project-performance\">\r\n");
            WriteLiteral(@"    </div>
    <div class=""col-sm-6 card"">
    <div class=""card-title text-center"">Work Type and Hours</div>
        <table id=""project-labour-hours"" class=""table-bordered table-striped table-hover"">

            <thead class=""bg-dark text-white"" >
                <tr>
                    <th class=""mr-1 p-1"">Type</th>

                    <th class=""mr-1 p-1"">Expected</th>
                    <th class=""mr-1 p-1"">Actual</th>
                    <th class=""mr-1 p-1"">Painter</th>
                </tr>
            </thead>
            <tbody id=""databody"">
            </tbody>
        </table>
    </div>");
            WriteLiteral("</div>");
            WriteLiteral("    <div class=\"row mt-4 p-4 \">\r\n        <div id=\"project\" class=\"col-sm-12 mt-4 p-4\">\r\n\r\n        </div>\r\n    </div>\r\n\r\n\r\n</section>\r\n\r\n\r\n\r\n");
            DefineSection("Dashboard_Scripts", async() => {
                WriteLiteral("\r\n\r\n");
                WriteLiteral("    <script type=\"text/javascript\" src=\"https://www.gstatic.com/charts/loader.js\"></script>\r\n\r\n");
                WriteLiteral(@"    <script type=""text/javascript"">
        google.charts.load('current', { 'packages': ['corechart'] });
        google.charts.setOnLoadCallback(drawChart);
        var weeklyProjectMonitoring;
        $(document).ready(function () {
            $.ajax({
                url: '/api/Dashboard/WeeklyPerformance',
                data: '',
                dataType: 'json',
                type: 'GET',
                contentType: 'application/json; chartset=utf-8',
                success: function (data) {
                    weeklyProjectMonitoring = data;
                },
                error: function () {
                    alert(""Error loading weekly performance  data, Please try again later"")
                },



            }).done(function () {
                console.log( weeklyProjectMonitoring)
            });

        });

        function drawChart() {
            var data = google.visualization.arrayToDataTable(weeklyProjectMonitoring);
            //    [
       ");
                WriteLiteral(@"     //    ['WeekEnd', 'Target', 'Actual'],
            //    ['31/06', 54, 60],
            //    ['07/08', 100, 110],
            //    ['14/08', 98, 78],
            //    ['21/08', 103, 150]
            //]);

            var options = {
                title: 'Weekly Project Performance',
                
                curveType: 'function',
                legend: { position: 'right' },
                   vAxis: {
                    title: ""Hours""
                },
                hAxis: {
                    title: ""Dates"",
                },
            };

            var chart = new google.visualization.LineChart(document.getElementById('weekly-performance'));

            chart.draw(data, options);
        }
    </script>
");
                WriteLiteral("\r\n");
                WriteLiteral(@"    <script type=""text/javascript"">

        window.onload = () => {
            var xmlr = new XMLHttpRequest();

            xmlr.onreadystatechange = function () {
                if (this.readyState == 4 && this.status == 200) {
                    console.log(this.responseText);
                    var responseJson = JSON.parse(this.responseText);
                    WorkSurfaceTable(responseJson);
                }
            }
            xmlr.open(""GET"", ""/api/Dashboard/WorkAnalysis"", true)
            xmlr.send();

        };
        //=====================Table population function=================
        function WorkSurfaceTable(data) {
            const tbody = document.getElementById('databody');
            let rows = ' ';
            for (let labourHours of data) {
                rows +=
                    `<tr>
                              <td class = ""p-1"">${labourHours.SurfaceType}</td>
                           
                          <td class = ""p-1"">${la");
                WriteLiteral(@"bourHours.ExpectedHours}</td>
                          <td class = ""p-1"">${labourHours.ActualHours}</td>
                         <td class = ""p-1"">${labourHours.Painter}</td>
                     </tr >`;
            }
            tbody.innerHTML = rows;
        }

    </script>





    <script type=""text/javascript"">
        google.charts.load('current', { packages: ['corechart'] });
    </script>
");
                WriteLiteral("\r\n\r\n");
                WriteLiteral(@"
    <script type=""text/javascript"">
        google.charts.load('current', { 'packages': ['bar'] });
        google.charts.setOnLoadCallback(drawChart);
        // global  data
        var projectPerformance;


        $(document).ready(function () {
            $.ajax({
                url: '/api/Dashboard/ProjectPerformance',
                data: '',
                dataType: 'json',
                type: 'GET',
                contentType: 'application/json; chartset=utf-8',
                success: function (data) {
                    projectPerformance = data;
                },
                error: function () {
                    alert(""Error loading project performance data from server! Please try again"");
                },


            }).done(function () {

                console.log(painterData);
            });


        });


        function drawChart() {
            var data = google.visualization.arrayToDataTable(projectPerformance);

            //va");
                WriteLiteral(@"r options = {
            //    chart: {
            //        title: 'Project Performance',
            //        subtitle: 'Work Targets andPerformance ',
            //    }

            //};

            var options = {
                title: 'Hours Performance Actual and Target',
                subtitle: 'Last Three Projects ',
                height: 350,
                seriesType: ""bars"",
                vAxis: {
                    title: ""Hours""
                },
                hAxis: {
                    title: ""Projects"",
                    slantedText: true,  /* Enable slantedText for horizontal axis */
                    slantedTextAngle: 90 /* Define slant Angle */
                },
                'chartArea': { 'width': '82%', height: '60%', top: '9%', left: '15%', right: '3%', bottom: '0' } /* Adjust chart alignment to fit vertical labels for horizontal axis*/
            };

            var chart = new google.charts.Bar(document.getElementById('project-perform");
                WriteLiteral("ance\'));\r\n\r\n            chart.draw(data, google.charts.Bar.convertOptions(options));\r\n        }\r\n    </script>\r\n\r\n");
                WriteLiteral(@"    <script language=""JavaScript"">
        function drawChart() {
            var jsonData = $.ajax({
                url: ""/api/Dashboard/WorkSurfaceAnalysis"",
                dataType: ""json"",
                async: false
            }).responseText;

            var jObj = JSON.parse(jsonData);
            console.log(jObj);
            var arrayRows = [];
            
            for (let workObj of jObj) {
                arrayRows.push([workObj.Name, workObj.Hours]);
               
            }
            // Define the chart to be drawn.
            var data = new google.visualization.DataTable();
            data.addColumn('string', 'Wall Surfaces');
            data.addColumn('number', 'Percentage');
            for (var i = 0; i < arrayRows.length; i++) {
                data.addRows([arrayRows[i]]);
            }
            //data.addRows([
            //    ['Firefox', 45.0],
            //    ['IE', 26.8],
            //    ['Chrome', 12.8],
            //    ['Safar");
                WriteLiteral(@"i', 8.5],
            //    ['Opera', 6.2],
            //    ['Others', 0.7]
            //]);

            // Set chart options
            var options = {
                'title': 'Painting Surface Ratio ',
                'width': 550,
                'height': 400,
              
            };

            // Instantiate and draw the chart.
            var chart = new google.visualization.PieChart(document.getElementById('work-category'));
            chart.draw(data, options);
        }
        google.charts.setOnLoadCallback(drawChart);
    </script>


");
                WriteLiteral(@"    <script type=""text/javascript"">
        google.charts.load('current', { 'packages': ['bar'] });
        google.charts.setOnLoadCallback(drawChart);
        // global  data
        var painterData;


        $(document).ready(function () {
            $.ajax({
                url: '/api/Dashboard/PainterPerformance',
                data: '',
                dataType: 'json',
                type: 'GET',
                contentType: 'application/json; chartset=utf-8',
                success: function (data) {
                    painterData = data;
                },
                error: function () {
                    alert(""Error loading painter Performance data from server! Please try again"");
                },


            });


        });


        function drawChart() {
            var data = google.visualization.arrayToDataTable(painterData);

            var options = {
                chart: {
                    title: 'Painting Performance',
            ");
                WriteLiteral(@"        subtitle: 'Work Targets and Performance ',
                },
                vAxis: {
                    title: 'Hours'
                }
            };

            var chart = new google.charts.Bar(document.getElementById('painter-performace'));

            chart.draw(data, google.charts.Bar.convertOptions(options));
        }
    </script>


");
                WriteLiteral("\r\n");
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(" ");
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
