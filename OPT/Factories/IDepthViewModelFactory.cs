using OPT.ViewModels;
using OPTCore.PerformanceCalculation.Models;

namespace OPT.Factories
{
    public interface IDepthViewModelFactory
    {
        DepthViewModel Create(TOParameters parameters);
    }
}
