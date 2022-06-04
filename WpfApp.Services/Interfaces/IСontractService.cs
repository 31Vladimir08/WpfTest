using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WpfApp.Services.Model;

namespace WpfApp.Services.Interfaces
{
    public interface IСontractService
    {
        IEnumerable<СontractDto> GetСontracts();
    }
}
