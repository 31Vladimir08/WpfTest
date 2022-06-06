using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;

using Autofac;

using AutoMapper;

using ReactiveUI;

using WpfApp.Infrastructure;
using WpfApp.Interfaces.Services;
using WpfApp.Models;

namespace WpfApp.ViewModels
{
    public class СontractsViewModel : BaseViewModel
    {
        private readonly IСontractService _сontractService;
        private readonly IMapper _mapper;
        private ICommand _refreshCommand;

        private СontractUi _selectedContract;
        private NotifyTaskCompletion<ObservableCollection<СontractUi>> _contracts;

        public СontractUi SelectedContract 
        { 
            get
            {
                return _selectedContract;
            }
            set
            {
                _selectedContract = value;
                NotifyPropertyChanged();
            }
        }
        public NotifyTaskCompletion<ObservableCollection<СontractUi>> Contracts 
        { 
            get
            {
                return _contracts;
            }
            set 
            { 
                _contracts = value;
                NotifyPropertyChanged();
            }
        }

        public СontractsViewModel()
        {
            _сontractService = Bootstrapper.Container.Resolve<IСontractService>();
            _mapper = Bootstrapper.Mapper;

            Refresh();
        }

        public void Refresh()
        {
            Contracts = new NotifyTaskCompletion<ObservableCollection<СontractUi>>(GetContractsAsync());
        }

        public ICommand RefreshCommand
        {
            get
            {
                if (_refreshCommand == null)
                    _refreshCommand = new RelayCommand(x => Refresh(), y => !Contracts.IsNotCompleted);
                return _refreshCommand;
            }
        }

        private async Task<ObservableCollection<СontractUi>> GetContractsAsync()
        {
            var contracts = await _сontractService.GetСontractsAsync();
            var result = _mapper.Map<IEnumerable<СontractUi>>(contracts);
            return new ObservableCollection<СontractUi>(result);
        }
    }
}
