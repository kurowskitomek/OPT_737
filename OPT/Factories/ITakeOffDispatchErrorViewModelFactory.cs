using OPT.ViewModels;
using OPTCore.PerformanceCalculation;

namespace OPT.Factories
{
    public interface ITakeOffDispatchErrorViewModelFactory
    {
        TakeOffDispatchErrorViewModel Create(DispatchException ex);
    }
}
