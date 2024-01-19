namespace OPT.ViewModels
{
    public interface IPopUpContent
    {
        bool CanDo { get; }
        void Done();

        bool CanCancel { get; }
        void Cancel();
    }
}
