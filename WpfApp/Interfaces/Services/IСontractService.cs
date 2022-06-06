using System.Collections.Generic;
using System.Threading.Tasks;

using WpfApp.Models.Dto;

namespace WpfApp.Interfaces.Services
{
    public interface IСontractService
    {
        Task<IEnumerable<СontractDto>> GetСontractsAsync();
    }
}
