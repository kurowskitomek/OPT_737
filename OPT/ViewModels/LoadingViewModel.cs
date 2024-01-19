using System;
using System.Collections.Generic;
using ReactiveUI;

namespace OPT.ViewModels
{
	public class LoadingViewModel : ViewModelBase
	{
		private string? _message;
		public string? Message
		{
			get => _message;
			set => this.RaiseAndSetIfChanged(ref _message, value);
		}
	}
}