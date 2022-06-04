using System.Collections.ObjectModel;

using WpfApp.Models;
using WpfApp.Services.Model;

namespace WpfApp.Interfaces.ViewModels
{
    public interface IСontractViewModel
    {
        СontractUi SelectedContract { get; set; }
        ObservableCollection<СontractUi> Contracts { get; }
    }
}
