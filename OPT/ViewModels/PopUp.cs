using DynamicData;
using OPT.Factories;
using System;

namespace OPT.ViewModels
{
    public delegate void ShowPopUp(PopUpViewModel popUpViewModel);
    public delegate void ClosePopUp();

    public class PopUp : IPopUp
    {        
        private readonly IPopUpViewModelFactory _popUpViewModelFactory;
        private readonly ShowPopUp _showPopUp;
        private readonly ClosePopUp _closePopUp;

        public PopUp(
            ShowPopUp showPopUp,
            ClosePopUp closePopUp,
            IPopUpViewModelFactory popUpViewModelFactory)
        {            
            _popUpViewModelFactory = popUpViewModelFactory;
            _showPopUp = showPopUp;
            _closePopUp = closePopUp;
        }

        public void Show(IPopUpContent content)
        {
            PopUpViewModel viewModel = _popUpViewModelFactory.Create(content);

            viewModel.DonePressed += ViewModel_DonePressed;
            viewModel.CancelPressed += ViewModel_CancelPressed;

            _showPopUp(viewModel);
        }

        public void Show(IPopUpContent content, Action<PopUpResult> callBack)
        {
            PopUpViewModel viewModel = _popUpViewModelFactory.Create(content);

            viewModel.DonePressed += ViewModel_DonePressed;
            viewModel.DonePressed += (source, args) => callBack(PopUpResult.Done);
            viewModel.CancelPressed += ViewModel_CancelPressed;
            viewModel.CancelPressed += (source, args) => callBack(PopUpResult.Cancelled);

            _showPopUp(viewModel);
        }

        public void Close()
        {
            _closePopUp();
        }

        private void ViewModel_DonePressed(object? source, EventArgs? args, Action<PopUpResult> callBack)
        {
            Close();

            if (source is PopUpViewModel vm)
                vm.DonePressed -= ViewModel_DonePressed;
        }

        private void ViewModel_CancelPressed(object? source, EventArgs? args, Action<PopUpResult> callBack)
        {
            Close();

            if (source is PopUpViewModel vm)
                vm.CancelPressed -= ViewModel_CancelPressed;
        }

        private void ViewModel_DonePressed(object? source, EventArgs? args)
        {
            Close();

            if (source is PopUpViewModel vm)
                vm.DonePressed -= ViewModel_DonePressed;
        }

        private void ViewModel_CancelPressed(object? source, EventArgs? args)
        {
            Close();

            if (source is PopUpViewModel vm)
                vm.CancelPressed -= ViewModel_CancelPressed;
        }
    }
}
