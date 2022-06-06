using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using WcfContractServiceLibrary.Models;

namespace WcfContractServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IContractService
    {
        [OperationContract]
        IEnumerable<СontractEntity> GetContracts();

        // TODO: Add your service operations here
    }
}
