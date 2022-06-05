using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

using Autofac;

using AutoMapper;

using WpfApp.Interfaces.Services;
using WpfApp.Models;

namespace WpfApp.ViewModels
{
    public class СontractsViewModel : BaseViewModel
    {
        private readonly IСontractService _сontractService;
        private readonly IMapper _mapper;

        private СontractUi _selectedContract;

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
        public NotifyTaskCompletion<ObservableCollection<СontractUi>> Contracts { get; private set; }

        public СontractsViewModel()
        {
            _сontractService = Bootstrapper.Container.Resolve<IСontractService>();
            _mapper = Bootstrapper.Mapper;
            Contracts = new NotifyTaskCompletion<ObservableCollection<СontractUi>>(GetContractsAsync());
        }

        public async Task<ObservableCollection<СontractUi>> GetContractsAsync()
        {
            var contracts = await _сontractService.GetСontractsAsync();
            var result = _mapper.Map<IEnumerable<СontractUi>>(contracts);
            return new ObservableCollection<СontractUi>(result);
        }
    }
}
