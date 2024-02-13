using OPT.Models;
using ReactiveUI;

namespace OPT.ViewModels
{
    public class TakeOffDispatchResultViewModel : ViewModelBase
	{
		private string? _v1;
		public string? V1
		{
			get => _v1;
			set => this.RaiseAndSetIfChanged(ref _v1, value);
		}

		private string? _vr;
		public string? Vr
		{
			get => _vr;
			set => this.RaiseAndSetIfChanged(ref _vr, value);
		}

		private string? _v2;
		public string? V2
		{
			get => _v2;
			set => this.RaiseAndSetIfChanged(ref _v2, value);
		}

		private string? _vref40;
		public string? Vref40
		{
			get => _vref40;
			set => this.RaiseAndSetIfChanged(ref _vref40, value);
		}

		public TakeOffDispatchResultViewModel(TOResults result)
		{
			V1 = result.V1 + "KT";
			Vr = result.Vr + "KT";
			V2 = result.V2 + "KT";
			Vref40 = result.Vref40 + "KT";
		}
	}
}