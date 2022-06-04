using System.Collections.Generic;
using System.Threading.Tasks;

using WpfApp.Services.Model;

namespace WpfApp.Services.Interfaces
{
    public interface IСontractService
    {
        Task<IEnumerable<СontractDto>> GetСontractsAsync();
    }
}
