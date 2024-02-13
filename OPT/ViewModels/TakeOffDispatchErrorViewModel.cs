using OPTCore.PerformanceCalculation;
using ReactiveUI;

namespace OPT.ViewModels
{
    public class TakeOffDispatchErrorViewModel : ViewModelBase
	{
		private string? _error;
		public string? Error
		{
			get => _error;
			set => this.RaiseAndSetIfChanged(ref _error, value);
		}

		public TakeOffDispatchErrorViewModel(DispatchException ex)
		{
			Error = ex.Message;
		}
	}
}