using OPT.Models;
using OPT.ViewModels;
using OPTCore.AirfieldsData.Models;

namespace OPT.Factories
{
    public interface ITakeOffDispatchResultViewModelFactory
    {
        TakeOffDispatchResultViewModel Create(TOResults result);
    }
}
