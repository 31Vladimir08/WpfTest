using System.Collections.Generic;
using System.Collections.ObjectModel;

using Autofac;

using AutoMapper;

using WpfApp.Interfaces.ViewModels;
using WpfApp.Models;
using WpfApp.Services.Interfaces;

namespace WpfApp.ViewModels
{
    public class СontractViewModel : IСontractViewModel
    {
        private readonly IСontractService _сontractService;
        private readonly IMapper _mapper;

        public СontractUi SelectedContract { get; set; }
        public ObservableCollection<СontractUi> Contracts { get; private set; }

        public СontractViewModel()
        {
            _сontractService = Bootstrapper.Container.Resolve<IСontractService>();
            _mapper = Bootstrapper.Mapper;
            Contracts = new ObservableCollection<СontractUi>(GetContracts());
        }

        public IEnumerable<СontractUi> GetContracts()
        {
            var contracts = _сontractService.GetСontracts();
            var result = _mapper.Map<IEnumerable<СontractUi>>(contracts);
            return result;
        }
    }
}
