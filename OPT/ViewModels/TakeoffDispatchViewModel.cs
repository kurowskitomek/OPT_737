using Avalonia.Metadata;
using OPT.Factories;
using OPT.Models;
using OPTCore.AirfieldsData;
using OPTCore.AirfieldsData.Models;
using OPTCore.PerformanceCalculation;
using OPTCore.PerformanceCalculation.Models;
using OPTCore.WeatherData;
using OPTCore.WeatherData.Models;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Threading.Tasks;

namespace OPT.ViewModels
{
    public class TakeoffDispatchViewModel : PageViewModelBase
	{
		private const int _minToWeight = 40000;
		private const int _maxToWeight = 90000;

		private readonly IWeatherService _weatherService;
		private readonly IDataCalculator _dataCalculator;
		private readonly IPerformanceCalculator _performanceCalculator;
		private readonly IAirfieldsDataBuilder _airfieldsDataBuilder;
		private readonly IDepthViewModelFactory _depthViewModelFactory;
		private readonly ITakeOffDispatchResultViewModelFactory _takeOffDispatchResultViewModelFactory;
		private readonly ITakeOffDispatchErrorViewModelFactory _takeOffDispatchErrorViewModelFactory;
        private readonly IPopUp _popUp;

		private readonly TOParameters _toParameters;

		private ViewModelBase? _resultsViewModel;
		public ViewModelBase? ResultsViewModel
		{
			get => _resultsViewModel;
			set => this.RaiseAndSetIfChanged(ref _resultsViewModel, value);
		}

		private int toWeight = 0;
        private string? _toWeight;
		public string ToWeight
		{
			get => _toWeight + " KG";
			set
			{	
				if (value.Contains('K'))
					value = value.Replace("K", "");

				if (value.Contains('G'))
					value = value.Replace("G", "");

				value = value.Trim();

				if (
					int.TryParse(value, CultureInfo.InvariantCulture, out int result) ||
					string.IsNullOrEmpty(value))
				{
					this.RaiseAndSetIfChanged(ref _toWeight, value);
					toWeight = result;
				}
			}
		}

		private readonly Dictionary<string, AntiSkid> _antiSkidConfigs =
			new Dictionary<string, AntiSkid>
			{
				{ "ON", AntiSkid.Operative },
				{ "INOP", AntiSkid.Inop }
			};

		public Dictionary<string, AntiSkid> AntiSkidConfigs => _antiSkidConfigs;

		private KeyValuePair<string?, AntiSkid> _antiSkidConfig = new KeyValuePair<string?, AntiSkid>(null, (AntiSkid)(-1));
		public KeyValuePair<string?, AntiSkid> AntiSkidConfig
		{
			get => _antiSkidConfig;
			set => this.RaiseAndSetIfChanged(ref _antiSkidConfig, value);	
		}

		private readonly Dictionary<string, ReverseThrust> _reverseConfigs =
			new Dictionary<string, ReverseThrust>
			{
				{ "MAX", ReverseThrust.Max },
				{ "ONE INOP", ReverseThrust.OneInop },
				{ "NONE", ReverseThrust.None }
			};

		public Dictionary<string, ReverseThrust> ReverseConfigs => _reverseConfigs;

		private KeyValuePair<string?, ReverseThrust> _reverseConfig = new KeyValuePair<string?, ReverseThrust>(null, (ReverseThrust)(-1));
		public KeyValuePair<string?, ReverseThrust> ReverseConfig
		{
			get => _reverseConfig;
			set => this.RaiseAndSetIfChanged(ref _reverseConfig, value);
		}

		private readonly Dictionary<string, AntiIce> _antiIceConfigs =
			new Dictionary<string, AntiIce>
			{
				{ "OFF", AntiIce.Off },
				{ "ENG", AntiIce.Eng },
				{ "ENG+WING", AntiIce.Eng_Wing }
			};

		public Dictionary<string, AntiIce> AntiIceConfigs => _antiIceConfigs;

		private KeyValuePair<string?, AntiIce> _antiIceConfig = new KeyValuePair<string?, AntiIce>(null, (AntiIce)(-1));
		public KeyValuePair<string?, AntiIce> AntiIceConfig
		{
			get => _antiIceConfig;
			set => this.RaiseAndSetIfChanged(ref _antiIceConfig, value);
		}

		private readonly Dictionary<string, AirCond> _airCondConfigs =
			new Dictionary<string, AirCond>
			{
				{ "BLEEDS ON", AirCond.On },
				{ "BLEEDS OFF", AirCond.Off }
			};

		public Dictionary<string, AirCond> AirCondConfigs => _airCondConfigs;

		private KeyValuePair<string?, AirCond> _airCondConfig = new KeyValuePair<string?, AirCond>(null, (AirCond)(-1));
		public KeyValuePair<string?, AirCond> AirCondConfig
		{
			get => _airCondConfig;
			set => this.RaiseAndSetIfChanged(ref _airCondConfig, value);
		}

