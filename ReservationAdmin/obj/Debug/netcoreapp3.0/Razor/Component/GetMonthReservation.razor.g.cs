
#pragma checksum "C:\Users\wurud\Documents\GitHub\ReservationSystem\ReservationAdmin\Component\GetMonthReservation.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2358a7e378aac9f828c5b38101bf411f0f63d7ce"

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
                   (e => GetChoose(e))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenElement(15, "option");
            __builder.AddAttribute(16, "value", "1");
            __builder.AddContent(17, "Jan");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.OpenElement(19, "option");
            __builder.AddAttribute(20, "value", "2");
            __builder.AddContent(21, "Feb");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.OpenElement(23, "option");
            __builder.AddAttribute(24, "value", "1");
            __builder.AddContent(25, "Jan");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n    ");
            __builder.OpenElement(27, "option");
            __builder.AddAttribute(28, "value", "2");
            __builder.AddContent(29, "Feb");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n\r\n");
            __builder.OpenComponent<ChartJs.Blazor.Charts.ChartJsBarChart>(32);
            __builder.AddAttribute(33, "Config", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ChartJs.Blazor.ChartJS.BarChart.BarConfig>(
#nullable restore
#line 29 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\GetMonthReservation.razor"
                                           _barChartConfig

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 29 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\GetMonthReservation.razor"
                                                                   700

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 29 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\GetMonthReservation.razor"
                                                                                300

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(36, (__value) => {
#nullable restore
#line 29 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\GetMonthReservation.razor"
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
#line 34 "C:\Users\royhe\OneDrive\Documenten\GitHub\ReservationSystem\ReservationAdmin\Component\GetMonthReservation.razor"


    private BarConfig _barChartConfig;
    private ChartJsBarChart _barChart;
    private BarDataset<DoubleWrapper> _barDataVoorspelling;
    private BarDataset<DoubleWrapper> _barDataSetWerkelijk;
    SqlConnection con = new SqlConnection();
    List<double> Result = new List<double>();
    [Parameter]
    public string Month { get; set; }
    public string Chose { get; set; }

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
        for (int i = 1; i < 13; i++)
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




        _barChartConfig.Data.Labels.AddRange(new[] { "Jan"});
        _barDataSetWerkelijk.AddRange(new double[] { 8, 5, 3, 7, 2, 5, 3, 7, 9, 10, 11, 12 }.Wrap());
        _barChartConfig.Data.Datasets.Add(_barDataSetWerkelijk);

        AddData();
    }



    public void GetFutureYear()
    {
        _barChartConfig.Data.Labels.AddRange(new[] { "Jan", "Feb", "Maart", "April", "Mei", "Juni", "Juli", "August", "September", "Oktober", "November", "Decemeber" });
        int LastYear = DateTime.Now.Year - 1;
        int SecondYear = DateTime.Now.Year - 2;
        int ThirdYear = DateTime.Now.Year - 3;
        int FourthYear = DateTime.Now.Year - 4;
        int FifthYear = DateTime.Now.Year - 5;

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
            int year = DateTime.Now.Year;
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
