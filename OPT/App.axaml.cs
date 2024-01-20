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
            ITOPerformance maxPerformance =
                new TOPerformance(
                    TOPerfMax.VSpeeds,
                    TOPerfMax.DensAltCorr,
                    TOPerfMax.SlopeCorr,
                    TOPerfMax.WindCorr,
                    TOPerfMax.Vmcg,
                    TOPerfMax.ClearwayCorr,
                    TOPerfMax.SlushV1Corr,
                    TOPerfMax.SlipperyV1Corr,
                    TOPerfMax.AntiSkidCorr);

            ITOPerformance _22KPerformance =
                new TOPerformance(
                    TOPerf22K.VSpeeds,
                    TOPerf22K.DensAltCorr,
                    TOPerf22K.SlopeCorr,
                    TOPerf22K.WindCorr,
                    TOPerf22K.Vmcg,
                    TOPerf22K.ClearwayCorr,
                    TOPerf22K.SlushV1Corr,
                    TOPerf22K.SlipperyV1Corr,
                    TOPerf22K.AntiSkidCorr);

            ITOPerformance _24KPerformance =
                new TOPerformance(
                    TOPerf24K.VSpeeds,
                    TOPerf24K.DensAltCorr,
                    TOPerf24K.SlopeCorr,
                    TOPerf24K.WindCorr,
                    TOPerf24K.Vmcg,
                    TOPerf24K.ClearwayCorr,
                    TOPerf24K.SlushV1Corr,
                    TOPerf24K.SlipperyV1Corr,
                    TOPerf24K.AntiSkidCorr);

            Dictionary<TOThrust, ITOPerformance> dataSets =
                new Dictionary<TOThrust, ITOPerformance>
                {
                    { TOThrust.Max, maxPerformance },
                    { TOThrust.Derate22K, _22KPerformance },
                    { TOThrust.Derate24K, _24KPerformance }
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