using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using WpfApp.Models;

namespace WpfApp.ViewModels
{
    public class СontractViewModel
    {
        public СontractUi SelectedContract { get; set; }
        public ObservableCollection<СontractUi> Contracts { get; private set; }

        public СontractViewModel()
        {
            Contracts = new ObservableCollection<СontractUi>();
            Contracts.Add(new СontractUi() { Id = 1, IsActual = true, Number = "1dgd" });
            Contracts.Add(new СontractUi() { Id = 2, IsActual = false, Number = "2dgd" });
            Contracts.Add(new СontractUi() { Id = 3, IsActual = false, Number = "3dgd" });
        }
    }
}
