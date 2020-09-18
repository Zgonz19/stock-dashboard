#pragma checksum "C:\Users\Gonzalo\Dropbox\GitHubProjects\stock-dashboard\StockDashboard\StockDashboard\Views\Details\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d4c79fd06ba3c87906bf1dc9c90e4b65303a8b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Details_Details), @"mvc.1.0.view", @"/Views/Details/Details.cshtml")]
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
#line 1 "C:\Users\Gonzalo\Dropbox\GitHubProjects\stock-dashboard\StockDashboard\StockDashboard\Views\_ViewImports.cshtml"
using StockDashboard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gonzalo\Dropbox\GitHubProjects\stock-dashboard\StockDashboard\StockDashboard\Views\_ViewImports.cshtml"
using StockDashboard.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d4c79fd06ba3c87906bf1dc9c90e4b65303a8b7", @"/Views/Details/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ec13e9e29a0ff15da18d2f49b86b2380c86a634", @"/Views/_ViewImports.cshtml")]
    public class Views_Details_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Gonzalo\Dropbox\GitHubProjects\stock-dashboard\StockDashboard\StockDashboard\Views\Details\Details.cshtml"
  
    ViewData["Title"] = "Stock Details";
    StockDetailsModel stockDetailsModel = Model;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/bootstrap-slider/9.9.0/css/bootstrap-slider.css"">
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js""></script>

<!-- Resources -->
<script src=""https://cdn.amcharts.com/lib/4/core.js""></script>
<script src=""https://cdn.amcharts.com/lib/4/charts.js""></script>
<script src=""https://cdn.amcharts.com/lib/4/themes/animated.js""></script>
<script src=""https://cdn.amcharts.com/lib/4/themes/frozen.js""></script>
<script src=""https://cdn.amcharts.com/lib/4/themes/dark.js""></script>

