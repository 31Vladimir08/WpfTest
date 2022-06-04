using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

using Autofac;

using AutoMapper;

using WpfApp.Models;
using WpfApp.Services.Interfaces;

namespace WpfApp.ViewModels
{
    public class СontractViewModel
    {
        private readonly IСontractService _сontractService;
        private readonly IMapper _mapper;

        public СontractUi SelectedContract { get; set; }
        public NotifyTaskCompletion<ObservableCollection<СontractUi>> Contracts { get; private set; }

        public СontractViewModel()
        {
            //throw new System.Exception("Test2");
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
