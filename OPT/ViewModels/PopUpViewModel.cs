using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using Avalonia.Metadata;
using ReactiveUI;

namespace OPT.ViewModels
{
	public class PopUpViewModel : ViewModelBase
	{
        public event EventHandler? DonePressed;
        public event EventHandler? CancelPressed;

        private IPopUpContent _content;
        public IPopUpContent Content
        {
            get => _content;
            private set => this.RaiseAndSetIfChanged(ref _content, value);
        }

        private bool _canDo;
        public bool CanDo
        {
            get => _canDo;
            set
            {
                //this.RaiseAndSetIfChanged(ref _canDo, value);
                _canDo = value;
                this.RaisePropertyChanged(nameof(CanDo));
            }
        }

        private bool _canCancel;
        public bool _CanCancel
        {
            get => _canDo;
            set
            {
                _canCancel = value;
                this.RaisePropertyChanged(nameof(_CanCancel));
            }
        }

        public PopUpViewModel(IPopUpContent content)
        {
            _content = content;

            ReactiveObject? rx = _content as ReactiveObject;

            rx?.Changed.Subscribe(x => 
            {
                if (x.PropertyName == nameof(_content.CanDo))
                    CanDo = _content.CanDo;

                if (x.PropertyName == nameof(_content.CanCancel))
                    _CanCancel = _content.CanCancel;
            });
        }

        public void Done()
        {
            _content.Done();
            DonePressed?.Invoke(this, EventArgs.Empty);
        }

        [DependsOn(nameof(CanDo))]
        public bool CanDone(object parameter)
            => _content.CanDo;

        public void Cancel()
        {
            _content.Cancel();
            CancelPressed?.Invoke(this, EventArgs.Empty);
        }

        [DependsOn(nameof(_CanCancel))]
        public bool CanCancel(object parameter)
            => _content.CanCancel;

    }
}