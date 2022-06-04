using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using WpfApp.Services.Interfaces;
using WpfApp.Services.Model;

namespace WpfApp.Services.Services
{
    public class СontractService : IСontractService
    {
        public async Task<IEnumerable<СontractDto>> GetСontractsAsync()
        {
            return await Task.Run(
                () =>
                {
                    return new List<СontractDto>() 
                    {
                        new СontractDto { Id = 1, IsActual = true, Number = "1dgd", LastDate = DateTime.Today.AddDays(-60) },
                        new СontractDto { Id = 2, IsActual = false, Number = "2dgd", LastDate = DateTime.Today.AddDays(-61) },
                        new СontractDto { Id = 3, IsActual = false, Number = "3dgd", LastDate = DateTime.Today.AddDays(-59) },
                    };
                });
        }
    }
}
