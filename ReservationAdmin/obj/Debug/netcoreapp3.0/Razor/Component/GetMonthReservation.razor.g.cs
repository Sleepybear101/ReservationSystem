#pragma checksum "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\GetMonthReservation.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2661542bacbe66ac1740916bcc5a9c400643fda1"
// <auto-generated/>
#pragma warning disable 1591
namespace ReservationAdmin.Component
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\GetMonthReservation.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\GetMonthReservation.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\GetMonthReservation.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\GetMonthReservation.razor"
using ReservationAdmin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\GetMonthReservation.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\GetMonthReservation.razor"
using ChartJs.Blazor.ChartJS.BarChart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\GetMonthReservation.razor"
using ChartJs.Blazor.ChartJS.BarChart.Axes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\GetMonthReservation.razor"
using ChartJs.Blazor.ChartJS.Common.Axes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\GetMonthReservation.razor"
using ChartJs.Blazor.ChartJS.Common.Axes.Ticks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\GetMonthReservation.razor"
using ChartJs.Blazor.ChartJS.Common.Properties;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\GetMonthReservation.razor"
using ChartJs.Blazor.ChartJS.Common.Wrappers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\GetMonthReservation.razor"
using ChartJs.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\GetMonthReservation.razor"
using ChartJs.Blazor.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\GetMonthReservation.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
    public class GetMonthReservation : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "select");
            __builder.AddAttribute(1, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\GetMonthReservation.razor"
                   (e => GetChoose(e))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "option");
            __builder.AddAttribute(4, "value", "Year");
            __builder.AddContent(5, "Jaar");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "option");
            __builder.AddAttribute(8, "value", "Month");
            __builder.AddContent(9, "Maand");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n\r\n");
            __builder.OpenElement(12, "select");
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\GetMonthReservation.razor"
                   (e => GetChooseWhichMonth(e))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "class", "CHidden");
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.OpenElement(16, "option");
            __builder.AddAttribute(17, "value", "01");
            __builder.AddContent(18, "Jan");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n    ");
            __builder.OpenElement(20, "option");
            __builder.AddAttribute(21, "value", "02");
            __builder.AddContent(22, "Feb");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n    ");
            __builder.OpenElement(24, "option");
            __builder.AddAttribute(25, "value", "03");
            __builder.AddContent(26, "Maart");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.OpenElement(28, "option");
            __builder.AddAttribute(29, "value", "04");
            __builder.AddContent(30, "April");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n    ");
            __builder.OpenElement(32, "option");
            __builder.AddAttribute(33, "value", "05");
            __builder.AddContent(34, "Mei");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n    ");
            __builder.OpenElement(36, "option");
            __builder.AddAttribute(37, "value", "06");
            __builder.AddContent(38, "Juni");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n    ");
            __builder.OpenElement(40, "option");
            __builder.AddAttribute(41, "value", "07");
            __builder.AddContent(42, "Juli");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n    ");
            __builder.OpenElement(44, "option");
            __builder.AddAttribute(45, "value", "08");
            __builder.AddContent(46, "August");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n    ");
            __builder.OpenElement(48, "option");
            __builder.AddAttribute(49, "value", "09");
            __builder.AddContent(50, "Sept");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n    ");
            __builder.OpenElement(52, "option");
            __builder.AddAttribute(53, "value", "10");
            __builder.AddContent(54, "Okt");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n    ");
            __builder.OpenElement(56, "option");
            __builder.AddAttribute(57, "value", "11");
            __builder.AddContent(58, "Nov");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n    ");
            __builder.OpenElement(60, "option");
            __builder.AddAttribute(61, "value", "12");
            __builder.AddContent(62, "Nov");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n");
            __builder.OpenElement(65, "select");
            __builder.AddAttribute(66, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\GetMonthReservation.razor"
                   (e => GetWhichYear(e))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(67, "\r\n    ");
            __builder.OpenElement(68, "option");
            __builder.AddAttribute(69, "value", "2020");
            __builder.AddContent(70, "2020");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n    ");
            __builder.OpenElement(72, "option");
            __builder.AddAttribute(73, "value", "2019");
            __builder.AddContent(74, "2019");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n    ");
            __builder.OpenElement(76, "option");
            __builder.AddAttribute(77, "value", "2018");
            __builder.AddContent(78, "2018");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n    ");
            __builder.OpenElement(80, "option");
            __builder.AddAttribute(81, "value", "2017");
            __builder.AddContent(82, "2017");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n    ");
            __builder.OpenElement(84, "option");
            __builder.AddAttribute(85, "value", "2016");
            __builder.AddContent(86, "2016");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n    ");
            __builder.OpenElement(88, "option");
            __builder.AddAttribute(89, "value", "2015");
            __builder.AddContent(90, "2015");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n\r\n");
            __builder.OpenComponent<ChartJs.Blazor.Charts.ChartJsBarChart>(93);
            __builder.AddAttribute(94, "Config", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ChartJs.Blazor.ChartJS.BarChart.BarConfig>(
#nullable restore
#line 47 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\GetMonthReservation.razor"
                                           _barChartConfig

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(95, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 47 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\GetMonthReservation.razor"
                                                                   700

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(96, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 47 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\GetMonthReservation.razor"
                                                                                300

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(97, (__value) => {
#nullable restore
#line 47 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\GetMonthReservation.razor"
                       _barChart = (ChartJs.Blazor.Charts.ChartJsBarChart)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\GetMonthReservation.razor"
 

    private BarConfig _barChartConfig;
    private ChartJsBarChart _barChart;
    private BarDataset<DoubleWrapper> _barDataVoorspelling;
    private BarDataset<DoubleWrapper> _barDataSetWerkelijk;
    SqlConnection con = new SqlConnection();
    List<double> Result = new List<double>();
    [Parameter]
    public int Month { get; set; } = 1;
    public string Chose { get; set; }

    public int LastYear = DateTime.Now.Year - 1;
    public int SecondYear = DateTime.Now.Year - 2;
    public int ThirdYear = DateTime.Now.Year - 3;
    public int FourthYear = DateTime.Now.Year - 4;
    public int FifthYear = DateTime.Now.Year - 5;
    public int year = DateTime.Now.Year;

    protected override void OnInitialized()
    {
        SetBarChart();
        GetFutureYear();
    }

    public void SetBarChart()
    {
        _barChartConfig = new BarConfig
        {
            Options = new BarOptions
            {
                Title = new OptionsTitle
                {
                    Display = true,
                    Text = "Statiek - Aantal reserveringen"

                },
                Scales = new BarScales
                {
                    XAxes = new List<CartesianAxis>
                    {
                    new BarCategoryAxis
                    {
                    BarPercentage = 0.8,
                    BarThickness = BarThickness.Flex
                    }
                    },
                    YAxes = new List<CartesianAxis>
                        {
                        new BarLinearCartesianAxis
                        {
                        Ticks = new LinearCartesianTicks
                        {
                        BeginAtZero = true
                        }
                        }
                        }
                }
            }
        };
        _barDataVoorspelling = new BarDataset<DoubleWrapper>
        {
            Label = "Voorspelling",
            BackgroundColor = "#A3A1FB",
            BorderWidth = 0,
            HoverBackgroundColor = ColorUtil.RandomColorString(),
            HoverBorderColor = ColorUtil.RandomColorString(),
            HoverBorderWidth = 1,
            BorderColor = "#ffffff"
        };

        _barDataSetWerkelijk = new BarDataset<DoubleWrapper>
        {
            Label = "Werkelijk",
            BackgroundColor = "#56D9FE",
            BorderWidth = 0,
            HoverBackgroundColor = ColorUtil.RandomColorString(),
            HoverBorderColor = ColorUtil.RandomColorString(),
            HoverBorderWidth = 1,
            BorderColor = "#ffffff"
        };
    }

    public void GetChooseWhichMonth(ChangeEventArgs e)
    {
        RemoveData();
        Month = Convert.ToInt32(e.Value);
        SetLastMonth();
    }
    public void GetWhichYear(ChangeEventArgs e)
    {
        RemoveData();
        year = Convert.ToInt32(e.Value);
        SetLastMonth();

    }

    public void GetChoose(ChangeEventArgs e)
    {
        RemoveData();
        Chose = e.Value.ToString();
        if (Chose == "Year")
        {
            GetFutureYear();

        }
        else
        {
            SetLastMonth();
        }

    }

    private async Task RemoveData()
    {
        for (int i = 1; i < 31; i++)
        {
            if (_barChartConfig.Data.Labels.Count > 0)
            {

                _barChartConfig.Data.Labels.RemoveAt(_barChartConfig.Data.Labels.Count - 1);
            }

            if (_barDataVoorspelling.Data.Count > 0)
            {
                _barDataVoorspelling.RemoveAt(_barDataVoorspelling.Data.Count - 1);
            }

            if (_barDataSetWerkelijk.Data.Count > 0)
            {
                _barDataSetWerkelijk.RemoveAt(_barDataSetWerkelijk.Data.Count - 1);
            }
        }
    }


    private async Task AddData()
    {
        await _barChart.Update();
    }

    public void SetLastMonth()
    {

        for (int i = 1; i < 31; i++)
        {
            con.SqlQuery("SELECT COUNT(*)  FROM `reservation` WHERE `Date` = '" + year + "-" + Month + "-" + i + "'");
            con.QueryEx();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                string maand = i.ToString()+",";
                _barDataSetWerkelijk.AddRange(new double[] { Convert.ToDouble(dr[0]) }.Wrap());
            }
        }
        for (int i = 1; i < 31; i++)
        {
            con.SqlQuery("SELECT ROUND((year1.Total1+year2.Total2+year3.Total3+year4.Total4+year5.Total5)/5) FROM (" +
            " (SELECT COUNT(*) as Total1 FROM `reservation` WHERE `Date`='"+SecondYear+"-" + Month + "-"+i+"') year1," +
            " (SELECT COUNT(*) as Total2 FROM `reservation` WHERE `Date`='"+LastYear+"-" + Month + "-"+i+"') year2," +
            "(SELECT COUNT(*) as Total3 FROM `reservation` WHERE `Date` = '"+ThirdYear+"-" + Month + "-"+i+"') year3," +
            "(SELECT COUNT(*) as Total4 FROM `reservation` WHERE `Date` ='"+FourthYear +"-" + Month + "-"+i+"') year4," +
            "(SELECT COUNT(*) as Total5 FROM `reservation` WHERE `Date` = '"+FifthYear+"-" + Month+ "-"+i+"') year5)");
            con.QueryEx();
            foreach (DataRow dr in con.QueryEx().Rows)
            {

                _barDataVoorspelling.AddRange(new double[] { Convert.ToDouble(dr[0]) }.Wrap());
            }
        }





        _barChartConfig.Data.Labels.AddRange(new[] {"1","2","3","4","5","6","7","8","9","10","11","12","13","14","15","16","17","18","19","20","21","22","24","25","26","27","28","29","30","31"});
        //   _barChartConfig.Data.Labels.AddRange(new [] {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31});
        _barChartConfig.Data.Datasets.Add(_barDataSetWerkelijk);

        AddData();
    }


    public void GetFutureYear()
    {
        _barChartConfig.Data.Labels.AddRange(new[] { "Jan", "Feb", "Maart", "April", "Mei", "Juni", "Juli", "August", "September", "Oktober", "November", "Decemeber" });

        for (int i = 1; i < 13; i++)
        {
            con.SqlQuery("SELECT ROUND((year1.Total1+year2.Total2+year3.Total3+year4.Total4+year5.Total5)/5) FROM (" +
            " (SELECT COUNT(*) as Total1 FROM `reservation` WHERE `Date` BETWEEN '"+SecondYear+"-" + i + "-1' AND '2018-" + i + "-31') year1," +
            " (SELECT COUNT(*) as Total2 FROM `reservation` WHERE `Date` BETWEEN '"+LastYear+"-" + i + "-1'AND '2019-" + i + "-31') year2," +
            "(SELECT COUNT(*) as Total3 FROM `reservation` WHERE `Date` BETWEEN '"+ThirdYear+"-" + i + "-1'AND '2017-" + i + "-31') year3," +
            "(SELECT COUNT(*) as Total4 FROM `reservation` WHERE `Date` BETWEEN '"+FourthYear +"-" + i + "-1'AND '2016-" + i + "-31') year4," +
            "(SELECT COUNT(*) as Total5 FROM `reservation` WHERE `Date` BETWEEN '"+FifthYear+"-" + i + "-1'AND '2015-" + i + "-31') year5)");
            con.QueryEx();
            foreach (DataRow dr in con.QueryEx().Rows)
            {

                _barDataVoorspelling.AddRange(new double[] { Convert.ToDouble(dr[0]) }.Wrap());
            }
        }

        for (int i = 1; i < 13; i++)
        {
            con.SqlQuery("SELECT COUNT(*) FROM `reservation` WHERE  `Date` BETWEEN '"+ year +"-" + i + "-1' AND '2020-" + i + "-31'");
            con.QueryEx();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                _barDataSetWerkelijk.AddRange(new double[] { Convert.ToDouble(dr[0])}.Wrap());
            }
        }

        _barChartConfig.Data.Datasets.Add(_barDataVoorspelling);
        _barChartConfig.Data.Datasets.Add(_barDataSetWerkelijk);
        AddData();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
