using ReactiveUI;

namespace OPT.ViewModels
{
    public class PageViewModelBase : ViewModelBase
    {
        private string? _header;
        public string? Header
        {
            get => _header;
            set => this.RaiseAndSetIfChanged(ref _header, value);
        }

        public string? _icon;
        public string? Icon
        {
            get => _icon;
            set => this.RaiseAndSetIfChanged(ref _icon, value);
        }
    }
}