<script src=""https://canvasjs.com/assets/script/canvasjs.min.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/bootstrap-slider/11.0.2/bootstrap-slider.js""></script>
<script>
    am4core.ready(function () {

        // Themes begin
        am4core.useTheme(am4themes_animated);
        // Themes end
        var x = am4charts.XYChart;
        x.skipEmptyPeriods = true;
        x.equalSpacing = true;
        //x.");
            WriteLiteral(@"categoryAxesSettings.equalSpacing = true;
        // Create chart
        var chart = am4core.create(""chartdiv"", x);
        //am4charts.categoryAxesSettings
        //chart.categoryAxesSettings = ;
        //chart.categoryAxesSettings.equalSpacing = true;
        chart.data = ");
#nullable restore
#line 33 "C:\Users\Gonzalo\Dropbox\GitHubProjects\stock-dashboard\StockDashboard\StockDashboard\Views\Details\Details.cshtml"
                Write(Html.Raw(stockDetailsModel.JsonCandleData));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
        //chart.categoryAxesSettings.equalSpacing = true;
        chart.padding(0, 15, 0, 15);
        // Load data
        //chart.dataSource.url = ""stockDetailsModel.JsonCandleData"";
        //chart.dataSource.parser = new am4core.JSONParser();
        //chart.dataSource.parser.options.useColumnNames = true;
        //chart.dataSource.parser.options.reverse = true;
        
        // the following line makes value axes to be arranged vertically.
        chart.leftAxesContainer.layout = ""vertical"";
        //chart.xAxes.skipEmptyPeriods = true;
        // uncomment this line if you want to change order of axes
        //chart.bottomAxesContainer.reverseOrder = true;
        
        var dateAxis = chart.xAxes.push(new am4charts.DateAxis());
        
        dateAxis.skipEmptyPeriods = true;
        dateAxis.renderer.grid.template.location = 0;
        dateAxis.renderer.ticks.template.length = 8;
        dateAxis.renderer.ticks.template.strokeOpacity = 0.1;
        dateAxis.renderer.gr");
            WriteLiteral(@"id.template.disabled = true;
        dateAxis.renderer.ticks.template.disabled = false;
        dateAxis.renderer.ticks.template.strokeOpacity = 0.2;
        dateAxis.renderer.minLabelPosition = 0.01;
        dateAxis.renderer.maxLabelPosition = 0.99;
        dateAxis.keepSelection = true;
        dateAxis.minHeight = 30;
        dateAxis.groupData = true;
        dateAxis.minZoomCount = 5;

        // these two lines makes the axis to be initially zoomed-in
        // dateAxis.start = 0.7;
        // dateAxis.keepSelection = true;

        var valueAxis = chart.yAxes.push(new am4charts.ValueAxis());
        valueAxis.skipEmptyPeriods = true;
        valueAxis.tooltip.disabled = true;
        valueAxis.zIndex = 1;
        valueAxis.renderer.baseGrid.disabled = true;
        // height of axis
        valueAxis.height = am4core.percent(65);

        valueAxis.renderer.gridContainer.background.fill = am4core.color(""#000000"");
        valueAxis.renderer.gridContainer.background.fillOpacity ");
            WriteLiteral(@"= 0.05;
        valueAxis.renderer.inside = true;
        valueAxis.renderer.labels.template.verticalCenter = ""bottom"";
        valueAxis.renderer.labels.template.padding(2, 2, 2, 2);

        //valueAxis.renderer.maxLabelPosition = 0.95;
        valueAxis.renderer.fontSize = ""0.8em""

        var series = chart.series.push(new am4charts.CandlestickSeries());
        series.skipEmptyPeriods = true;
        series.dataFields.dateX = ""Date"";
        series.dataFields.openValueY = ""Open"";
        series.dataFields.valueY = ""Close"";
        series.dataFields.lowValueY = ""Low"";
        series.dataFields.highValueY = ""High"";
        series.clustered = false;
        series.tooltipText = ""open: {openValueY.value}\nlow: {lowValueY.value}\nhigh: {highValueY.value}\nclose: {valueY.value}"";
        series.name = ""MSFT"";
        series.defaultState.transitionDuration = 0;

        var valueAxis2 = chart.yAxes.push(new am4charts.ValueAxis());
        valueAxis2.skipEmptyPeriods = true;
        valueAx");
            WriteLiteral(@"is2.tooltip.disabled = true;
        // height of axis
        valueAxis2.height = am4core.percent(35);
        valueAxis2.zIndex = 3
        // this makes gap between panels
        valueAxis2.marginTop = 30;
        valueAxis2.renderer.baseGrid.disabled = true;
        valueAxis2.renderer.inside = true;
        valueAxis2.renderer.labels.template.verticalCenter = ""bottom"";
        valueAxis2.renderer.labels.template.padding(2, 2, 2, 2);
        //valueAxis.renderer.maxLabelPosition = 0.95;
        valueAxis2.renderer.fontSize = ""0.8em""

        valueAxis2.renderer.gridContainer.background.fill = am4core.color(""#000000"");
        valueAxis2.renderer.gridContainer.background.fillOpacity = 0.05;

        var series2 = chart.series.push(new am4charts.ColumnSeries());
        series2.skipEmptyPeriods = true
        series2.dataFields.dateX = ""Date"";
        series2.clustered = false;
        series2.dataFields.valueY = ""Volume"";
        series2.yAxis = valueAxis2;
        series2.tooltipTex");
            WriteLiteral(@"t = ""{valueY.value}"";
        series2.name = ""Series 2"";
        // volume should be summed
        series2.groupFields.valueY = ""sum"";
        series2.defaultState.transitionDuration = 0;

        chart.cursor = new am4charts.XYCursor();

        var scrollbarX = new am4charts.XYChartScrollbar();

        var sbSeries = chart.series.push(new am4charts.LineSeries());
        sbSeries.skipEmptyPeriods = true;
        sbSeries.dataFields.valueY = ""Close"";
        sbSeries.dataFields.dateX = ""Date"";
        scrollbarX.series.push(sbSeries);
        sbSeries.disabled = true;
        scrollbarX.marginBottom = 20;
        chart.scrollbarX = scrollbarX;
        scrollbarX.scrollbarChart.xAxes.getIndex(0).minHeight = undefined;



        /**
         * Set up external controls
         */

        // Date format to be used in input fields
        var inputFieldFormat = ""yyyy-MM-dd"";

        document.getElementById(""b1m"").addEventListener(""click"", function () {
            var max = dat");
            WriteLiteral(@"eAxis.groupMax[""day1""];
            var date = new Date(max);
            am4core.time.add(date, ""month"", -1);
            zoomToDates(date);
        });

        document.getElementById(""b3m"").addEventListener(""click"", function () {
            var max = dateAxis.groupMax[""day1""];
            var date = new Date(max);
            am4core.time.add(date, ""month"", -3);
            zoomToDates(date);
        });

        document.getElementById(""b6m"").addEventListener(""click"", function () {
            var max = dateAxis.groupMax[""day1""];
            var date = new Date(max);
            am4core.time.add(date, ""month"", -6);
            zoomToDates(date);
        });

        document.getElementById(""b1y"").addEventListener(""click"", function () {
            var max = dateAxis.groupMax[""day1""];
            var date = new Date(max);
            am4core.time.add(date, ""year"", -1);
            zoomToDates(date);
        });

        document.getElementById(""bytd"").addEventListener(""click"", ");
            WriteLiteral(@"function () {
            var max = dateAxis.groupMax[""day1""];
            var date = new Date(max);
            am4core.time.round(date, ""year"", 1);
            zoomToDates(date);
        });

        document.getElementById(""bmax"").addEventListener(""click"", function () {
            var min = dateAxis.groupMin[""day1""];
            var date = new Date(min);
            zoomToDates(date);
        });

        dateAxis.events.on(""selectionextremeschanged"", function () {
            updateFields();
        });

        dateAxis.events.on(""extremeschanged"", updateFields);

        function updateFields() {
            var minZoomed = dateAxis.minZoomed + am4core.time.getDuration(dateAxis.mainBaseInterval.timeUnit, dateAxis.mainBaseInterval.count) * 0.5;
            document.getElementById(""fromfield"").value = chart.dateFormatter.format(minZoomed, inputFieldFormat);
            document.getElementById(""tofield"").value = chart.dateFormatter.format(new Date(dateAxis.maxZoomed), inputFieldForma");
            WriteLiteral(@"t);
        }

        document.getElementById(""fromfield"").addEventListener(""keyup"", updateZoom);
        document.getElementById(""tofield"").addEventListener(""keyup"", updateZoom);

        var zoomTimeout;
        function updateZoom() {
            if (zoomTimeout) {
                clearTimeout(zoomTimeout);
            }
            zoomTimeout = setTimeout(function () {
                var start = document.getElementById(""fromfield"").value;
                var end = document.getElementById(""tofield"").value;
                if ((start.length < inputFieldFormat.length) || (end.length < inputFieldFormat.length)) {
                    return;
                }
                var startDate = chart.dateFormatter.parse(start, inputFieldFormat);
                var endDate = chart.dateFormatter.parse(end, inputFieldFormat);

                if (startDate && endDate) {
                    dateAxis.zoomToDates(startDate, endDate);
                }
            }, 500);
        }

       ");
            WriteLiteral(@" function zoomToDates(date) {
            var min = dateAxis.groupMin[""day1""];
            var max = dateAxis.groupMax[""day1""];
            dateAxis.keepSelection = true;
            //dateAxis.start = (date.getTime() - min)/(max - min);
            //dateAxis.end = 1;

            dateAxis.zoom({ start: (date.getTime() - min) / (max - min), end: 1 });
        }

    }); // end am4core.ready()
</script>






");
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d4c79fd06ba3c87906bf1dc9c90e4b65303a8b714174", async() => {
                WriteLiteral("\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div style=\"margin-right:auto;\">\r\n                <h1>");
#nullable restore
#line 527 "C:\Users\Gonzalo\Dropbox\GitHubProjects\stock-dashboard\StockDashboard\StockDashboard\Views\Details\Details.cshtml"
                Write(stockDetailsModel.Symbol + " - " + stockDetailsModel.CompanyName);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h1>
            </div>
        </div>


        <!-- HTML -->
        <div class=""row"">
            <div class=""column""></div>
            <div class=""column""></div>
        </div>


        <div id=""controls"" style=""width: 100%; overflow: hidden;"">
            <div style=""float: left; margin-left: 1px;"" class=""row"">
                <div class=""column""><b> &nbsp; From: &nbsp; </b></div>
                <div class=""column""> <input type=""text"" class=""form-control"" id=""fromfield"" /></div>
                <div class=""column""><b> &nbsp; To: &nbsp; </b></div>
                <div class=""column""> <input type=""text"" id=""tofield"" class=""form-control"" /></div>


            </div>
            <div style=""float: right; margin-right: 15px;"">
                <button id=""b1m"" class=""btn btn-primary"">1m</button>
                <button id=""b3m"" class=""btn btn-primary"">3m</button>
                <button id=""b6m"" class=""btn btn-primary"">6m</button>
                <button id=""b1y"" class=""btn btn-pr");
                WriteLiteral("imary\">1y</button>\r\n                <button id=\"bytd\" class=\"btn btn-primary\">YTD</button>\r\n                <button id=\"bmax\" class=\"btn btn-primary\">MAX</button>\r\n            </div>\r\n        </div>\r\n        <div id=\"chartdiv\"></div>\r\n\r\n\r\n    </div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<style>\r\n    #chartdiv {\r\n        width: 100%;\r\n        height: 720px;\r\n        max-width: 100%;\r\n    }\r\n</style>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
