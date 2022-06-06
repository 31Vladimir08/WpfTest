using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Controls;

using AutoMapper;

using ServiceReference;

using WpfApp.Interfaces.Services;
using WpfApp.Models.Dto;

namespace WpfApp.Services
{
    public class СontractService : IСontractService
    {
        private readonly IMapper _mapper;
        public СontractService()
        {
            _mapper = Bootstrapper.Mapper;
        }
        public async Task<IEnumerable<СontractDto>> GetСontractsAsync()
        {

            ContractServiceClient client = new ContractServiceClient();
            var contracts = await client.GetContractsAsync();
            var result = _mapper.Map<IEnumerable<СontractDto>>(contracts);
            return result;
        }
    }
}
