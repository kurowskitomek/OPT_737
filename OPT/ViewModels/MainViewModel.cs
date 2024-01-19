using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using ReactiveUI;

namespace OPT.ViewModels
{
	public class MainViewModel : ViewModelBase
	{
		private ObservableCollection<PageViewModelBase>? _pages;
		public ObservableCollection<PageViewModelBase>? Pages
		{
			get => _pages;
			set => this.RaiseAndSetIfChanged(ref _pages, value);
        }

		public MainViewModel(IEnumerable<PageViewModelBase> pages)
		{
			Pages = new ObservableCollection<PageViewModelBase>(pages);
		}
	}
}