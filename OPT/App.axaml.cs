using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Avalonia.VisualTree;
using OPT.ViewModels;
using OPT.Views;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using OPTCore.AirfieldsData;
using OPTCore.WeatherData;
using OPTCore.PerformanceCalculation.Data;
using OPTCore.PerformanceCalculation.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using OPTCore.PerformanceCalculation;
using AspNetCoreInjection.TypedFactories;
using OPT.Factories;

namespace OPT
{
    public partial class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override async void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                IHost appHost = Host.CreateDefaultBuilder()
                                    .ConfigureServices(ConfigureServices)
                                    .Build();

                await appHost.StartAsync();

                MainWindowViewModel viewModel = 
                    appHost.Services.GetRequiredService<MainWindowViewModel>();

                desktop.MainWindow = new MainWindow
                {
                    DataContext = viewModel
                };

                await viewModel.Load();
            }

            base.OnFrameworkInitializationCompleted();
        }

        private void ConfigureServices(HostBuilderContext hostContext, IServiceCollection services)
        {
            ITOPerformance dryMaxPerformance =
                new TOPerformance(
                    TOSpeedsDryMax.VSpeeds,
                    TOSpeedsDryMax.PressAltAndTempCorrection,
                    TOSpeedsDryMax.SlopeCorrection,
                    TOSpeedsDryMax.WindCorrection,
                    TOSpeedsDryMax.Vmcg,
                    TOSpeedsDryMax.ClearwayCorrection,
                    TOSpeedsDryMax.SlushV1Correction,
                    TOSpeedsDryMax.SlipperyV1Correction,
                    TOSpeedsDryMax.AntiSkidInopCorrection);

            ITOPerformance dry22KPerformance =
                new TOPerformance(
                    TOSpeedsDryMax.VSpeeds,
                    TOSpeedsDryMax.PressAltAndTempCorrection,
                    TOSpeedsDryMax.SlopeCorrection,
                    TOSpeedsDryMax.WindCorrection,
                    TOSpeedsDryMax.Vmcg,
                    TOSpeedsDryMax.ClearwayCorrection,
                    TOSpeedsDryMax.SlushV1Correction,
                    TOSpeedsDryMax.SlipperyV1Correction,
                    TOSpeedsDryMax.AntiSkidInopCorrection);

            ITOPerformance dry24KPerformance =
                new TOPerformance(
                    TOSpeedsDryMax.VSpeeds,
                    TOSpeedsDryMax.PressAltAndTempCorrection,
                    TOSpeedsDryMax.SlopeCorrection,
                    TOSpeedsDryMax.WindCorrection,
                    TOSpeedsDryMax.Vmcg,
                    TOSpeedsDryMax.ClearwayCorrection,
                    TOSpeedsDryMax.SlushV1Correction,
                    TOSpeedsDryMax.SlipperyV1Correction,
                    TOSpeedsDryMax.AntiSkidInopCorrection);

            ITOPerformance wetMaxPerformance =
                new TOPerformance(
                    TOSpeedsDryMax.VSpeeds,
                    TOSpeedsDryMax.PressAltAndTempCorrection,
                    TOSpeedsDryMax.SlopeCorrection,
                    TOSpeedsDryMax.WindCorrection,
                    TOSpeedsDryMax.Vmcg,
                    TOSpeedsDryMax.ClearwayCorrection,
                    TOSpeedsDryMax.SlushV1Correction,
                    TOSpeedsDryMax.SlipperyV1Correction,
                    TOSpeedsDryMax.AntiSkidInopCorrection);

            ITOPerformance wet22KPerformance =
                new TOPerformance(
                    TOSpeedsDryMax.VSpeeds,
                    TOSpeedsDryMax.PressAltAndTempCorrection,
                    TOSpeedsDryMax.SlopeCorrection,
                    TOSpeedsDryMax.WindCorrection,
                    TOSpeedsDryMax.Vmcg,
                    TOSpeedsDryMax.ClearwayCorrection,
                    TOSpeedsDryMax.SlushV1Correction,
                    TOSpeedsDryMax.SlipperyV1Correction,
                    TOSpeedsDryMax.AntiSkidInopCorrection);

            ITOPerformance wet24KPerformance =
                new TOPerformance(
                    TOSpeedsDryMax.VSpeeds,
                    TOSpeedsDryMax.PressAltAndTempCorrection,
                    TOSpeedsDryMax.SlopeCorrection,
                    TOSpeedsDryMax.WindCorrection,
                    TOSpeedsDryMax.Vmcg,
                    TOSpeedsDryMax.ClearwayCorrection,
                    TOSpeedsDryMax.SlushV1Correction,
                    TOSpeedsDryMax.SlipperyV1Correction,
                    TOSpeedsDryMax.AntiSkidInopCorrection);

            Dictionary<TOThrust, ITOPerformance> dryPerformance =
                new Dictionary<TOThrust, ITOPerformance>
                {
                    { TOThrust.Max, dryMaxPerformance },
                    { TOThrust.Derate22K, dry22KPerformance },
                    { TOThrust.Derate24K, dry24KPerformance }
                };

            Dictionary<TOThrust, ITOPerformance> wetPerformance =
                new Dictionary<TOThrust, ITOPerformance>
                {
                    { TOThrust.Max, wetMaxPerformance },
                    { TOThrust.Derate22K, wet22KPerformance },
                    { TOThrust.Derate24K, wet24KPerformance }
                };

            Dictionary<RunwayCondition, Dictionary<TOThrust, ITOPerformance>> dataSets
                = new Dictionary<RunwayCondition, Dictionary<TOThrust, ITOPerformance>>
                {
                    { RunwayCondition.Dry, dryPerformance },
                    { RunwayCondition.Good, wetPerformance }
                };

            services.AddSingleton<MainWindowViewModel>();
            services.AddSingleton<MainViewModel>();
            services.AddTransient<LoadingViewModel>();

            services.AddSingleton<PageViewModelBase, TakeoffDispatchViewModel>();
            services.RegisterTypedFactory<ITakeOffDispatchResultViewModelFactory>().ForConcreteType<TakeOffDispatchResultViewModel>();

            services.AddTransient<ICSVReader, CSVReader>();
            services.AddSingleton<IAirfieldsDataBuilder, AirfieldsDataBuilder>();
            services.AddTransient<IWeatherService, WeatherService>();
            services.AddTransient<IDataCalculator, DataCalculator>();
            services.AddTransient<IPerformanceCalculator, PerformanceCalculator>();
            services.AddSingleton(dataSets);
            services.RegisterTypedFactory<IPopUpViewModelFactory>().ForConcreteType<PopUpViewModel>();
            services.RegisterTypedFactory<IDepthViewModelFactory>().ForConcreteType<DepthViewModel>();
            services.AddTransient<IPopUp, PopUp>();

            services.AddTransient<ShowPopUp>(provider => vm =>
            {
                MainWindowViewModel windowVM = provider.GetRequiredService<MainWindowViewModel>();
                windowVM.PopUpViewModel = vm;
            });

            services.AddTransient<ClosePopUp>(provider => () =>
            {
                MainWindowViewModel windowVM = provider.GetRequiredService<MainWindowViewModel>();
                windowVM.PopUpViewModel = null;
            });
        }
    }
}