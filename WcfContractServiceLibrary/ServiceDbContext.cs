using System;
using System.Data.Entity;
using System.Linq;

using WcfContractServiceLibrary.Models;

namespace WcfContractServiceLibrary
{
    public class ServiceDbContext : DbContext
    {
        public ServiceDbContext()
            : base("name=ServiceDbContext")
        {
        }

        public virtual DbSet<ÑontractEntity> Ñontracts { get; set; }
    }
}