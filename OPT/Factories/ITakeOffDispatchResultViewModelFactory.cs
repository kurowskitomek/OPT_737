using OPT.Models;
using OPT.ViewModels;

namespace OPT.Factories
{
    public interface ITakeOffDispatchResultViewModelFactory
    {
        TakeOffDispatchResultViewModel Create(TOResults result);        
    }
}