		private readonly Dictionary<string, Flaps> _flapsConfigs =
			new Dictionary<string, Flaps>
			{
				{ "1", Flaps.Flaps1 },
				{ "5", Flaps.Flaps5 },
				{ "10", Flaps.Flaps10 },
				{ "15", Flaps.Flaps15 },
				{ "20", Flaps.Flaps25 }
			};

		public Dictionary<string, Flaps> FlapsConfigs => _flapsConfigs;

		private KeyValuePair<string?, Flaps> _flapsConfig = new KeyValuePair<string?, Flaps>(null, (Flaps)(-1));
		public KeyValuePair<string?, Flaps> FlapsConfig
		{
			get => _flapsConfig;
			set => this.RaiseAndSetIfChanged(ref _flapsConfig, value);
		}

        private readonly Dictionary<string, TOThrust> _thrRTGs = 
			new Dictionary<string, TOThrust>
			{
                { "TO (MAX Thr)", TOThrust.Max },
                { "TO1 (24K Derate)", TOThrust.Derate24K },
                { "TO2 (22K Derate)", TOThrust.Derate22K }
			};

		public Dictionary<string, TOThrust> ThrRTGs => _thrRTGs;

		private KeyValuePair<string?, TOThrust> _thrRTG = new KeyValuePair<string?, TOThrust>(null, (TOThrust)(-1));
		public KeyValuePair<string?, TOThrust> ThrRTG
		{
			get => _thrRTG;
			set => this.RaiseAndSetIfChanged(ref _thrRTG, value);
		}

        private readonly Dictionary<string, RunwayCondition> _rwyConditions =
			new Dictionary<string, RunwayCondition>
			{
				{ "DRY", RunwayCondition.Dry },
				{ "GOOD", RunwayCondition.Good },
				{ "MEDIUM", RunwayCondition.Medium },
				{ "POOR", RunwayCondition.Poor },
				{ "SLUSH", RunwayCondition.Slush },
				{ "STNDNG WTR", RunwayCondition.Slush }
			};

		public Dictionary<string, RunwayCondition> RwyConditions => _rwyConditions;

		private KeyValuePair<string?, RunwayCondition> _rwyCondition = new KeyValuePair<string?, RunwayCondition>(null, (RunwayCondition)(-1));
		public KeyValuePair<string?, RunwayCondition> RwyCondition
		{
			get => _rwyCondition;
			set
			{
				if (value.Value is RunwayCondition.Slush)
				{
					DepthViewModel depthVM = _depthViewModelFactory.Create(_toParameters);
					depthVM.Contamination = value.Key;

					_popUp.Show(depthVM, (result) =>
					{
						if (result is PopUpResult.Cancelled)
							RwyCondition = new KeyValuePair<string?, RunwayCondition>(null, (RunwayCondition)(-1));
						else
						{
							Depth = string.Format(" {0} mm", _toParameters.Slush);
                            this.RaisePropertyChanged(nameof(RwyCondition));
                        }
							
                    });
				}
				else
				{
                    _toParameters.Slush = 0;
					Depth = null;
                }
					
				this.RaiseAndSetIfChanged(ref _rwyCondition, value);
			}
		}

		private string? _depth;
		public string? Depth
		{
			get => _depth;
			set => this.RaiseAndSetIfChanged(ref _depth, value);
		}

		public ObservableCollection<Airfield>? Airfields
		{
			get 
			{
				if (_airfieldsDataBuilder.HasData)
					return new ObservableCollection<Airfield>(_airfieldsDataBuilder.Airfields);

				return new ObservableCollection<Airfield>();
            } 
		}

		private Airfield? _selectedAirfield;
		public Airfield? SelectedAirfield
		{
			get => _selectedAirfield;
			set => this.RaiseAndSetIfChanged(ref _selectedAirfield, value);
		}

		private Runway? _selectedRunway;
		public Runway? SelectedRunway
		{
			get => _selectedRunway;
			set => this.RaiseAndSetIfChanged(ref _selectedRunway, value);
		}

        public int WindDirInt
        {
            get
            {
                if (int.TryParse(WindDir, out var value))
                    return value;

                return 0;
            }
        }

        private string? _windDir;
		public string? WindDir
		{
			get => _windDir;
			set => this.RaiseAndSetIfChanged(ref _windDir, value);
		}

		private int? _windSpd;
		public int? WindSpd
		{
			get => _windSpd;
			set => this.RaiseAndSetIfChanged(ref _windSpd, value);
		}

		private int? _windGust;
		public int? WindGust
		{
			get => _windGust;
			set => this.RaiseAndSetIfChanged(ref _windGust, value);
		}

		private int? _oat;
		public int? Oat
		{
			get => _oat;
			set => this.RaiseAndSetIfChanged(ref _oat, value);
		}

		private int? _qnh;
		public int? Qnh
		{
			get => _qnh;
			set => this.RaiseAndSetIfChanged(ref _qnh, value);
		}

