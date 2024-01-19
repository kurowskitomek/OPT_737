
using OPTCore.AirfieldsData;
using ReactiveUI;
using System.Threading.Tasks;

namespace OPT.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private readonly MainViewModel _mainViewModel;
        private readonly LoadingViewModel _loadingViewModel;
        private readonly IAirfieldsDataBuilder _airfieldsDataBuilder;

        private PopUpViewModel? _popUpViewModel;
        public PopUpViewModel? PopUpViewModel
        {
            get => _popUpViewModel;
            set => this.RaiseAndSetIfChanged(ref _popUpViewModel, value);
        }

        private ViewModelBase? _content;
        public ViewModelBase? Content
        {
            get => _content;
            set => this.RaiseAndSetIfChanged(ref _content, value);
        }

        public MainWindowViewModel(
            MainViewModel mainViewModel,
            LoadingViewModel loadingViewModel,
            IAirfieldsDataBuilder airfieldsDataBuilder)
        {
            _mainViewModel = mainViewModel;
            _loadingViewModel = loadingViewModel;
            _airfieldsDataBuilder = airfieldsDataBuilder;
        }

        public async Task Load()
        {
            Content = _loadingViewModel;
            _loadingViewModel.Message = "Loading airfields...";

            await _airfieldsDataBuilder.BuildDataAsync();            

            Content = _mainViewModel;
        }
    }
}