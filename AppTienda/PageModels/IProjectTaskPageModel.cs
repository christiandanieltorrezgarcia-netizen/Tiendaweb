using AppTienda.Models;
using CommunityToolkit.Mvvm.Input;

namespace AppTienda.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}