		public TakeoffDispatchViewModel(
			IWeatherService weatherService,
			IDataCalculator dataCalculator,
			IPerformanceCalculator performanceCalculator,
			IAirfieldsDataBuilder airfieldsDataBuilder,
			IDepthViewModelFactory depthViewModelFactory,
			ITakeOffDispatchResultViewModelFactory takeoffDispatchResultViewModelFactory,
			ITakeOffDispatchErrorViewModelFactory takeoffDispatchErrorViewModelFactory,
			IPopUp popUp)
		{
			_weatherService = weatherService;
			_dataCalculator = dataCalculator;
			_performanceCalculator = performanceCalculator;
			_airfieldsDataBuilder = airfieldsDataBuilder;
			_depthViewModelFactory = depthViewModelFactory;
			_takeOffDispatchResultViewModelFactory = takeoffDispatchResultViewModelFactory;
			_takeOffDispatchErrorViewModelFactory = takeoffDispatchErrorViewModelFactory;
			_popUp = popUp;

			_toParameters = new TOParameters();
		}

		[DependsOn(nameof(SelectedAirfield))]
		[DependsOn(nameof(SelectedRunway))]
		[DependsOn(nameof(WindDir))]
		[DependsOn(nameof(WindSpd))]
		[DependsOn(nameof(Oat))]
		[DependsOn(nameof(Qnh))]
		[DependsOn(nameof(RwyCondition))]
		[DependsOn(nameof(ThrRTG))]
		[DependsOn(nameof(FlapsConfig))]
		[DependsOn(nameof(AirCondConfig))]
		[DependsOn(nameof(AntiIceConfig))]
		[DependsOn(nameof(ReverseConfig))]
		[DependsOn(nameof(AntiSkidConfig))]
		[DependsOn(nameof(ToWeight))]
		public bool CanCalculate(object? parameter)
			=>
			SelectedAirfield is not null &&
			SelectedRunway is not null &&
			WindDir is not null &&
			WindSpd is not null &&
			Oat is not null &&
			Qnh is not null &&
			RwyCondition.Key is not null &&
			ThrRTG.Key is not null &&
			FlapsConfig.Key is not null &&
			AirCondConfig.Key is not null &&
			AntiIceConfig.Key is not null &&
			ReverseConfig.Key is not null &&
			AntiSkidConfig.Key is not null &&
			toWeight >= _minToWeight &&
			toWeight <= _maxToWeight;
		
		public void Calculate()
		{
			if (!CanCalculate(null))
				return;

			_toParameters.Thrust = ThrRTG.Value;
			_toParameters.RunwayCondition = RwyCondition.Value;
			_toParameters.Flaps = FlapsConfig.Value;
			_toParameters.ReverseThrust = ReverseConfig.Value;
			_toParameters.AntiSkid = AntiSkidConfig.Value;
			_toParameters.AirCond = AirCondConfig.Value;
			_toParameters.AntiIce = AntiIceConfig.Value;
			_toParameters.Weight = (float)toWeight / 1000;
			_toParameters.Temperature = (int)Oat!;
			_toParameters.PressureAltitude = _dataCalculator.CalculatePressAlt((int)Qnh!, SelectedRunway!.Elevation) / 1000;
			_toParameters.RunwaySlope = SelectedRunway.Slope;
			_toParameters.HeadWind = (int)Math.Round(_dataCalculator.WindComponent(WindDirInt, SelectedRunway.TrueHeading, (int)WindSpd!), 0);
			_toParameters.ClearwayMStopway = SelectedRunway.TODA - SelectedRunway.ASDA;
			_toParameters.RunwayLength = SelectedRunway.TORA;

			try
			{
				float v1 = _performanceCalculator.CalculateV1(_toParameters);
				float vr = _performanceCalculator.CalculateVr(_toParameters);
				float v2 = _performanceCalculator.CalculateV2(_toParameters);

                TOResults results = new TOResults
                {
                    Runway = SelectedRunway,
                    V1 = (int)Math.Round(v1, 0),
                    Vr = (int)Math.Round(vr, 0),
                    V2 = (int)Math.Round(v2, 0)
                };

                ResultsViewModel = _takeOffDispatchResultViewModelFactory.Create(results);
            }
			catch (DispatchException ex)
			{
				ResultsViewModel = _takeOffDispatchErrorViewModelFactory.Create(ex);
			}
		}

        [DependsOn(nameof(SelectedAirfield))]
        public bool CanLoadWeather(object? parameter)
			=> SelectedAirfield is not null && SelectedAirfield.ICAOCode is not null;

		public async Task LoadWeather()
		{
			if (!CanLoadWeather(null))
				return;

			Metar? metar = 
				await _weatherService.GetMetarAsync(SelectedAirfield!.ICAOCode!);

			if (metar is null)
				return;

			WindDir = metar.Wdir;
			WindSpd = metar.Wspd;
			WindGust = metar.Wgst;

			if (metar.Temp is not null)
				Oat = (int)Math.Round((float)metar.Temp);

			if (metar.Altim is not null)
				Qnh = (int)Math.Round((float)metar.Altim);
		}
	}
}