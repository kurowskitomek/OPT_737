using OPT.ViewModels;

namespace OPT.Factories
{
    public interface IPopUpViewModelFactory
    {
        PopUpViewModel Create(IPopUpContent content);
    }
}
