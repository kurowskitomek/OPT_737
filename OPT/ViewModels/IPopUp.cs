using System;

namespace OPT.ViewModels
{
    public enum PopUpResult
    {
        Done,
        Cancelled
    }

    public interface IPopUp
    {
        void Show(IPopUpContent content);
        void Show(IPopUpContent content, Action<PopUpResult> callBack);
    }
}
