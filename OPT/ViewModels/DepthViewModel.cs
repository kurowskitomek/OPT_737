using System;
using System.Collections.Generic;
using System.Globalization;
using OPTCore.PerformanceCalculation.Models;
using ReactiveUI;

namespace OPT.ViewModels
{
	public class DepthViewModel : ViewModelBase, IPopUpContent
	{
        private readonly TOParameters _parameters;

        private const int _min = 3;
        public int Min => _min;

        private const int _max = 13;
        public int Max => _max;

        private string? _contamination;
		public string? Contamination
		{
			get => _contamination;
			set => this.RaiseAndSetIfChanged(ref _contamination, value);
		}

		private int depth = _min;
		private string _depth = _min.ToString();
		public string Depth
		{
			get => _depth;
			set
			{
				if (
					int.TryParse(value, CultureInfo.InvariantCulture, out int result) || 
					string.IsNullOrEmpty(value))
				{
                    this.RaiseAndSetIfChanged(ref _depth, value);
					depth = result;

					CanDo = depth >= _min && depth <= _max;
                }		
			}
		}

		private bool _canDo = true;
        public bool CanDo
		{
			get => _canDo;
			set => this.RaiseAndSetIfChanged(ref _canDo, value);
		}

        public bool CanCancel => true;

        public DepthViewModel(TOParameters parameters)
		{
			_parameters = parameters;
		}

        public void Done()
        {
			if (depth < _min || depth > _max)
				return;

			_parameters.Slush = depth;
        }

        public void Cancel()
        {
			_parameters.Slush = 0;
        }
    }
}