using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using WcfContractServiceLibrary.Models;

namespace WcfContractServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ContractService : IContractService
    {
        public IEnumerable<СontractEntity> GetContracts()
        {
            using(var db = new ServiceDbContext())
            {
                var res = db.Сontracts.ToList();
                return res;
            }
        }
    }
}
