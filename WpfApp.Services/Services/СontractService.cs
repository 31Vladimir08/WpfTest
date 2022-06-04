using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using WpfApp.Services.Interfaces;
using WpfApp.Services.Model;

namespace WpfApp.Services.Services
{
    public class СontractService : IСontractService
    {
        public IEnumerable<СontractDto> GetСontracts()
        {
            Thread.Sleep(10000);
            return new List<СontractDto>() {
            new СontractDto { Id = 1, IsActual = true, Number = "1dgd" },
            new СontractDto { Id = 2, IsActual = false, Number = "2dgd" },
            new СontractDto { Id = 3, IsActual = false, Number = "3dgd" },
            };
        }
    }
}
