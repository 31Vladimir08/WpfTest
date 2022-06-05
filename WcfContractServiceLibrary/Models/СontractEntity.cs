using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace WcfContractServiceLibrary.Models
{
    [Table("Сontracts")]
    [DataContract]
    public class СontractEntity
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Number { get; set; }

        [DataMember]
        public DateTime CreateDate { get; set; }

        [DataMember]
        public DateTime LastDate { get; set; }

        [DataMember]
        public bool IsActual { get; set; }
    }
}
