using ChartsDemo.Models;
using ChartsDemo.Services;
using Microcharts;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Entry = Microcharts.Entry;
namespace ChartsDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ChartDepAbs();
            ChartAbsBySex();
            ChartAbsByStatusMarital();
        }  
        public async void ChartDepAbs()
        {
            ApiService apiService = new ApiService();
            var Dep1 =  await apiService.GetDepDaysAsync(1);
            var Dep2 =  await apiService.GetDepDaysAsync(2);
            var Dep3 =  await apiService.GetDepDaysAsync(3);
            var Dep4 =  await apiService.GetDepDaysAsync(4);
            var Dep5 =  await apiService.GetDepDaysAsync(5);
            var Dep6 =  await apiService.GetDepDaysAsync(6);
            var entries = new[]
            {
                new Entry((float)Dep1.Days)
                {
                    Label = Dep1.DepName,
                    ValueLabel = Dep1.Days.ToString(),
                    Color = SKColor.Parse("#2c3e50")
                },
                new Entry((float)Dep2.Days)
                {
                    Label = Dep2.DepName,
                    ValueLabel = Dep2.Days.ToString(),
                    Color = SKColor.Parse("#77d065")
                },
                new Entry((float)Dep3.Days)
                {
                    Label = Dep3.DepName,
                    ValueLabel = Dep3.Days.ToString(),
                    Color = SKColor.Parse("#b455b6")
                },
                new Entry((float)Dep4.Days)
                {
                    Label = Dep4.DepName,
                    ValueLabel = Dep4.Days.ToString(),
                    Color = SKColor.Parse("#3498db")
                },
                new Entry((float)Dep5.Days)
                {
                    Label = Dep5.DepName,
                    ValueLabel = Dep5.Days.ToString(),
                    Color = SKColor.Parse("#FF5733")
                },
                new Entry((float)Dep6.Days)
                {
                    Label = Dep6.DepName,
                    ValueLabel = Dep6.Days.ToString(),
                    Color = SKColor.Parse("#003F87")
                }
            };
            var chart = new BarChart() { Entries = entries, LabelTextSize = 35 };
            chartView.Chart = chart;

        }

        public async void ChartAbsBySex()
        {
            ApiService apiService = new ApiService();
            var Sex1 = await apiService.GetAbsBySexAsync(1);
            var Sex2 = await apiService.GetAbsBySexAsync(2);

            var entries1 = new[]
            {
                new Entry(Sex1.Taux)
                {
                    Label = Sex1.Sex,
                    ValueLabel = $"{Sex1.Taux.ToString()} %",
                    Color = SKColor.Parse("#2c3e50")
                },
                new Entry(Sex2.Taux)
                {
                    Label = Sex2.Sex,
                    ValueLabel = $"{Sex2.Taux.ToString()} %",
                    Color = SKColor.Parse("#77d065")
                }               
            };

            var chart1 = new DonutChart() { Entries = entries1, LabelTextSize = 35 , HoleRadius = 0.5f};
            chartView1.Chart = chart1;
        }
        public async void ChartAbsByStatusMarital()
        {
            ApiService apiService = new ApiService();
            var StatusM = await apiService.GetAbsByStatusMaritalAsync(1);
            var StatusM1 = await apiService.GetAbsByStatusMaritalAsync(2);
            var StatusM2 = await apiService.GetAbsByStatusMaritalAsync(3);
            var StatusM3 = await apiService.GetAbsByStatusMaritalAsync(4);
            var StatusM4 = await apiService.GetAbsByStatusMaritalAsync(5);


            var entries2 = new[]
            {
                new Entry(StatusM.Taux)
                {
                    Label = StatusM.Status,
                    ValueLabel = $"{StatusM.Taux.ToString()} %",
                    Color = SKColor.Parse("#2c3e50")
                },
                new Entry(StatusM1.Taux)
                {
                    Label = StatusM1.Status,
                    ValueLabel = $"{StatusM1.Taux.ToString()} %",
                    Color = SKColor.Parse("#77d065")
                },
                new Entry(StatusM2.Taux)
                {
                    Label = StatusM2.Status,
                    ValueLabel = $"{StatusM2.Taux.ToString()} %",
                    Color = SKColor.Parse("#b455b6")
                },
                new Entry(StatusM3.Taux)
                {
                    Label = StatusM3.Status,
                    ValueLabel = $"{StatusM3.Taux.ToString()} %",
                    Color = SKColor.Parse("#003F87")
                },
                new Entry(StatusM4.Taux)
                {
                    Label = StatusM4.Status,
                    ValueLabel = $"{StatusM4.Taux.ToString()} %",
                    Color = SKColor.Parse("#5B0091")
                }
            };
            var chart2 = new RadialGaugeChart() { Entries = entries2, LabelTextSize = 35 };
            chartView2.Chart = chart2;
        }
    }
}
