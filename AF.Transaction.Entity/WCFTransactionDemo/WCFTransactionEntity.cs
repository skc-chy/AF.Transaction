using System;
using System.Runtime.Serialization;

namespace AF.Transaction.Entity.WCFTransactionDemo
{
    [DataContract]
    public sealed class WCFTransactionEntity
    {
        [DataMember]
        public Guid EmpID { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Address { get; set; }

        [DataMember]
        public string EMail { get; set; }

        [DataMember]
        public string Phone { get; set; }

    }
}
